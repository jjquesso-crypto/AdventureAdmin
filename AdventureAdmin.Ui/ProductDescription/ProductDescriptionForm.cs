using System;
using System.Windows.Forms;
using AdventureAdmin.Data.Models;
using AdventureAdmin.Ui.Services;

namespace AdventureAdmin.Ui.Product
{
    public partial class ProductDescriptionForm : Form
    {
        private readonly ProductDescriptionService _productDescriptionService;
        private readonly ProductDescription? _productDescription;

        public ProductDescriptionForm(ProductDescriptionService productDescriptionService) : this(productDescriptionService, null) { }

        public ProductDescriptionForm(ProductDescriptionService productDescriptionService, ProductDescription? productDescription)
        {
            InitializeComponent();
            _productDescriptionService = productDescriptionService;
            _productDescription = productDescription;

            if (_productDescription != null)
                CargarDatos(_productDescription);
        }

        private void AplicarCampos(ProductDescription e)
        {
            e.Description = txtDescription.Text.Trim();
            e.ModifiedDate = DateTime.Now;
        }

        private async Task Actualizar()
        {
            var entidad = await _productDescriptionService
                .Buscar(_productDescription.ProductDescriptionId);

            if (entidad != null)
            {
                AplicarCampos(entidad);
                await _productDescriptionService.Modificar(entidad);
            }
        }

        private async Task Insertar()
        {
            var productDescription = new ProductDescription
            {
                Description = txtDescription.Text.Trim(),
                Rowguid = Guid.NewGuid(),
                ModifiedDate = DateTime.Now
            };

            await _productDescriptionService.Guardar(productDescription);
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();

            if (!ValidateForm()) return;

            try
            {
                btnSave.Enabled = false;

                if (_productDescription == null)
                    await Insertar();
                else
                    await Actualizar();

                MessageBox.Show("Descripción de producto guardada correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnSave.Enabled = true;
            }
        }

        private bool ValidateForm()
        {
            errorProvider.Clear();
            bool valid = true;

            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                errorProvider.SetError(txtDescription, "La descripción es obligatoria.");
                valid = false;
            }
            else if (txtDescription.Text.Length > 400)
            {
                errorProvider.SetError(txtDescription, "Máximo 400 caracteres.");
                valid = false;
            }

            return valid;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void CargarDatos(ProductDescription e)
        {
            txtDescription.Text = e.Description;
        }
    }
}
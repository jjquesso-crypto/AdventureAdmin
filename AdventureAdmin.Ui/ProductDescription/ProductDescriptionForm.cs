using System;
using System.Windows.Forms;
using AdventureAdmin.Data.Models;
using AdventureAdmin.Ui.Services;

namespace AdventureAdmin.Ui.Product
{
    public partial class ProductDescriptionForm : Form
    {
        private readonly ProductDescriptionServices _productDescriptionServices;

        public ProductDescriptionForm(ProductDescriptionServices productDescriptionServices)
        {
            InitializeComponent();
            _productDescriptionServices = productDescriptionServices;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();

            if (!ValidateForm()) return;

            try
            {
                btnSave.Enabled = false;

                var productDescription = new ProductDescription
                {
                    Description = txtDescription.Text.Trim(),
                    Rowguid = Guid.NewGuid(),
                    ModifiedDate = DateTime.Now
                };

                var paso = await _productDescriptionServices.Guardar(productDescription);

                if (!paso)
                {
                    MessageBox.Show("Error al guardar", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show("Descripción de producto creada correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
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

            if (txtDescription.Text.Length > 400)
            {
                errorProvider.SetError(txtDescription, "Máximo 400 caracteres.");
                valid = false;
            }

            return valid;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
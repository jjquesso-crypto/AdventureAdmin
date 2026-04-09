using AdventureAdmin.Data.Models;
using AdventureAdmin.Data.Services;
using AdventureAdmin.Ui.Services;
using Aplicada1.Core;
using Microsoft.Extensions.DependencyInjection;

namespace AdventureAdmin.Ui.Product;

public partial class ProductDescriptionList : Form
{
    private readonly ProductDescriptionServices _productDescriptionServices;

    public ProductDescriptionList(ProductDescriptionServices productDescriptionServices)
    {
        InitializeComponent();
        _productDescriptionServices = productDescriptionServices;
    }

    private void ProductDescriptionList_Load(object sender, EventArgs e)
    {
        RefrescarDatos();
    }

    private async Task RefrescarDatos()
    {
        try
        {
            var descripciones = await _productDescriptionServices.GetList(d => true);
            productDescriptionDataGridView.DataSource = descripciones;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error al cargar datos: {ex.Message}");
        }
    }

    private async void nuevoButton_Click(object sender, EventArgs e)
    {
        var form = Program.ServiceProvider.GetRequiredService<ProductDescriptionForm>();

        if (form.ShowDialog() == DialogResult.OK)
        {
            await RefrescarDatos();
        }
    }

    private async void refrescarButton_Click(object sender, EventArgs e)
    {
        await RefrescarDatos();
    }

    private void btnModificar_Click(object sender, EventArgs e)
    {
        var entidad = (ProductDescription)productDescriptionDataGridView.CurrentRow.DataBoundItem;

        var form = ActivatorUtilities.CreateInstance<ProductDescriptionForm>(
            Program.ServiceProvider, entidad);

        if (form.ShowDialog(this) == DialogResult.OK)
            RefrescarDatos();
    }
}
using AdventureAdmin.Data.Context;

namespace AdventureAdmin.Ui.ScrapReason;

public partial class ScrapReasonForm : Form
{
    private readonly AdventureWorksContext _context;

    public ScrapReasonForm(AdventureWorksContext context)
    {
        InitializeComponent();
        _context = context;
    }

    private async void btnSave_Click(object sender, EventArgs e)
    {
        if (!ValidateForm()) return;

        try
        {
            btnSave.Enabled = false;

            var scrapReason = new Data.Models.ScrapReason
            {
                Name = txtName.Text.Trim(),
                ModifiedDate = DateTime.Now
            };

            _context.ScrapReasons.Add(scrapReason);
            await _context.SaveChangesAsync();

            MessageBox.Show("ScrapReason creado correctamente.", "Éxito",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

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
        var valid = true;

        if (string.IsNullOrWhiteSpace(txtName.Text))
        {
            errorProvider.SetError(txtName, "El nombre es obligatorio.");
            valid = false;
        }
        else if (txtName.Text.Trim().Length > 50)
        {
            errorProvider.SetError(txtName, "El nombre no puede exceder 50 caracteres.");
            valid = false;
        }

        return valid;
    }

    private void btnCancel_Click(object sender, EventArgs e) => Close();

    private void txtName_TextChanged(object sender, EventArgs e)
    {

    }
}

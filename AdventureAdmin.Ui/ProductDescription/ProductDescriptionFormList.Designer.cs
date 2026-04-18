namespace AdventureAdmin.Ui.Product;

partial class ProductDescriptionList
{
    private System.ComponentModel.IContainer components = null;

    private DataGridView productDescriptionDataGridView;
    private Button refrescarButton;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        productDescriptionDataGridView = new DataGridView();
        refrescarButton = new Button();
        nuevoButton = new Button();
        btnModificar = new Button();
        ((System.ComponentModel.ISupportInitialize)productDescriptionDataGridView).BeginInit();
        SuspendLayout();
        // 
        // productDescriptionDataGridView
        // 
        productDescriptionDataGridView.AllowUserToAddRows = false;
        productDescriptionDataGridView.AllowUserToDeleteRows = false;
        productDescriptionDataGridView.AllowUserToOrderColumns = true;
        productDescriptionDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        productDescriptionDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        productDescriptionDataGridView.Location = new Point(10, 28);
        productDescriptionDataGridView.Margin = new Padding(3, 2, 3, 2);
        productDescriptionDataGridView.Name = "productDescriptionDataGridView";
        productDescriptionDataGridView.ReadOnly = true;
        productDescriptionDataGridView.RowHeadersWidth = 51;
        productDescriptionDataGridView.Size = new Size(688, 368);
        productDescriptionDataGridView.TabIndex = 0;
        // 
        // refrescarButton
        // 
        refrescarButton.Location = new Point(107, 3);
        refrescarButton.Name = "refrescarButton";
        refrescarButton.Size = new Size(94, 22);
        refrescarButton.TabIndex = 2;
        refrescarButton.Text = "🔄 Refrescar";
        refrescarButton.UseVisualStyleBackColor = true;
        refrescarButton.Click += refrescarButton_Click;
        // 
        // nuevoButton
        // 
        nuevoButton.Location = new Point(10, 2);
        nuevoButton.Margin = new Padding(3, 2, 3, 2);
        nuevoButton.Name = "nuevoButton";
        nuevoButton.Size = new Size(82, 22);
        nuevoButton.TabIndex = 1;
        nuevoButton.Text = "✅ Nuevo";
        nuevoButton.UseVisualStyleBackColor = true;
        nuevoButton.Click += nuevoButton_Click;
        // 
        // btnModificar
        // 
        btnModificar.Location = new Point(217, 2);
        btnModificar.Name = "btnModificar";
        btnModificar.Size = new Size(75, 23);
        btnModificar.TabIndex = 3;
        btnModificar.Text = "Modificar";
        btnModificar.UseVisualStyleBackColor = true;
        btnModificar.Click += btnModificar_Click;
        // 
        // ProductDescriptionList
        // 
        AutoScaleMode = AutoScaleMode.None;
        ClientSize = new Size(900, 450);
        Controls.Add(btnModificar);
        Controls.Add(refrescarButton);
        Controls.Add(nuevoButton);
        Controls.Add(productDescriptionDataGridView);
        Margin = new Padding(3, 2, 3, 2);
        Name = "ProductDescriptionList";
        Text = "Lista de Descripciones de Producto";
        Load += ProductDescriptionList_Load;
        ((System.ComponentModel.ISupportInitialize)productDescriptionDataGridView).EndInit();
        ResumeLayout(false);
    }

    private Button nuevoButton;
    private Button btnModificar;
}
namespace AdventureAdmin.Ui.Product;

partial class ProductDescriptionList
{
    private System.ComponentModel.IContainer components = null;

    private DataGridView productDescriptionDataGridView;
    private Button nuevoButton;
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
        nuevoButton = new Button();
        refrescarButton = new Button();
        ((System.ComponentModel.ISupportInitialize)productDescriptionDataGridView).BeginInit();
        SuspendLayout();
        // 
        // productDescriptionDataGridView
        // 
        productDescriptionDataGridView.AllowUserToAddRows = false;
        productDescriptionDataGridView.AllowUserToDeleteRows = false;
        productDescriptionDataGridView.AllowUserToOrderColumns = true;
        productDescriptionDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        productDescriptionDataGridView.Location = new Point(10, 28);
        productDescriptionDataGridView.Margin = new Padding(3, 2, 3, 2);
        productDescriptionDataGridView.Name = "productDescriptionDataGridView";
        productDescriptionDataGridView.ReadOnly = true;
        productDescriptionDataGridView.RowHeadersWidth = 51;
        productDescriptionDataGridView.Size = new Size(679, 300);
        productDescriptionDataGridView.TabIndex = 0;
        productDescriptionDataGridView.CellContentClick += productDescriptionDataGridView_CellContentClick;
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
        // refrescarButton
        // 
        refrescarButton.Location = new Point(98, 2);
        refrescarButton.Margin = new Padding(3, 2, 3, 2);
        refrescarButton.Name = "refrescarButton";
        refrescarButton.Size = new Size(82, 22);
        refrescarButton.TabIndex = 2;
        refrescarButton.Text = "🔄 Refrescar";
        refrescarButton.UseVisualStyleBackColor = true;
        refrescarButton.Click += refrescarButton_Click;
        // 
        // ProductDescriptionList
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(700, 338);
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
}
namespace AdventureAdmin.Ui.ScrapReason;

partial class ScrapReasonForm
{
    private System.ComponentModel.IContainer components = null;

    private Label lblName;
    private TextBox txtName;
    private Button btnSave;
    private Button btnCancel;
    private ErrorProvider errorProvider;
    private Panel panelButtons;
    private TableLayoutPanel layout;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null)) components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        lblName = new Label();
        txtName = new TextBox();
        btnSave = new Button();
        btnCancel = new Button();
        errorProvider = new ErrorProvider(components);
        panelButtons = new Panel();
        layout = new TableLayoutPanel();
        ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
        panelButtons.SuspendLayout();
        layout.SuspendLayout();
        SuspendLayout();
        // 
        // lblName
        // 
        lblName.Location = new Point(4, 0);
        lblName.Margin = new Padding(4, 0, 4, 0);
        lblName.Name = "lblName";
        lblName.Size = new Size(150, 29);
        lblName.TabIndex = 0;
        lblName.Text = "Nombre";
        // 
        // txtName
        // 
        txtName.Location = new Point(192, 4);
        txtName.Margin = new Padding(4);
        txtName.MaxLength = 50;
        txtName.Name = "txtName";
        txtName.Size = new Size(385, 31);
        txtName.TabIndex = 1;
        txtName.TextChanged += txtName_TextChanged;
        // 
        // btnSave
        // 
        btnSave.Location = new Point(4, 4);
        btnSave.Margin = new Padding(4);
        btnSave.Name = "btnSave";
        btnSave.Size = new Size(130, 42);
        btnSave.TabIndex = 0;
        btnSave.Text = "💾Guardar";
        btnSave.UseVisualStyleBackColor = true;
        btnSave.Click += btnSave_Click;
        // 
        // btnCancel
        // 
        btnCancel.Location = new Point(141, 4);
        btnCancel.Margin = new Padding(4);
        btnCancel.Name = "btnCancel";
        btnCancel.Size = new Size(130, 42);
        btnCancel.TabIndex = 1;
        btnCancel.Text = "❌ Cancelar";
        btnCancel.UseVisualStyleBackColor = true;
        btnCancel.Click += btnCancel_Click;
        // 
        // errorProvider
        // 
        errorProvider.ContainerControl = this;
        // 
        // panelButtons
        // 
        panelButtons.Controls.Add(btnSave);
        panelButtons.Controls.Add(btnCancel);
        panelButtons.Location = new Point(98, 15);
        panelButtons.Margin = new Padding(4);
        panelButtons.Name = "panelButtons";
        panelButtons.Size = new Size(275, 50);
        panelButtons.TabIndex = 0;
        // 
        // layout
        // 
        layout.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        layout.ColumnCount = 2;
        layout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 188F));
        layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        layout.Controls.Add(lblName, 0, 0);
        layout.Controls.Add(txtName, 1, 0);
        layout.Location = new Point(15, 82);
        layout.Margin = new Padding(4);
        layout.Name = "layout";
        layout.RowCount = 1;
        layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
        layout.Size = new Size(805, 50);
        layout.TabIndex = 1;
        // 
        // ScrapReasonForm
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(835, 332);
        Controls.Add(layout);
        Controls.Add(panelButtons);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        Margin = new Padding(4);
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "ScrapReasonForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Crear Scrap Reason";
        ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
        panelButtons.ResumeLayout(false);
        layout.ResumeLayout(false);
        layout.PerformLayout();
        ResumeLayout(false);
    }
}
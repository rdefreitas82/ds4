namespace Laboratorio14
{
    partial class frmProductos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductos));
            lblBuscar = new Label();
            lblNombre = new Label();
            lblId = new Label();
            lblPrecio = new Label();
            lblStock = new Label();
            txtNombre = new TextBox();
            txtId = new TextBox();
            txtPrecio = new TextBox();
            txtStock = new TextBox();
            btnSalir = new Button();
            txtBuscarId = new TextBox();
            tsbNuevo = new PictureBox();
            tsbGuardar = new PictureBox();
            tsbCancelar = new PictureBox();
            tsbEliminar = new PictureBox();
            tsbBuscar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)tsbNuevo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tsbGuardar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tsbCancelar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tsbEliminar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tsbBuscar).BeginInit();
            SuspendLayout();
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Font = new Font("Segoe UI", 12F);
            lblBuscar.Location = new Point(146, 8);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(104, 21);
            lblBuscar.TabIndex = 0;
            lblBuscar.Text = "Buscar por Id:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 10F);
            lblNombre.Location = new Point(180, 84);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(59, 19);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 10F);
            lblId.Location = new Point(23, 84);
            lblId.Name = "lblId";
            lblId.Size = new Size(21, 19);
            lblId.TabIndex = 2;
            lblId.Text = "Id";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI", 10F);
            lblPrecio.Location = new Point(23, 151);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(46, 19);
            lblPrecio.TabIndex = 3;
            lblPrecio.Text = "Precio";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Segoe UI", 10F);
            lblStock.Location = new Point(180, 151);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(42, 19);
            lblStock.TabIndex = 4;
            lblStock.Text = "Stock";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(180, 102);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(478, 23);
            txtNombre.TabIndex = 5;
            // 
            // txtId
            // 
            txtId.Location = new Point(23, 102);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 6;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(23, 169);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 23);
            txtPrecio.TabIndex = 7;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(180, 169);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(100, 23);
            txtStock.TabIndex = 8;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(23, 231);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(90, 30);
            btnSalir.TabIndex = 9;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // txtBuscarId
            // 
            txtBuscarId.Location = new Point(256, 8);
            txtBuscarId.Name = "txtBuscarId";
            txtBuscarId.Size = new Size(118, 23);
            txtBuscarId.TabIndex = 10;
            // 
            // tsbNuevo
            // 
            tsbNuevo.BackgroundImage = (Image)resources.GetObject("tsbNuevo.BackgroundImage");
            tsbNuevo.BackgroundImageLayout = ImageLayout.Zoom;
            tsbNuevo.Location = new Point(22, 6);
            tsbNuevo.Name = "tsbNuevo";
            tsbNuevo.Size = new Size(25, 25);
            tsbNuevo.TabIndex = 11;
            tsbNuevo.TabStop = false;
            tsbNuevo.Click += tsbNuevo_Click;
            // 
            // tsbGuardar
            // 
            tsbGuardar.BackgroundImage = (Image)resources.GetObject("tsbGuardar.BackgroundImage");
            tsbGuardar.BackgroundImageLayout = ImageLayout.Zoom;
            tsbGuardar.Location = new Point(53, 6);
            tsbGuardar.Name = "tsbGuardar";
            tsbGuardar.Size = new Size(25, 25);
            tsbGuardar.TabIndex = 12;
            tsbGuardar.TabStop = false;
            tsbGuardar.Click += tsbGuardar_Click;
            // 
            // tsbCancelar
            // 
            tsbCancelar.BackgroundImage = (Image)resources.GetObject("tsbCancelar.BackgroundImage");
            tsbCancelar.BackgroundImageLayout = ImageLayout.Zoom;
            tsbCancelar.Location = new Point(84, 6);
            tsbCancelar.Name = "tsbCancelar";
            tsbCancelar.Size = new Size(25, 25);
            tsbCancelar.TabIndex = 13;
            tsbCancelar.TabStop = false;
            tsbCancelar.Click += tsbCancelar_Click;
            // 
            // tsbEliminar
            // 
            tsbEliminar.BackgroundImage = (Image)resources.GetObject("tsbEliminar.BackgroundImage");
            tsbEliminar.BackgroundImageLayout = ImageLayout.Zoom;
            tsbEliminar.Location = new Point(115, 6);
            tsbEliminar.Name = "tsbEliminar";
            tsbEliminar.Size = new Size(25, 25);
            tsbEliminar.TabIndex = 14;
            tsbEliminar.TabStop = false;
            tsbEliminar.Click += tsbEliminar_Click;
            // 
            // tsbBuscar
            // 
            tsbBuscar.BackgroundImage = (Image)resources.GetObject("tsbBuscar.BackgroundImage");
            tsbBuscar.BackgroundImageLayout = ImageLayout.Zoom;
            tsbBuscar.Location = new Point(371, 8);
            tsbBuscar.Name = "tsbBuscar";
            tsbBuscar.Size = new Size(25, 25);
            tsbBuscar.TabIndex = 15;
            tsbBuscar.TabStop = false;
            tsbBuscar.Click += tsbBuscar_Click;
            // 
            // frmProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(686, 280);
            Controls.Add(tsbBuscar);
            Controls.Add(tsbEliminar);
            Controls.Add(tsbCancelar);
            Controls.Add(tsbGuardar);
            Controls.Add(tsbNuevo);
            Controls.Add(txtBuscarId);
            Controls.Add(btnSalir);
            Controls.Add(txtStock);
            Controls.Add(txtPrecio);
            Controls.Add(txtId);
            Controls.Add(txtNombre);
            Controls.Add(lblStock);
            Controls.Add(lblPrecio);
            Controls.Add(lblId);
            Controls.Add(lblNombre);
            Controls.Add(lblBuscar);
            Name = "frmProductos";
            Text = "Productos";
            Load += frmProductos_Load;
            ((System.ComponentModel.ISupportInitialize)tsbNuevo).EndInit();
            ((System.ComponentModel.ISupportInitialize)tsbGuardar).EndInit();
            ((System.ComponentModel.ISupportInitialize)tsbCancelar).EndInit();
            ((System.ComponentModel.ISupportInitialize)tsbEliminar).EndInit();
            ((System.ComponentModel.ISupportInitialize)tsbBuscar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBuscar;
        private Label lblNombre;
        private Label lblId;
        private Label lblPrecio;
        private Label lblStock;
        private TextBox txtNombre;
        private TextBox txtId;
        private TextBox txtPrecio;
        private TextBox txtStock;
        private Button btnSalir;
        private TextBox txtBuscarId;
        private PictureBox tsbNuevo;
        private PictureBox tsbGuardar;
        private PictureBox tsbCancelar;
        private PictureBox tsbEliminar;
        private PictureBox tsbBuscar;
    }
}

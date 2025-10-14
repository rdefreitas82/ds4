namespace Laboratorio121
{
    partial class Form1
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
            lblTitulo = new Label();
            lblVelocidad = new Label();
            lblTiempo = new Label();
            lblDistanciaTotal = new Label();
            txtVelocidad = new TextBox();
            txtTiempo = new TextBox();
            txtDistanciaTotal = new TextBox();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(113, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(124, 15);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Velocidad de un móvil";
            lblTitulo.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblVelocidad
            // 
            lblVelocidad.AutoSize = true;
            lblVelocidad.Location = new Point(29, 64);
            lblVelocidad.Name = "lblVelocidad";
            lblVelocidad.Size = new Size(58, 15);
            lblVelocidad.TabIndex = 1;
            lblVelocidad.Text = "Velocidad";
            // 
            // lblTiempo
            // 
            lblTiempo.AutoSize = true;
            lblTiempo.Location = new Point(29, 144);
            lblTiempo.Name = "lblTiempo";
            lblTiempo.Size = new Size(48, 15);
            lblTiempo.TabIndex = 2;
            lblTiempo.Text = "Tiempo";
            // 
            // lblDistanciaTotal
            // 
            lblDistanciaTotal.AutoSize = true;
            lblDistanciaTotal.Location = new Point(29, 244);
            lblDistanciaTotal.Name = "lblDistanciaTotal";
            lblDistanciaTotal.Size = new Size(84, 15);
            lblDistanciaTotal.TabIndex = 3;
            lblDistanciaTotal.Text = "Distancia Total";
            // 
            // txtVelocidad
            // 
            txtVelocidad.Location = new Point(158, 56);
            txtVelocidad.Name = "txtVelocidad";
            txtVelocidad.Size = new Size(161, 23);
            txtVelocidad.TabIndex = 4;
            // 
            // txtTiempo
            // 
            txtTiempo.Location = new Point(158, 141);
            txtTiempo.Name = "txtTiempo";
            txtTiempo.Size = new Size(161, 23);
            txtTiempo.TabIndex = 5;
            // 
            // txtDistanciaTotal
            // 
            txtDistanciaTotal.Location = new Point(158, 236);
            txtDistanciaTotal.Name = "txtDistanciaTotal";
            txtDistanciaTotal.Size = new Size(161, 23);
            txtDistanciaTotal.TabIndex = 6;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(29, 196);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 7;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(134, 196);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 8;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(244, 196);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 9;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(373, 315);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCalcular);
            Controls.Add(txtDistanciaTotal);
            Controls.Add(txtTiempo);
            Controls.Add(txtVelocidad);
            Controls.Add(lblDistanciaTotal);
            Controls.Add(lblTiempo);
            Controls.Add(lblVelocidad);
            Controls.Add(lblTitulo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblVelocidad;
        private Label lblTiempo;
        private Label lblDistanciaTotal;
        private TextBox txtVelocidad;
        private TextBox txtTiempo;
        private TextBox txtDistanciaTotal;
        private Button btnCalcular;
        private Button btnLimpiar;
        private Button btnSalir;
    }
}

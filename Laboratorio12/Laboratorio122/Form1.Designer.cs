namespace Laboratorio122
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
            lblNota1 = new Label();
            lblNota2 = new Label();
            lblNota3 = new Label();
            lblPromedio = new Label();
            txtNota1 = new TextBox();
            txtNota2 = new TextBox();
            txtNota3 = new TextBox();
            txtPromedio = new TextBox();
            btnPromedio = new Button();
            btnReset = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(118, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(91, 15);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Nota Promedio";
            // 
            // lblNota1
            // 
            lblNota1.AutoSize = true;
            lblNota1.Location = new Point(59, 52);
            lblNota1.Name = "lblNota1";
            lblNota1.Size = new Size(69, 15);
            lblNota1.TabIndex = 1;
            lblNota1.Text = "NOTA No. 1";
            // 
            // lblNota2
            // 
            lblNota2.AutoSize = true;
            lblNota2.Location = new Point(59, 92);
            lblNota2.Name = "lblNota2";
            lblNota2.Size = new Size(69, 15);
            lblNota2.TabIndex = 2;
            lblNota2.Text = "NOTA No. 2";
            // 
            // lblNota3
            // 
            lblNota3.AutoSize = true;
            lblNota3.Location = new Point(59, 139);
            lblNota3.Name = "lblNota3";
            lblNota3.Size = new Size(69, 15);
            lblNota3.TabIndex = 3;
            lblNota3.Text = "NOTA No. 3";
            // 
            // lblPromedio
            // 
            lblPromedio.AutoSize = true;
            lblPromedio.Location = new Point(59, 228);
            lblPromedio.Name = "lblPromedio";
            lblPromedio.Size = new Size(88, 15);
            lblPromedio.TabIndex = 4;
            lblPromedio.Text = "Nota Promedio";
            // 
            // txtNota1
            // 
            txtNota1.Location = new Point(151, 49);
            txtNota1.Name = "txtNota1";
            txtNota1.Size = new Size(100, 23);
            txtNota1.TabIndex = 5;
            // 
            // txtNota2
            // 
            txtNota2.Location = new Point(151, 89);
            txtNota2.Name = "txtNota2";
            txtNota2.Size = new Size(100, 23);
            txtNota2.TabIndex = 6;
            // 
            // txtNota3
            // 
            txtNota3.Location = new Point(151, 136);
            txtNota3.Name = "txtNota3";
            txtNota3.Size = new Size(100, 23);
            txtNota3.TabIndex = 7;
            // 
            // txtPromedio
            // 
            txtPromedio.Location = new Point(153, 225);
            txtPromedio.Name = "txtPromedio";
            txtPromedio.Size = new Size(100, 23);
            txtPromedio.TabIndex = 8;
            // 
            // btnPromedio
            // 
            btnPromedio.Location = new Point(26, 185);
            btnPromedio.Name = "btnPromedio";
            btnPromedio.Size = new Size(75, 23);
            btnPromedio.TabIndex = 9;
            btnPromedio.Text = "Promedio";
            btnPromedio.UseVisualStyleBackColor = true;
            btnPromedio.Click += btnPromedio_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(118, 185);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 23);
            btnReset.TabIndex = 10;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(216, 185);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 11;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(335, 295);
            Controls.Add(btnSalir);
            Controls.Add(btnReset);
            Controls.Add(btnPromedio);
            Controls.Add(txtPromedio);
            Controls.Add(txtNota3);
            Controls.Add(txtNota2);
            Controls.Add(txtNota1);
            Controls.Add(lblPromedio);
            Controls.Add(lblNota3);
            Controls.Add(lblNota2);
            Controls.Add(lblNota1);
            Controls.Add(lblTitulo);
            Name = "Form1";
            Text = "Calcular Promedio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblNota1;
        private Label lblNota2;
        private Label lblNota3;
        private Label lblPromedio;
        private TextBox txtNota1;
        private TextBox txtNota2;
        private TextBox txtNota3;
        private TextBox txtPromedio;
        private Button btnPromedio;
        private Button btnReset;
        private Button btnSalir;
    }
}

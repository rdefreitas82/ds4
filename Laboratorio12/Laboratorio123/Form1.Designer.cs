namespace Laboratorio123
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
            lblLadoA = new Label();
            lblLadoB = new Label();
            lblLadoC = new Label();
            lblSemiPerimetro = new Label();
            lblArea = new Label();
            txtLadoA = new TextBox();
            txtLadoB = new TextBox();
            txtLadoC = new TextBox();
            txtSemiPerimetro = new TextBox();
            txtArea = new TextBox();
            btnSemiperimetro = new Button();
            btnArea = new Button();
            btnReset = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // lblLadoA
            // 
            lblLadoA.AutoSize = true;
            lblLadoA.Location = new Point(35, 41);
            lblLadoA.Name = "lblLadoA";
            lblLadoA.Size = new Size(161, 15);
            lblLadoA.TabIndex = 0;
            lblLadoA.Text = "Ingresa la longitud del lado A";
            // 
            // lblLadoB
            // 
            lblLadoB.AutoSize = true;
            lblLadoB.Location = new Point(35, 96);
            lblLadoB.Name = "lblLadoB";
            lblLadoB.Size = new Size(160, 15);
            lblLadoB.TabIndex = 1;
            lblLadoB.Text = "Ingresa la longitud del lado B";
            // 
            // lblLadoC
            // 
            lblLadoC.AutoSize = true;
            lblLadoC.Location = new Point(35, 160);
            lblLadoC.Name = "lblLadoC";
            lblLadoC.Size = new Size(161, 15);
            lblLadoC.TabIndex = 2;
            lblLadoC.Text = "Ingresa la longitud del lado C";
            // 
            // lblSemiPerimetro
            // 
            lblSemiPerimetro.AutoSize = true;
            lblSemiPerimetro.Location = new Point(35, 296);
            lblSemiPerimetro.Name = "lblSemiPerimetro";
            lblSemiPerimetro.Size = new Size(131, 15);
            lblSemiPerimetro.TabIndex = 3;
            lblSemiPerimetro.Text = "Calcular Semiperimetro";
            // 
            // lblArea
            // 
            lblArea.AutoSize = true;
            lblArea.Location = new Point(35, 345);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(101, 15);
            lblArea.TabIndex = 4;
            lblArea.Text = "Area del triangulo";
            // 
            // txtLadoA
            // 
            txtLadoA.Location = new Point(246, 38);
            txtLadoA.Name = "txtLadoA";
            txtLadoA.Size = new Size(100, 23);
            txtLadoA.TabIndex = 5;
            // 
            // txtLadoB
            // 
            txtLadoB.Location = new Point(246, 93);
            txtLadoB.Name = "txtLadoB";
            txtLadoB.Size = new Size(100, 23);
            txtLadoB.TabIndex = 6;
            // 
            // txtLadoC
            // 
            txtLadoC.Location = new Point(246, 157);
            txtLadoC.Name = "txtLadoC";
            txtLadoC.Size = new Size(100, 23);
            txtLadoC.TabIndex = 7;
            // 
            // txtSemiPerimetro
            // 
            txtSemiPerimetro.Location = new Point(246, 293);
            txtSemiPerimetro.Name = "txtSemiPerimetro";
            txtSemiPerimetro.Size = new Size(100, 23);
            txtSemiPerimetro.TabIndex = 8;
            // 
            // txtArea
            // 
            txtArea.Location = new Point(246, 342);
            txtArea.Name = "txtArea";
            txtArea.Size = new Size(100, 23);
            txtArea.TabIndex = 9;
            // 
            // btnSemiperimetro
            // 
            btnSemiperimetro.Location = new Point(35, 216);
            btnSemiperimetro.Name = "btnSemiperimetro";
            btnSemiperimetro.Size = new Size(95, 40);
            btnSemiperimetro.TabIndex = 10;
            btnSemiperimetro.Text = "Semiperimetro";
            btnSemiperimetro.UseVisualStyleBackColor = true;
            btnSemiperimetro.Click += btnSemiperimetro_Click;
            // 
            // btnArea
            // 
            btnArea.Location = new Point(143, 216);
            btnArea.Name = "btnArea";
            btnArea.Size = new Size(95, 40);
            btnArea.TabIndex = 11;
            btnArea.Text = "Area";
            btnArea.UseVisualStyleBackColor = true;
            btnArea.Click += btnArea_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(244, 216);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(95, 40);
            btnReset.TabIndex = 12;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(345, 216);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(95, 40);
            btnSalir.TabIndex = 13;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(498, 450);
            Controls.Add(btnSalir);
            Controls.Add(btnReset);
            Controls.Add(btnArea);
            Controls.Add(btnSemiperimetro);
            Controls.Add(txtArea);
            Controls.Add(txtSemiPerimetro);
            Controls.Add(txtLadoC);
            Controls.Add(txtLadoB);
            Controls.Add(txtLadoA);
            Controls.Add(lblArea);
            Controls.Add(lblSemiPerimetro);
            Controls.Add(lblLadoC);
            Controls.Add(lblLadoB);
            Controls.Add(lblLadoA);
            Name = "Form1";
            Text = "Calculos Triangulo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLadoA;
        private Label lblLadoB;
        private Label lblLadoC;
        private Label lblSemiPerimetro;
        private Label lblArea;
        private TextBox txtLadoA;
        private TextBox txtLadoB;
        private TextBox txtLadoC;
        private TextBox txtSemiPerimetro;
        private TextBox txtArea;
        private Button btnSemiperimetro;
        private Button btnArea;
        private Button btnReset;
        private Button btnSalir;
    }
}

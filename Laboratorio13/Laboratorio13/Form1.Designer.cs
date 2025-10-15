namespace Laboratorio13
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
            btnConectarSQL = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // btnConectarSQL
            // 
            btnConectarSQL.Location = new Point(341, 114);
            btnConectarSQL.Name = "btnConectarSQL";
            btnConectarSQL.Size = new Size(118, 53);
            btnConectarSQL.TabIndex = 0;
            btnConectarSQL.Text = "Conectar y desconectar de SQL Server";
            btnConectarSQL.UseVisualStyleBackColor = true;
            btnConectarSQL.Click += btnConectarSQL_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(287, 186);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(249, 229);
            listBox1.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox1);
            Controls.Add(btnConectarSQL);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnConectarSQL;
        private ListBox listBox1;
    }
}

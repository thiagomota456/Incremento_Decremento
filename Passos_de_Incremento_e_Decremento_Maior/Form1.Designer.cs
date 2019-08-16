namespace WindowsFormsApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Incrementar = new System.Windows.Forms.Button();
            this.Decrementar = new System.Windows.Forms.Button();
            this.Mostrar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Incrementar
            // 
            this.Incrementar.Location = new System.Drawing.Point(150, 211);
            this.Incrementar.Name = "Incrementar";
            this.Incrementar.Size = new System.Drawing.Size(177, 169);
            this.Incrementar.TabIndex = 0;
            this.Incrementar.Text = "Incrementar";
            this.Incrementar.UseVisualStyleBackColor = true;
            this.Incrementar.Click += new System.EventHandler(this.Incrementar_Click);
            this.Incrementar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Incrementar_MouseDown);
            this.Incrementar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PararIncrementoMaior_MouseUp);
            // 
            // Decrementar
            // 
            this.Decrementar.Cursor = System.Windows.Forms.Cursors.Default;
            this.Decrementar.Location = new System.Drawing.Point(432, 211);
            this.Decrementar.Name = "Decrementar";
            this.Decrementar.Size = new System.Drawing.Size(179, 169);
            this.Decrementar.TabIndex = 2;
            this.Decrementar.Text = "Decrementar";
            this.Decrementar.UseVisualStyleBackColor = true;
            this.Decrementar.Click += new System.EventHandler(this.Decrementar_Click);
            this.Decrementar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Decrementar_MouseDown);
            this.Decrementar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PararIncrementoMaior_MouseUp);
            // 
            // Mostrar
            // 
            this.Mostrar.Enabled = false;
            this.Mostrar.Location = new System.Drawing.Point(254, 87);
            this.Mostrar.Multiline = true;
            this.Mostrar.Name = "Mostrar";
            this.Mostrar.Size = new System.Drawing.Size(254, 97);
            this.Mostrar.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Mostrar);
            this.Controls.Add(this.Decrementar);
            this.Controls.Add(this.Incrementar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Incrementar;
        private System.Windows.Forms.Button Decrementar;
        private System.Windows.Forms.TextBox Mostrar;
    }
}


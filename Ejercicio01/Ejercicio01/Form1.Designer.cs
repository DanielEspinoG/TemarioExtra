namespace Ejercicio01
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BBotón1 = new System.Windows.Forms.Button();
            this.BBotón2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BBotón1
            // 
            this.BBotón1.Location = new System.Drawing.Point(357, 186);
            this.BBotón1.Name = "BBotón1";
            this.BBotón1.Size = new System.Drawing.Size(75, 23);
            this.BBotón1.TabIndex = 0;
            this.BBotón1.Text = "Botón1";
            this.BBotón1.UseVisualStyleBackColor = true;
            this.BBotón1.Click += new System.EventHandler(this.BBotón1_Click);
            // 
            // BBotón2
            // 
            this.BBotón2.Location = new System.Drawing.Point(357, 236);
            this.BBotón2.Name = "BBotón2";
            this.BBotón2.Size = new System.Drawing.Size(75, 23);
            this.BBotón2.TabIndex = 1;
            this.BBotón2.Text = "Botón2";
            this.BBotón2.UseVisualStyleBackColor = true;
            this.BBotón2.Click += new System.EventHandler(this.BBotón2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(729, 426);
            this.Controls.Add(this.BBotón2);
            this.Controls.Add(this.BBotón1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BBotón1;
        private System.Windows.Forms.Button BBotón2;
    }
}


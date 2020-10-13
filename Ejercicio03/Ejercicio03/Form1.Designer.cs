namespace Ejercicio03
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
            this.LTexto1 = new System.Windows.Forms.Label();
            this.TCuadroTexto1 = new System.Windows.Forms.TextBox();
            this.BBotón1 = new System.Windows.Forms.Button();
            this.BBotón2 = new System.Windows.Forms.Button();
            this.BBotón3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LTexto1
            // 
            this.LTexto1.AutoSize = true;
            this.LTexto1.Location = new System.Drawing.Point(80, 111);
            this.LTexto1.Name = "LTexto1";
            this.LTexto1.Size = new System.Drawing.Size(76, 13);
            this.LTexto1.TabIndex = 0;
            this.LTexto1.Text = "Botón Pulsado";
            // 
            // TCuadroTexto1
            // 
            this.TCuadroTexto1.Location = new System.Drawing.Point(221, 104);
            this.TCuadroTexto1.Name = "TCuadroTexto1";
            this.TCuadroTexto1.Size = new System.Drawing.Size(388, 20);
            this.TCuadroTexto1.TabIndex = 1;
            // 
            // BBotón1
            // 
            this.BBotón1.Location = new System.Drawing.Point(221, 244);
            this.BBotón1.Name = "BBotón1";
            this.BBotón1.Size = new System.Drawing.Size(75, 23);
            this.BBotón1.TabIndex = 2;
            this.BBotón1.Text = "Botón 1";
            this.BBotón1.UseVisualStyleBackColor = true;
            this.BBotón1.Click += new System.EventHandler(this.BBotón1_Click);
            // 
            // BBotón2
            // 
            this.BBotón2.Location = new System.Drawing.Point(221, 336);
            this.BBotón2.Name = "BBotón2";
            this.BBotón2.Size = new System.Drawing.Size(75, 23);
            this.BBotón2.TabIndex = 3;
            this.BBotón2.Text = "Botón 2";
            this.BBotón2.UseVisualStyleBackColor = true;
            this.BBotón2.Click += new System.EventHandler(this.BBotón2_Click);
            // 
            // BBotón3
            // 
            this.BBotón3.Location = new System.Drawing.Point(441, 284);
            this.BBotón3.Name = "BBotón3";
            this.BBotón3.Size = new System.Drawing.Size(75, 23);
            this.BBotón3.TabIndex = 4;
            this.BBotón3.Text = "Borrar Texto";
            this.BBotón3.UseVisualStyleBackColor = true;
            this.BBotón3.Click += new System.EventHandler(this.BBotón3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BBotón3);
            this.Controls.Add(this.BBotón2);
            this.Controls.Add(this.BBotón1);
            this.Controls.Add(this.TCuadroTexto1);
            this.Controls.Add(this.LTexto1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LTexto1;
        private System.Windows.Forms.TextBox TCuadroTexto1;
        private System.Windows.Forms.Button BBotón1;
        private System.Windows.Forms.Button BBotón2;
        private System.Windows.Forms.Button BBotón3;
    }
}


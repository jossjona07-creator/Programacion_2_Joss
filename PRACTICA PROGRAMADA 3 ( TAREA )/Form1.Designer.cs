namespace PRACTICA_PROGRAMADA_3___TAREA__
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
            this.btnMostrarDia = new System.Windows.Forms.Button();
            this.txtDia = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnMostrarDia
            // 
            this.btnMostrarDia.Location = new System.Drawing.Point(289, 35);
            this.btnMostrarDia.Name = "btnMostrarDia";
            this.btnMostrarDia.Size = new System.Drawing.Size(138, 23);
            this.btnMostrarDia.TabIndex = 0;
            this.btnMostrarDia.Text = "MOSTRAR DIA";
            this.btnMostrarDia.UseVisualStyleBackColor = true;
            this.btnMostrarDia.Click += new System.EventHandler(this.btnMostrarDia_Click);
            // 
            // txtDia
            // 
            this.txtDia.Location = new System.Drawing.Point(72, 36);
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(100, 22);
            this.txtDia.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 142);
            this.Controls.Add(this.txtDia);
            this.Controls.Add(this.btnMostrarDia);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMostrarDia;
        private System.Windows.Forms.TextBox txtDia;
    }
}


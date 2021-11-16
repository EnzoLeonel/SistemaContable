
namespace SistemaContable
{
    partial class MenuPrincipal
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
            this.botonLibroMayor = new System.Windows.Forms.Button();
            this.botonLibroDiario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botonLibroMayor
            // 
            this.botonLibroMayor.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonLibroMayor.Location = new System.Drawing.Point(2, 3);
            this.botonLibroMayor.Name = "botonLibroMayor";
            this.botonLibroMayor.Size = new System.Drawing.Size(171, 231);
            this.botonLibroMayor.TabIndex = 3;
            this.botonLibroMayor.Text = "Libro \r\nMayor";
            this.botonLibroMayor.UseVisualStyleBackColor = true;
            this.botonLibroMayor.Click += new System.EventHandler(this.botonLibroMayor_Click);
            // 
            // botonLibroDiario
            // 
            this.botonLibroDiario.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonLibroDiario.Location = new System.Drawing.Point(179, 3);
            this.botonLibroDiario.Name = "botonLibroDiario";
            this.botonLibroDiario.Size = new System.Drawing.Size(183, 231);
            this.botonLibroDiario.TabIndex = 0;
            this.botonLibroDiario.Text = "Libro \r\nDiario";
            this.botonLibroDiario.UseVisualStyleBackColor = true;
            this.botonLibroDiario.Click += new System.EventHandler(this.BotonLibroDiario_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 236);
            this.Controls.Add(this.botonLibroMayor);
            this.Controls.Add(this.botonLibroDiario);
            this.Name = "MenuPrincipal";
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.ResumeLayout(false);

        }



        #endregion

        private System.Windows.Forms.Button botonLibroMayor;
        private System.Windows.Forms.Button botonLibroDiario;
    }
}


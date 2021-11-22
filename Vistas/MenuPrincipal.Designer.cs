
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.botonLibroMayor = new System.Windows.Forms.Button();
            this.botonLibroDiario = new System.Windows.Forms.Button();
            this.botonAjustes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botonLibroMayor
            // 
            this.botonLibroMayor.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.botonLibroMayor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonLibroMayor.Font = new System.Drawing.Font("Arial", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonLibroMayor.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.botonLibroMayor.Location = new System.Drawing.Point(2, 3);
            this.botonLibroMayor.Name = "botonLibroMayor";
            this.botonLibroMayor.Size = new System.Drawing.Size(175, 231);
            this.botonLibroMayor.TabIndex = 3;
            this.botonLibroMayor.Text = "Libro \r\nMayor";
            this.botonLibroMayor.UseVisualStyleBackColor = false;
            this.botonLibroMayor.Click += new System.EventHandler(this.botonLibroMayor_Click);
            // 
            // botonLibroDiario
            // 
            this.botonLibroDiario.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.botonLibroDiario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonLibroDiario.Font = new System.Drawing.Font("Arial", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonLibroDiario.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.botonLibroDiario.Location = new System.Drawing.Point(173, 3);
            this.botonLibroDiario.Name = "botonLibroDiario";
            this.botonLibroDiario.Size = new System.Drawing.Size(189, 231);
            this.botonLibroDiario.TabIndex = 0;
            this.botonLibroDiario.Text = "Libro \r\nDiario";
            this.botonLibroDiario.UseVisualStyleBackColor = false;
            this.botonLibroDiario.Click += new System.EventHandler(this.BotonLibroDiario_Click);
            // 
            // botonAjustes
            // 
            this.botonAjustes.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.botonAjustes.FlatAppearance.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.botonAjustes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonAjustes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.botonAjustes.Location = new System.Drawing.Point(2, 3);
            this.botonAjustes.Margin = new System.Windows.Forms.Padding(0);
            this.botonAjustes.Name = "botonAjustes";
            this.botonAjustes.Size = new System.Drawing.Size(75, 23);
            this.botonAjustes.TabIndex = 4;
            this.botonAjustes.Text = "Ajustes";
            this.botonAjustes.UseVisualStyleBackColor = false;
            this.botonAjustes.Click += new System.EventHandler(this.botonAjustes_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 233);
            this.Controls.Add(this.botonAjustes);
            this.Controls.Add(this.botonLibroMayor);
            this.Controls.Add(this.botonLibroDiario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.ResumeLayout(false);

        }



        #endregion

        private System.Windows.Forms.Button botonLibroMayor;
        private System.Windows.Forms.Button botonLibroDiario;
        public System.Windows.Forms.Button botonAjustes;
    }
}


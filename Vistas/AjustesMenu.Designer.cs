
namespace SistemaContable.Vistas
{
    partial class AjustesMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AjustesMenu));
            this.botonGuardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.boxIP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.boxPuerto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.boxUsuario = new System.Windows.Forms.TextBox();
            this.boxContrasena = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.boxBaseDatos = new System.Windows.Forms.TextBox();
            this.datosPrueba = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botonGuardar
            // 
            this.botonGuardar.Location = new System.Drawing.Point(124, 206);
            this.botonGuardar.Name = "botonGuardar";
            this.botonGuardar.Size = new System.Drawing.Size(75, 23);
            this.botonGuardar.TabIndex = 0;
            this.botonGuardar.Text = "Guardar";
            this.botonGuardar.UseVisualStyleBackColor = true;
            this.botonGuardar.Click += new System.EventHandler(this.botonGuardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LemonChiffon;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP del servidor:";
            // 
            // boxIP
            // 
            this.boxIP.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxIP.Location = new System.Drawing.Point(16, 41);
            this.boxIP.Name = "boxIP";
            this.boxIP.Size = new System.Drawing.Size(125, 24);
            this.boxIP.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LemonChiffon;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Puerto:";
            // 
            // boxPuerto
            // 
            this.boxPuerto.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxPuerto.Location = new System.Drawing.Point(16, 100);
            this.boxPuerto.Name = "boxPuerto";
            this.boxPuerto.Size = new System.Drawing.Size(125, 24);
            this.boxPuerto.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LemonChiffon;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(184, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Usuario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LemonChiffon;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(184, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Contraseña";
            // 
            // boxUsuario
            // 
            this.boxUsuario.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxUsuario.Location = new System.Drawing.Point(187, 41);
            this.boxUsuario.Name = "boxUsuario";
            this.boxUsuario.Size = new System.Drawing.Size(125, 24);
            this.boxUsuario.TabIndex = 7;
            // 
            // boxContrasena
            // 
            this.boxContrasena.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxContrasena.Location = new System.Drawing.Point(187, 100);
            this.boxContrasena.Name = "boxContrasena";
            this.boxContrasena.Size = new System.Drawing.Size(125, 24);
            this.boxContrasena.TabIndex = 8;
            this.boxContrasena.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LemonChiffon;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Base de Datos:";
            // 
            // boxBaseDatos
            // 
            this.boxBaseDatos.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxBaseDatos.Location = new System.Drawing.Point(16, 160);
            this.boxBaseDatos.Name = "boxBaseDatos";
            this.boxBaseDatos.Size = new System.Drawing.Size(125, 24);
            this.boxBaseDatos.TabIndex = 10;
            // 
            // datosPrueba
            // 
            this.datosPrueba.Location = new System.Drawing.Point(187, 160);
            this.datosPrueba.Name = "datosPrueba";
            this.datosPrueba.Size = new System.Drawing.Size(125, 23);
            this.datosPrueba.TabIndex = 11;
            this.datosPrueba.Text = "Usar Datos de Prueba";
            this.datosPrueba.UseVisualStyleBackColor = true;
            this.datosPrueba.Click += new System.EventHandler(this.datosPrueba_Click);
            // 
            // AjustesMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 241);
            this.Controls.Add(this.datosPrueba);
            this.Controls.Add(this.boxBaseDatos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.boxContrasena);
            this.Controls.Add(this.boxUsuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.boxPuerto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.boxIP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botonGuardar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AjustesMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajustes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AjustesMenu_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonGuardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox boxIP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox boxPuerto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox boxUsuario;
        private System.Windows.Forms.TextBox boxContrasena;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox boxBaseDatos;
        private System.Windows.Forms.Button datosPrueba;
    }
}
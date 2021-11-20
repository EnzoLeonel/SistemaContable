
namespace SistemaContable.Vistas
{
    partial class NuevoAsiento
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.boxDescripcion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.boxFecha = new System.Windows.Forms.TextBox();
            this.boxNumAsiento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridMovimientos = new System.Windows.Forms.DataGridView();
            this.ColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSaldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRestablecer = new System.Windows.Forms.Button();
            this.btnAgregarMovi = new System.Windows.Forms.Button();
            this.btnHaber = new System.Windows.Forms.RadioButton();
            this.boxSaldo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDebe = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.boxCuenta = new System.Windows.Forms.ComboBox();
            this.boxTipoCuenta = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGuardarAsiento = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMovimientos)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.boxDescripcion);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.boxFecha);
            this.groupBox1.Controls.Add(this.boxNumAsiento);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dataGridMovimientos);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(691, 271);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Crear Asiento";
            // 
            // boxDescripcion
            // 
            this.boxDescripcion.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxDescripcion.Location = new System.Drawing.Point(315, 19);
            this.boxDescripcion.Multiline = true;
            this.boxDescripcion.Name = "boxDescripcion";
            this.boxDescripcion.Size = new System.Drawing.Size(365, 51);
            this.boxDescripcion.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LemonChiffon;
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(227, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Descripción\r\ndel Asiento:";
            // 
            // boxFecha
            // 
            this.boxFecha.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxFecha.Location = new System.Drawing.Point(66, 47);
            this.boxFecha.Name = "boxFecha";
            this.boxFecha.Size = new System.Drawing.Size(111, 23);
            this.boxFecha.TabIndex = 4;
            // 
            // boxNumAsiento
            // 
            this.boxNumAsiento.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxNumAsiento.Location = new System.Drawing.Point(150, 15);
            this.boxNumAsiento.Name = "boxNumAsiento";
            this.boxNumAsiento.Size = new System.Drawing.Size(27, 23);
            this.boxNumAsiento.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LemonChiffon;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LemonChiffon;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numero de Asiento: ";
            // 
            // dataGridMovimientos
            // 
            this.dataGridMovimientos.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridMovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMovimientos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColID,
            this.ColNombre,
            this.ColTipo,
            this.ColValor,
            this.ColSaldo,
            this.ColEliminar});
            this.dataGridMovimientos.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridMovimientos.Location = new System.Drawing.Point(6, 86);
            this.dataGridMovimientos.Name = "dataGridMovimientos";
            this.dataGridMovimientos.Size = new System.Drawing.Size(674, 179);
            this.dataGridMovimientos.TabIndex = 0;
            // 
            // ColID
            // 
            this.ColID.FillWeight = 30F;
            this.ColID.HeaderText = "ID";
            this.ColID.Name = "ColID";
            this.ColID.ReadOnly = true;
            this.ColID.Width = 30;
            // 
            // ColNombre
            // 
            this.ColNombre.FillWeight = 200F;
            this.ColNombre.HeaderText = "Nombre Cuenta";
            this.ColNombre.Name = "ColNombre";
            this.ColNombre.ReadOnly = true;
            this.ColNombre.Width = 200;
            // 
            // ColTipo
            // 
            this.ColTipo.FillWeight = 130F;
            this.ColTipo.HeaderText = "Tipo de Cuenta";
            this.ColTipo.Name = "ColTipo";
            this.ColTipo.ReadOnly = true;
            this.ColTipo.Width = 130;
            // 
            // ColValor
            // 
            this.ColValor.HeaderText = "Valor";
            this.ColValor.Name = "ColValor";
            this.ColValor.ReadOnly = true;
            // 
            // ColSaldo
            // 
            this.ColSaldo.HeaderText = "Saldo";
            this.ColSaldo.Name = "ColSaldo";
            this.ColSaldo.ReadOnly = true;
            // 
            // ColEliminar
            // 
            this.ColEliminar.HeaderText = "Eliminar";
            this.ColEliminar.Name = "ColEliminar";
            this.ColEliminar.ReadOnly = true;
            this.ColEliminar.Width = 70;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRestablecer);
            this.groupBox2.Controls.Add(this.btnAgregarMovi);
            this.groupBox2.Controls.Add(this.btnHaber);
            this.groupBox2.Controls.Add(this.boxSaldo);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnDebe);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.boxCuenta);
            this.groupBox2.Controls.Add(this.boxTipoCuenta);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(18, 289);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(430, 149);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Agregar Movimiento";
            // 
            // btnRestablecer
            // 
            this.btnRestablecer.BackColor = System.Drawing.Color.Gainsboro;
            this.btnRestablecer.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestablecer.Location = new System.Drawing.Point(224, 92);
            this.btnRestablecer.Name = "btnRestablecer";
            this.btnRestablecer.Size = new System.Drawing.Size(109, 30);
            this.btnRestablecer.TabIndex = 15;
            this.btnRestablecer.Text = "Restablecer";
            this.btnRestablecer.UseVisualStyleBackColor = false;
            // 
            // btnAgregarMovi
            // 
            this.btnAgregarMovi.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAgregarMovi.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarMovi.Location = new System.Drawing.Point(62, 92);
            this.btnAgregarMovi.Name = "btnAgregarMovi";
            this.btnAgregarMovi.Size = new System.Drawing.Size(109, 30);
            this.btnAgregarMovi.TabIndex = 14;
            this.btnAgregarMovi.Text = "Agregar";
            this.btnAgregarMovi.UseVisualStyleBackColor = false;
            // 
            // btnHaber
            // 
            this.btnHaber.AutoSize = true;
            this.btnHaber.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHaber.Location = new System.Drawing.Point(334, 57);
            this.btnHaber.Name = "btnHaber";
            this.btnHaber.Size = new System.Drawing.Size(64, 20);
            this.btnHaber.TabIndex = 13;
            this.btnHaber.TabStop = true;
            this.btnHaber.Text = "Haber";
            this.btnHaber.UseVisualStyleBackColor = true;
            // 
            // boxSaldo
            // 
            this.boxSaldo.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxSaldo.Location = new System.Drawing.Point(309, 23);
            this.boxSaldo.Name = "boxSaldo";
            this.boxSaldo.Size = new System.Drawing.Size(89, 23);
            this.boxSaldo.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LavenderBlush;
            this.label5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(57, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Cuenta:";
            // 
            // btnDebe
            // 
            this.btnDebe.AutoSize = true;
            this.btnDebe.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDebe.Location = new System.Drawing.Point(258, 57);
            this.btnDebe.Name = "btnDebe";
            this.btnDebe.Size = new System.Drawing.Size(60, 20);
            this.btnDebe.TabIndex = 11;
            this.btnDebe.TabStop = true;
            this.btnDebe.Text = "Debe";
            this.btnDebe.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LemonChiffon;
            this.label6.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(255, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Saldo:";
            // 
            // boxCuenta
            // 
            this.boxCuenta.FormattingEnabled = true;
            this.boxCuenta.Location = new System.Drawing.Point(122, 53);
            this.boxCuenta.Name = "boxCuenta";
            this.boxCuenta.Size = new System.Drawing.Size(121, 21);
            this.boxCuenta.TabIndex = 9;
            // 
            // boxTipoCuenta
            // 
            this.boxTipoCuenta.FormattingEnabled = true;
            this.boxTipoCuenta.Location = new System.Drawing.Point(122, 26);
            this.boxTipoCuenta.Name = "boxTipoCuenta";
            this.boxTipoCuenta.Size = new System.Drawing.Size(121, 21);
            this.boxTipoCuenta.TabIndex = 8;
            this.boxTipoCuenta.SelectedIndexChanged += new System.EventHandler(this.boxTipoCuenta_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LavenderBlush;
            this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tipo de Cuenta:";
            // 
            // btnGuardarAsiento
            // 
            this.btnGuardarAsiento.BackColor = System.Drawing.Color.Honeydew;
            this.btnGuardarAsiento.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarAsiento.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnGuardarAsiento.Location = new System.Drawing.Point(477, 303);
            this.btnGuardarAsiento.Name = "btnGuardarAsiento";
            this.btnGuardarAsiento.Size = new System.Drawing.Size(215, 56);
            this.btnGuardarAsiento.TabIndex = 2;
            this.btnGuardarAsiento.Text = "Guardar Asiento";
            this.btnGuardarAsiento.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Maroon;
            this.btnCancelar.Location = new System.Drawing.Point(477, 368);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(215, 56);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // NuevoAsiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(709, 450);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardarAsiento);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "NuevoAsiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NuevoAsiento";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NuevoAsiento_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMovimientos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridMovimientos;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSaldo;
        private System.Windows.Forms.DataGridViewButtonColumn ColEliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox boxFecha;
        private System.Windows.Forms.TextBox boxNumAsiento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox boxDescripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAgregarMovi;
        private System.Windows.Forms.RadioButton btnHaber;
        private System.Windows.Forms.TextBox boxSaldo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton btnDebe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox boxCuenta;
        private System.Windows.Forms.ComboBox boxTipoCuenta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRestablecer;
        private System.Windows.Forms.Button btnGuardarAsiento;
        private System.Windows.Forms.Button btnCancelar;
    }
}
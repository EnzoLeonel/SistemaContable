
namespace SistemaContable.Vistas
{
    partial class LibroMayor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LibroMayor));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.boxMes = new System.Windows.Forms.ComboBox();
            this.boxAnio = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridLibroMayor = new System.Windows.Forms.DataGridView();
            this.ColFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDebe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColHaber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boxCuentas = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLibroMayor)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MintCream;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mes:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MintCream;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(197, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Año:";
            // 
            // boxMes
            // 
            this.boxMes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxMes.FormattingEnabled = true;
            this.boxMes.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.boxMes.Location = new System.Drawing.Point(77, 13);
            this.boxMes.Name = "boxMes";
            this.boxMes.Size = new System.Drawing.Size(114, 27);
            this.boxMes.TabIndex = 3;
            // 
            // boxAnio
            // 
            this.boxAnio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxAnio.FormattingEnabled = true;
            this.boxAnio.Location = new System.Drawing.Point(248, 13);
            this.boxAnio.Name = "boxAnio";
            this.boxAnio.Size = new System.Drawing.Size(77, 27);
            this.boxAnio.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridLibroMayor);
            this.groupBox1.Location = new System.Drawing.Point(13, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(590, 308);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cuentas";
            // 
            // dataGridLibroMayor
            // 
            this.dataGridLibroMayor.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dataGridLibroMayor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridLibroMayor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColFecha,
            this.ID,
            this.ColCuenta,
            this.ColDebe,
            this.ColHaber,
            this.ColTotal});
            this.dataGridLibroMayor.Location = new System.Drawing.Point(16, 20);
            this.dataGridLibroMayor.Name = "dataGridLibroMayor";
            this.dataGridLibroMayor.Size = new System.Drawing.Size(568, 282);
            this.dataGridLibroMayor.TabIndex = 0;
            // 
            // ColFecha
            // 
            this.ColFecha.FillWeight = 80F;
            this.ColFecha.HeaderText = "Fecha";
            this.ColFecha.Name = "ColFecha";
            this.ColFecha.ReadOnly = true;
            this.ColFecha.Width = 80;
            // 
            // ID
            // 
            this.ID.FillWeight = 40F;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 40;
            // 
            // ColCuenta
            // 
            this.ColCuenta.FillWeight = 150F;
            this.ColCuenta.HeaderText = "Cuenta";
            this.ColCuenta.Name = "ColCuenta";
            this.ColCuenta.ReadOnly = true;
            this.ColCuenta.Width = 150;
            // 
            // ColDebe
            // 
            this.ColDebe.FillWeight = 80F;
            this.ColDebe.HeaderText = "Debe";
            this.ColDebe.Name = "ColDebe";
            this.ColDebe.ReadOnly = true;
            this.ColDebe.Width = 80;
            // 
            // ColHaber
            // 
            this.ColHaber.FillWeight = 80F;
            this.ColHaber.HeaderText = "Haber";
            this.ColHaber.Name = "ColHaber";
            this.ColHaber.ReadOnly = true;
            this.ColHaber.Width = 80;
            // 
            // ColTotal
            // 
            this.ColTotal.FillWeight = 90F;
            this.ColTotal.HeaderText = "Total";
            this.ColTotal.Name = "ColTotal";
            this.ColTotal.ReadOnly = true;
            this.ColTotal.Width = 90;
            // 
            // boxCuentas
            // 
            this.boxCuentas.Font = new System.Drawing.Font("Arial", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxCuentas.FormattingEnabled = true;
            this.boxCuentas.Items.AddRange(new object[] {
            "Todas"});
            this.boxCuentas.Location = new System.Drawing.Point(351, 13);
            this.boxCuentas.Name = "boxCuentas";
            this.boxCuentas.Size = new System.Drawing.Size(140, 24);
            this.boxCuentas.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(507, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Mostrar Año";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // LibroMayor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(613, 369);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.boxCuentas);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.boxAnio);
            this.Controls.Add(this.boxMes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LibroMayor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Libro Mayor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LibroMayor_FormClosing);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLibroMayor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDebe;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColHaber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTotal;
        public System.Windows.Forms.DataGridView dataGridLibroMayor;
        public System.Windows.Forms.ComboBox boxMes;
        public System.Windows.Forms.ComboBox boxAnio;
        public System.Windows.Forms.ComboBox boxCuentas;
    }
}
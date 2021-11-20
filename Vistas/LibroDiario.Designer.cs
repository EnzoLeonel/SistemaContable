namespace SistemaContable.Vistas
{
    partial class LibroDiario
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
            this.dataGridAsientos = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnMostrarMes = new System.Windows.Forms.Button();
            this.selectorFecha = new System.Windows.Forms.DateTimePicker();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNAsiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTipoCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDebe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColHaber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BotonEliminar = new System.Windows.Forms.Button();
            this.BotonNuevo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAsientos)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridAsientos);
            this.groupBox1.Location = new System.Drawing.Point(12, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(826, 446);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Asientos Contables";
            // 
            // dataGridAsientos
            // 
            this.dataGridAsientos.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridAsientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAsientos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ColNAsiento,
            this.ColFecha,
            this.ColCuenta,
            this.ColTipoCuenta,
            this.ColDebe,
            this.ColHaber,
            this.ColDescripcion});
            this.dataGridAsientos.Location = new System.Drawing.Point(0, 19);
            this.dataGridAsientos.Name = "dataGridAsientos";
            this.dataGridAsientos.Size = new System.Drawing.Size(826, 409);
            this.dataGridAsientos.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BotonNuevo);
            this.groupBox2.Controls.Add(this.BotonEliminar);
            this.groupBox2.Controls.Add(this.btnMostrarMes);
            this.groupBox2.Controls.Add(this.selectorFecha);
            this.groupBox2.Location = new System.Drawing.Point(12, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(826, 42);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fecha";
            // 
            // btnMostrarMes
            // 
            this.btnMostrarMes.Location = new System.Drawing.Point(231, 19);
            this.btnMostrarMes.Name = "btnMostrarMes";
            this.btnMostrarMes.Size = new System.Drawing.Size(93, 23);
            this.btnMostrarMes.TabIndex = 1;
            this.btnMostrarMes.Text = "Mostrar mes";
            this.btnMostrarMes.UseVisualStyleBackColor = true;
            // 
            // selectorFecha
            // 
            this.selectorFecha.Location = new System.Drawing.Point(6, 19);
            this.selectorFecha.Name = "selectorFecha";
            this.selectorFecha.Size = new System.Drawing.Size(218, 20);
            this.selectorFecha.TabIndex = 0;
            this.selectorFecha.ValueChanged += new System.EventHandler(this.selectorFecha_ValueChanged);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // ColNAsiento
            // 
            this.ColNAsiento.FillWeight = 60F;
            this.ColNAsiento.HeaderText = "N°Asiento";
            this.ColNAsiento.Name = "ColNAsiento";
            this.ColNAsiento.ReadOnly = true;
            this.ColNAsiento.Width = 60;
            // 
            // ColFecha
            // 
            this.ColFecha.HeaderText = "Fecha";
            this.ColFecha.Name = "ColFecha";
            this.ColFecha.ReadOnly = true;
            // 
            // ColCuenta
            // 
            this.ColCuenta.HeaderText = "Cuenta";
            this.ColCuenta.Name = "ColCuenta";
            // 
            // ColTipoCuenta
            // 
            this.ColTipoCuenta.HeaderText = "Tipo Cuenta";
            this.ColTipoCuenta.Name = "ColTipoCuenta";
            this.ColTipoCuenta.ReadOnly = true;
            // 
            // ColDebe
            // 
            this.ColDebe.HeaderText = "Debe";
            this.ColDebe.Name = "ColDebe";
            this.ColDebe.ReadOnly = true;
            // 
            // ColHaber
            // 
            this.ColHaber.HeaderText = "Haber";
            this.ColHaber.Name = "ColHaber";
            this.ColHaber.ReadOnly = true;
            // 
            // ColDescripcion
            // 
            this.ColDescripcion.FillWeight = 400F;
            this.ColDescripcion.HeaderText = "Descripcion";
            this.ColDescripcion.Name = "ColDescripcion";
            this.ColDescripcion.ReadOnly = true;
            this.ColDescripcion.Width = 400;
            // 
            // BotonEliminar
            // 
            this.BotonEliminar.BackColor = System.Drawing.Color.MistyRose;
            this.BotonEliminar.Location = new System.Drawing.Point(705, 19);
            this.BotonEliminar.Name = "BotonEliminar";
            this.BotonEliminar.Size = new System.Drawing.Size(115, 23);
            this.BotonEliminar.TabIndex = 2;
            this.BotonEliminar.Text = "Eliminar Asiento";
            this.BotonEliminar.UseVisualStyleBackColor = false;
            // 
            // BotonNuevo
            // 
            this.BotonNuevo.BackColor = System.Drawing.Color.Honeydew;
            this.BotonNuevo.Location = new System.Drawing.Point(582, 19);
            this.BotonNuevo.Name = "BotonNuevo";
            this.BotonNuevo.Size = new System.Drawing.Size(117, 23);
            this.BotonNuevo.TabIndex = 3;
            this.BotonNuevo.Text = "Nuevo Asiento";
            this.BotonNuevo.UseVisualStyleBackColor = false;
            this.BotonNuevo.Click += new System.EventHandler(this.BotonNuevo_Click);
            // 
            // LibroDiario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 510);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "LibroDiario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LibroDiario";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LibroDiario_FormClosing);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAsientos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.DataGridView dataGridAsientos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnMostrarMes;
        private System.Windows.Forms.DateTimePicker selectorFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNAsiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTipoCuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDebe;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColHaber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDescripcion;
        private System.Windows.Forms.Button BotonNuevo;
        private System.Windows.Forms.Button BotonEliminar;
    }
}
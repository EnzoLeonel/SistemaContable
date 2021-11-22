
namespace SistemaContable.Vistas
{
    partial class EliminarAsiento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EliminarAsiento));
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.dataGridEliminar = new System.Windows.Forms.DataGridView();
            this.ColFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAsiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEliminar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.dataGridEliminar);
            this.groupBox.Location = new System.Drawing.Point(12, 12);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(571, 252);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Asientos";
            // 
            // dataGridEliminar
            // 
            this.dataGridEliminar.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dataGridEliminar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEliminar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColFecha,
            this.ID,
            this.ColAsiento,
            this.ColValor,
            this.ColDescripcion,
            this.ColEliminar});
            this.dataGridEliminar.Location = new System.Drawing.Point(6, 19);
            this.dataGridEliminar.Name = "dataGridEliminar";
            this.dataGridEliminar.Size = new System.Drawing.Size(553, 227);
            this.dataGridEliminar.TabIndex = 0;
            this.dataGridEliminar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridEliminar_CellContentClick);
            // 
            // ColFecha
            // 
            this.ColFecha.FillWeight = 70F;
            this.ColFecha.HeaderText = "Fecha";
            this.ColFecha.Name = "ColFecha";
            this.ColFecha.ReadOnly = true;
            this.ColFecha.Width = 70;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // ColAsiento
            // 
            this.ColAsiento.FillWeight = 50F;
            this.ColAsiento.HeaderText = "N°Asiento";
            this.ColAsiento.Name = "ColAsiento";
            this.ColAsiento.ReadOnly = true;
            this.ColAsiento.Width = 50;
            // 
            // ColValor
            // 
            this.ColValor.FillWeight = 70F;
            this.ColValor.HeaderText = "Valor";
            this.ColValor.Name = "ColValor";
            this.ColValor.ReadOnly = true;
            this.ColValor.Width = 70;
            // 
            // ColDescripcion
            // 
            this.ColDescripcion.FillWeight = 250F;
            this.ColDescripcion.HeaderText = "Descripción";
            this.ColDescripcion.Name = "ColDescripcion";
            this.ColDescripcion.ReadOnly = true;
            this.ColDescripcion.Width = 250;
            // 
            // ColEliminar
            // 
            this.ColEliminar.FillWeight = 70F;
            this.ColEliminar.HeaderText = "Eliminar";
            this.ColEliminar.Name = "ColEliminar";
            this.ColEliminar.ReadOnly = true;
            this.ColEliminar.Width = 70;
            // 
            // EliminarAsiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 268);
            this.Controls.Add(this.groupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EliminarAsiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar Asiento";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EliminarAsiento_FormClosing);
            this.groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEliminar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        public System.Windows.Forms.DataGridView dataGridEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAsiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDescripcion;
        private System.Windows.Forms.DataGridViewButtonColumn ColEliminar;
    }
}
namespace farmacia_residencia_modelado
{
    partial class Index
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
            this.txtNom = new System.Windows.Forms.TextBox();
            this.dg = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Laboratorio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Vencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.combo_venc = new System.Windows.Forms.ComboBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.lbl_labo = new System.Windows.Forms.Label();
            this.txt_labo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNom
            // 
            this.txtNom.BackColor = System.Drawing.Color.Silver;
            this.txtNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNom.Location = new System.Drawing.Point(225, 57);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(122, 22);
            this.txtNom.TabIndex = 1;
            this.txtNom.TextChanged += new System.EventHandler(this.txtNom_TextChanged);
            // 
            // dg
            // 
            this.dg.AllowUserToAddRows = false;
            this.dg.AllowUserToDeleteRows = false;
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Laboratorio,
            this.Unidad,
            this.Cantidad,
            this.Fecha_Vencimiento});
            this.dg.Location = new System.Drawing.Point(50, 112);
            this.dg.Name = "dg";
            this.dg.Size = new System.Drawing.Size(646, 330);
            this.dg.TabIndex = 4;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Laboratorio
            // 
            this.Laboratorio.HeaderText = "Laboratorio";
            this.Laboratorio.Name = "Laboratorio";
            // 
            // Unidad
            // 
            this.Unidad.HeaderText = "Unidad";
            this.Unidad.Name = "Unidad";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Fecha_Vencimiento
            // 
            this.Fecha_Vencimiento.HeaderText = "Fecha_Vencimiento";
            this.Fecha_Vencimiento.Name = "Fecha_Vencimiento";
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha.ForeColor = System.Drawing.Color.White;
            this.lbl_fecha.Location = new System.Drawing.Point(543, 38);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(124, 16);
            this.lbl_fecha.TabIndex = 6;
            this.lbl_fecha.Text = "Fecha vencimiento:";
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codigo.ForeColor = System.Drawing.Color.White;
            this.lbl_codigo.Location = new System.Drawing.Point(47, 38);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(90, 16);
            this.lbl_codigo.TabIndex = 8;
            this.lbl_codigo.Text = "Código GTIN:";
            // 
            // combo_venc
            // 
            this.combo_venc.BackColor = System.Drawing.Color.Silver;
            this.combo_venc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_venc.FormattingEnabled = true;
            this.combo_venc.Items.AddRange(new object[] {
            "Todas",
            "Solo vencidas",
            "Vencen dentro 7 días",
            "Vencen dentro 30 días",
            "Vencen próximos meses",
            "Vencen el próximo año"});
            this.combo_venc.Location = new System.Drawing.Point(546, 57);
            this.combo_venc.Name = "combo_venc";
            this.combo_venc.Size = new System.Drawing.Size(150, 24);
            this.combo_venc.TabIndex = 3;
            this.combo_venc.SelectedIndexChanged += new System.EventHandler(this.combo_venc_SelectedIndexChanged);
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.ForeColor = System.Drawing.Color.White;
            this.lbl_nombre.Location = new System.Drawing.Point(222, 40);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(60, 16);
            this.lbl_nombre.TabIndex = 11;
            this.lbl_nombre.Text = "Nombre:";
            // 
            // txt_codigo
            // 
            this.txt_codigo.BackColor = System.Drawing.Color.Silver;
            this.txt_codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigo.Location = new System.Drawing.Point(50, 57);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(134, 22);
            this.txt_codigo.TabIndex = 0;
            this.txt_codigo.TextChanged += new System.EventHandler(this.txt_codigo_TextChanged);
            // 
            // lbl_labo
            // 
            this.lbl_labo.AutoSize = true;
            this.lbl_labo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_labo.ForeColor = System.Drawing.Color.White;
            this.lbl_labo.Location = new System.Drawing.Point(388, 38);
            this.lbl_labo.Name = "lbl_labo";
            this.lbl_labo.Size = new System.Drawing.Size(80, 16);
            this.lbl_labo.TabIndex = 13;
            this.lbl_labo.Text = "Laboratorio:";
            // 
            // txt_labo
            // 
            this.txt_labo.BackColor = System.Drawing.Color.Silver;
            this.txt_labo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_labo.Location = new System.Drawing.Point(391, 57);
            this.txt_labo.Name = "txt_labo";
            this.txt_labo.Size = new System.Drawing.Size(115, 22);
            this.txt_labo.TabIndex = 2;
            this.txt_labo.TextChanged += new System.EventHandler(this.txt_labo_TextChanged);
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(752, 495);
            this.Controls.Add(this.lbl_labo);
            this.Controls.Add(this.txt_labo);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.combo_venc);
            this.Controls.Add(this.lbl_codigo);
            this.Controls.Add(this.lbl_fecha);
            this.Controls.Add(this.dg);
            this.Controls.Add(this.txtNom);
            this.MaximizeBox = false;
            this.Name = "Index";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Medicamento";
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.Label lbl_codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Laboratorio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Vencimiento;
        private System.Windows.Forms.ComboBox combo_venc;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Label lbl_labo;
        private System.Windows.Forms.TextBox txt_labo;
    }
}


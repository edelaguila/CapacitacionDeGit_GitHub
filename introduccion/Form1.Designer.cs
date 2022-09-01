namespace introduccion
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
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_marca = new System.Windows.Forms.Label();
            this.lbl_existencia = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_marca = new System.Windows.Forms.TextBox();
            this.txt_existencia = new System.Windows.Forms.TextBox();
            this.rdb_activo = new System.Windows.Forms.RadioButton();
            this.txt_inactivo = new System.Windows.Forms.RadioButton();
            this.btg_estado = new System.Windows.Forms.GroupBox();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.dtv_datos = new System.Windows.Forms.DataGridView();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btg_estado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtv_datos)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(12, 9);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(23, 16);
            this.lbl_id.TabIndex = 0;
            this.lbl_id.Text = "ID:";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(12, 41);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(59, 16);
            this.lbl_nombre.TabIndex = 1;
            this.lbl_nombre.Text = "Nombre:";
            // 
            // lbl_marca
            // 
            this.lbl_marca.AutoSize = true;
            this.lbl_marca.Location = new System.Drawing.Point(12, 73);
            this.lbl_marca.Name = "lbl_marca";
            this.lbl_marca.Size = new System.Drawing.Size(48, 16);
            this.lbl_marca.TabIndex = 2;
            this.lbl_marca.Text = "Marca:";
            // 
            // lbl_existencia
            // 
            this.lbl_existencia.AutoSize = true;
            this.lbl_existencia.Location = new System.Drawing.Point(12, 105);
            this.lbl_existencia.Name = "lbl_existencia";
            this.lbl_existencia.Size = new System.Drawing.Size(71, 16);
            this.lbl_existencia.TabIndex = 3;
            this.lbl_existencia.Text = "Existencia:";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(162, 9);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(296, 22);
            this.txt_id.TabIndex = 5;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(162, 41);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(296, 22);
            this.txt_nombre.TabIndex = 6;
            // 
            // txt_marca
            // 
            this.txt_marca.Location = new System.Drawing.Point(162, 73);
            this.txt_marca.Name = "txt_marca";
            this.txt_marca.Size = new System.Drawing.Size(296, 22);
            this.txt_marca.TabIndex = 7;
            // 
            // txt_existencia
            // 
            this.txt_existencia.Location = new System.Drawing.Point(162, 105);
            this.txt_existencia.Name = "txt_existencia";
            this.txt_existencia.Size = new System.Drawing.Size(296, 22);
            this.txt_existencia.TabIndex = 8;
            // 
            // rdb_activo
            // 
            this.rdb_activo.AutoSize = true;
            this.rdb_activo.Location = new System.Drawing.Point(150, 21);
            this.rdb_activo.Name = "rdb_activo";
            this.rdb_activo.Size = new System.Drawing.Size(64, 20);
            this.rdb_activo.TabIndex = 9;
            this.rdb_activo.TabStop = true;
            this.rdb_activo.Text = "activo";
            this.rdb_activo.UseVisualStyleBackColor = true;
            // 
            // txt_inactivo
            // 
            this.txt_inactivo.AutoSize = true;
            this.txt_inactivo.Location = new System.Drawing.Point(366, 21);
            this.txt_inactivo.Name = "txt_inactivo";
            this.txt_inactivo.Size = new System.Drawing.Size(74, 20);
            this.txt_inactivo.TabIndex = 10;
            this.txt_inactivo.TabStop = true;
            this.txt_inactivo.Text = "inactivo";
            this.txt_inactivo.UseVisualStyleBackColor = true;
            // 
            // btg_estado
            // 
            this.btg_estado.Controls.Add(this.rdb_activo);
            this.btg_estado.Controls.Add(this.txt_inactivo);
            this.btg_estado.Location = new System.Drawing.Point(12, 139);
            this.btg_estado.Name = "btg_estado";
            this.btg_estado.Size = new System.Drawing.Size(446, 52);
            this.btg_estado.TabIndex = 11;
            this.btg_estado.TabStop = false;
            this.btg_estado.Text = "Estado:";
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(12, 270);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(125, 50);
            this.btn_agregar.TabIndex = 12;
            this.btn_agregar.Text = "AGREGAR";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(162, 270);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(138, 50);
            this.btn_eliminar.TabIndex = 13;
            this.btn_eliminar.Text = "ELIMINAR";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // dtv_datos
            // 
            this.dtv_datos.AllowUserToAddRows = false;
            this.dtv_datos.AllowUserToDeleteRows = false;
            this.dtv_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtv_datos.Location = new System.Drawing.Point(474, 9);
            this.dtv_datos.Name = "dtv_datos";
            this.dtv_datos.ReadOnly = true;
            this.dtv_datos.RowHeadersWidth = 51;
            this.dtv_datos.RowTemplate.Height = 24;
            this.dtv_datos.Size = new System.Drawing.Size(761, 311);
            this.dtv_datos.TabIndex = 14;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(320, 270);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(138, 50);
            this.btn_buscar.TabIndex = 15;
            this.btn_buscar.Text = "BUSCAR";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 332);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.dtv_datos);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.btg_estado);
            this.Controls.Add(this.txt_existencia);
            this.Controls.Add(this.txt_marca);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.lbl_existencia);
            this.Controls.Add(this.lbl_marca);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.lbl_id);
            this.Name = "Form1";
            this.Text = "Mant. Productos";
            this.btg_estado.ResumeLayout(false);
            this.btg_estado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtv_datos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_marca;
        private System.Windows.Forms.Label lbl_existencia;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_marca;
        private System.Windows.Forms.TextBox txt_existencia;
        private System.Windows.Forms.RadioButton rdb_activo;
        private System.Windows.Forms.RadioButton txt_inactivo;
        private System.Windows.Forms.GroupBox btg_estado;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.DataGridView dtv_datos;
        private System.Windows.Forms.Button btn_buscar;
    }
}


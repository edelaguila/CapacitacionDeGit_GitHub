
namespace CapacitacionODBC
{
    partial class General
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
            this.Lbl_receta = new System.Windows.Forms.Label();
            this.Lbl_nombre = new System.Windows.Forms.Label();
            this.Lbl_puesto = new System.Windows.Forms.Label();
            this.Lbl_departamento = new System.Windows.Forms.Label();
            this.Txt_nombre = new System.Windows.Forms.TextBox();
            this.Txt_puesto = new System.Windows.Forms.TextBox();
            this.Txt_departamento = new System.Windows.Forms.TextBox();
            this.Btn_agregar = new System.Windows.Forms.Button();
            this.Btn_eliminar = new System.Windows.Forms.Button();
            this.Btn_consulta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_receta
            // 
            this.Lbl_receta.AutoSize = true;
            this.Lbl_receta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_receta.Location = new System.Drawing.Point(21, 25);
            this.Lbl_receta.Name = "Lbl_receta";
            this.Lbl_receta.Size = new System.Drawing.Size(55, 18);
            this.Lbl_receta.TabIndex = 0;
            this.Lbl_receta.Text = "Receta";
            // 
            // Lbl_nombre
            // 
            this.Lbl_nombre.AutoSize = true;
            this.Lbl_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_nombre.Location = new System.Drawing.Point(21, 67);
            this.Lbl_nombre.Name = "Lbl_nombre";
            this.Lbl_nombre.Size = new System.Drawing.Size(62, 18);
            this.Lbl_nombre.TabIndex = 1;
            this.Lbl_nombre.Text = "Nombre";
            // 
            // Lbl_puesto
            // 
            this.Lbl_puesto.AutoSize = true;
            this.Lbl_puesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_puesto.Location = new System.Drawing.Point(21, 104);
            this.Lbl_puesto.Name = "Lbl_puesto";
            this.Lbl_puesto.Size = new System.Drawing.Size(55, 18);
            this.Lbl_puesto.TabIndex = 2;
            this.Lbl_puesto.Text = "Puesto";
            // 
            // Lbl_departamento
            // 
            this.Lbl_departamento.AutoSize = true;
            this.Lbl_departamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_departamento.Location = new System.Drawing.Point(21, 140);
            this.Lbl_departamento.Name = "Lbl_departamento";
            this.Lbl_departamento.Size = new System.Drawing.Size(102, 18);
            this.Lbl_departamento.TabIndex = 3;
            this.Lbl_departamento.Text = "Departamento";
            // 
            // Txt_nombre
            // 
            this.Txt_nombre.Location = new System.Drawing.Point(138, 68);
            this.Txt_nombre.Name = "Txt_nombre";
            this.Txt_nombre.Size = new System.Drawing.Size(254, 20);
            this.Txt_nombre.TabIndex = 4;
            // 
            // Txt_puesto
            // 
            this.Txt_puesto.Location = new System.Drawing.Point(138, 105);
            this.Txt_puesto.Name = "Txt_puesto";
            this.Txt_puesto.Size = new System.Drawing.Size(254, 20);
            this.Txt_puesto.TabIndex = 5;
            // 
            // Txt_departamento
            // 
            this.Txt_departamento.Location = new System.Drawing.Point(138, 141);
            this.Txt_departamento.Name = "Txt_departamento";
            this.Txt_departamento.Size = new System.Drawing.Size(254, 20);
            this.Txt_departamento.TabIndex = 6;
            // 
            // Btn_agregar
            // 
            this.Btn_agregar.BackColor = System.Drawing.Color.PaleGreen;
            this.Btn_agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_agregar.Location = new System.Drawing.Point(187, 186);
            this.Btn_agregar.Name = "Btn_agregar";
            this.Btn_agregar.Size = new System.Drawing.Size(83, 88);
            this.Btn_agregar.TabIndex = 7;
            this.Btn_agregar.Text = "Agregar";
            this.Btn_agregar.UseVisualStyleBackColor = false;
            this.Btn_agregar.Click += new System.EventHandler(this.Btn_agregar_Click);
            // 
            // Btn_eliminar
            // 
            this.Btn_eliminar.BackColor = System.Drawing.Color.PaleGreen;
            this.Btn_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_eliminar.Location = new System.Drawing.Point(276, 186);
            this.Btn_eliminar.Name = "Btn_eliminar";
            this.Btn_eliminar.Size = new System.Drawing.Size(83, 88);
            this.Btn_eliminar.TabIndex = 8;
            this.Btn_eliminar.Text = "Eliminar";
            this.Btn_eliminar.UseVisualStyleBackColor = false;
            // 
            // Btn_consulta
            // 
            this.Btn_consulta.BackColor = System.Drawing.Color.PaleGreen;
            this.Btn_consulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_consulta.Location = new System.Drawing.Point(408, 186);
            this.Btn_consulta.Name = "Btn_consulta";
            this.Btn_consulta.Size = new System.Drawing.Size(83, 88);
            this.Btn_consulta.TabIndex = 9;
            this.Btn_consulta.Text = "Consulta";
            this.Btn_consulta.UseVisualStyleBackColor = false;
            this.Btn_consulta.Click += new System.EventHandler(this.Btn_consulta_Click);
            // 
            // General
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 295);
            this.Controls.Add(this.Btn_consulta);
            this.Controls.Add(this.Btn_eliminar);
            this.Controls.Add(this.Btn_agregar);
            this.Controls.Add(this.Txt_departamento);
            this.Controls.Add(this.Txt_puesto);
            this.Controls.Add(this.Txt_nombre);
            this.Controls.Add(this.Lbl_departamento);
            this.Controls.Add(this.Lbl_puesto);
            this.Controls.Add(this.Lbl_nombre);
            this.Controls.Add(this.Lbl_receta);
            this.Name = "General";
            this.Text = "General";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_receta;
        private System.Windows.Forms.Label Lbl_nombre;
        private System.Windows.Forms.Label Lbl_puesto;
        private System.Windows.Forms.Label Lbl_departamento;
        private System.Windows.Forms.TextBox Txt_nombre;
        private System.Windows.Forms.TextBox Txt_puesto;
        private System.Windows.Forms.TextBox Txt_departamento;
        private System.Windows.Forms.Button Btn_agregar;
        private System.Windows.Forms.Button Btn_eliminar;
        private System.Windows.Forms.Button Btn_consulta;
    }
}


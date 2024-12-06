
namespace EmpleadosPrueba
{
    partial class txt_depto
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_puesto = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_aliminar = new System.Windows.Forms.Button();
            this.btn_consulta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(54, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Receto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(58, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(58, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 30);
            this.label3.TabIndex = 3;
            this.label3.Text = "Puesto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(58, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 30);
            this.label4.TabIndex = 4;
            this.label4.Text = "Departamento";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txt_puesto
            // 
            this.txt_puesto.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_puesto.Location = new System.Drawing.Point(246, 134);
            this.txt_puesto.Name = "txt_puesto";
            this.txt_puesto.Size = new System.Drawing.Size(232, 34);
            this.txt_puesto.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(246, 177);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(232, 34);
            this.textBox3.TabIndex = 6;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.Location = new System.Drawing.Point(246, 86);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(232, 34);
            this.txt_nombre.TabIndex = 7;
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(166, 290);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(131, 129);
            this.btn_agregar.TabIndex = 8;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // btn_aliminar
            // 
            this.btn_aliminar.Location = new System.Drawing.Point(329, 290);
            this.btn_aliminar.Name = "btn_aliminar";
            this.btn_aliminar.Size = new System.Drawing.Size(131, 129);
            this.btn_aliminar.TabIndex = 9;
            this.btn_aliminar.Text = "Eliminar";
            this.btn_aliminar.UseVisualStyleBackColor = true;
            // 
            // btn_consulta
            // 
            this.btn_consulta.Location = new System.Drawing.Point(497, 290);
            this.btn_consulta.Name = "btn_consulta";
            this.btn_consulta.Size = new System.Drawing.Size(131, 129);
            this.btn_consulta.TabIndex = 10;
            this.btn_consulta.Text = "Consulta";
            this.btn_consulta.UseVisualStyleBackColor = true;
            this.btn_consulta.Click += new System.EventHandler(this.btn_consulta_Click);
            // 
            // txt_depto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_consulta);
            this.Controls.Add(this.btn_aliminar);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txt_puesto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "txt_depto";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_puesto;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_aliminar;
        private System.Windows.Forms.Button btn_consulta;
    }
}


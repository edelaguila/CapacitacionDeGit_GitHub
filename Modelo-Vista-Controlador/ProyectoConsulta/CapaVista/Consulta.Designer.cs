
namespace CapaVista
{
    partial class Consulta
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
            this.Btn_consulta = new System.Windows.Forms.Button();
            this.Dgv_consulta = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_consulta)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_consulta
            // 
            this.Btn_consulta.Location = new System.Drawing.Point(600, 82);
            this.Btn_consulta.Name = "Btn_consulta";
            this.Btn_consulta.Size = new System.Drawing.Size(166, 97);
            this.Btn_consulta.TabIndex = 0;
            this.Btn_consulta.Text = "Consulta";
            this.Btn_consulta.UseVisualStyleBackColor = true;
            this.Btn_consulta.Click += new System.EventHandler(this.Btn_consulta_Click);
            // 
            // Dgv_consulta
            // 
            this.Dgv_consulta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_consulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_consulta.Location = new System.Drawing.Point(42, 214);
            this.Dgv_consulta.Name = "Dgv_consulta";
            this.Dgv_consulta.ReadOnly = true;
            this.Dgv_consulta.RowHeadersWidth = 62;
            this.Dgv_consulta.RowTemplate.Height = 28;
            this.Dgv_consulta.Size = new System.Drawing.Size(724, 211);
            this.Dgv_consulta.TabIndex = 1;
            // 
            // Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Dgv_consulta);
            this.Controls.Add(this.Btn_consulta);
            this.Name = "Consulta";
            this.Text = "Consulta";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_consulta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_consulta;
        private System.Windows.Forms.DataGridView Dgv_consulta;
    }
}
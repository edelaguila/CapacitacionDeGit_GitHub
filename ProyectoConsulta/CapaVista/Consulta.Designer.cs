
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
            this.Dgv_consulta = new System.Windows.Forms.DataGridView();
            this.Btn_consulta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_consulta)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_consulta
            // 
            this.Dgv_consulta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_consulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_consulta.Location = new System.Drawing.Point(12, 195);
            this.Dgv_consulta.Name = "Dgv_consulta";
            this.Dgv_consulta.Size = new System.Drawing.Size(691, 150);
            this.Dgv_consulta.TabIndex = 0;
            // 
            // Btn_consulta
            // 
            this.Btn_consulta.Location = new System.Drawing.Point(609, 67);
            this.Btn_consulta.Name = "Btn_consulta";
            this.Btn_consulta.Size = new System.Drawing.Size(94, 44);
            this.Btn_consulta.TabIndex = 1;
            this.Btn_consulta.Text = "Consulta";
            this.Btn_consulta.UseVisualStyleBackColor = true;
            this.Btn_consulta.Click += new System.EventHandler(this.Btn_consulta_Click);
            // 
            // Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 357);
            this.Controls.Add(this.Btn_consulta);
            this.Controls.Add(this.Dgv_consulta);
            this.Name = "Consulta";
            this.Text = "Consulta";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_consulta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_consulta;
        private System.Windows.Forms.Button Btn_consulta;
    }
}
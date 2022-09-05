
namespace Capa_Vista
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
            this.Dtg1 = new System.Windows.Forms.DataGridView();
            this.BtnCons = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dtg1)).BeginInit();
            this.SuspendLayout();
            // 
            // Dtg1
            // 
            this.Dtg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dtg1.Location = new System.Drawing.Point(13, 88);
            this.Dtg1.Margin = new System.Windows.Forms.Padding(4);
            this.Dtg1.Name = "Dtg1";
            this.Dtg1.RowHeadersWidth = 51;
            this.Dtg1.Size = new System.Drawing.Size(680, 219);
            this.Dtg1.TabIndex = 0;
            // 
            // BtnCons
            // 
            this.BtnCons.Location = new System.Drawing.Point(13, 13);
            this.BtnCons.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCons.Name = "BtnCons";
            this.BtnCons.Size = new System.Drawing.Size(167, 33);
            this.BtnCons.TabIndex = 1;
            this.BtnCons.Text = "Mostrar";
            this.BtnCons.UseVisualStyleBackColor = true;
            this.BtnCons.Click += new System.EventHandler(this.BtnCons_Click);
            // 
            // Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(699, 334);
            this.Controls.Add(this.BtnCons);
            this.Controls.Add(this.Dtg1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Consulta";
            this.Text = "Consulta";
            this.Load += new System.EventHandler(this.Consulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dtg1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Dtg1;
        private System.Windows.Forms.Button BtnCons;
    }
}
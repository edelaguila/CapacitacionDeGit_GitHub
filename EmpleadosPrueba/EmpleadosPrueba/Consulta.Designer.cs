
namespace EmpleadosPrueba
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
            this.Dgb_1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Dgb_1)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgb_1
            // 
            this.Dgb_1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgb_1.Location = new System.Drawing.Point(12, 101);
            this.Dgb_1.Name = "Dgb_1";
            this.Dgb_1.Size = new System.Drawing.Size(776, 263);
            this.Dgb_1.TabIndex = 0;
            // 
            // Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 387);
            this.Controls.Add(this.Dgb_1);
            this.Name = "Consulta";
            this.Text = "Consulta";
            ((System.ComponentModel.ISupportInitialize)(this.Dgb_1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgb_1;
    }
}
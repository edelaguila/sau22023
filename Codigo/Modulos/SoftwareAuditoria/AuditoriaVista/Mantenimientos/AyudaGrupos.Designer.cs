
namespace AuditoriaVista.Mantenimientos
{
    partial class AyudaGrupos
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
            this.dtgGrupos = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgGrupos)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgGrupos
            // 
            this.dtgGrupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgGrupos.Location = new System.Drawing.Point(12, 57);
            this.dtgGrupos.Name = "dtgGrupos";
            this.dtgGrupos.Size = new System.Drawing.Size(326, 149);
            this.dtgGrupos.TabIndex = 33;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(125, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 28);
            this.button1.TabIndex = 34;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // AyudaGrupos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 221);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtgGrupos);
            this.Name = "AyudaGrupos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AyudaGrupos";
            ((System.ComponentModel.ISupportInitialize)(this.dtgGrupos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgGrupos;
        private System.Windows.Forms.Button button1;
    }
}
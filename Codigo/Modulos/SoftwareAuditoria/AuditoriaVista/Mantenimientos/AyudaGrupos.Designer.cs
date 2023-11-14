
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
            this.dtgAyudaGrupos = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAyudaGrupos)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgAyudaGrupos
            // 
            this.dtgAyudaGrupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAyudaGrupos.Location = new System.Drawing.Point(12, 57);
            this.dtgAyudaGrupos.Name = "dtgAyudaGrupos";
            this.dtgAyudaGrupos.Size = new System.Drawing.Size(326, 149);
            this.dtgAyudaGrupos.TabIndex = 33;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(125, 12);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(106, 28);
            this.btnAgregar.TabIndex = 34;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // AyudaGrupos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 221);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dtgAyudaGrupos);
            this.Name = "AyudaGrupos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AyudaGrupos";
            this.Load += new System.EventHandler(this.AyudaGrupos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgAyudaGrupos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgAyudaGrupos;
        private System.Windows.Forms.Button btnAgregar;
    }
}
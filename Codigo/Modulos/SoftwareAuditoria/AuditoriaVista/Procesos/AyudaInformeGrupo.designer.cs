
namespace AuditoriaVista.Procesos
{
    partial class AyudaInformeGrupo
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
            this.txtAgregar = new System.Windows.Forms.Button();
            this.dtgAyudaGrupo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAyudaGrupo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAgregar
            // 
            this.txtAgregar.Location = new System.Drawing.Point(125, 12);
            this.txtAgregar.Name = "txtAgregar";
            this.txtAgregar.Size = new System.Drawing.Size(88, 27);
            this.txtAgregar.TabIndex = 0;
            this.txtAgregar.Text = "Agregar";
            this.txtAgregar.UseVisualStyleBackColor = true;
            this.txtAgregar.Click += new System.EventHandler(this.txtAgregar_Click);
            // 
            // dtgAyudaGrupo
            // 
            this.dtgAyudaGrupo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAyudaGrupo.Location = new System.Drawing.Point(12, 45);
            this.dtgAyudaGrupo.Name = "dtgAyudaGrupo";
            this.dtgAyudaGrupo.Size = new System.Drawing.Size(320, 150);
            this.dtgAyudaGrupo.TabIndex = 1;
            this.dtgAyudaGrupo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgAyudaGrupo_CellContentClick);
            // 
            // AyudaInformeGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 212);
            this.Controls.Add(this.dtgAyudaGrupo);
            this.Controls.Add(this.txtAgregar);
            this.Name = "AyudaInformeGrupo";
            this.Text = "AyudaInformeGrupo";
            this.Load += new System.EventHandler(this.AyudaInformeGrupo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgAyudaGrupo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button txtAgregar;
        private System.Windows.Forms.DataGridView dtgAyudaGrupo;
    }
}
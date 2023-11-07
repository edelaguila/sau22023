
namespace AuditoriaVista.Procesos
{
    partial class AyudaInformeActividad
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dtgAyudaActividad = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAyudaActividad)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(121, 12);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(106, 28);
            this.btnAgregar.TabIndex = 36;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dtgAyudaActividad
            // 
            this.dtgAyudaActividad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAyudaActividad.Location = new System.Drawing.Point(12, 46);
            this.dtgAyudaActividad.Name = "dtgAyudaActividad";
            this.dtgAyudaActividad.Size = new System.Drawing.Size(326, 149);
            this.dtgAyudaActividad.TabIndex = 37;
            this.dtgAyudaActividad.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgAyudaActividad_CellContentClick);
            // 
            // AyudaInformeActividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 203);
            this.Controls.Add(this.dtgAyudaActividad);
            this.Controls.Add(this.btnAgregar);
            this.Name = "AyudaInformeActividad";
            this.Text = "AyudaInformeActividad";
            this.Load += new System.EventHandler(this.AyudaInformeActividad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgAyudaActividad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dtgAyudaActividad;
    }
}
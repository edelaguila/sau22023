
namespace AuditoriaVista.Procesos
{
    partial class AyudaInformes
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
            this.btnAgregarActividad = new System.Windows.Forms.Button();
            this.dtgActividad = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dtgGrupo = new System.Windows.Forms.DataGridView();
            this.btnAgregarGrupo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgActividad)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgGrupo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarActividad
            // 
            this.btnAgregarActividad.Location = new System.Drawing.Point(115, 26);
            this.btnAgregarActividad.Name = "btnAgregarActividad";
            this.btnAgregarActividad.Size = new System.Drawing.Size(99, 42);
            this.btnAgregarActividad.TabIndex = 36;
            this.btnAgregarActividad.Text = "Agregar";
            this.btnAgregarActividad.UseVisualStyleBackColor = true;
            // 
            // dtgActividad
            // 
            this.dtgActividad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgActividad.Location = new System.Drawing.Point(6, 74);
            this.dtgActividad.Name = "dtgActividad";
            this.dtgActividad.Size = new System.Drawing.Size(326, 149);
            this.dtgActividad.TabIndex = 35;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(349, 254);
            this.tabControl1.TabIndex = 37;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dtgActividad);
            this.tabPage1.Controls.Add(this.btnAgregarActividad);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(341, 228);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Actividad";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnAgregarGrupo);
            this.tabPage2.Controls.Add(this.dtgGrupo);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(341, 228);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Grupo";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dtgGrupo
            // 
            this.dtgGrupo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgGrupo.Location = new System.Drawing.Point(6, 72);
            this.dtgGrupo.Name = "dtgGrupo";
            this.dtgGrupo.Size = new System.Drawing.Size(329, 150);
            this.dtgGrupo.TabIndex = 0;
            // 
            // btnAgregarGrupo
            // 
            this.btnAgregarGrupo.Location = new System.Drawing.Point(113, 26);
            this.btnAgregarGrupo.Name = "btnAgregarGrupo";
            this.btnAgregarGrupo.Size = new System.Drawing.Size(91, 40);
            this.btnAgregarGrupo.TabIndex = 1;
            this.btnAgregarGrupo.Text = "Agregar";
            this.btnAgregarGrupo.UseVisualStyleBackColor = true;
            // 
            // AyudaInformes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 276);
            this.Controls.Add(this.tabControl1);
            this.Name = "AyudaInformes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ayudaActividades";
            ((System.ComponentModel.ISupportInitialize)(this.dtgActividad)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgGrupo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarActividad;
        private System.Windows.Forms.DataGridView dtgActividad;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnAgregarGrupo;
        private System.Windows.Forms.DataGridView dtgGrupo;
    }
}
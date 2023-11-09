
namespace AuditoriaVista.Mantenimientos
{
    partial class Estandares
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
            this.navegador1 = new NavegadorVista.Navegador();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_normaEstandar = new System.Windows.Forms.TextBox();
            this.txt_nombreEstandar = new System.Windows.Forms.TextBox();
            this.txt_estadoEstandar = new System.Windows.Forms.TextBox();
            this.txt_idEstandar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(148, 15);
            this.navegador1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(765, 187);
            this.navegador1.TabIndex = 0;
            this.navegador1.Load += new System.EventHandler(this.navegador1_Load);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(116, 332);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(884, 207);
            this.dataGridView1.TabIndex = 38;
            this.dataGridView1.Tag = "tbl_estandares";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(51, 225);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 25);
            this.label9.TabIndex = 37;
            this.label9.Text = "Id";
            // 
            // txt_normaEstandar
            // 
            this.txt_normaEstandar.Location = new System.Drawing.Point(849, 223);
            this.txt_normaEstandar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_normaEstandar.Name = "txt_normaEstandar";
            this.txt_normaEstandar.Size = new System.Drawing.Size(181, 22);
            this.txt_normaEstandar.TabIndex = 35;
            this.txt_normaEstandar.Tag = "norma_estandar";
            // 
            // txt_nombreEstandar
            // 
            this.txt_nombreEstandar.Location = new System.Drawing.Point(507, 224);
            this.txt_nombreEstandar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_nombreEstandar.Name = "txt_nombreEstandar";
            this.txt_nombreEstandar.Size = new System.Drawing.Size(181, 22);
            this.txt_nombreEstandar.TabIndex = 32;
            this.txt_nombreEstandar.Tag = "nombre_estandar";
            // 
            // txt_estadoEstandar
            // 
            this.txt_estadoEstandar.Location = new System.Drawing.Point(148, 287);
            this.txt_estadoEstandar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_estadoEstandar.Name = "txt_estadoEstandar";
            this.txt_estadoEstandar.Size = new System.Drawing.Size(181, 22);
            this.txt_estadoEstandar.TabIndex = 30;
            this.txt_estadoEstandar.Tag = "estado_estandar";
            // 
            // txt_idEstandar
            // 
            this.txt_idEstandar.Location = new System.Drawing.Point(148, 225);
            this.txt_idEstandar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_idEstandar.Name = "txt_idEstandar";
            this.txt_idEstandar.Size = new System.Drawing.Size(181, 22);
            this.txt_idEstandar.TabIndex = 29;
            this.txt_idEstandar.Tag = "pk_id_estandar";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(733, 225);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 25);
            this.label8.TabIndex = 27;
            this.label8.Text = "Norma";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(376, 222);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 25);
            this.label4.TabIndex = 23;
            this.label4.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 289);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "Estado";
            // 
            // Estandares
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_normaEstandar);
            this.Controls.Add(this.txt_nombreEstandar);
            this.Controls.Add(this.txt_estadoEstandar);
            this.Controls.Add(this.txt_idEstandar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.navegador1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Estandares";
            this.Text = "Estandares";
            this.Load += new System.EventHandler(this.Estandares_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NavegadorVista.Navegador navegador1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_normaEstandar;
        private System.Windows.Forms.TextBox txt_nombreEstandar;
        private System.Windows.Forms.TextBox txt_estadoEstandar;
        private System.Windows.Forms.TextBox txt_idEstandar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}

namespace AuditoriaVista.Mantenimientos
{
    partial class Unidades
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
            this.label9 = new System.Windows.Forms.Label();
            this.txt_idUnidad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtNombreUnidad = new System.Windows.Forms.TextBox();
            this.cbxMedidas = new System.Windows.Forms.ComboBox();
            this.cbxEstado = new System.Windows.Forms.ComboBox();
            this.txtDescripcionUnidad = new System.Windows.Forms.TextBox();
            this.navegador1 = new NavegadorVista.Navegador();
            this.txtMedida = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(35, 250);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 25);
            this.label9.TabIndex = 69;
            this.label9.Text = "ID Unidad";
            // 
            // txt_idUnidad
            // 
            this.txt_idUnidad.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_idUnidad.Location = new System.Drawing.Point(184, 246);
            this.txt_idUnidad.Margin = new System.Windows.Forms.Padding(4);
            this.txt_idUnidad.Name = "txt_idUnidad";
            this.txt_idUnidad.ReadOnly = true;
            this.txt_idUnidad.Size = new System.Drawing.Size(155, 29);
            this.txt_idUnidad.TabIndex = 63;
            this.txt_idUnidad.Tag = "pk_id_unidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(472, 312);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 25);
            this.label5.TabIndex = 62;
            this.label5.Text = "Estado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(362, 246);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 25);
            this.label6.TabIndex = 61;
            this.label6.Text = "Nombre de Unidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 307);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 25);
            this.label2.TabIndex = 58;
            this.label2.Text = "Medida";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 369);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.TabIndex = 57;
            this.label1.Text = "Descripción";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(45, 431);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(844, 258);
            this.dataGridView1.TabIndex = 72;
            this.dataGridView1.Tag = "tbl_unidades";
            // 
            // txtNombreUnidad
            // 
            this.txtNombreUnidad.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreUnidad.Location = new System.Drawing.Point(593, 246);
            this.txtNombreUnidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreUnidad.Name = "txtNombreUnidad";
            this.txtNombreUnidad.Size = new System.Drawing.Size(332, 29);
            this.txtNombreUnidad.TabIndex = 73;
            this.txtNombreUnidad.Tag = "nombre_unidad";
            // 
            // cbxMedidas
            // 
            this.cbxMedidas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMedidas.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMedidas.FormattingEnabled = true;
            this.cbxMedidas.Location = new System.Drawing.Point(184, 307);
            this.cbxMedidas.Name = "cbxMedidas";
            this.cbxMedidas.Size = new System.Drawing.Size(155, 30);
            this.cbxMedidas.TabIndex = 74;
            this.cbxMedidas.SelectedIndexChanged += new System.EventHandler(this.cbxMedidas_SelectedIndexChanged);
            // 
            // cbxEstado
            // 
            this.cbxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEstado.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEstado.FormattingEnabled = true;
            this.cbxEstado.Location = new System.Drawing.Point(593, 302);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(153, 30);
            this.cbxEstado.TabIndex = 75;
            this.cbxEstado.SelectedIndexChanged += new System.EventHandler(this.cbxEstado_SelectedIndexChanged);
            // 
            // txtDescripcionUnidad
            // 
            this.txtDescripcionUnidad.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionUnidad.Location = new System.Drawing.Point(184, 365);
            this.txtDescripcionUnidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcionUnidad.Name = "txtDescripcionUnidad";
            this.txtDescripcionUnidad.Size = new System.Drawing.Size(741, 29);
            this.txtDescripcionUnidad.TabIndex = 76;
            this.txtDescripcionUnidad.Tag = "descripcion_unidad";
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(86, 14);
            this.navegador1.Margin = new System.Windows.Forms.Padding(5);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(765, 187);
            this.navegador1.TabIndex = 77;
            this.navegador1.Load += new System.EventHandler(this.navegador1_Load);
            // 
            // txtMedida
            // 
            this.txtMedida.Location = new System.Drawing.Point(354, 310);
            this.txtMedida.Name = "txtMedida";
            this.txtMedida.Size = new System.Drawing.Size(100, 22);
            this.txtMedida.TabIndex = 78;
            this.txtMedida.Tag = "fk_id_medida";
            this.txtMedida.Visible = false;
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(768, 307);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(100, 22);
            this.txtEstado.TabIndex = 79;
            this.txtEstado.Tag = "estado_unidad";
            this.txtEstado.Visible = false;
            // 
            // Unidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 725);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtMedida);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.txtDescripcionUnidad);
            this.Controls.Add(this.cbxEstado);
            this.Controls.Add(this.cbxMedidas);
            this.Controls.Add(this.txtNombreUnidad);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_idUnidad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Unidades";
            this.Text = "Unidades";
            this.Load += new System.EventHandler(this.Unidades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_idUnidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtNombreUnidad;
        private System.Windows.Forms.ComboBox cbxMedidas;
        private System.Windows.Forms.ComboBox cbxEstado;
        private System.Windows.Forms.TextBox txtDescripcionUnidad;
        private NavegadorVista.Navegador navegador1;
        private System.Windows.Forms.TextBox txtMedida;
        private System.Windows.Forms.TextBox txtEstado;
    }
}
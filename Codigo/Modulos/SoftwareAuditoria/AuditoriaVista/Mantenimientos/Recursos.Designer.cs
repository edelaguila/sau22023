
namespace AuditoriaVista.Mantenimientos
{
    partial class Recursos
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.navegador1 = new NavegadorVista.Navegador();
            this.txt_costoRecurso = new System.Windows.Forms.TextBox();
            this.txt_nombreRecurso = new System.Windows.Forms.TextBox();
            this.txt_cantidadRecurso = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_unidadRecurso = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_encargadoRecurso = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxEncargado = new System.Windows.Forms.ComboBox();
            this.txt_idRecurso = new System.Windows.Forms.TextBox();
            this.cbxEstado = new System.Windows.Forms.ComboBox();
            this.txtEstadoRecurso = new System.Windows.Forms.TextBox();
            this.cbxUnidad = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(80, 417);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(889, 228);
            this.dataGridView1.TabIndex = 55;
            this.dataGridView1.Tag = "tbl_recursos";
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(151, 15);
            this.navegador1.Margin = new System.Windows.Forms.Padding(5);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(765, 187);
            this.navegador1.TabIndex = 59;
            this.navegador1.Load += new System.EventHandler(this.navegador1_Load);
            // 
            // txt_costoRecurso
            // 
            this.txt_costoRecurso.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_costoRecurso.Location = new System.Drawing.Point(597, 288);
            this.txt_costoRecurso.Margin = new System.Windows.Forms.Padding(4);
            this.txt_costoRecurso.Name = "txt_costoRecurso";
            this.txt_costoRecurso.Size = new System.Drawing.Size(126, 30);
            this.txt_costoRecurso.TabIndex = 51;
            this.txt_costoRecurso.Tag = "costo_recurso";
            // 
            // txt_nombreRecurso
            // 
            this.txt_nombreRecurso.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombreRecurso.Location = new System.Drawing.Point(597, 235);
            this.txt_nombreRecurso.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nombreRecurso.Name = "txt_nombreRecurso";
            this.txt_nombreRecurso.Size = new System.Drawing.Size(426, 30);
            this.txt_nombreRecurso.TabIndex = 49;
            this.txt_nombreRecurso.Tag = "nombre_recurso";
            // 
            // txt_cantidadRecurso
            // 
            this.txt_cantidadRecurso.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cantidadRecurso.Location = new System.Drawing.Point(856, 286);
            this.txt_cantidadRecurso.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cantidadRecurso.Name = "txt_cantidadRecurso";
            this.txt_cantidadRecurso.Size = new System.Drawing.Size(167, 30);
            this.txt_cantidadRecurso.TabIndex = 52;
            this.txt_cantidadRecurso.Tag = "cantidad_recurso";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(108, 352);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 25);
            this.label6.TabIndex = 45;
            this.label6.Text = "Unidad";
            // 
            // txt_unidadRecurso
            // 
            this.txt_unidadRecurso.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_unidadRecurso.Location = new System.Drawing.Point(21, 121);
            this.txt_unidadRecurso.Margin = new System.Windows.Forms.Padding(4);
            this.txt_unidadRecurso.Name = "txt_unidadRecurso";
            this.txt_unidadRecurso.Size = new System.Drawing.Size(121, 30);
            this.txt_unidadRecurso.TabIndex = 53;
            this.txt_unidadRecurso.Tag = "fk_id_unidad";
            this.txt_unidadRecurso.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(743, 286);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 25);
            this.label3.TabIndex = 44;
            this.label3.Text = "Cantidad";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(83, 239);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 25);
            this.label9.TabIndex = 54;
            this.label9.Text = "Id recurso";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(489, 288);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 25);
            this.label4.TabIndex = 43;
            this.label4.Text = "Costo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(489, 350);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 25);
            this.label5.TabIndex = 46;
            this.label5.Text = "Estado";
            // 
            // txt_encargadoRecurso
            // 
            this.txt_encargadoRecurso.Location = new System.Drawing.Point(21, 189);
            this.txt_encargadoRecurso.Margin = new System.Windows.Forms.Padding(4);
            this.txt_encargadoRecurso.Name = "txt_encargadoRecurso";
            this.txt_encargadoRecurso.Size = new System.Drawing.Size(121, 22);
            this.txt_encargadoRecurso.TabIndex = 50;
            this.txt_encargadoRecurso.Tag = "fk_id_encargado";
            this.txt_encargadoRecurso.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(393, 235);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 25);
            this.label1.TabIndex = 41;
            this.label1.Text = "Nombre Recurso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 290);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 25);
            this.label2.TabIndex = 42;
            this.label2.Text = "Encargado";
            // 
            // cbxEncargado
            // 
            this.cbxEncargado.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEncargado.FormattingEnabled = true;
            this.cbxEncargado.Location = new System.Drawing.Point(227, 290);
            this.cbxEncargado.Margin = new System.Windows.Forms.Padding(4);
            this.cbxEncargado.Name = "cbxEncargado";
            this.cbxEncargado.Size = new System.Drawing.Size(150, 31);
            this.cbxEncargado.TabIndex = 57;
            this.cbxEncargado.SelectedIndexChanged += new System.EventHandler(this.cbxEncargado_SelectedIndexChanged);
            // 
            // txt_idRecurso
            // 
            this.txt_idRecurso.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_idRecurso.Location = new System.Drawing.Point(227, 238);
            this.txt_idRecurso.Margin = new System.Windows.Forms.Padding(4);
            this.txt_idRecurso.Name = "txt_idRecurso";
            this.txt_idRecurso.Size = new System.Drawing.Size(150, 30);
            this.txt_idRecurso.TabIndex = 47;
            this.txt_idRecurso.Tag = "pk_id_recurso";
            // 
            // cbxEstado
            // 
            this.cbxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEstado.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEstado.FormattingEnabled = true;
            this.cbxEstado.Location = new System.Drawing.Point(597, 345);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(143, 30);
            this.cbxEstado.TabIndex = 76;
            this.cbxEstado.SelectedIndexChanged += new System.EventHandler(this.cbxEstado_SelectedIndexChanged);
            // 
            // txtEstadoRecurso
            // 
            this.txtEstadoRecurso.Location = new System.Drawing.Point(21, 159);
            this.txtEstadoRecurso.Margin = new System.Windows.Forms.Padding(4);
            this.txtEstadoRecurso.Name = "txtEstadoRecurso";
            this.txtEstadoRecurso.Size = new System.Drawing.Size(121, 22);
            this.txtEstadoRecurso.TabIndex = 77;
            this.txtEstadoRecurso.Tag = "estado_recurso";
            this.txtEstadoRecurso.Visible = false;
            // 
            // cbxUnidad
            // 
            this.cbxUnidad.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxUnidad.FormattingEnabled = true;
            this.cbxUnidad.Location = new System.Drawing.Point(227, 344);
            this.cbxUnidad.Margin = new System.Windows.Forms.Padding(4);
            this.cbxUnidad.Name = "cbxUnidad";
            this.cbxUnidad.Size = new System.Drawing.Size(150, 31);
            this.cbxUnidad.TabIndex = 78;
            this.cbxUnidad.SelectedIndexChanged += new System.EventHandler(this.cbxUnidad_SelectedIndexChanged);
            // 
            // Recursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 688);
            this.Controls.Add(this.cbxUnidad);
            this.Controls.Add(this.txtEstadoRecurso);
            this.Controls.Add(this.cbxEstado);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.cbxEncargado);
            this.Controls.Add(this.txt_idRecurso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_encargadoRecurso);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_unidadRecurso);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_nombreRecurso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_cantidadRecurso);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_costoRecurso);
            this.Controls.Add(this.label9);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Recursos";
            this.Text = "Recursos";
            this.Load += new System.EventHandler(this.Recursos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private NavegadorVista.Navegador navegador1;
        private System.Windows.Forms.TextBox txt_costoRecurso;
        private System.Windows.Forms.TextBox txt_nombreRecurso;
        private System.Windows.Forms.TextBox txt_cantidadRecurso;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_unidadRecurso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_encargadoRecurso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxEncargado;
        private System.Windows.Forms.TextBox txt_idRecurso;
        private System.Windows.Forms.ComboBox cbxEstado;
        private System.Windows.Forms.TextBox txtEstadoRecurso;
        private System.Windows.Forms.ComboBox cbxUnidad;
    }
}
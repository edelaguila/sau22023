
namespace AuditoriaVista.Procesos
{
    partial class Actividades
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_actividad = new System.Windows.Forms.TextBox();
            this.txt_proyecto = new System.Windows.Forms.TextBox();
            this.txt_recurso = new System.Windows.Forms.TextBox();
            this.txt_NoGrupo = new System.Windows.Forms.TextBox();
            this.cb_prioridad = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_NomActividad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dTP_fechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dTP_fechaFinalizar = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_porcentaje = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cB_estadoActividad = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Actividad";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID Proyecto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(247, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID Recurso";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(370, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Prioridad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(480, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "No. Grupo";
            // 
            // txt_actividad
            // 
            this.txt_actividad.Location = new System.Drawing.Point(30, 62);
            this.txt_actividad.Name = "txt_actividad";
            this.txt_actividad.Size = new System.Drawing.Size(62, 20);
            this.txt_actividad.TabIndex = 5;
            // 
            // txt_proyecto
            // 
            this.txt_proyecto.Location = new System.Drawing.Point(133, 62);
            this.txt_proyecto.Name = "txt_proyecto";
            this.txt_proyecto.Size = new System.Drawing.Size(60, 20);
            this.txt_proyecto.TabIndex = 6;
            this.txt_proyecto.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txt_recurso
            // 
            this.txt_recurso.Location = new System.Drawing.Point(250, 62);
            this.txt_recurso.Name = "txt_recurso";
            this.txt_recurso.Size = new System.Drawing.Size(58, 20);
            this.txt_recurso.TabIndex = 7;
            // 
            // txt_NoGrupo
            // 
            this.txt_NoGrupo.Location = new System.Drawing.Point(483, 62);
            this.txt_NoGrupo.Name = "txt_NoGrupo";
            this.txt_NoGrupo.Size = new System.Drawing.Size(58, 20);
            this.txt_NoGrupo.TabIndex = 8;
            // 
            // cb_prioridad
            // 
            this.cb_prioridad.FormattingEnabled = true;
            this.cb_prioridad.Items.AddRange(new object[] {
            "Alto",
            "Medio",
            "Bajo"});
            this.cb_prioridad.Location = new System.Drawing.Point(358, 62);
            this.cb_prioridad.Name = "cb_prioridad";
            this.cb_prioridad.Size = new System.Drawing.Size(75, 21);
            this.cb_prioridad.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Nombre de Actividad";
            // 
            // txt_NomActividad
            // 
            this.txt_NomActividad.Location = new System.Drawing.Point(30, 161);
            this.txt_NomActividad.Name = "txt_NomActividad";
            this.txt_NomActividad.Size = new System.Drawing.Size(103, 20);
            this.txt_NomActividad.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(166, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Fecha de Inicio";
            // 
            // dTP_fechaInicio
            // 
            this.dTP_fechaInicio.Location = new System.Drawing.Point(169, 161);
            this.dTP_fechaInicio.Name = "dTP_fechaInicio";
            this.dTP_fechaInicio.Size = new System.Drawing.Size(159, 20);
            this.dTP_fechaInicio.TabIndex = 13;
            // 
            // dTP_fechaFinalizar
            // 
            this.dTP_fechaFinalizar.Location = new System.Drawing.Point(362, 161);
            this.dTP_fechaFinalizar.Name = "dTP_fechaFinalizar";
            this.dTP_fechaFinalizar.Size = new System.Drawing.Size(179, 20);
            this.dTP_fechaFinalizar.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(359, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Fecha de Finalizacion";
            // 
            // txt_porcentaje
            // 
            this.txt_porcentaje.Location = new System.Drawing.Point(30, 262);
            this.txt_porcentaje.Name = "txt_porcentaje";
            this.txt_porcentaje.Size = new System.Drawing.Size(121, 20);
            this.txt_porcentaje.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 228);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Porcentaje de Activadad";
            // 
            // cB_estadoActividad
            // 
            this.cB_estadoActividad.FormattingEnabled = true;
            this.cB_estadoActividad.Items.AddRange(new object[] {
            "Completado",
            "Pendiente"});
            this.cB_estadoActividad.Location = new System.Drawing.Point(211, 261);
            this.cB_estadoActividad.Name = "cB_estadoActividad";
            this.cB_estadoActividad.Size = new System.Drawing.Size(97, 21);
            this.cB_estadoActividad.TabIndex = 19;
            this.cB_estadoActividad.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(208, 228);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Estado de Activadad";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(410, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Actividades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cB_estadoActividad);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_porcentaje);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dTP_fechaFinalizar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dTP_fechaInicio);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_NomActividad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cb_prioridad);
            this.Controls.Add(this.txt_NoGrupo);
            this.Controls.Add(this.txt_recurso);
            this.Controls.Add(this.txt_proyecto);
            this.Controls.Add(this.txt_actividad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Actividades";
            this.Text = "Actividades";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_actividad;
        private System.Windows.Forms.TextBox txt_proyecto;
        private System.Windows.Forms.TextBox txt_recurso;
        private System.Windows.Forms.TextBox txt_NoGrupo;
        private System.Windows.Forms.ComboBox cb_prioridad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_NomActividad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dTP_fechaInicio;
        private System.Windows.Forms.DateTimePicker dTP_fechaFinalizar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_porcentaje;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cB_estadoActividad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
    }
}

namespace AuditoriaVista.Mantenimientos
{
    partial class Usuarios
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
            this.label6 = new System.Windows.Forms.Label();
            this.txt_idUsuario = new System.Windows.Forms.TextBox();
            this.navegador1 = new NavegadorVista.Navegador();
            this.txt_nombreUsuario = new System.Windows.Forms.TextBox();
            this.txt_apellidoUsuario = new System.Windows.Forms.TextBox();
            this.txt_correoUsuario = new System.Windows.Forms.TextBox();
            this.txt_passUsuario = new System.Windows.Forms.TextBox();
            this.txt_userUsuario = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_estado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombres";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellidos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(274, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Contraseña";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(274, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Usuario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(560, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "Estado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(274, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 21);
            this.label6.TabIndex = 4;
            this.label6.Text = "Correo";
            // 
            // txt_idUsuario
            // 
            this.txt_idUsuario.Location = new System.Drawing.Point(103, 179);
            this.txt_idUsuario.Name = "txt_idUsuario";
            this.txt_idUsuario.Size = new System.Drawing.Size(137, 20);
            this.txt_idUsuario.TabIndex = 8;
            this.txt_idUsuario.Tag = "pk_id_usurioAuditoria";
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(121, 9);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(574, 152);
            this.navegador1.TabIndex = 9;
            this.navegador1.Load += new System.EventHandler(this.navegador1_Load);
            // 
            // txt_nombreUsuario
            // 
            this.txt_nombreUsuario.Location = new System.Drawing.Point(103, 229);
            this.txt_nombreUsuario.Name = "txt_nombreUsuario";
            this.txt_nombreUsuario.Size = new System.Drawing.Size(137, 20);
            this.txt_nombreUsuario.TabIndex = 10;
            this.txt_nombreUsuario.Tag = "nombre_usuarioAuditoria";
            // 
            // txt_apellidoUsuario
            // 
            this.txt_apellidoUsuario.Location = new System.Drawing.Point(103, 282);
            this.txt_apellidoUsuario.Name = "txt_apellidoUsuario";
            this.txt_apellidoUsuario.Size = new System.Drawing.Size(137, 20);
            this.txt_apellidoUsuario.TabIndex = 11;
            this.txt_apellidoUsuario.Tag = "apellido_usuarioAuditoria";
            // 
            // txt_correoUsuario
            // 
            this.txt_correoUsuario.Location = new System.Drawing.Point(372, 282);
            this.txt_correoUsuario.Name = "txt_correoUsuario";
            this.txt_correoUsuario.Size = new System.Drawing.Size(137, 20);
            this.txt_correoUsuario.TabIndex = 14;
            this.txt_correoUsuario.Tag = "correo_usuarioAuditoria";
            // 
            // txt_passUsuario
            // 
            this.txt_passUsuario.Location = new System.Drawing.Point(372, 228);
            this.txt_passUsuario.Name = "txt_passUsuario";
            this.txt_passUsuario.Size = new System.Drawing.Size(137, 20);
            this.txt_passUsuario.TabIndex = 13;
            this.txt_passUsuario.Tag = "password_usuarioAuditoria";
            // 
            // txt_userUsuario
            // 
            this.txt_userUsuario.Location = new System.Drawing.Point(372, 178);
            this.txt_userUsuario.Name = "txt_userUsuario";
            this.txt_userUsuario.Size = new System.Drawing.Size(137, 20);
            this.txt_userUsuario.TabIndex = 12;
            this.txt_userUsuario.Tag = "username_usuarioAuditoria";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(30, 179);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 21);
            this.label9.TabIndex = 17;
            this.label9.Text = "Id";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(69, 323);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(663, 115);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.Tag = "tbl_usuariosauditoria";
            // 
            // txt_estado
            // 
            this.txt_estado.Location = new System.Drawing.Point(622, 229);
            this.txt_estado.Name = "txt_estado";
            this.txt_estado.Size = new System.Drawing.Size(137, 20);
            this.txt_estado.TabIndex = 21;
            this.txt_estado.Tag = "estado_usuarioAuditoria";
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_estado);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_correoUsuario);
            this.Controls.Add(this.txt_passUsuario);
            this.Controls.Add(this.txt_userUsuario);
            this.Controls.Add(this.txt_apellidoUsuario);
            this.Controls.Add(this.txt_nombreUsuario);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.txt_idUsuario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Usuarios";
            this.Text = "Usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_idUsuario;
        private NavegadorVista.Navegador navegador1;
        private System.Windows.Forms.TextBox txt_nombreUsuario;
        private System.Windows.Forms.TextBox txt_apellidoUsuario;
        private System.Windows.Forms.TextBox txt_correoUsuario;
        private System.Windows.Forms.TextBox txt_passUsuario;
        private System.Windows.Forms.TextBox txt_userUsuario;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_estado;
    }
}

namespace CapaPresentacion
{
    partial class RegistrarClientes
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
            this.nombreClient = new System.Windows.Forms.TextBox();
            this.registrar = new FontAwesome.Sharp.IconButton();
            this.label8 = new System.Windows.Forms.Label();
            this.CorreoClien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.telCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(453, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(475, 58);
            this.label1.TabIndex = 99;
            this.label1.Text = "Registro de Clientes";
            // 
            // nombreClient
            // 
            this.nombreClient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nombreClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreClient.Location = new System.Drawing.Point(172, 112);
            this.nombreClient.Name = "nombreClient";
            this.nombreClient.Size = new System.Drawing.Size(285, 30);
            this.nombreClient.TabIndex = 94;
            // 
            // registrar
            // 
            this.registrar.BackColor = System.Drawing.Color.SpringGreen;
            this.registrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrar.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.registrar.IconColor = System.Drawing.Color.Black;
            this.registrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.registrar.IconSize = 20;
            this.registrar.Location = new System.Drawing.Point(214, 298);
            this.registrar.Name = "registrar";
            this.registrar.Size = new System.Drawing.Size(191, 34);
            this.registrar.TabIndex = 97;
            this.registrar.Text = "Registrar";
            this.registrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.registrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.registrar.UseVisualStyleBackColor = false;
            this.registrar.Click += new System.EventHandler(this.registrar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 20);
            this.label8.TabIndex = 91;
            this.label8.Text = "Nombre Completo:";
            // 
            // CorreoClien
            // 
            this.CorreoClien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CorreoClien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CorreoClien.Location = new System.Drawing.Point(172, 224);
            this.CorreoClien.Name = "CorreoClien";
            this.CorreoClien.Size = new System.Drawing.Size(285, 30);
            this.CorreoClien.TabIndex = 96;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(85, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 92;
            this.label3.Text = "Telefono:";
            // 
            // telCliente
            // 
            this.telCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.telCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telCliente.Location = new System.Drawing.Point(172, 169);
            this.telCliente.Name = "telCliente";
            this.telCliente.Size = new System.Drawing.Size(285, 30);
            this.telCliente.TabIndex = 95;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(100, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 93;
            this.label4.Text = "Correo:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.nombreClient);
            this.groupBox1.Controls.Add(this.registrar);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.CorreoClien);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.telCliente);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(321, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(573, 409);
            this.groupBox1.TabIndex = 100;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalles del cliente";
            // 
            // RegistrarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 632);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrarClientes";
            this.Text = "RegistrarClientes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nombreClient;
        private FontAwesome.Sharp.IconButton registrar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox CorreoClien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox telCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
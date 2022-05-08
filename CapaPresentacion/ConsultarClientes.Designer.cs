
namespace CapaPresentacion
{
    partial class ConsultarClientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtIndi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.btnEditarClien = new FontAwesome.Sharp.IconButton();
            this.telCliente = new System.Windows.Forms.TextBox();
            this.CorreoCliente = new System.Windows.Forms.TextBox();
            this.NombreClien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbobusqueda = new System.Windows.Forms.ComboBox();
            this.btnLimpiar = new FontAwesome.Sharp.IconButton();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBus = new System.Windows.Forms.TextBox();
            this.DatosClientes = new System.Windows.Forms.DataGridView();
            this.btnSelecccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telCli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DatosClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIndi
            // 
            this.txtIndi.Location = new System.Drawing.Point(222, 116);
            this.txtIndi.Name = "txtIndi";
            this.txtIndi.Size = new System.Drawing.Size(32, 22);
            this.txtIndi.TabIndex = 133;
            this.txtIndi.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label2.Location = new System.Drawing.Point(23, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 25);
            this.label2.TabIndex = 132;
            this.label2.Text = "Detalles del Cliente";
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(271, 116);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(32, 22);
            this.txtid.TabIndex = 131;
            this.txtid.Visible = false;
            // 
            // btnEditarClien
            // 
            this.btnEditarClien.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnEditarClien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarClien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarClien.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnEditarClien.IconColor = System.Drawing.Color.Black;
            this.btnEditarClien.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditarClien.IconSize = 20;
            this.btnEditarClien.Location = new System.Drawing.Point(68, 432);
            this.btnEditarClien.Name = "btnEditarClien";
            this.btnEditarClien.Size = new System.Drawing.Size(155, 59);
            this.btnEditarClien.TabIndex = 130;
            this.btnEditarClien.Text = "Editar";
            this.btnEditarClien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarClien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditarClien.UseVisualStyleBackColor = false;
            this.btnEditarClien.Click += new System.EventHandler(this.btnEditarClien_Click);
            // 
            // telCliente
            // 
            this.telCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.telCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telCliente.Location = new System.Drawing.Point(28, 360);
            this.telCliente.Name = "telCliente";
            this.telCliente.Size = new System.Drawing.Size(275, 27);
            this.telCliente.TabIndex = 127;
            // 
            // CorreoCliente
            // 
            this.CorreoCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CorreoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CorreoCliente.Location = new System.Drawing.Point(28, 289);
            this.CorreoCliente.Name = "CorreoCliente";
            this.CorreoCliente.Size = new System.Drawing.Size(275, 27);
            this.CorreoCliente.TabIndex = 126;
            // 
            // NombreClien
            // 
            this.NombreClien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NombreClien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreClien.Location = new System.Drawing.Point(28, 222);
            this.NombreClien.Name = "NombreClien";
            this.NombreClien.Size = new System.Drawing.Size(275, 27);
            this.NombreClien.TabIndex = 125;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 340);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 124;
            this.label4.Text = "Telefono:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 123;
            this.label3.Text = "Correo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 20);
            this.label8.TabIndex = 122;
            this.label8.Text = "Nombre Completo:";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Dock = System.Windows.Forms.DockStyle.Left;
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(324, 632);
            this.label10.TabIndex = 121;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 605);
            this.label1.TabIndex = 120;
            // 
            // cbobusqueda
            // 
            this.cbobusqueda.BackColor = System.Drawing.SystemColors.Control;
            this.cbobusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbobusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbobusqueda.FormattingEnabled = true;
            this.cbobusqueda.Location = new System.Drawing.Point(618, 107);
            this.cbobusqueda.Name = "cbobusqueda";
            this.cbobusqueda.Size = new System.Drawing.Size(171, 28);
            this.cbobusqueda.TabIndex = 119;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.White;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnLimpiar.IconColor = System.Drawing.Color.Black;
            this.btnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiar.IconSize = 24;
            this.btnLimpiar.Location = new System.Drawing.Point(1072, 109);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(33, 29);
            this.btnLimpiar.TabIndex = 117;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.White;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnBuscar.IconColor = System.Drawing.Color.Black;
            this.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscar.IconSize = 24;
            this.btnBuscar.Location = new System.Drawing.Point(1022, 109);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(33, 29);
            this.btnBuscar.TabIndex = 116;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(481, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 25);
            this.label7.TabIndex = 115;
            this.label7.Text = "Buscar  Por:";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label9.Location = new System.Drawing.Point(683, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(211, 82);
            this.label9.TabIndex = 114;
            this.label9.Text = "Lista de Clientes";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBus
            // 
            this.txtBus.BackColor = System.Drawing.Color.White;
            this.txtBus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBus.Location = new System.Drawing.Point(795, 109);
            this.txtBus.Name = "txtBus";
            this.txtBus.Size = new System.Drawing.Size(205, 26);
            this.txtBus.TabIndex = 118;
            // 
            // DatosClientes
            // 
            this.DatosClientes.AllowUserToAddRows = false;
            this.DatosClientes.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DatosClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DatosClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatosClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnSelecccionar,
            this.ID,
            this.Nombre,
            this.Correo,
            this.telCli,
            this.btnEliminar});
            this.DatosClientes.Location = new System.Drawing.Point(395, 187);
            this.DatosClientes.MultiSelect = false;
            this.DatosClientes.Name = "DatosClientes";
            this.DatosClientes.ReadOnly = true;
            this.DatosClientes.RowHeadersWidth = 51;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.DatosClientes.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DatosClientes.RowTemplate.Height = 28;
            this.DatosClientes.Size = new System.Drawing.Size(796, 397);
            this.DatosClientes.TabIndex = 113;
            this.DatosClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DatosClientes_CellContentClick);
            this.DatosClientes.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.DatosClientes_CellPainting);
            // 
            // btnSelecccionar
            // 
            this.btnSelecccionar.HeaderText = "";
            this.btnSelecccionar.MinimumWidth = 6;
            this.btnSelecccionar.Name = "btnSelecccionar";
            this.btnSelecccionar.ReadOnly = true;
            this.btnSelecccionar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnSelecccionar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnSelecccionar.Width = 32;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 35;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 220;
            // 
            // Correo
            // 
            this.Correo.HeaderText = "Correo";
            this.Correo.MinimumWidth = 6;
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            this.Correo.Width = 240;
            // 
            // telCli
            // 
            this.telCli.HeaderText = "Telefono";
            this.telCli.MinimumWidth = 6;
            this.telCli.Name = "telCli";
            this.telCli.ReadOnly = true;
            this.telCli.Width = 180;
            // 
            // btnEliminar
            // 
            this.btnEliminar.HeaderText = "";
            this.btnEliminar.MinimumWidth = 6;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.ReadOnly = true;
            this.btnEliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnEliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnEliminar.Width = 30;
            // 
            // ConsultarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 632);
            this.Controls.Add(this.txtIndi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.btnEditarClien);
            this.Controls.Add(this.telCliente);
            this.Controls.Add(this.CorreoCliente);
            this.Controls.Add(this.NombreClien);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbobusqueda);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtBus);
            this.Controls.Add(this.DatosClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultarClientes";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "ConsultarClientes";
            this.Load += new System.EventHandler(this.ConsultarClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DatosClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtIndi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtid;
        private FontAwesome.Sharp.IconButton btnEditarClien;
        private System.Windows.Forms.TextBox telCliente;
        private System.Windows.Forms.TextBox CorreoCliente;
        private System.Windows.Forms.TextBox NombreClien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbobusqueda;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBus;
        private System.Windows.Forms.DataGridView DatosClientes;
        private System.Windows.Forms.DataGridViewButtonColumn btnSelecccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn telCli;
        private System.Windows.Forms.DataGridViewButtonColumn btnEliminar;
    }
}
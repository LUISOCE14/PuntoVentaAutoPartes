
namespace CapaPresentacion
{
    partial class ConsultarEmpleados
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CorreoEmple = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.EditarEmpl = new FontAwesome.Sharp.IconButton();
            this.telEmple = new System.Windows.Forms.TextBox();
            this.NombreEmpl = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbobusqueda = new System.Windows.Forms.ComboBox();
            this.txtBus = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new FontAwesome.Sharp.IconButton();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.DatosEmpleados = new System.Windows.Forms.DataGridView();
            this.btnSelecccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreEm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CorreoEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnElimimar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DatosEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // CorreoEmple
            // 
            this.CorreoEmple.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CorreoEmple.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CorreoEmple.Location = new System.Drawing.Point(23, 300);
            this.CorreoEmple.Name = "CorreoEmple";
            this.CorreoEmple.Size = new System.Drawing.Size(206, 27);
            this.CorreoEmple.TabIndex = 266;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 265;
            this.label1.Text = "Correo:";
            // 
            // txtIn
            // 
            this.txtIn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIn.Location = new System.Drawing.Point(196, 104);
            this.txtIn.Name = "txtIn";
            this.txtIn.Size = new System.Drawing.Size(29, 22);
            this.txtIn.TabIndex = 264;
            this.txtIn.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label2.Location = new System.Drawing.Point(18, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 26);
            this.label2.TabIndex = 263;
            this.label2.Text = "Detalles del Empleado";
            // 
            // txtid
            // 
            this.txtid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(231, 104);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(38, 22);
            this.txtid.TabIndex = 262;
            this.txtid.Visible = false;
            // 
            // EditarEmpl
            // 
            this.EditarEmpl.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.EditarEmpl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditarEmpl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditarEmpl.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.EditarEmpl.IconColor = System.Drawing.Color.Black;
            this.EditarEmpl.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.EditarEmpl.IconSize = 20;
            this.EditarEmpl.Location = new System.Drawing.Point(47, 381);
            this.EditarEmpl.Name = "EditarEmpl";
            this.EditarEmpl.Size = new System.Drawing.Size(155, 48);
            this.EditarEmpl.TabIndex = 261;
            this.EditarEmpl.Text = "Editar";
            this.EditarEmpl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EditarEmpl.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EditarEmpl.UseVisualStyleBackColor = false;
            this.EditarEmpl.Click += new System.EventHandler(this.EditarEmpl_Click);
            // 
            // telEmple
            // 
            this.telEmple.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.telEmple.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telEmple.Location = new System.Drawing.Point(24, 241);
            this.telEmple.Name = "telEmple";
            this.telEmple.Size = new System.Drawing.Size(206, 27);
            this.telEmple.TabIndex = 256;
            // 
            // NombreEmpl
            // 
            this.NombreEmpl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NombreEmpl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreEmpl.Location = new System.Drawing.Point(23, 177);
            this.NombreEmpl.Name = "NombreEmpl";
            this.NombreEmpl.Size = new System.Drawing.Size(206, 27);
            this.NombreEmpl.TabIndex = 254;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 253;
            this.label4.Text = "Telefono:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 20);
            this.label8.TabIndex = 251;
            this.label8.Text = "Nombre Completo:";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Dock = System.Windows.Forms.DockStyle.Left;
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(281, 632);
            this.label10.TabIndex = 250;
            // 
            // cbobusqueda
            // 
            this.cbobusqueda.BackColor = System.Drawing.SystemColors.Control;
            this.cbobusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbobusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbobusqueda.FormattingEnabled = true;
            this.cbobusqueda.Location = new System.Drawing.Point(603, 118);
            this.cbobusqueda.Name = "cbobusqueda";
            this.cbobusqueda.Size = new System.Drawing.Size(171, 28);
            this.cbobusqueda.TabIndex = 249;
            // 
            // txtBus
            // 
            this.txtBus.BackColor = System.Drawing.Color.White;
            this.txtBus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBus.Location = new System.Drawing.Point(780, 120);
            this.txtBus.Name = "txtBus";
            this.txtBus.Size = new System.Drawing.Size(205, 26);
            this.txtBus.TabIndex = 248;
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
            this.btnLimpiar.Location = new System.Drawing.Point(1057, 120);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(33, 29);
            this.btnLimpiar.TabIndex = 247;
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
            this.btnBuscar.Location = new System.Drawing.Point(1007, 120);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(33, 29);
            this.btnBuscar.TabIndex = 246;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(466, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 25);
            this.label7.TabIndex = 245;
            this.label7.Text = "Buscar  Por:";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label9.Location = new System.Drawing.Point(657, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(334, 82);
            this.label9.TabIndex = 244;
            this.label9.Text = "Lista de Empleados";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DatosEmpleados
            // 
            this.DatosEmpleados.AllowUserToAddRows = false;
            this.DatosEmpleados.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DatosEmpleados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DatosEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatosEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnSelecccionar,
            this.ID,
            this.NombreEm,
            this.Telefono,
            this.CorreoEmpleado,
            this.btnElimimar});
            this.DatosEmpleados.Location = new System.Drawing.Point(333, 177);
            this.DatosEmpleados.MultiSelect = false;
            this.DatosEmpleados.Name = "DatosEmpleados";
            this.DatosEmpleados.ReadOnly = true;
            this.DatosEmpleados.RowHeadersWidth = 51;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.DatosEmpleados.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DatosEmpleados.RowTemplate.Height = 28;
            this.DatosEmpleados.Size = new System.Drawing.Size(875, 418);
            this.DatosEmpleados.TabIndex = 243;
            this.DatosEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DatosEmpleados_CellContentClick);
            this.DatosEmpleados.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.DatosEmpleados_CellPainting);
            // 
            // btnSelecccionar
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.btnSelecccionar.DefaultCellStyle = dataGridViewCellStyle2;
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
            // NombreEm
            // 
            this.NombreEm.HeaderText = "Nombre";
            this.NombreEm.MinimumWidth = 6;
            this.NombreEm.Name = "NombreEm";
            this.NombreEm.ReadOnly = true;
            this.NombreEm.Width = 220;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.MinimumWidth = 6;
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            this.Telefono.Width = 180;
            // 
            // CorreoEmpleado
            // 
            this.CorreoEmpleado.HeaderText = "Correo";
            this.CorreoEmpleado.MinimumWidth = 6;
            this.CorreoEmpleado.Name = "CorreoEmpleado";
            this.CorreoEmpleado.ReadOnly = true;
            this.CorreoEmpleado.Width = 230;
            // 
            // btnElimimar
            // 
            this.btnElimimar.HeaderText = "";
            this.btnElimimar.MinimumWidth = 6;
            this.btnElimimar.Name = "btnElimimar";
            this.btnElimimar.ReadOnly = true;
            this.btnElimimar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnElimimar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnElimimar.Width = 30;
            // 
            // ConsultarEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 632);
            this.Controls.Add(this.CorreoEmple);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.EditarEmpl);
            this.Controls.Add(this.telEmple);
            this.Controls.Add(this.NombreEmpl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbobusqueda);
            this.Controls.Add(this.txtBus);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.DatosEmpleados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultarEmpleados";
            this.Text = "ConsultarEmpleados";
            this.Load += new System.EventHandler(this.ConsultarEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DatosEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CorreoEmple;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtid;
        private FontAwesome.Sharp.IconButton EditarEmpl;
        private System.Windows.Forms.TextBox telEmple;
        private System.Windows.Forms.TextBox NombreEmpl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbobusqueda;
        private System.Windows.Forms.TextBox txtBus;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView DatosEmpleados;
        private System.Windows.Forms.DataGridViewButtonColumn btnSelecccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreEm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn CorreoEmpleado;
        private System.Windows.Forms.DataGridViewButtonColumn btnElimimar;
    }
}
namespace CapaVistaHoteleria
{
    partial class frmReservaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReservaciones));
            this.navegador1 = new DLL.nav.navegador();
            this.dgvReservacion = new System.Windows.Forms.DataGridView();
            this.txtEstatus = new System.Windows.Forms.TextBox();
            this.rbtInactivo = new System.Windows.Forms.RadioButton();
            this.rbtActivo = new System.Windows.Forms.RadioButton();
            this.txtFechaFin = new System.Windows.Forms.TextBox();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFechaInicio = new System.Windows.Forms.TextBox();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCantidadHabitacion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxHabitacion = new System.Windows.Forms.ComboBox();
            this.txtIdHabitacion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxCliente = new System.Windows.Forms.ComboBox();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdReservacion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbcheckout = new System.Windows.Forms.RadioButton();
            this.rbtCheckin = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservacion)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.navegador1.Location = new System.Drawing.Point(0, -1);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(1189, 87);
            this.navegador1.TabIndex = 0;
            // 
            // dgvReservacion
            // 
            this.dgvReservacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservacion.Location = new System.Drawing.Point(614, 148);
            this.dgvReservacion.Name = "dgvReservacion";
            this.dgvReservacion.RowHeadersWidth = 47;
            this.dgvReservacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReservacion.Size = new System.Drawing.Size(565, 260);
            this.dgvReservacion.TabIndex = 42;
            this.dgvReservacion.SelectionChanged += new System.EventHandler(this.dgvReservacion_SelectionChanged);
            // 
            // txtEstatus
            // 
            this.txtEstatus.Location = new System.Drawing.Point(507, 339);
            this.txtEstatus.Name = "txtEstatus";
            this.txtEstatus.Size = new System.Drawing.Size(59, 20);
            this.txtEstatus.TabIndex = 41;
            this.txtEstatus.Tag = "estatus";
            this.txtEstatus.TextChanged += new System.EventHandler(this.txtEstatus_TextChanged);
            // 
            // rbtInactivo
            // 
            this.rbtInactivo.AutoSize = true;
            this.rbtInactivo.Location = new System.Drawing.Point(26, 48);
            this.rbtInactivo.Name = "rbtInactivo";
            this.rbtInactivo.Size = new System.Drawing.Size(63, 17);
            this.rbtInactivo.TabIndex = 40;
            this.rbtInactivo.TabStop = true;
            this.rbtInactivo.Text = "Inactivo";
            this.rbtInactivo.UseVisualStyleBackColor = true;
            this.rbtInactivo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbtInactivo_MouseClick);
            // 
            // rbtActivo
            // 
            this.rbtActivo.AutoSize = true;
            this.rbtActivo.Location = new System.Drawing.Point(26, 25);
            this.rbtActivo.Name = "rbtActivo";
            this.rbtActivo.Size = new System.Drawing.Size(55, 17);
            this.rbtActivo.TabIndex = 39;
            this.rbtActivo.TabStop = true;
            this.rbtActivo.Text = "Activo";
            this.rbtActivo.UseVisualStyleBackColor = true;
            this.rbtActivo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbtActivo_MouseClick);
            // 
            // txtFechaFin
            // 
            this.txtFechaFin.Location = new System.Drawing.Point(507, 249);
            this.txtFechaFin.Name = "txtFechaFin";
            this.txtFechaFin.Size = new System.Drawing.Size(59, 20);
            this.txtFechaFin.TabIndex = 37;
            this.txtFechaFin.Tag = "fechaFin";
            this.txtFechaFin.TextChanged += new System.EventHandler(this.txtFechaFin_TextChanged);
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFin.Location = new System.Drawing.Point(355, 248);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(129, 20);
            this.dtpFechaFin.TabIndex = 36;
            this.dtpFechaFin.Value = new System.DateTime(2021, 10, 26, 0, 0, 0, 0);
            this.dtpFechaFin.ValueChanged += new System.EventHandler(this.dtpFechaFin_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(352, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Fecha Fin";
            // 
            // txtFechaInicio
            // 
            this.txtFechaInicio.Location = new System.Drawing.Point(507, 176);
            this.txtFechaInicio.Name = "txtFechaInicio";
            this.txtFechaInicio.Size = new System.Drawing.Size(59, 20);
            this.txtFechaInicio.TabIndex = 34;
            this.txtFechaInicio.Tag = "fechaInicio";
            this.txtFechaInicio.TextChanged += new System.EventHandler(this.txtFechaInicio_TextChanged);
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Checked = false;
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicio.Location = new System.Drawing.Point(355, 175);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(129, 20);
            this.dtpFechaInicio.TabIndex = 33;
            this.dtpFechaInicio.Value = new System.DateTime(2021, 10, 26, 0, 0, 0, 0);
            this.dtpFechaInicio.ValueChanged += new System.EventHandler(this.dtpFechaInicio_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(352, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Fecha Inicio";
            // 
            // txtCantidadHabitacion
            // 
            this.txtCantidadHabitacion.Location = new System.Drawing.Point(59, 405);
            this.txtCantidadHabitacion.Name = "txtCantidadHabitacion";
            this.txtCantidadHabitacion.Size = new System.Drawing.Size(100, 20);
            this.txtCantidadHabitacion.TabIndex = 31;
            this.txtCantidadHabitacion.Tag = "cantidadHabitacion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 374);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Cantidad Habitaciones";
            // 
            // cbxHabitacion
            // 
            this.cbxHabitacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxHabitacion.FormattingEnabled = true;
            this.cbxHabitacion.Location = new System.Drawing.Point(58, 326);
            this.cbxHabitacion.Name = "cbxHabitacion";
            this.cbxHabitacion.Size = new System.Drawing.Size(121, 21);
            this.cbxHabitacion.TabIndex = 29;
            this.cbxHabitacion.SelectedIndexChanged += new System.EventHandler(this.cbxHabitacion_SelectedIndexChanged);
            // 
            // txtIdHabitacion
            // 
            this.txtIdHabitacion.Location = new System.Drawing.Point(203, 326);
            this.txtIdHabitacion.Name = "txtIdHabitacion";
            this.txtIdHabitacion.Size = new System.Drawing.Size(50, 20);
            this.txtIdHabitacion.TabIndex = 28;
            this.txtIdHabitacion.Tag = "idHabitacion";
            this.txtIdHabitacion.TextChanged += new System.EventHandler(this.txtIdHabitacion_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "ID Habitación";
            // 
            // cbxCliente
            // 
            this.cbxCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCliente.FormattingEnabled = true;
            this.cbxCliente.Location = new System.Drawing.Point(58, 251);
            this.cbxCliente.Name = "cbxCliente";
            this.cbxCliente.Size = new System.Drawing.Size(121, 21);
            this.cbxCliente.TabIndex = 26;
            this.cbxCliente.SelectedIndexChanged += new System.EventHandler(this.cbxCliente_SelectedIndexChanged);
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Location = new System.Drawing.Point(203, 251);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(50, 20);
            this.txtIdCliente.TabIndex = 25;
            this.txtIdCliente.Tag = "idCliente";
            this.txtIdCliente.TextChanged += new System.EventHandler(this.txtIdCliente_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Cliente";
            // 
            // txtIdReservacion
            // 
            this.txtIdReservacion.Location = new System.Drawing.Point(58, 176);
            this.txtIdReservacion.Name = "txtIdReservacion";
            this.txtIdReservacion.Size = new System.Drawing.Size(100, 20);
            this.txtIdReservacion.TabIndex = 23;
            this.txtIdReservacion.Tag = "idReservacion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "ID Reservación";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbcheckout);
            this.groupBox1.Controls.Add(this.rbtCheckin);
            this.groupBox1.Controls.Add(this.rbtActivo);
            this.groupBox1.Controls.Add(this.rbtInactivo);
            this.groupBox1.Location = new System.Drawing.Point(355, 308);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(146, 133);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estado Reservación:";
            // 
            // rbcheckout
            // 
            this.rbcheckout.AutoSize = true;
            this.rbcheckout.Location = new System.Drawing.Point(26, 94);
            this.rbcheckout.Name = "rbcheckout";
            this.rbcheckout.Size = new System.Drawing.Size(74, 17);
            this.rbcheckout.TabIndex = 42;
            this.rbcheckout.TabStop = true;
            this.rbcheckout.Text = "Check-out";
            this.rbcheckout.UseVisualStyleBackColor = true;
            this.rbcheckout.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbcheckout_MouseClick);
            // 
            // rbtCheckin
            // 
            this.rbtCheckin.AutoSize = true;
            this.rbtCheckin.Location = new System.Drawing.Point(26, 71);
            this.rbtCheckin.Name = "rbtCheckin";
            this.rbtCheckin.Size = new System.Drawing.Size(68, 17);
            this.rbtCheckin.TabIndex = 41;
            this.rbtCheckin.TabStop = true;
            this.rbtCheckin.Text = "Check-In";
            this.rbtCheckin.UseVisualStyleBackColor = true;
            this.rbtCheckin.CheckedChanged += new System.EventHandler(this.rbtCheckin_CheckedChanged);
            // 
            // frmReservaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1191, 536);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvReservacion);
            this.Controls.Add(this.txtEstatus);
            this.Controls.Add(this.txtFechaFin);
            this.Controls.Add(this.dtpFechaFin);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtFechaInicio);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCantidadHabitacion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxHabitacion);
            this.Controls.Add(this.txtIdHabitacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxCliente);
            this.Controls.Add(this.txtIdCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdReservacion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.navegador1);
            this.Name = "frmReservaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "1011 - Proceso Reservación";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservacion)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DLL.nav.navegador navegador1;
        private System.Windows.Forms.DataGridView dgvReservacion;
        private System.Windows.Forms.TextBox txtEstatus;
        private System.Windows.Forms.RadioButton rbtInactivo;
        private System.Windows.Forms.RadioButton rbtActivo;
        private System.Windows.Forms.TextBox txtFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCantidadHabitacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxHabitacion;
        private System.Windows.Forms.TextBox txtIdHabitacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxCliente;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdReservacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtCheckin;
        private System.Windows.Forms.RadioButton rbcheckout;
    }
}
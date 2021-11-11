namespace CapaVistaHoteleria
{
    partial class frmTipoServicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTipoServicio));
            this.rbtInactivo = new System.Windows.Forms.RadioButton();
            this.rbtActivo = new System.Windows.Forms.RadioButton();
            this.txtEstatus = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dvgTipoServicio = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdTipoServicio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.navegador1 = new DLL.nav.navegador();
            ((System.ComponentModel.ISupportInitialize)(this.dvgTipoServicio)).BeginInit();
            this.SuspendLayout();
            // 
            // rbtInactivo
            // 
            this.rbtInactivo.AutoSize = true;
            this.rbtInactivo.Location = new System.Drawing.Point(115, 429);
            this.rbtInactivo.Name = "rbtInactivo";
            this.rbtInactivo.Size = new System.Drawing.Size(63, 17);
            this.rbtInactivo.TabIndex = 25;
            this.rbtInactivo.TabStop = true;
            this.rbtInactivo.Text = "Inactivo";
            this.rbtInactivo.UseVisualStyleBackColor = true;
            this.rbtInactivo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbtInactivo_MouseClick);
            // 
            // rbtActivo
            // 
            this.rbtActivo.AutoSize = true;
            this.rbtActivo.Location = new System.Drawing.Point(115, 406);
            this.rbtActivo.Name = "rbtActivo";
            this.rbtActivo.Size = new System.Drawing.Size(55, 17);
            this.rbtActivo.TabIndex = 24;
            this.rbtActivo.TabStop = true;
            this.rbtActivo.Text = "Activo";
            this.rbtActivo.UseVisualStyleBackColor = true;
            this.rbtActivo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbtActivo_MouseClick);
            // 
            // txtEstatus
            // 
            this.txtEstatus.Location = new System.Drawing.Point(226, 404);
            this.txtEstatus.Name = "txtEstatus";
            this.txtEstatus.Size = new System.Drawing.Size(100, 20);
            this.txtEstatus.TabIndex = 23;
            this.txtEstatus.Tag = "estatus";
            this.txtEstatus.TextChanged += new System.EventHandler(this.txtEstatus_TextChanged);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(107, 336);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 22;
            this.txtPrecio.Tag = "precio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Precio Servicio:";
            // 
            // dvgTipoServicio
            // 
            this.dvgTipoServicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgTipoServicio.Location = new System.Drawing.Point(502, 148);
            this.dvgTipoServicio.Name = "dvgTipoServicio";
            this.dvgTipoServicio.RowHeadersWidth = 47;
            this.dvgTipoServicio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgTipoServicio.Size = new System.Drawing.Size(585, 247);
            this.dvgTipoServicio.TabIndex = 20;
            this.dvgTipoServicio.SelectionChanged += new System.EventHandler(this.dvgTipoServicio_SelectionChanged);
            this.dvgTipoServicio.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dvgTipoServicio_MouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 375);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Estatus";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(107, 264);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 18;
            this.txtNombre.Tag = "nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nombre Servicio";
            // 
            // txtIdTipoServicio
            // 
            this.txtIdTipoServicio.Location = new System.Drawing.Point(107, 188);
            this.txtIdTipoServicio.Name = "txtIdTipoServicio";
            this.txtIdTipoServicio.Size = new System.Drawing.Size(100, 20);
            this.txtIdTipoServicio.TabIndex = 16;
            this.txtIdTipoServicio.Tag = "idTipoServicio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "ID Tipo Servicio";
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.navegador1.Location = new System.Drawing.Point(1, -1);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(1189, 87);
            this.navegador1.TabIndex = 26;
            // 
            // frmTipoServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1191, 536);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.rbtInactivo);
            this.Controls.Add(this.rbtActivo);
            this.Controls.Add(this.txtEstatus);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dvgTipoServicio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdTipoServicio);
            this.Controls.Add(this.label1);
            this.Name = "frmTipoServicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "1008 - Mantenimiento Tipo Servicio";
            this.Load += new System.EventHandler(this.frmTipoServicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgTipoServicio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtInactivo;
        private System.Windows.Forms.RadioButton rbtActivo;
        private System.Windows.Forms.TextBox txtEstatus;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dvgTipoServicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdTipoServicio;
        private System.Windows.Forms.Label label1;
        private DLL.nav.navegador navegador1;
    }
}
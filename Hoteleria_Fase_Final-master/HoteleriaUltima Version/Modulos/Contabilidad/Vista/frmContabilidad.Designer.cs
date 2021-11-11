
namespace Vista
{
    partial class frmContabilidad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmContabilidad));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaGeneralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasInteligentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasInteligentesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menúConsultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.polizasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.presupuestosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activosFijosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadosFinancierosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cierreContableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.polizasToolStripMenuItem,
            this.presupuestosToolStripMenuItem,
            this.activosFijosToolStripMenuItem,
            this.estadosFinancierosToolStripMenuItem,
            this.cierreContableToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1902, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ayudaGeneralToolStripMenuItem,
            this.herramientasToolStripMenuItem,
            this.cerrarSesiónToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.inicioToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // ayudaGeneralToolStripMenuItem
            // 
            this.ayudaGeneralToolStripMenuItem.Name = "ayudaGeneralToolStripMenuItem";
            this.ayudaGeneralToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.ayudaGeneralToolStripMenuItem.Text = "Ayuda General";
            this.ayudaGeneralToolStripMenuItem.Click += new System.EventHandler(this.ayudaGeneralToolStripMenuItem_Click);
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteadorToolStripMenuItem,
            this.consultasInteligentesToolStripMenuItem,
            this.seguridadToolStripMenuItem});
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.herramientasToolStripMenuItem.Text = "Herramientas";
            // 
            // reporteadorToolStripMenuItem
            // 
            this.reporteadorToolStripMenuItem.Name = "reporteadorToolStripMenuItem";
            this.reporteadorToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.reporteadorToolStripMenuItem.Text = "Reporteador";
            this.reporteadorToolStripMenuItem.Click += new System.EventHandler(this.reporteadorToolStripMenuItem_Click);
            // 
            // consultasInteligentesToolStripMenuItem
            // 
            this.consultasInteligentesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultasInteligentesToolStripMenuItem1,
            this.menúConsultasToolStripMenuItem});
            this.consultasInteligentesToolStripMenuItem.Name = "consultasInteligentesToolStripMenuItem";
            this.consultasInteligentesToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.consultasInteligentesToolStripMenuItem.Text = "Consultas Inteligentes";
            // 
            // consultasInteligentesToolStripMenuItem1
            // 
            this.consultasInteligentesToolStripMenuItem1.Name = "consultasInteligentesToolStripMenuItem1";
            this.consultasInteligentesToolStripMenuItem1.Size = new System.Drawing.Size(236, 26);
            this.consultasInteligentesToolStripMenuItem1.Text = "Consultas Inteligentes";
            this.consultasInteligentesToolStripMenuItem1.Click += new System.EventHandler(this.consultasInteligentesToolStripMenuItem1_Click);
            // 
            // menúConsultasToolStripMenuItem
            // 
            this.menúConsultasToolStripMenuItem.Name = "menúConsultasToolStripMenuItem";
            this.menúConsultasToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.menúConsultasToolStripMenuItem.Text = "Menú Consultas";
            this.menúConsultasToolStripMenuItem.Click += new System.EventHandler(this.menúConsultasToolStripMenuItem_Click);
            // 
            // seguridadToolStripMenuItem
            // 
            this.seguridadToolStripMenuItem.Name = "seguridadToolStripMenuItem";
            this.seguridadToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.seguridadToolStripMenuItem.Text = "Seguridad";
            this.seguridadToolStripMenuItem.Click += new System.EventHandler(this.seguridadToolStripMenuItem_Click);
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión";
            this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // polizasToolStripMenuItem
            // 
            this.polizasToolStripMenuItem.Name = "polizasToolStripMenuItem";
            this.polizasToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.polizasToolStripMenuItem.Text = "Polizas";
            // 
            // presupuestosToolStripMenuItem
            // 
            this.presupuestosToolStripMenuItem.Name = "presupuestosToolStripMenuItem";
            this.presupuestosToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.presupuestosToolStripMenuItem.Text = "Presupuestos";
            // 
            // activosFijosToolStripMenuItem
            // 
            this.activosFijosToolStripMenuItem.Name = "activosFijosToolStripMenuItem";
            this.activosFijosToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this.activosFijosToolStripMenuItem.Text = "Activos Fijos";
            // 
            // estadosFinancierosToolStripMenuItem
            // 
            this.estadosFinancierosToolStripMenuItem.Name = "estadosFinancierosToolStripMenuItem";
            this.estadosFinancierosToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.estadosFinancierosToolStripMenuItem.Text = "Estados Financieros";
            // 
            // cierreContableToolStripMenuItem
            // 
            this.cierreContableToolStripMenuItem.Name = "cierreContableToolStripMenuItem";
            this.cierreContableToolStripMenuItem.Size = new System.Drawing.Size(126, 24);
            this.cierreContableToolStripMenuItem.Text = "Cierre Contable";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(709, 5);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 22);
            this.txtUsuario.TabIndex = 3;
            // 
            // frmContabilidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "frmContabilidad";
            this.Text = "7001 Contabilidad";
            this.Load += new System.EventHandler(this.frmContabilidad_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaGeneralToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem polizasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem presupuestosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activosFijosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadosFinancierosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cierreContableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consultasInteligentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasInteligentesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menúConsultasToolStripMenuItem;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seguridadToolStripMenuItem;
    }
}
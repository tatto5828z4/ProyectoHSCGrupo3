using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaVistaSeguridadHSC;
using System.Windows.Forms;

namespace CapaVistaMBancos
{
    public partial class MDIBancos : Form
    {
        public MDIBancos()
        {
            InitializeComponent();
        }
        // Luis Reyes 0901-15-3121
        private void MDIBancos_Load(object sender, EventArgs e)
        {
            frmLoginHSC form = new frmLoginHSC();
            if (form.ShowDialog() == DialogResult.OK)
            {
                txtUsuario.Text = form.usuario();
            }
            else
            {
                this.Close();
            }
        }

        private void consultasInteligentesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CapaVista.ConsultasInteligentes frm = new CapaVista.ConsultasInteligentes();
            frm.Show();
        }

        private void menuConsultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CapaVista.menuconsultas frm = new CapaVista.menuconsultas();
            frm.Show();
        }

        private void seguridadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CapaVistaSeguridadHSC.frmMIDSeguridad frm = new CapaVistaSeguridadHSC.frmMIDSeguridad();
            frm.Show();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLoginHSC form = new frmLoginHSC();
            if (form.ShowDialog() == DialogResult.OK)
            {
                txtUsuario.Text = form.usuario();
                this.Show();
            }
            else
            { this.Close(); }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reporteadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CapaVistaReporte.ReporteadorAdmin frm = new CapaVistaReporte.ReporteadorAdmin();
            frm.Show();
        }
    }
}

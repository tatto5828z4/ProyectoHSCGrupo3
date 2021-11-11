using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaVistaSeguridadHSC;
using CapaVistaReporte;

namespace Vista
{
    public partial class frmContabilidad : Form
    {
        public frmContabilidad()
        {
            InitializeComponent();
            

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reporteadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
           CapaVistaReporte.ReporteadorAdmin formulario = new CapaVistaReporte.ReporteadorAdmin(); 
            formulario.Show();
        }

        private void consultasInteligentesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CapaVista.ConsultasInteligentes formulario = new CapaVista.ConsultasInteligentes();
            formulario.Show();
        }

        private void menúConsultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CapaVista.menuconsultas formulario = new CapaVista.menuconsultas();
            formulario.Show();
        }

        private void frmContabilidad_Load(object sender, EventArgs e)
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

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void seguridadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CapaVistaSeguridadHSC.frmMIDSeguridad formulario = new CapaVistaSeguridadHSC.frmMIDSeguridad();
            formulario.Show();
        }

        private void ayudaGeneralToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

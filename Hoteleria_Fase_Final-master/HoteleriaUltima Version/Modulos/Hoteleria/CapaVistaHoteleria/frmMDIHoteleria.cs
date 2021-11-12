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
using CapaVista;
using RecetasAreaHoteleria;

namespace CapaVistaHoteleria
{
   
    public partial class frmMDIHoteleria : Form
    {
        public frmMDIHoteleria()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void frmMDIHoteleria_Load(object sender, EventArgs e)
        {
            frmLoginHSC form = new frmLoginHSC();
            if (form.ShowDialog() == DialogResult.OK)
            {
                txtUsuario.Text = form.usuario();
                nombreUsuario.nombre = txtUsuario.Text;

            }
            else
            { 
                this.Close(); 
            }
        }

        private void seguridadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMIDSeguridad seguridad = new frmMIDSeguridad();
            seguridad.Show();
        }

        private void reporteadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReporteadorAdmin repo = new ReporteadorAdmin();
            repo.Show();
        }

        private void consultasInteligentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuconsultas consultas = new menuconsultas();
            consultas.Show();
        }

        private void mantenimientoEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmpresa form = new frmEmpresa();
            form.MdiParent = this;
            form.Show();

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmSucursal form = new frmSucursal();
            form.MdiParent = this;
            form.Show();
        }

        private void mantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTipoCliente form = new frmTipoCliente();
            form.MdiParent = this;
            form.Show();
        }

        private void mantenimientoTipoCamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTipoCama form = new frmTipoCama();
            form.MdiParent = this;
            form.Show();
        }

        private void mantenimientoTipoHabitaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTipoHabitacion form = new frmTipoHabitacion();
            form.MdiParent = this;
            form.Show();
        }

        private void mantenimientoHabitaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHabitacion form = new frmHabitacion();
            form.MdiParent = this;
            form.Show();
        }

        private void mantenimientoTipoServicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTipoServicio form = new frmTipoServicio();
            form.MdiParent = this;
            form.Show();
        }

        private void mantenimientoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmSalon form = new frmSalon();
            form.MdiParent = this;
            form.Show();
        }

        private void mantenimientoMesaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMesa form = new frmMesa();
            form.MdiParent = this;
            form.Show();
        }

        private void reservaciónEventosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEventos form = new frmEventos();
            form.MdiParent = this;
            form.Show();
        }

        private void trasladoDePólizaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEnlaceContableHoteleria_impuestos form = new frmEnlaceContableHoteleria_impuestos();
            form.MdiParent = this;
            form.Show();
        }

        private void reservaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReservaciones form = new frmReservaciones();
            form.MdiParent = this;
            form.Show();
        }

        private void salirDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void ayudaDelMóduloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "C:\\Users\\Brayan Cifuentes\\Desktop\\HoteleriaMantenimientosFinal-Ultima Version\\Ayuda\\Hoteleria\\AyudasMantenimientosHoteleria.chm", "1000-Ayudas-Mantenimientos.html");
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.EnableRaisingEvents = false;
            proc.StartInfo.FileName = "calc";
            proc.Start();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Restaurante.frmConfigurarMesas mesas = new Restaurante.frmConfigurarMesas();
            mesas.Show();
        }

        private void pundoDeVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Restaurante.frmPuntoVenta venta = new Restaurante.frmPuntoVenta();
            venta.Show();
        }

        private void recetaEncabezadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRecetaEncabezado recetaEnc = new frmRecetaEncabezado();
            recetaEnc.Show();
        }

        private void recetaDetalladoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRecetaDetalle detalle = new frmRecetaDetalle();
            detalle.Show();
        }
    }
}

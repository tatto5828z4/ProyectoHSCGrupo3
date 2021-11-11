using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVistaMBancos
{
    public partial class frmTipodeCambio : Form
    {
        public frmTipodeCambio()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            double quet, us, resul;
            us = 0.13;
            quet = double.Parse(txtcantidad.Text);
            resul = quet * us;
            label3.Visible = true;
            txtresultado.Visible = true;
            txtresultado.Text = resul.ToString();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            double quet, euro, resul;
            euro = 0.11;
            quet = double.Parse(txtcantidad.Text);
            resul = quet * euro;
            label3.Visible = true;
            txtresultado.Visible = true;
            txtresultado.Text = resul.ToString();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtcantidad.Clear();
            txtresultado.Visible = false;
            label3.Visible = false;
            txtcantidad.Focus();
        }
    }
}

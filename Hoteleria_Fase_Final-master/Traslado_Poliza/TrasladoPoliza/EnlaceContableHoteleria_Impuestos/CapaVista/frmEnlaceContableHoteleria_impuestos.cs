using CapaControlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista
{
    public partial class frmEnlaceContableHoteleria_impuestos : Form
    {
        /*Geovani Fernando Mendoza Galiano  9959-18-15407*/
        ctlEnlaceContableHoteleria_impuesto con = new ctlEnlaceContableHoteleria_impuesto();
        string totalSaldoDebe;
        string totalSaldoHaber;
        string idTotal;
        string fechaHoy;

        public frmEnlaceContableHoteleria_impuestos()
        {
            /*Geovani Fernando Mendoza Galiano  9959-18-15407*/
            InitializeComponent();
            txtIdPoliza.Text = incrementarId();
            string fechaI = dtpFechaInicio.Value.ToString("yyyy-MM-dd");
            string fechaF = dtpFechaFin.Value.ToString("yyyy-MM-dd");
            

          
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        /*Geovani Fernando Mendoza Galiano  9959-18-15407*/
        /*Funcion de grabar poliza encabezado y detalle*/
        private void btnAceptar_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                string fechaI = dtpFechaInicio.Value.ToString("yyyy-MM-dd");
                string fechaF = dtpFechaFin.Value.ToString("yyyy-MM-dd");
                fechaHoy = dtpFechaHoy.Value.ToString("yyyy-MM-dd");
                totalSaldoDebe = calculoDebe(fechaI, fechaF);
                totalSaldoHaber = calculoHaber(fechaI, fechaF);




                if(totalSaldoDebe == totalSaldoHaber)
                {
                    insertar();

                    //Llenando encabezado
                    MessageBox.Show("¨Poliza de totales guardada");
                   Console.WriteLine("Monto Cargos" + totalSaldoDebe);
                    MessageBox.Show("Monto Abonos"  + totalSaldoHaber);

                    txtConcepto.Text = "";
                    txtIdPoliza.Text = incrementarId();
                    
                }
                else
                {
                    MessageBox.Show("EL SALDO DEL ABONO TIENE QUE SER IGUAL AL CARGO, POR LO TANTO NO SE PUEDE REGISTRAR LA POLIZA");
                }

                /*insertar();

                //Llenando encabezado
                MessageBox.Show("¨Poliza de totales guardada");

                txtConcepto.Text = "";
                txtIdPoliza.Text = incrementarId();
                txtAbono.Text = "";
                txtCargo.Text = "";
                */
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
            finally
            {

            }
        }

        /*Geovani Fernando Mendoza Galiano  9959-18-15407*/
        public string calculoDebe(string fechaInicio, string fechaFinal)
        {
            totalSaldoDebe = con.calculoDebe(fechaInicio, fechaFinal);
            return totalSaldoDebe;
        }
        /*Geovani Fernando Mendoza Galiano  9959-18-15407*/
        public string calculoHaber(string fechaInicio, string fechaFinal)
        {
            totalSaldoHaber = con.calculoHaber(fechaInicio, fechaFinal);
            return totalSaldoHaber;
        }

        /*Geovani Fernando Mendoza Galiano  9959-18-15407*/
        //Sumarle 1 al ultimo id
        public string incrementarId()
        {
            string id;
            id = con.incrementarId();

            int aux = int.Parse(id);
            aux++;

            id = aux.ToString();


            return id;
        }

        /*Geovani Fernando Mendoza Galiano  9959-18-15407*/
        //Insertar encabezado
        public string insertarEncabezado()
        {
            string id = "";
            //string idEncabezado = incrementarId();
            fechaHoy = dtpFechaHoy.Value.ToString("yyyy-MM-dd");

            con.insertarEncabezado(txtIdPoliza.Text, fechaHoy, "1");
            id = buscarId();

            return id;
        }
        /*Geovani Fernando Mendoza Galiano  9959-18-15407*/
        public string buscarId()
        {
            string id = "";

            id = con.incrementarId();

            return id;
        }
        /*Geovani Fernando Mendoza Galiano  9959-18-15407*/
        public void insertarDetalleDebe(string id)
        {
            fechaHoy = dtpFechaHoy.Value.ToString("yyyy-MM-dd");


            string fechaI = dtpFechaInicio.Value.ToString("yyyy-MM-dd");
            string fechaF = dtpFechaFin.Value.ToString("yyyy-MM-dd");

            totalSaldoDebe = calculoDebe(fechaI, fechaF);


            con.insertarDetalle(txtIdPoliza.Text, fechaHoy, "1", totalSaldoDebe, "1", txtConcepto.Text);

        }
        /*Geovani Fernando Mendoza Galiano  9959-18-15407*/
        public void insertarDetalleHaber(string id)
        {
            fechaHoy = dtpFechaHoy.Value.ToString("yyyy-MM-dd");
            string fechaI = dtpFechaInicio.Value.ToString("yyyy-MM-dd");
            string fechaF = dtpFechaFin.Value.ToString("yyyy-MM-dd");

            totalSaldoHaber = calculoHaber(fechaI, fechaF);

            con.insertarDetalle(txtIdPoliza.Text, fechaHoy, "2", totalSaldoHaber, "2", txtConcepto.Text);

        }

        /*Geovani Fernando Mendoza Galiano  9959-18-15407*/
        public void insertar()
        {

            string id = insertarEncabezado();
            insertarDetalleDebe(id);

            insertarDetalleHaber(id);



        }
        /*Geovani Fernando Mendoza Galiano  9959-18-15407*/
        private void btnActualizar_Click(object sender, EventArgs e)
        {

            
            

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            txtConcepto.Text = "";
        }

        private void frmEnlaceContableHoteleria_impuestos_Load(object sender, EventArgs e)
        {

        }

        public void dtpFechaInicio_ValueChanged(object sender, EventArgs e)
        {
           


        }

        public void dtpFechaFin_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void dtpFechaHoy_ValueChanged(object sender, EventArgs e)
        {
            string fechaI = dtpFechaInicio.Value.ToString("yyyy-MM-dd");
            string fechaF = dtpFechaFin.Value.ToString("yyyy-MM-dd");
          
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        public void button1_Click_2(object sender, EventArgs e)
        {
            string fechaI = dtpFechaInicio.Value.ToString("yyyy-MM-dd");
            string fechaF = dtpFechaFin.Value.ToString("yyyy-MM-dd");

            con.consultaSaldo(fechaI, fechaF);

            Console.WriteLine("el total debe es: " + totalSaldoDebe);
            Console.WriteLine("el total haber es: " + totalSaldoHaber);
        }

        private void btnReportes_MouseClick(object sender, MouseEventArgs e)
        {
            frmReportesHoteleria_Impuestos reporte = new frmReportesHoteleria_Impuestos();
            reporte.Show();
        }

        private void btnAyudas_MouseClick(object sender, MouseEventArgs e)
        {
             Help.ShowHelp(this, "C:/Users/Brayan Cifuentes/Desktop/BackupTrasladoGEOVVANI/BackupTrasladoGEOVVANI/Ayuda_TrasladoPolizaHoteleria/Ayuda.chm", "Manual-de-usuario-Area-hoteleria,-Traslado-Poliza.html");
        }

        private void btnAyudas_Click(object sender, EventArgs e)
        {

        }
    }
}

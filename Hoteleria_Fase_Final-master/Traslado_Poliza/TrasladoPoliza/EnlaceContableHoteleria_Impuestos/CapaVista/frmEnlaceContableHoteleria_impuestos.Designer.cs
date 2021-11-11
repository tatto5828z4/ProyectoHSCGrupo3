
namespace CapaVista
{
    partial class frmEnlaceContableHoteleria_impuestos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEnlaceContableHoteleria_impuestos));
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtConcepto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdPoliza = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFechaHoy = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnAyudas = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCancelar.Location = new System.Drawing.Point(384, 394);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(83, 46);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAceptar.Location = new System.Drawing.Point(270, 395);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(85, 45);
            this.btnAceptar.TabIndex = 12;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.button1_Click);
            this.btnAceptar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnAceptar_MouseClick);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.txtConcepto);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtIdPoliza);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dtpFechaHoy);
            this.groupBox2.Location = new System.Drawing.Point(153, 190);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(445, 176);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Generales de la Poliza";
            // 
            // txtConcepto
            // 
            this.txtConcepto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConcepto.Location = new System.Drawing.Point(124, 110);
            this.txtConcepto.Name = "txtConcepto";
            this.txtConcepto.Size = new System.Drawing.Size(242, 23);
            this.txtConcepto.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Concepto:";
            // 
            // txtIdPoliza
            // 
            this.txtIdPoliza.Enabled = false;
            this.txtIdPoliza.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdPoliza.Location = new System.Drawing.Point(125, 65);
            this.txtIdPoliza.Name = "txtIdPoliza";
            this.txtIdPoliza.Size = new System.Drawing.Size(95, 23);
            this.txtIdPoliza.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "ID Poliza:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha De Hoy:";
            // 
            // dtpFechaHoy
            // 
            this.dtpFechaHoy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaHoy.Location = new System.Drawing.Point(125, 31);
            this.dtpFechaHoy.Name = "dtpFechaHoy";
            this.dtpFechaHoy.Size = new System.Drawing.Size(241, 23);
            this.dtpFechaHoy.TabIndex = 0;
            this.dtpFechaHoy.Value = new System.DateTime(2021, 10, 31, 0, 0, 0, 0);
            this.dtpFechaHoy.ValueChanged += new System.EventHandler(this.dtpFechaHoy_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpFechaFin);
            this.groupBox1.Controls.Add(this.dtpFechaInicio);
            this.groupBox1.Location = new System.Drawing.Point(153, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(445, 129);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rangos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Fecha Fin:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fecha Inicio:";
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaFin.Location = new System.Drawing.Point(125, 61);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(241, 23);
            this.dtpFechaFin.TabIndex = 1;
            this.dtpFechaFin.Value = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            this.dtpFechaFin.ValueChanged += new System.EventHandler(this.dtpFechaFin_ValueChanged);
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaInicio.Location = new System.Drawing.Point(125, 20);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(241, 23);
            this.dtpFechaInicio.TabIndex = 0;
            this.dtpFechaInicio.Value = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.dtpFechaInicio.ValueChanged += new System.EventHandler(this.dtpFechaInicio_ValueChanged);
            // 
            // btnReportes
            // 
            this.btnReportes.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnReportes.Image = ((System.Drawing.Image)(resources.GetObject("btnReportes.Image")));
            this.btnReportes.Location = new System.Drawing.Point(626, 42);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(77, 83);
            this.btnReportes.TabIndex = 19;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReportes.UseVisualStyleBackColor = false;
            this.btnReportes.Click += new System.EventHandler(this.button1_Click_1);
            this.btnReportes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnReportes_MouseClick);
            // 
            // btnAyudas
            // 
            this.btnAyudas.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnAyudas.Image = ((System.Drawing.Image)(resources.GetObject("btnAyudas.Image")));
            this.btnAyudas.Location = new System.Drawing.Point(709, 42);
            this.btnAyudas.Name = "btnAyudas";
            this.btnAyudas.Size = new System.Drawing.Size(76, 83);
            this.btnAyudas.TabIndex = 20;
            this.btnAyudas.Text = "Ayuda";
            this.btnAyudas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAyudas.UseVisualStyleBackColor = false;
            this.btnAyudas.Click += new System.EventHandler(this.btnAyudas_Click);
            this.btnAyudas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnAyudas_MouseClick);
            // 
            // frmEnlaceContableHoteleria_impuestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 475);
            this.Controls.Add(this.btnAyudas);
            this.Controls.Add(this.btnReportes);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmEnlaceContableHoteleria_impuestos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "1020-Poliza Hoteleria";
            this.Load += new System.EventHandler(this.frmEnlaceContableHoteleria_impuestos_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtConcepto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdPoliza;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFechaHoy;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnAyudas;
    }
}

namespace CapaVistaMBancos
{
    partial class frmDisponibilidad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDisponibilidad));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnEstadosCuentas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDisponibilidadBancaria = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 184);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 242);
            this.dataGridView1.TabIndex = 38;
            // 
            // btnEstadosCuentas
            // 
            this.btnEstadosCuentas.BackColor = System.Drawing.Color.Tan;
            this.btnEstadosCuentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstadosCuentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstadosCuentas.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEstadosCuentas.Location = new System.Drawing.Point(482, 139);
            this.btnEstadosCuentas.Name = "btnEstadosCuentas";
            this.btnEstadosCuentas.Size = new System.Drawing.Size(195, 30);
            this.btnEstadosCuentas.TabIndex = 37;
            this.btnEstadosCuentas.Text = "Estados de Cuentas";
            this.btnEstadosCuentas.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(204, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 39);
            this.label1.TabIndex = 36;
            this.label1.Text = "Disponibilidad Bancaria";
            // 
            // btnDisponibilidadBancaria
            // 
            this.btnDisponibilidadBancaria.BackColor = System.Drawing.Color.Tan;
            this.btnDisponibilidadBancaria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisponibilidadBancaria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisponibilidadBancaria.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDisponibilidadBancaria.Location = new System.Drawing.Point(77, 139);
            this.btnDisponibilidadBancaria.Name = "btnDisponibilidadBancaria";
            this.btnDisponibilidadBancaria.Size = new System.Drawing.Size(195, 30);
            this.btnDisponibilidadBancaria.TabIndex = 35;
            this.btnDisponibilidadBancaria.Text = "Disponibilidad Bancaria";
            this.btnDisponibilidadBancaria.UseVisualStyleBackColor = false;
            // 
            // frmDisponibilidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnEstadosCuentas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDisponibilidadBancaria);
            this.Name = "frmDisponibilidad";
            this.Text = "6663 Disponibilidad";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnEstadosCuentas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDisponibilidadBancaria;
    }
}
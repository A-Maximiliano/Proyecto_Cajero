
namespace InterfazGrafica
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.btnRetiro = new System.Windows.Forms.Button();
            this.btnDeposito = new System.Windows.Forms.Button();
            this.btnPagoServicios = new System.Windows.Forms.Button();
            this.btnCompraDolares = new System.Windows.Forms.Button();
            this.lblDeposito = new System.Windows.Forms.Label();
            this.lblRetiro = new System.Windows.Forms.Label();
            this.lblCompa = new System.Windows.Forms.Label();
            this.lblPagos = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnRetiro
            // 
            this.btnRetiro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRetiro.BackgroundImage")));
            this.btnRetiro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRetiro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRetiro.FlatAppearance.BorderSize = 0;
            this.btnRetiro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btnRetiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetiro.Location = new System.Drawing.Point(267, 211);
            this.btnRetiro.Name = "btnRetiro";
            this.btnRetiro.Size = new System.Drawing.Size(89, 70);
            this.btnRetiro.TabIndex = 5;
            this.btnRetiro.UseVisualStyleBackColor = true;
            this.btnRetiro.Click += new System.EventHandler(this.btnRetiro_Click);
            // 
            // btnDeposito
            // 
            this.btnDeposito.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeposito.BackgroundImage")));
            this.btnDeposito.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeposito.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeposito.FlatAppearance.BorderSize = 0;
            this.btnDeposito.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender;
            this.btnDeposito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeposito.Location = new System.Drawing.Point(267, 103);
            this.btnDeposito.Name = "btnDeposito";
            this.btnDeposito.Size = new System.Drawing.Size(89, 70);
            this.btnDeposito.TabIndex = 6;
            this.btnDeposito.UseVisualStyleBackColor = true;
            this.btnDeposito.Click += new System.EventHandler(this.btnDeposito_Click);
            // 
            // btnPagoServicios
            // 
            this.btnPagoServicios.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPagoServicios.BackgroundImage")));
            this.btnPagoServicios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPagoServicios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPagoServicios.FlatAppearance.BorderSize = 0;
            this.btnPagoServicios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btnPagoServicios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagoServicios.Location = new System.Drawing.Point(267, 430);
            this.btnPagoServicios.Name = "btnPagoServicios";
            this.btnPagoServicios.Size = new System.Drawing.Size(89, 70);
            this.btnPagoServicios.TabIndex = 7;
            this.btnPagoServicios.UseVisualStyleBackColor = true;
            this.btnPagoServicios.Click += new System.EventHandler(this.btnPagoServicios_Click);
            // 
            // btnCompraDolares
            // 
            this.btnCompraDolares.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCompraDolares.BackgroundImage")));
            this.btnCompraDolares.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCompraDolares.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCompraDolares.FlatAppearance.BorderSize = 0;
            this.btnCompraDolares.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnCompraDolares.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompraDolares.Location = new System.Drawing.Point(267, 320);
            this.btnCompraDolares.Name = "btnCompraDolares";
            this.btnCompraDolares.Size = new System.Drawing.Size(89, 70);
            this.btnCompraDolares.TabIndex = 8;
            this.btnCompraDolares.UseVisualStyleBackColor = true;
            this.btnCompraDolares.Click += new System.EventHandler(this.btnCompraDolares_Click);
            // 
            // lblDeposito
            // 
            this.lblDeposito.AutoSize = true;
            this.lblDeposito.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeposito.Location = new System.Drawing.Point(30, 126);
            this.lblDeposito.Name = "lblDeposito";
            this.lblDeposito.Size = new System.Drawing.Size(178, 21);
            this.lblDeposito.TabIndex = 11;
            this.lblDeposito.Text = "Depósito de Dinero";
            // 
            // lblRetiro
            // 
            this.lblRetiro.AutoSize = true;
            this.lblRetiro.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRetiro.Location = new System.Drawing.Point(30, 234);
            this.lblRetiro.Name = "lblRetiro";
            this.lblRetiro.Size = new System.Drawing.Size(150, 21);
            this.lblRetiro.TabIndex = 12;
            this.lblRetiro.Text = "Retiro de Dinero";
            // 
            // lblCompa
            // 
            this.lblCompa.AutoSize = true;
            this.lblCompa.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompa.Location = new System.Drawing.Point(30, 343);
            this.lblCompa.Name = "lblCompa";
            this.lblCompa.Size = new System.Drawing.Size(181, 21);
            this.lblCompa.TabIndex = 13;
            this.lblCompa.Text = "Compra de Dólares";
            // 
            // lblPagos
            // 
            this.lblPagos.AutoSize = true;
            this.lblPagos.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagos.Location = new System.Drawing.Point(30, 453);
            this.lblPagos.Name = "lblPagos";
            this.lblPagos.Size = new System.Drawing.Size(165, 21);
            this.lblPagos.TabIndex = 14;
            this.lblPagos.Text = "Pago de Servicios";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label18.Location = new System.Drawing.Point(69, 9);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(250, 21);
            this.label18.TabIndex = 147;
            this.label18.Text = "SERVICIO AUTOMATIZADO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(380, 21);
            this.label5.TabIndex = 148;
            this.label5.Text = "Pulse un botón para realizar la transacción";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 73);
            this.panel1.TabIndex = 149;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 522);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.lblPagos);
            this.Controls.Add(this.lblCompa);
            this.Controls.Add(this.lblRetiro);
            this.Controls.Add(this.lblDeposito);
            this.Controls.Add(this.btnCompraDolares);
            this.Controls.Add(this.btnPagoServicios);
            this.Controls.Add(this.btnDeposito);
            this.Controls.Add(this.btnRetiro);
            this.Controls.Add(this.panel1);
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRetiro;
        private System.Windows.Forms.Button btnDeposito;
        private System.Windows.Forms.Button btnPagoServicios;
        private System.Windows.Forms.Button btnCompraDolares;
        private System.Windows.Forms.Label lblDeposito;
        private System.Windows.Forms.Label lblRetiro;
        private System.Windows.Forms.Label lblCompa;
        private System.Windows.Forms.Label lblPagos;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
    }
}


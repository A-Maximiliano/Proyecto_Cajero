
namespace InterfazGrafica
{
    partial class CompraDolares
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompraDolares));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.btnComprar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.btnVolverMenu = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblCedulaCom = new System.Windows.Forms.Label();
            this.txtTipoCambio = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtCantidadDolares = new System.Windows.Forms.TextBox();
            this.txtNobreCom = new System.Windows.Forms.TextBox();
            this.txtApellidoCom = new System.Windows.Forms.TextBox();
            this.txtCedulaCom = new System.Windows.Forms.TextBox();
            this.lblDolares = new System.Windows.Forms.Label();
            this.lblCambio = new System.Windows.Forms.Label();
            this.lblApellidoCom = new System.Windows.Forms.Label();
            this.lblNombreCom = new System.Windows.Forms.Label();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblnumTar = new System.Windows.Forms.Label();
            this.txtNumTarjeta = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panel1.Controls.Add(this.txtNumTarjeta);
            this.panel1.Controls.Add(this.lblnumTar);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.btnComprar);
            this.panel1.Controls.Add(this.btnCalcular);
            this.panel1.Controls.Add(this.btnAsignar);
            this.panel1.Controls.Add(this.btnVolverMenu);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.lblCedulaCom);
            this.panel1.Controls.Add(this.txtTipoCambio);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.txtCantidadDolares);
            this.panel1.Controls.Add(this.txtNobreCom);
            this.panel1.Controls.Add(this.txtApellidoCom);
            this.panel1.Controls.Add(this.txtCedulaCom);
            this.panel1.Controls.Add(this.lblDolares);
            this.panel1.Controls.Add(this.lblCambio);
            this.panel1.Controls.Add(this.lblApellidoCom);
            this.panel1.Controls.Add(this.lblNombreCom);
            this.panel1.Controls.Add(this.dgvCliente);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(687, 645);
            this.panel1.TabIndex = 3;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.SystemColors.Control;
            this.label22.Location = new System.Drawing.Point(541, 311);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(120, 20);
            this.label22.TabIndex = 160;
            this.label22.Text = "Volver al menú";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.SystemColors.Control;
            this.label21.Location = new System.Drawing.Point(541, 227);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(120, 20);
            this.label21.TabIndex = 159;
            this.label21.Text = "Calcular saldos";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.Control;
            this.label19.Location = new System.Drawing.Point(566, 142);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(74, 20);
            this.label19.TabIndex = 157;
            this.label19.Text = "Comprar";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.Control;
            this.label20.Location = new System.Drawing.Point(576, 59);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(63, 20);
            this.label20.TabIndex = 158;
            this.label20.Text = "Asignar";
            // 
            // btnComprar
            // 
            this.btnComprar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnComprar.BackgroundImage")));
            this.btnComprar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnComprar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnComprar.FlatAppearance.BorderSize = 0;
            this.btnComprar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnComprar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComprar.Location = new System.Drawing.Point(583, 165);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(45, 45);
            this.btnComprar.TabIndex = 164;
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCalcular.BackgroundImage")));
            this.btnCalcular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcular.FlatAppearance.BorderSize = 0;
            this.btnCalcular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Location = new System.Drawing.Point(580, 250);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(45, 45);
            this.btnCalcular.TabIndex = 163;
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnAsignar
            // 
            this.btnAsignar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAsignar.BackgroundImage")));
            this.btnAsignar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAsignar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAsignar.FlatAppearance.BorderSize = 0;
            this.btnAsignar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnAsignar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsignar.Location = new System.Drawing.Point(580, 82);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(45, 45);
            this.btnAsignar.TabIndex = 162;
            this.btnAsignar.UseVisualStyleBackColor = true;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // btnVolverMenu
            // 
            this.btnVolverMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnVolverMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVolverMenu.BackgroundImage")));
            this.btnVolverMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVolverMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolverMenu.FlatAppearance.BorderSize = 0;
            this.btnVolverMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnVolverMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolverMenu.Location = new System.Drawing.Point(583, 336);
            this.btnVolverMenu.Name = "btnVolverMenu";
            this.btnVolverMenu.Size = new System.Drawing.Size(45, 45);
            this.btnVolverMenu.TabIndex = 161;
            this.btnVolverMenu.UseVisualStyleBackColor = false;
            this.btnVolverMenu.Click += new System.EventHandler(this.btnVolverMenu_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(537, 59);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(130, 319);
            this.panel3.TabIndex = 165;
            // 
            // lblCedulaCom
            // 
            this.lblCedulaCom.AutoSize = true;
            this.lblCedulaCom.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCedulaCom.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCedulaCom.Location = new System.Drawing.Point(17, 69);
            this.lblCedulaCom.Name = "lblCedulaCom";
            this.lblCedulaCom.Size = new System.Drawing.Size(172, 21);
            this.lblCedulaCom.TabIndex = 155;
            this.lblCedulaCom.Text = "Cédula del cliente";
            // 
            // txtTipoCambio
            // 
            this.txtTipoCambio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtTipoCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoCambio.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtTipoCambio.Location = new System.Drawing.Point(222, 354);
            this.txtTipoCambio.Name = "txtTipoCambio";
            this.txtTipoCambio.Size = new System.Drawing.Size(252, 24);
            this.txtTipoCambio.TabIndex = 153;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.Control;
            this.label18.Location = new System.Drawing.Point(243, 8);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(210, 21);
            this.label18.TabIndex = 146;
            this.label18.Text = "COMPRA DE DÓLARES";
            // 
            // txtCantidadDolares
            // 
            this.txtCantidadDolares.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtCantidadDolares.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadDolares.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtCantidadDolares.Location = new System.Drawing.Point(222, 298);
            this.txtCantidadDolares.Name = "txtCantidadDolares";
            this.txtCantidadDolares.Size = new System.Drawing.Size(252, 24);
            this.txtCantidadDolares.TabIndex = 144;
            // 
            // txtNobreCom
            // 
            this.txtNobreCom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtNobreCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNobreCom.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtNobreCom.Location = new System.Drawing.Point(222, 128);
            this.txtNobreCom.Name = "txtNobreCom";
            this.txtNobreCom.Size = new System.Drawing.Size(252, 24);
            this.txtNobreCom.TabIndex = 143;
            // 
            // txtApellidoCom
            // 
            this.txtApellidoCom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtApellidoCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoCom.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtApellidoCom.Location = new System.Drawing.Point(222, 186);
            this.txtApellidoCom.Name = "txtApellidoCom";
            this.txtApellidoCom.Size = new System.Drawing.Size(252, 24);
            this.txtApellidoCom.TabIndex = 142;
            // 
            // txtCedulaCom
            // 
            this.txtCedulaCom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtCedulaCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedulaCom.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtCedulaCom.Location = new System.Drawing.Point(222, 68);
            this.txtCedulaCom.Name = "txtCedulaCom";
            this.txtCedulaCom.Size = new System.Drawing.Size(252, 24);
            this.txtCedulaCom.TabIndex = 141;
            // 
            // lblDolares
            // 
            this.lblDolares.AutoSize = true;
            this.lblDolares.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDolares.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDolares.Location = new System.Drawing.Point(17, 299);
            this.lblDolares.Name = "lblDolares";
            this.lblDolares.Size = new System.Drawing.Size(191, 21);
            this.lblDolares.TabIndex = 136;
            this.lblDolares.Text = "Cantidad de dólares";
            // 
            // lblCambio
            // 
            this.lblCambio.AutoSize = true;
            this.lblCambio.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCambio.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCambio.Location = new System.Drawing.Point(17, 354);
            this.lblCambio.Name = "lblCambio";
            this.lblCambio.Size = new System.Drawing.Size(147, 21);
            this.lblCambio.TabIndex = 135;
            this.lblCambio.Text = "Tipo de cambio";
            // 
            // lblApellidoCom
            // 
            this.lblApellidoCom.AutoSize = true;
            this.lblApellidoCom.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoCom.ForeColor = System.Drawing.SystemColors.Control;
            this.lblApellidoCom.Location = new System.Drawing.Point(17, 189);
            this.lblApellidoCom.Name = "lblApellidoCom";
            this.lblApellidoCom.Size = new System.Drawing.Size(186, 21);
            this.lblApellidoCom.TabIndex = 134;
            this.lblApellidoCom.Text = "Apellidos del cliente";
            // 
            // lblNombreCom
            // 
            this.lblNombreCom.AutoSize = true;
            this.lblNombreCom.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCom.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNombreCom.Location = new System.Drawing.Point(17, 128);
            this.lblNombreCom.Name = "lblNombreCom";
            this.lblNombreCom.Size = new System.Drawing.Size(178, 21);
            this.lblNombreCom.TabIndex = 133;
            this.lblNombreCom.Text = "Nombre del cliente";
            // 
            // dgvCliente
            // 
            this.dgvCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Location = new System.Drawing.Point(12, 414);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.Size = new System.Drawing.Size(662, 218);
            this.dgvCliente.TabIndex = 0;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblnumTar
            // 
            this.lblnumTar.AutoSize = true;
            this.lblnumTar.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumTar.ForeColor = System.Drawing.SystemColors.Control;
            this.lblnumTar.Location = new System.Drawing.Point(17, 241);
            this.lblnumTar.Name = "lblnumTar";
            this.lblnumTar.Size = new System.Drawing.Size(172, 21);
            this.lblnumTar.TabIndex = 166;
            this.lblnumTar.Text = "Número de tarjeta";
            // 
            // txtNumTarjeta
            // 
            this.txtNumTarjeta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtNumTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumTarjeta.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtNumTarjeta.Location = new System.Drawing.Point(222, 241);
            this.txtNumTarjeta.Name = "txtNumTarjeta";
            this.txtNumTarjeta.Size = new System.Drawing.Size(252, 24);
            this.txtNumTarjeta.TabIndex = 167;
            // 
            // CompraDolares
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 645);
            this.Controls.Add(this.panel1);
            this.Name = "CompraDolares";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CompraDolares";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCedulaCom;
        private System.Windows.Forms.TextBox txtTipoCambio;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtCantidadDolares;
        private System.Windows.Forms.TextBox txtNobreCom;
        private System.Windows.Forms.TextBox txtApellidoCom;
        private System.Windows.Forms.TextBox txtCedulaCom;
        private System.Windows.Forms.Label lblDolares;
        private System.Windows.Forms.Label lblCambio;
        private System.Windows.Forms.Label lblApellidoCom;
        private System.Windows.Forms.Label lblNombreCom;
        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.Button btnVolverMenu;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtNumTarjeta;
        private System.Windows.Forms.Label lblnumTar;
    }
}
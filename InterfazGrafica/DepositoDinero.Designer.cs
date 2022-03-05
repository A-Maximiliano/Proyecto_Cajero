
namespace InterfazGrafica
{
    partial class DepositoDinero
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepositoDinero));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label22 = new System.Windows.Forms.Label();
            this.lblcedula = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txtMontoDepositar = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.btnDepositar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.btnVolverMenu = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.txtNombreDep = new System.Windows.Forms.TextBox();
            this.txtApellidoDep = new System.Windows.Forms.TextBox();
            this.txtCedulaDep = new System.Windows.Forms.TextBox();
            this.lblTerjeta = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.mtxtTarjeta = new System.Windows.Forms.MaskedTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panel1.Controls.Add(this.mtxtTarjeta);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.lblcedula);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.txtMontoDepositar);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.btnDepositar);
            this.panel1.Controls.Add(this.btnCalcular);
            this.panel1.Controls.Add(this.btnAsignar);
            this.panel1.Controls.Add(this.btnVolverMenu);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.txtNombreDep);
            this.panel1.Controls.Add(this.txtApellidoDep);
            this.panel1.Controls.Add(this.txtCedulaDep);
            this.panel1.Controls.Add(this.lblTerjeta);
            this.panel1.Controls.Add(this.lblMonto);
            this.panel1.Controls.Add(this.lblApellido);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Controls.Add(this.dgvCliente);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(687, 645);
            this.panel1.TabIndex = 1;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.SystemColors.Control;
            this.label22.Location = new System.Drawing.Point(541, 311);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(120, 20);
            this.label22.TabIndex = 42;
            this.label22.Text = "Volver al menú";
            // 
            // lblcedula
            // 
            this.lblcedula.AutoSize = true;
            this.lblcedula.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcedula.ForeColor = System.Drawing.SystemColors.Control;
            this.lblcedula.Location = new System.Drawing.Point(17, 69);
            this.lblcedula.Name = "lblcedula";
            this.lblcedula.Size = new System.Drawing.Size(172, 21);
            this.lblcedula.TabIndex = 155;
            this.lblcedula.Text = "Cédula del cliente";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.SystemColors.Control;
            this.label21.Location = new System.Drawing.Point(541, 227);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(120, 20);
            this.label21.TabIndex = 41;
            this.label21.Text = "Calcular saldos";
            // 
            // txtMontoDepositar
            // 
            this.txtMontoDepositar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtMontoDepositar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoDepositar.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtMontoDepositar.Location = new System.Drawing.Point(222, 354);
            this.txtMontoDepositar.Name = "txtMontoDepositar";
            this.txtMontoDepositar.Size = new System.Drawing.Size(252, 24);
            this.txtMontoDepositar.TabIndex = 153;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.Control;
            this.label19.Location = new System.Drawing.Point(566, 142);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(79, 20);
            this.label19.TabIndex = 39;
            this.label19.Text = "Depositar";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.Control;
            this.label20.Location = new System.Drawing.Point(576, 59);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(63, 20);
            this.label20.TabIndex = 40;
            this.label20.Text = "Asignar";
            // 
            // btnDepositar
            // 
            this.btnDepositar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDepositar.BackgroundImage")));
            this.btnDepositar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDepositar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDepositar.FlatAppearance.BorderSize = 0;
            this.btnDepositar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnDepositar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepositar.Location = new System.Drawing.Point(583, 165);
            this.btnDepositar.Name = "btnDepositar";
            this.btnDepositar.Size = new System.Drawing.Size(45, 45);
            this.btnDepositar.TabIndex = 149;
            this.btnDepositar.UseVisualStyleBackColor = true;
            this.btnDepositar.Click += new System.EventHandler(this.btnDepositar_Click);
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
            this.btnCalcular.TabIndex = 148;
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
            this.btnAsignar.TabIndex = 147;
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
            this.btnVolverMenu.TabIndex = 132;
            this.btnVolverMenu.UseVisualStyleBackColor = false;
            this.btnVolverMenu.Click += new System.EventHandler(this.btnVolverMenu_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.Control;
            this.label18.Location = new System.Drawing.Point(218, 9);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(228, 21);
            this.label18.TabIndex = 146;
            this.label18.Text = "DEPÓSITOS DE EFECTIVO";
            // 
            // txtNombreDep
            // 
            this.txtNombreDep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtNombreDep.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreDep.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtNombreDep.Location = new System.Drawing.Point(222, 137);
            this.txtNombreDep.Name = "txtNombreDep";
            this.txtNombreDep.Size = new System.Drawing.Size(252, 24);
            this.txtNombreDep.TabIndex = 143;
            // 
            // txtApellidoDep
            // 
            this.txtApellidoDep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtApellidoDep.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoDep.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtApellidoDep.Location = new System.Drawing.Point(222, 206);
            this.txtApellidoDep.Name = "txtApellidoDep";
            this.txtApellidoDep.Size = new System.Drawing.Size(252, 24);
            this.txtApellidoDep.TabIndex = 142;
            // 
            // txtCedulaDep
            // 
            this.txtCedulaDep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtCedulaDep.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedulaDep.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtCedulaDep.Location = new System.Drawing.Point(222, 68);
            this.txtCedulaDep.Name = "txtCedulaDep";
            this.txtCedulaDep.Size = new System.Drawing.Size(252, 24);
            this.txtCedulaDep.TabIndex = 141;
            // 
            // lblTerjeta
            // 
            this.lblTerjeta.AutoSize = true;
            this.lblTerjeta.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTerjeta.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTerjeta.Location = new System.Drawing.Point(18, 277);
            this.lblTerjeta.Name = "lblTerjeta";
            this.lblTerjeta.Size = new System.Drawing.Size(172, 21);
            this.lblTerjeta.TabIndex = 136;
            this.lblTerjeta.Text = "Número de tarjeta";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonto.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMonto.Location = new System.Drawing.Point(17, 354);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(173, 21);
            this.lblMonto.TabIndex = 135;
            this.lblMonto.Text = "Monto a depositar";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.ForeColor = System.Drawing.SystemColors.Control;
            this.lblApellido.Location = new System.Drawing.Point(17, 206);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(186, 21);
            this.lblApellido.TabIndex = 134;
            this.lblApellido.Text = "Apellidos del cliente";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNombre.Location = new System.Drawing.Point(18, 137);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(178, 21);
            this.lblNombre.TabIndex = 133;
            this.lblNombre.Text = "Nombre del cliente";
            // 
            // dgvCliente
            // 
            this.dgvCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Location = new System.Drawing.Point(11, 414);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.Size = new System.Drawing.Size(663, 218);
            this.dgvCliente.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(537, 59);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(130, 319);
            this.panel3.TabIndex = 156;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // mtxtTarjeta
            // 
            this.mtxtTarjeta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.mtxtTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtTarjeta.ForeColor = System.Drawing.SystemColors.Window;
            this.mtxtTarjeta.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert;
            this.mtxtTarjeta.Location = new System.Drawing.Point(222, 277);
            this.mtxtTarjeta.Mask = "0000-0000-0000-0000";
            this.mtxtTarjeta.Name = "mtxtTarjeta";
            this.mtxtTarjeta.Size = new System.Drawing.Size(252, 24);
            this.mtxtTarjeta.TabIndex = 169;
            // 
            // DepositoDinero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 644);
            this.Controls.Add(this.panel1);
            this.Name = "DepositoDinero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DepositoDinero";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblcedula;
        private System.Windows.Forms.TextBox txtMontoDepositar;
        private System.Windows.Forms.Button btnDepositar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.Button btnVolverMenu;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtNombreDep;
        private System.Windows.Forms.TextBox txtApellidoDep;
        private System.Windows.Forms.TextBox txtCedulaDep;
        private System.Windows.Forms.Label lblTerjeta;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.MaskedTextBox mtxtTarjeta;
    }
}
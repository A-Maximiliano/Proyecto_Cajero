
namespace InterfazGrafica
{
    partial class RetiroDinero
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RetiroDinero));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRetirar = new System.Windows.Forms.Button();
            this.btnCalcularRet = new System.Windows.Forms.Button();
            this.btnAsignarRet = new System.Windows.Forms.Button();
            this.btnVolverMenu = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblcedula = new System.Windows.Forms.Label();
            this.txtMontoRetirar = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtNombreRet = new System.Windows.Forms.TextBox();
            this.txtApellidoRet = new System.Windows.Forms.TextBox();
            this.txtCedulaRet = new System.Windows.Forms.TextBox();
            this.lblTarjetaRet = new System.Windows.Forms.Label();
            this.lblRetirar = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.mtxtTarjeta = new System.Windows.Forms.MaskedTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panel1.Controls.Add(this.mtxtTarjeta);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnRetirar);
            this.panel1.Controls.Add(this.btnCalcularRet);
            this.panel1.Controls.Add(this.btnAsignarRet);
            this.panel1.Controls.Add(this.btnVolverMenu);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lblcedula);
            this.panel1.Controls.Add(this.txtMontoRetirar);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.txtNombreRet);
            this.panel1.Controls.Add(this.txtApellidoRet);
            this.panel1.Controls.Add(this.txtCedulaRet);
            this.panel1.Controls.Add(this.lblTarjetaRet);
            this.panel1.Controls.Add(this.lblRetirar);
            this.panel1.Controls.Add(this.lblApellido);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Controls.Add(this.dgvCliente);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(687, 645);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(541, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 160;
            this.label1.Text = "Volver al menú";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(541, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 159;
            this.label2.Text = "Calcular saldos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(576, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 158;
            this.label4.Text = "Asignar";
            // 
            // btnRetirar
            // 
            this.btnRetirar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRetirar.BackgroundImage")));
            this.btnRetirar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRetirar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRetirar.FlatAppearance.BorderSize = 0;
            this.btnRetirar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnRetirar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetirar.Location = new System.Drawing.Point(583, 159);
            this.btnRetirar.Name = "btnRetirar";
            this.btnRetirar.Size = new System.Drawing.Size(45, 45);
            this.btnRetirar.TabIndex = 164;
            this.btnRetirar.UseVisualStyleBackColor = true;
            this.btnRetirar.Click += new System.EventHandler(this.btnRetirar_Click);
            // 
            // btnCalcularRet
            // 
            this.btnCalcularRet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCalcularRet.BackgroundImage")));
            this.btnCalcularRet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCalcularRet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcularRet.FlatAppearance.BorderSize = 0;
            this.btnCalcularRet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnCalcularRet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcularRet.Location = new System.Drawing.Point(580, 244);
            this.btnCalcularRet.Name = "btnCalcularRet";
            this.btnCalcularRet.Size = new System.Drawing.Size(45, 45);
            this.btnCalcularRet.TabIndex = 163;
            this.btnCalcularRet.UseVisualStyleBackColor = true;
            this.btnCalcularRet.Click += new System.EventHandler(this.btnCalcularRet_Click);
            // 
            // btnAsignarRet
            // 
            this.btnAsignarRet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAsignarRet.BackgroundImage")));
            this.btnAsignarRet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAsignarRet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAsignarRet.FlatAppearance.BorderSize = 0;
            this.btnAsignarRet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnAsignarRet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsignarRet.Location = new System.Drawing.Point(580, 76);
            this.btnAsignarRet.Name = "btnAsignarRet";
            this.btnAsignarRet.Size = new System.Drawing.Size(45, 45);
            this.btnAsignarRet.TabIndex = 162;
            this.btnAsignarRet.UseVisualStyleBackColor = true;
            this.btnAsignarRet.Click += new System.EventHandler(this.btnAsignarRet_Click);
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
            this.btnVolverMenu.Location = new System.Drawing.Point(583, 330);
            this.btnVolverMenu.Name = "btnVolverMenu";
            this.btnVolverMenu.Size = new System.Drawing.Size(45, 45);
            this.btnVolverMenu.TabIndex = 161;
            this.btnVolverMenu.UseVisualStyleBackColor = false;
            this.btnVolverMenu.Click += new System.EventHandler(this.btnVolverMenu_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(537, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(130, 319);
            this.panel2.TabIndex = 165;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(38, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 157;
            this.label3.Text = "Retirar";
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
            // txtMontoRetirar
            // 
            this.txtMontoRetirar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtMontoRetirar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoRetirar.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtMontoRetirar.Location = new System.Drawing.Point(222, 348);
            this.txtMontoRetirar.Name = "txtMontoRetirar";
            this.txtMontoRetirar.Size = new System.Drawing.Size(252, 24);
            this.txtMontoRetirar.TabIndex = 153;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.Control;
            this.label18.Location = new System.Drawing.Point(243, 8);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(192, 21);
            this.label18.TabIndex = 146;
            this.label18.Text = "RETIRO DE EFECTIVO";
            // 
            // txtNombreRet
            // 
            this.txtNombreRet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtNombreRet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreRet.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtNombreRet.Location = new System.Drawing.Point(222, 131);
            this.txtNombreRet.Name = "txtNombreRet";
            this.txtNombreRet.Size = new System.Drawing.Size(252, 24);
            this.txtNombreRet.TabIndex = 143;
            // 
            // txtApellidoRet
            // 
            this.txtApellidoRet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtApellidoRet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoRet.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtApellidoRet.Location = new System.Drawing.Point(222, 200);
            this.txtApellidoRet.Name = "txtApellidoRet";
            this.txtApellidoRet.Size = new System.Drawing.Size(252, 24);
            this.txtApellidoRet.TabIndex = 142;
            // 
            // txtCedulaRet
            // 
            this.txtCedulaRet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtCedulaRet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedulaRet.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtCedulaRet.Location = new System.Drawing.Point(222, 62);
            this.txtCedulaRet.Name = "txtCedulaRet";
            this.txtCedulaRet.Size = new System.Drawing.Size(252, 24);
            this.txtCedulaRet.TabIndex = 141;
            // 
            // lblTarjetaRet
            // 
            this.lblTarjetaRet.AutoSize = true;
            this.lblTarjetaRet.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTarjetaRet.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTarjetaRet.Location = new System.Drawing.Point(18, 277);
            this.lblTarjetaRet.Name = "lblTarjetaRet";
            this.lblTarjetaRet.Size = new System.Drawing.Size(172, 21);
            this.lblTarjetaRet.TabIndex = 136;
            this.lblTarjetaRet.Text = "Número de tarjeta";
            // 
            // lblRetirar
            // 
            this.lblRetirar.AutoSize = true;
            this.lblRetirar.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRetirar.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRetirar.Location = new System.Drawing.Point(18, 354);
            this.lblRetirar.Name = "lblRetirar";
            this.lblRetirar.Size = new System.Drawing.Size(140, 21);
            this.lblRetirar.TabIndex = 135;
            this.lblRetirar.Text = "Monto a retirar";
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
            this.mtxtTarjeta.TabIndex = 170;
            // 
            // RetiroDinero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 646);
            this.Controls.Add(this.panel1);
            this.Name = "RetiroDinero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Retiro Dinero";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblcedula;
        private System.Windows.Forms.TextBox txtMontoRetirar;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtNombreRet;
        private System.Windows.Forms.TextBox txtApellidoRet;
        private System.Windows.Forms.TextBox txtCedulaRet;
        private System.Windows.Forms.Label lblTarjetaRet;
        private System.Windows.Forms.Label lblRetirar;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRetirar;
        private System.Windows.Forms.Button btnCalcularRet;
        private System.Windows.Forms.Button btnAsignarRet;
        private System.Windows.Forms.Button btnVolverMenu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.MaskedTextBox mtxtTarjeta;
    }
}
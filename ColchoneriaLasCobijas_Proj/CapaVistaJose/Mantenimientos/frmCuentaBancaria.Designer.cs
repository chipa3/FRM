namespace CapaVistaJose.Mantenimientos
{
    partial class frmCuentaBancaria
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
            this.cmbMoneda = new System.Windows.Forms.ComboBox();
            this.cmbPropietario = new System.Windows.Forms.ComboBox();
            this.cmbBanco = new System.Windows.Forms.ComboBox();
            this.dvgDatos = new System.Windows.Forms.DataGridView();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblMoneda = new System.Windows.Forms.Label();
            this.lblPropietario = new System.Windows.Forms.Label();
            this.lblBanco = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.cmbCodigoMoneda = new System.Windows.Forms.ComboBox();
            this.cmbCodigoPropietario = new System.Windows.Forms.ComboBox();
            this.cmbCodigoBanco = new System.Windows.Forms.ComboBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.navegador1 = new CapaVistaNavegador.Navegador();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.rbEstadoActivo = new System.Windows.Forms.RadioButton();
            this.rbEstadoInactivo = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dvgDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbMoneda
            // 
            this.cmbMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMoneda.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMoneda.FormattingEnabled = true;
            this.cmbMoneda.Location = new System.Drawing.Point(215, 285);
            this.cmbMoneda.Name = "cmbMoneda";
            this.cmbMoneda.Size = new System.Drawing.Size(282, 28);
            this.cmbMoneda.TabIndex = 55;
            this.cmbMoneda.SelectedIndexChanged += new System.EventHandler(this.cmbMoneda_SelectedIndexChanged);
            // 
            // cmbPropietario
            // 
            this.cmbPropietario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPropietario.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPropietario.FormattingEnabled = true;
            this.cmbPropietario.Location = new System.Drawing.Point(215, 240);
            this.cmbPropietario.Name = "cmbPropietario";
            this.cmbPropietario.Size = new System.Drawing.Size(282, 28);
            this.cmbPropietario.TabIndex = 54;
            this.cmbPropietario.SelectedIndexChanged += new System.EventHandler(this.cmbPropietario_SelectedIndexChanged);
            // 
            // cmbBanco
            // 
            this.cmbBanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBanco.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBanco.FormattingEnabled = true;
            this.cmbBanco.Location = new System.Drawing.Point(215, 199);
            this.cmbBanco.Name = "cmbBanco";
            this.cmbBanco.Size = new System.Drawing.Size(282, 28);
            this.cmbBanco.TabIndex = 53;
            this.cmbBanco.SelectedIndexChanged += new System.EventHandler(this.cmbBanco_SelectedIndexChanged);
            // 
            // dvgDatos
            // 
            this.dvgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgDatos.Location = new System.Drawing.Point(619, 156);
            this.dvgDatos.Name = "dvgDatos";
            this.dvgDatos.ReadOnly = true;
            this.dvgDatos.RowHeadersWidth = 51;
            this.dvgDatos.RowTemplate.Height = 24;
            this.dvgDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgDatos.Size = new System.Drawing.Size(812, 270);
            this.dvgDatos.TabIndex = 52;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(12, 387);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(77, 20);
            this.lblEstado.TabIndex = 51;
            this.lblEstado.Text = "ESTADO";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(12, 439);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(157, 20);
            this.lblFecha.TabIndex = 50;
            this.lblFecha.Text = "FECHA APERTURA";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.Location = new System.Drawing.Point(12, 335);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(65, 20);
            this.lblSaldo.TabIndex = 49;
            this.lblSaldo.Text = "SALDO";
            // 
            // lblMoneda
            // 
            this.lblMoneda.AutoSize = true;
            this.lblMoneda.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoneda.Location = new System.Drawing.Point(12, 285);
            this.lblMoneda.Name = "lblMoneda";
            this.lblMoneda.Size = new System.Drawing.Size(85, 20);
            this.lblMoneda.TabIndex = 48;
            this.lblMoneda.Text = "MONEDA";
            // 
            // lblPropietario
            // 
            this.lblPropietario.AutoSize = true;
            this.lblPropietario.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPropietario.Location = new System.Drawing.Point(12, 237);
            this.lblPropietario.Name = "lblPropietario";
            this.lblPropietario.Size = new System.Drawing.Size(120, 20);
            this.lblPropietario.TabIndex = 47;
            this.lblPropietario.Text = "PROPIETARIO";
            // 
            // lblBanco
            // 
            this.lblBanco.AutoSize = true;
            this.lblBanco.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBanco.Location = new System.Drawing.Point(12, 196);
            this.lblBanco.Name = "lblBanco";
            this.lblBanco.Size = new System.Drawing.Size(70, 20);
            this.lblBanco.TabIndex = 46;
            this.lblBanco.Text = "BANCO";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(12, 159);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(81, 20);
            this.lblCodigo.TabIndex = 45;
            this.lblCodigo.Text = "CODIGO";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Location = new System.Drawing.Point(244, 439);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(442, 27);
            this.dtpFecha.TabIndex = 43;
            this.dtpFecha.Tag = "fecha_apertura_cuenta_bancaria";
            // 
            // txtSueldo
            // 
            this.txtSueldo.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSueldo.Location = new System.Drawing.Point(215, 332);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(282, 27);
            this.txtSueldo.TabIndex = 42;
            this.txtSueldo.Tag = "saldo_cuenta_bancaria";
            this.txtSueldo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSueldo_KeyPress);
            // 
            // cmbCodigoMoneda
            // 
            this.cmbCodigoMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCodigoMoneda.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCodigoMoneda.FormattingEnabled = true;
            this.cmbCodigoMoneda.Location = new System.Drawing.Point(506, 282);
            this.cmbCodigoMoneda.Name = "cmbCodigoMoneda";
            this.cmbCodigoMoneda.Size = new System.Drawing.Size(61, 28);
            this.cmbCodigoMoneda.TabIndex = 41;
            this.cmbCodigoMoneda.Tag = "fk_id_tipo_moneda";
            this.cmbCodigoMoneda.SelectedIndexChanged += new System.EventHandler(this.cmbCodigoMoneda_SelectedIndexChanged);
            // 
            // cmbCodigoPropietario
            // 
            this.cmbCodigoPropietario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCodigoPropietario.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCodigoPropietario.FormattingEnabled = true;
            this.cmbCodigoPropietario.Location = new System.Drawing.Point(506, 237);
            this.cmbCodigoPropietario.Name = "cmbCodigoPropietario";
            this.cmbCodigoPropietario.Size = new System.Drawing.Size(61, 28);
            this.cmbCodigoPropietario.TabIndex = 40;
            this.cmbCodigoPropietario.Tag = "fk_id_propietario";
            this.cmbCodigoPropietario.SelectedIndexChanged += new System.EventHandler(this.cmbCodigoPropietario_SelectedIndexChanged);
            // 
            // cmbCodigoBanco
            // 
            this.cmbCodigoBanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCodigoBanco.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCodigoBanco.FormattingEnabled = true;
            this.cmbCodigoBanco.Location = new System.Drawing.Point(506, 201);
            this.cmbCodigoBanco.Name = "cmbCodigoBanco";
            this.cmbCodigoBanco.Size = new System.Drawing.Size(61, 28);
            this.cmbCodigoBanco.TabIndex = 39;
            this.cmbCodigoBanco.Tag = "fk_id_banco";
            this.cmbCodigoBanco.SelectedIndexChanged += new System.EventHandler(this.cmbCodigoBanco_SelectedIndexChanged);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(215, 156);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(110, 27);
            this.txtCodigo.TabIndex = 38;
            this.txtCodigo.Tag = "pk_id_numero_cuenta_bancaria";
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.Color.Transparent;
            this.navegador1.Location = new System.Drawing.Point(16, 13);
            this.navegador1.Margin = new System.Windows.Forms.Padding(4);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(1412, 129);
            this.navegador1.TabIndex = 37;
            this.navegador1.Load += new System.EventHandler(this.navegador1_Load);
            // 
            // txtEstado
            // 
            this.txtEstado.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstado.Location = new System.Drawing.Point(692, 439);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(65, 27);
            this.txtEstado.TabIndex = 56;
            this.txtEstado.Tag = "estado_apertura_cuenta_bancaria";
            this.txtEstado.Visible = false;
            this.txtEstado.TextChanged += new System.EventHandler(this.txtEstado_TextChanged);
            // 
            // rbEstadoActivo
            // 
            this.rbEstadoActivo.AutoSize = true;
            this.rbEstadoActivo.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEstadoActivo.Location = new System.Drawing.Point(215, 387);
            this.rbEstadoActivo.Name = "rbEstadoActivo";
            this.rbEstadoActivo.Size = new System.Drawing.Size(80, 24);
            this.rbEstadoActivo.TabIndex = 57;
            this.rbEstadoActivo.TabStop = true;
            this.rbEstadoActivo.Text = "Activo";
            this.rbEstadoActivo.UseVisualStyleBackColor = true;
            this.rbEstadoActivo.CheckedChanged += new System.EventHandler(this.rbEstadoActivo_CheckedChanged);
            // 
            // rbEstadoInactivo
            // 
            this.rbEstadoInactivo.AutoSize = true;
            this.rbEstadoInactivo.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEstadoInactivo.Location = new System.Drawing.Point(339, 387);
            this.rbEstadoInactivo.Name = "rbEstadoInactivo";
            this.rbEstadoInactivo.Size = new System.Drawing.Size(92, 24);
            this.rbEstadoInactivo.TabIndex = 58;
            this.rbEstadoInactivo.TabStop = true;
            this.rbEstadoInactivo.Text = "Inactivo";
            this.rbEstadoInactivo.UseVisualStyleBackColor = true;
            this.rbEstadoInactivo.CheckedChanged += new System.EventHandler(this.rbEstadoInactivo_CheckedChanged);
            // 
            // frmCuentaBancaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1450, 482);
            this.Controls.Add(this.rbEstadoInactivo);
            this.Controls.Add(this.rbEstadoActivo);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.cmbMoneda);
            this.Controls.Add(this.cmbPropietario);
            this.Controls.Add(this.cmbBanco);
            this.Controls.Add(this.dvgDatos);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.lblMoneda);
            this.Controls.Add(this.lblPropietario);
            this.Controls.Add(this.lblBanco);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.txtSueldo);
            this.Controls.Add(this.cmbCodigoMoneda);
            this.Controls.Add(this.cmbCodigoPropietario);
            this.Controls.Add(this.cmbCodigoBanco);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.navegador1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCuentaBancaria";
            this.Text = "Mantenimiento - Cuenta Bancaria - 1305";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCuentaBancaria_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dvgDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbMoneda;
        private System.Windows.Forms.ComboBox cmbPropietario;
        private System.Windows.Forms.ComboBox cmbBanco;
        private System.Windows.Forms.DataGridView dvgDatos;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblMoneda;
        private System.Windows.Forms.Label lblPropietario;
        private System.Windows.Forms.Label lblBanco;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.ComboBox cmbCodigoMoneda;
        private System.Windows.Forms.ComboBox cmbCodigoPropietario;
        private System.Windows.Forms.ComboBox cmbCodigoBanco;
        private System.Windows.Forms.TextBox txtCodigo;
        private CapaVistaNavegador.Navegador navegador1;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.RadioButton rbEstadoActivo;
        private System.Windows.Forms.RadioButton rbEstadoInactivo;
    }
}
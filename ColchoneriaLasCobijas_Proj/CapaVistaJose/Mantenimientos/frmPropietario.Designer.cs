namespace CapaVistaJose.Mantenimientos
{
    partial class frmPropietario
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
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblPropietario = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtPropietario = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.navegador1 = new CapaVistaNavegador.Navegador();
            this.rbEstadoActivo = new System.Windows.Forms.RadioButton();
            this.rbEstadoInactivo = new System.Windows.Forms.RadioButton();
            this.txtEstado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(544, 159);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RowHeadersWidth = 51;
            this.dgvDatos.RowTemplate.Height = 24;
            this.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatos.Size = new System.Drawing.Size(847, 246);
            this.dgvDatos.TabIndex = 37;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(18, 366);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(77, 20);
            this.lblEstado.TabIndex = 36;
            this.lblEstado.Text = "ESTADO";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(14, 247);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(123, 20);
            this.lblDescripcion.TabIndex = 35;
            this.lblDescripcion.Text = "DESCRIPCION";
            // 
            // lblPropietario
            // 
            this.lblPropietario.AutoSize = true;
            this.lblPropietario.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPropietario.Location = new System.Drawing.Point(14, 205);
            this.lblPropietario.Name = "lblPropietario";
            this.lblPropietario.Size = new System.Drawing.Size(120, 20);
            this.lblPropietario.TabIndex = 34;
            this.lblPropietario.Text = "PROPIETARIO";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(14, 159);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(81, 20);
            this.lblCodigo.TabIndex = 33;
            this.lblCodigo.Text = "CODIGO";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(188, 242);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(325, 102);
            this.txtDescripcion.TabIndex = 31;
            this.txtDescripcion.Tag = "descripcion_propietario";
            this.txtDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescripcion_KeyPress);
            // 
            // txtPropietario
            // 
            this.txtPropietario.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPropietario.Location = new System.Drawing.Point(188, 200);
            this.txtPropietario.Name = "txtPropietario";
            this.txtPropietario.Size = new System.Drawing.Size(325, 27);
            this.txtPropietario.TabIndex = 30;
            this.txtPropietario.Tag = "nombre_propietario";
            this.txtPropietario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPropietario_KeyPress);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(188, 159);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(140, 27);
            this.txtCodigo.TabIndex = 29;
            this.txtCodigo.Tag = "pk_id_propietario";
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.Color.Transparent;
            this.navegador1.Location = new System.Drawing.Point(13, 23);
            this.navegador1.Margin = new System.Windows.Forms.Padding(4);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(1412, 129);
            this.navegador1.TabIndex = 28;
            this.navegador1.Load += new System.EventHandler(this.navegador1_Load);
            // 
            // rbEstadoActivo
            // 
            this.rbEstadoActivo.AutoSize = true;
            this.rbEstadoActivo.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEstadoActivo.Location = new System.Drawing.Point(188, 366);
            this.rbEstadoActivo.Name = "rbEstadoActivo";
            this.rbEstadoActivo.Size = new System.Drawing.Size(80, 24);
            this.rbEstadoActivo.TabIndex = 38;
            this.rbEstadoActivo.TabStop = true;
            this.rbEstadoActivo.Text = "Activo";
            this.rbEstadoActivo.UseVisualStyleBackColor = true;
            this.rbEstadoActivo.CheckedChanged += new System.EventHandler(this.rbEstadoActivo_CheckedChanged);
            // 
            // rbEstadoInactivo
            // 
            this.rbEstadoInactivo.AutoSize = true;
            this.rbEstadoInactivo.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEstadoInactivo.Location = new System.Drawing.Point(306, 366);
            this.rbEstadoInactivo.Name = "rbEstadoInactivo";
            this.rbEstadoInactivo.Size = new System.Drawing.Size(92, 24);
            this.rbEstadoInactivo.TabIndex = 39;
            this.rbEstadoInactivo.TabStop = true;
            this.rbEstadoInactivo.Text = "Inactivo";
            this.rbEstadoInactivo.UseVisualStyleBackColor = true;
            this.rbEstadoInactivo.CheckedChanged += new System.EventHandler(this.rbEstadoInactivo_CheckedChanged);
            // 
            // txtEstado
            // 
            this.txtEstado.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstado.Location = new System.Drawing.Point(443, 365);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(70, 27);
            this.txtEstado.TabIndex = 40;
            this.txtEstado.Tag = "estado_propietario";
            this.txtEstado.Visible = false;
            this.txtEstado.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // frmPropietario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1437, 450);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.rbEstadoInactivo);
            this.Controls.Add(this.rbEstadoActivo);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblPropietario);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtPropietario);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.navegador1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPropietario";
            this.Text = "Mantenimiento - Propietario de Cuenta Bancaria- 1306";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblPropietario;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtPropietario;
        private System.Windows.Forms.TextBox txtCodigo;
        private CapaVistaNavegador.Navegador navegador1;
        private System.Windows.Forms.RadioButton rbEstadoActivo;
        private System.Windows.Forms.RadioButton rbEstadoInactivo;
        private System.Windows.Forms.TextBox txtEstado;
    }
}
﻿namespace CapaVistaJose.Mantenimientos
{
    partial class frmTipoMovimientoBancario
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
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblTransaccion = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtTransaccion = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.navegador1 = new CapaVistaNavegador.Navegador();
            this.rbEstadoActivo = new System.Windows.Forms.RadioButton();
            this.rbEstadoInactivo = new System.Windows.Forms.RadioButton();
            this.txtEstado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(16, 383);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(90, 22);
            this.lblEstado.TabIndex = 28;
            this.lblEstado.Text = "ESTADO";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(16, 269);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(144, 22);
            this.lblDescripcion.TabIndex = 27;
            this.lblDescripcion.Text = "DESCRIPCION";
            // 
            // lblTransaccion
            // 
            this.lblTransaccion.AutoSize = true;
            this.lblTransaccion.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransaccion.Location = new System.Drawing.Point(16, 223);
            this.lblTransaccion.Name = "lblTransaccion";
            this.lblTransaccion.Size = new System.Drawing.Size(152, 22);
            this.lblTransaccion.TabIndex = 26;
            this.lblTransaccion.Text = "TRANSACCION";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(16, 180);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(94, 22);
            this.lblCodigo.TabIndex = 25;
            this.lblCodigo.Text = "CODIGO";
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Enabled = false;
            this.dgvDatos.Location = new System.Drawing.Point(511, 175);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.RowHeadersWidth = 51;
            this.dgvDatos.RowTemplate.Height = 24;
            this.dgvDatos.Size = new System.Drawing.Size(889, 235);
            this.dgvDatos.TabIndex = 24;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(181, 264);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(314, 110);
            this.txtDescripcion.TabIndex = 22;
            this.txtDescripcion.Tag = "descripcion_tipo_transaccion";
            // 
            // txtTransaccion
            // 
            this.txtTransaccion.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTransaccion.Location = new System.Drawing.Point(181, 220);
            this.txtTransaccion.Name = "txtTransaccion";
            this.txtTransaccion.Size = new System.Drawing.Size(314, 31);
            this.txtTransaccion.TabIndex = 21;
            this.txtTransaccion.Tag = "nombre_tipo_transaccion";
            this.txtTransaccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTransaccion_KeyPress);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(181, 175);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(314, 31);
            this.txtCodigo.TabIndex = 20;
            this.txtCodigo.Tag = "pk_id_tipo_transaccion";
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.Color.Transparent;
            this.navegador1.Location = new System.Drawing.Point(14, 19);
            this.navegador1.Margin = new System.Windows.Forms.Padding(4);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(1412, 129);
            this.navegador1.TabIndex = 19;
            this.navegador1.Load += new System.EventHandler(this.navegador1_Load);
            // 
            // rbEstadoActivo
            // 
            this.rbEstadoActivo.AutoSize = true;
            this.rbEstadoActivo.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEstadoActivo.Location = new System.Drawing.Point(181, 383);
            this.rbEstadoActivo.Name = "rbEstadoActivo";
            this.rbEstadoActivo.Size = new System.Drawing.Size(89, 26);
            this.rbEstadoActivo.TabIndex = 29;
            this.rbEstadoActivo.TabStop = true;
            this.rbEstadoActivo.Text = "Activo";
            this.rbEstadoActivo.UseVisualStyleBackColor = true;
            this.rbEstadoActivo.CheckedChanged += new System.EventHandler(this.rbEstadoActivo_CheckedChanged);
            // 
            // rbEstadoInactivo
            // 
            this.rbEstadoInactivo.AutoSize = true;
            this.rbEstadoInactivo.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEstadoInactivo.Location = new System.Drawing.Point(297, 383);
            this.rbEstadoInactivo.Name = "rbEstadoInactivo";
            this.rbEstadoInactivo.Size = new System.Drawing.Size(103, 26);
            this.rbEstadoInactivo.TabIndex = 30;
            this.rbEstadoInactivo.TabStop = true;
            this.rbEstadoInactivo.Text = "Inactivo";
            this.rbEstadoInactivo.UseVisualStyleBackColor = true;
            this.rbEstadoInactivo.CheckedChanged += new System.EventHandler(this.rbEstadoInactivo_CheckedChanged);
            // 
            // txtEstado
            // 
            this.txtEstado.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstado.Location = new System.Drawing.Point(413, 383);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(82, 31);
            this.txtEstado.TabIndex = 31;
            this.txtEstado.Tag = "estado_tipo_transaccion";
            this.txtEstado.Visible = false;
            this.txtEstado.TextChanged += new System.EventHandler(this.txtEstado_TextChanged);
            // 
            // frmTipoMovimientoBancario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1442, 450);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.rbEstadoInactivo);
            this.Controls.Add(this.rbEstadoActivo);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblTransaccion);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtTransaccion);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.navegador1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTipoMovimientoBancario";
            this.Text = "Mantenimiento - Tipo De Movimiento Bancario - 1304";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblTransaccion;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtTransaccion;
        private System.Windows.Forms.TextBox txtCodigo;
        private CapaVistaNavegador.Navegador navegador1;
        private System.Windows.Forms.RadioButton rbEstadoActivo;
        private System.Windows.Forms.RadioButton rbEstadoInactivo;
        private System.Windows.Forms.TextBox txtEstado;
    }
}
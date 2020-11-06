﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVistaJose.Mantenimientos
{
    public partial class frmTipoMovimientoBancario : Form
    {
        string UsuarioAplicacion;
        static Form FormularioPadre;
        public frmTipoMovimientoBancario(string usuario, Form formularioPadre)
        {
            InitializeComponent();
            UsuarioAplicacion = usuario;
            navegador1.Usuario = UsuarioAplicacion;
            FormularioPadre = formularioPadre;
        }

        private void rbEstadoActivo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEstadoActivo.Checked == true)
            {
                txtEstado.Text = "1";
            }
        }

        private void rbEstadoInactivo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEstadoInactivo.Checked == true)
            {
                txtEstado.Text = "0";
            }
        }

        private void txtEstado_TextChanged(object sender, EventArgs e)
        {
            if (txtEstado.Text == "")
            {
                rbEstadoActivo.Checked = false;
                rbEstadoInactivo.Checked = false;
            }
            if (txtEstado.Text == "1")
            {
                rbEstadoActivo.Checked = true;
            }
        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            List<string> CamposTabla = new List<string>();
            List<Control> lista = new List<Control>();
            //el numero de aplicacion se debe cambiar por el numero asignado en la base de datos 
            navegador1.aplicacion = 1304;
            //banco se debe cambiar por la tabla a la que se quiere hacer el mantenimiento
            navegador1.tbl = "tipo_transaccion";
            //estado_banco se debe cambiar por el estado de la tabla a la que se desea hacer mantenimiento
            navegador1.campoEstado = "estado_tipo_transaccion";
            navegador1.MDIformulario = FormularioPadre;
            foreach (Control C in this.Controls)
            {
                if ((C.Tag != null) && (!C.Tag.ToString().Equals("")))
                {
                    if (C is TextBox)
                    {
                        lista.Add(C);

                    }
                    else if (C is ComboBox)
                    {
                        lista.Add(C);

                    }
                    else if (C is DateTimePicker)
                    {
                        lista.Add(C);
                    }
                }
            }
            navegador1.control = lista;
            navegador1.formulario = this;
            //el dataGridView1 se debe cambiar por el que se tiene en el formulario
            navegador1.DatosActualizar = dgvDatos;
            navegador1.procActualizarData();
            navegador1.procCargar();
            //en la variable ayuda ruta debe colocar la carpeta y el archivo.chm de su proyecto de ayuda
            navegador1.ayudaRuta = "AyudaBancos/AyudaBancos.chm";
            //en ruta debe colocar la pagina html que quiere que se muestre cuendo se presione el boton ayuda
            navegador1.ruta = "Tipo_transaccion.html";
        }

        private void txtTransaccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClsValidaciones validar = new ClsValidaciones();
            validar.funcSoloLetras(e);

            if (txtTransaccion.Text.Length > 45)
            {
                MessageBox.Show("No puede ingresar mas de 45 Caracteres", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTransaccion.Text = "";
            }
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtDescripcion.Text.Length > 75)
            {
                MessageBox.Show("No puede ingresar mas de 75 Caracteres", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDescripcion.Text = "";
            }
        }
    }
}

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
    public partial class MantenimientosBancos1302 : Form
    {

        string UsuarioAplicacion;
        static Form FormularioPadre;
        public MantenimientosBancos1302(string usuario, Form formularioPadre)
        {
            InitializeComponent();
            UsuarioAplicacion = usuario;
            navegador1.Usuario = UsuarioAplicacion;
            FormularioPadre = formularioPadre;
        }

        private void rbEstadoInactivo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEstadoInactivo.Checked == true)
            {
                txtEstado.Text = "0";
            }
        }

        private void rbEstadoActivo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEstadoActivo.Checked == true)
            {
                txtEstado.Text = "1";
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
            navegador1.aplicacion = 1302;
            navegador1.tbl = "banco";
            navegador1.campoEstado = "estado_banco";
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
            navegador1.DatosActualizar = dvgDatos;
            navegador1.procActualizarData();
            navegador1.procCargar();
            navegador1.ayudaRuta = "AyudaBancos/AyudaBancos.chm";
            navegador1.ruta = "Bancos.html";
        }

        private void txtBanco_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClsValidaciones Validar = new ClsValidaciones();
            Validar.funcSoloLetras(e);
            if (txtBanco.Text.Length > 40)
            {
                MessageBox.Show("No puede ingresar mas de 40 Caracteres", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);  
                txtBanco.Text = "";
            }
          
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;

namespace CapaVistaJose.Mantenimientos
{
    public partial class frmPeticionPoliza : Form
    {
        ClsConexion cn = new ClsConexion();
        ClsValidaciones validar = new ClsValidaciones();
        string UsuarioAplicacion;
        static Form FormularioPadre;
        public frmPeticionPoliza(string usuario, Form formularioPadre)
        {
            InitializeComponent();
            UsuarioAplicacion = usuario;
            navegador1.Usuario = UsuarioAplicacion;
            FormularioPadre = formularioPadre;
        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            List<string> CamposTabla = new List<string>();
            List<Control> lista = new List<Control>();
            navegador1.aplicacion = 1309;
            navegador1.tbl = "peticion_poliza";
            navegador1.campoEstado = "estado_peticion_poliza";
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
            navegador1.DatosActualizar = dgvDatos;
            navegador1.procActualizarData();
            navegador1.procCargar();
            navegador1.ayudaRuta = "AyudaBancos/AyudaBancos.chm";
            navegador1.ruta = "Bancos.html";
        }

        private void txtEstado_TextChanged(object sender, EventArgs e)
        {
            if (txtEstado.Text == "")
            {
                rdbActivo.Checked = false;
                rdbInactivo.Checked = false;
            }
            if (txtEstado.Text == "1")
            {
                rdbActivo.Checked = true;
            }
        }

        private void rdbActivo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbActivo.Checked == true)
            {
                txtEstado.Text = "1";
            }
        }

        private void rdbInactivo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbInactivo.Checked == true)
            {
                txtEstado.Text = "0";
            }
        }

        private void txtPeticionEncabezado_TextChanged(object sender, EventArgs e)
        {
            txtPeticionEncabezado.Text = txtPolizaSeguridad.Text;
        }

        private void txtConcepto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(txtConcepto.Text.Length > 30)
            {
                MessageBox.Show("No puede ingresar mas de 30 Caracteres", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtConcepto.Text = "";
            }
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtDescripcion.Text.Length > 100)
            {
                MessageBox.Show("No puede ingresar mas de 100 Caracteres", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDescripcion.Text = "";
            }
        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.funcSueldo(e); 
            if (txtMonto.Text.Length > 12)
            {
                MessageBox.Show("No puede ingresar mas de 12 Caracteres", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMonto.Text = "";
            }
        }
    }
}

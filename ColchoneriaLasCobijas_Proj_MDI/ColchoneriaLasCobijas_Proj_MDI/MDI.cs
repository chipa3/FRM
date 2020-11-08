using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaVistaJose.Mantenimientos;
using CapaVistaBryan.Mantenimientos;
using CapaVistaSeguridad;

namespace ColchoneriaLasCobijas_Proj_MDI
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void cuentaBancariToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsVistaBitacora bit = new clsVistaBitacora();
            clsFuncionesSeguridad seguridad = new clsFuncionesSeguridad();
            //el numero 1 se debe cambiar por el numero de la aplicacion que se tiene asignado en la base de datos 
            if (seguridad.PermisosAcceso("1305", textBox1.Text) == 1)
            {

                bit.user(textBox1.Text);
                // SE DEBE CAMBIAR BANCO POR EL FORMULARIO QUE SE DESEA ABRIR
                frmCuentaBancaria variable = new frmCuentaBancaria(textBox1.Text, this);
                variable.MdiParent = this;
                variable.Show();
            }
            else
            {
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }

        private void MDI_Load(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.ShowDialog();
            textBox1.Text = login.usuario();
        }

        private void propietarioDeCuentaBancariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsVistaBitacora bit = new clsVistaBitacora();
            clsFuncionesSeguridad seguridad = new clsFuncionesSeguridad();
            //el numero 1 se debe cambiar por el numero de la aplicacion que se tiene asignado en la base de datos 
            if (seguridad.PermisosAcceso("1306", textBox1.Text) == 1)
            {

                bit.user(textBox1.Text);
                // SE DEBE CAMBIAR BANCO POR EL FORMULARIO QUE SE DESEA ABRIR
                frmPropietario variable = new frmPropietario(textBox1.Text, this);
                variable.MdiParent = this;
                variable.Show();
            }
            else
            {
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }

        private void bancosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            clsVistaBitacora bit = new clsVistaBitacora();
            clsFuncionesSeguridad seguridad = new clsFuncionesSeguridad();
            //el numero 1 se debe cambiar por el numero de la aplicacion que se tiene asignado en la base de datos 
            if (seguridad.PermisosAcceso("1302", textBox1.Text) == 1)
            {

                bit.user(textBox1.Text);
                // SE DEBE CAMBIAR BANCO POR EL FORMULARIO QUE SE DESEA ABRIR
                MantenimientosBancos1302 variable = new MantenimientosBancos1302(textBox1.Text, this);
                variable.MdiParent = this;
                variable.Show();
            }
            else
            {
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }

        private void monedaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsVistaBitacora bit = new clsVistaBitacora();
            clsFuncionesSeguridad seguridad = new clsFuncionesSeguridad();
            //el numero 1 se debe cambiar por el numero de la aplicacion que se tiene asignado en la base de datos 
            if (seguridad.PermisosAcceso("1303", textBox1.Text) == 1)
            {

                bit.user(textBox1.Text);
                // SE DEBE CAMBIAR BANCO POR EL FORMULARIO QUE SE DESEA ABRIR
                frmMoneda variable = new frmMoneda(textBox1.Text, this);
                variable.MdiParent = this;
                variable.Show();
            }
            else
            {
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }

        private void movimientosBancariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsVistaBitacora bit = new clsVistaBitacora();
            clsFuncionesSeguridad seguridad = new clsFuncionesSeguridad();
            //el numero 1 se debe cambiar por el numero de la aplicacion que se tiene asignado en la base de datos 
            if (seguridad.PermisosAcceso("1304", textBox1.Text) == 1)
            {

                bit.user(textBox1.Text);
                // SE DEBE CAMBIAR BANCO POR EL FORMULARIO QUE SE DESEA ABRIR
                frmTipoMovimientoBancario variable = new frmTipoMovimientoBancario(textBox1.Text, this);
                variable.MdiParent = this;
                variable.Show();
            }
            else
            {
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }

        private void cuentasContablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCuentas Cuentas = new frmCuentas();
            Cuentas.MdiParent = this;
            Cuentas.Show();
        }

        private void transaccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsVistaBitacora bit = new clsVistaBitacora();
            clsFuncionesSeguridad seguridad = new clsFuncionesSeguridad();

            if (seguridad.PermisosAcceso("1307", textBox1.Text) == 1)
            {

                bit.user(textBox1.Text);

                frmTransacciones variable = new frmTransacciones();
                variable.MdiParent = this;
                variable.Show();
            }
            else
            {
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }

        private void disponibilidadDiariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsVistaBitacora bit = new clsVistaBitacora();
            clsFuncionesSeguridad seguridad = new clsFuncionesSeguridad();

            if (seguridad.PermisosAcceso("1308", textBox1.Text) == 1)
            {

                bit.user(textBox1.Text);

                frmDisponibilidadDiaria variable = new frmDisponibilidadDiaria();
                variable.MdiParent = this;
                variable.Show();
            }
            else
            {
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }

        private void transaccionesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "AyudaBancos/AyudaBancos.chm", "Transacciones.html");
        }

        private void peticionPolizaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsVistaBitacora bit = new clsVistaBitacora();
            clsFuncionesSeguridad seguridad = new clsFuncionesSeguridad();

            if (seguridad.PermisosAcceso("1309", textBox1.Text) == 1)
            {

                bit.user(textBox1.Text);

                frmPeticionPoliza variable = new frmPeticionPoliza(textBox1.Text, this);
                variable.MdiParent = this;
                variable.Show();
            }
            else
            {
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }
    }
}

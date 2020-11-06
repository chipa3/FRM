using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaVistaSeguridad;
using CapaVistaJose.Mantenimientos;

namespace ColchoneriaLasCobijas_Proj_MDI
{
    public partial class MDIFRM : Form
    {
        private int childFormNumber = 0;

        public MDIFRM()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

      

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void cuentasContablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CapaVistaBryan.Mantenimientos.frmCuentas Cuentas = new CapaVistaBryan.Mantenimientos.frmCuentas();
            Cuentas.MdiParent = this;
            Cuentas.Show();
        }

        private void MDIFRM_Load(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.ShowDialog();
            textBox1.Text = login.usuario();
        }

        private void bancosToolStripMenuItem3_Click(object sender, EventArgs e)
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

        private void propietariosDeCuentaToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void cuentasBancariasToolStripMenuItem_Click(object sender, EventArgs e)
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
    }
}

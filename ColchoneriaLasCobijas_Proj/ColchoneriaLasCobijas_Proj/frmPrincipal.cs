using PrototipoNoFuncionalBacos;
using prototipoPresupuesto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace ColchoneriaLasCobijas_Proj
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void cuentasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bancosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cuentaBancariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCuentasBancarias frm = new frmCuentasBancarias();
            frm.MdiParent = this;
            frm.Show();
        }

        private void cuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.MdiParent = this;
            frm.Show();
        }

        private void propietariosCuentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPropietariosCuentas frm = new frmPropietariosCuentas();
            frm.MdiParent = this;
            frm.Show();
        }

        private void bancosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmBancos frm = new frmBancos();
            frm.MdiParent = this;
            frm.Show();
        }

        private void transaccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTransacciones frm = new frmTransacciones();
            frm.MdiParent = this;
            frm.Show();
        }

        private void presupuestoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPresupuesto frm = new frmPresupuesto();
            frm.MdiParent = this;
            frm.Show();
        }

        private void balanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBalance frm = new frmBalance();
            frm.MdiParent = this;
            frm.Show();
        }

        private void diarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDiario frm = new frmDiario();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mayorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMayor frm = new frmMayor();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}

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
    public partial class frmTransacciones : Form
    {

        ClsConexion cn = new ClsConexion();
        int numero = 0;
        int codigoA = 0;

        public frmTransacciones()
        {
            InitializeComponent();
            procCodigoA();
            CargarCombos();
            CargarDatos();
        }

        void procCodigoA()
        {
            try
            //esta funcion hace un conteo de los datos que se encuentran en la tabla pelicula y almacena ese valor en la variable numero

            {
                string contador = "SELECT count(pk_id_transaccion) FROM TRANSACCION ";
                OdbcCommand comando = new OdbcCommand(contador, cn.conexion());
                numero = Convert.ToInt32(comando.ExecuteScalar());
                //si numero = 0, no encuentra ningun registro convierte el cidigoA en 1 y envia ese codigo para guardado como ID
                if (numero == 0)
                {
                    codigoA = 1;
                }
                else
                {
                    //de lo contrario se ira incrementando + 1 codigoA
                    codigoA = numero + 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        void CargarCombos()
        {
            try
            {
                //se obtiene el codigo y el nombre de la cuenta bancaria y se asgina a los combos asignados
                string Banco = "SELECT * FROM CUENTA_BANCARIA ";
                OdbcCommand ComandBanco = new OdbcCommand(Banco, cn.conexion());
                OdbcDataReader MostarBanco = ComandBanco.ExecuteReader();

                while (MostarBanco.Read())
                {
                    cmbCodigoCuenta.Items.Add(MostarBanco.GetString(0));
                }
                //se obtiene el codigo y el nombre del tipo de transaccion y se asgina a los combos asignados
                string Propietario = "SELECT * FROM TIPO_TRANSACCION ";
                OdbcCommand ComandPropietario = new OdbcCommand(Propietario, cn.conexion());
                OdbcDataReader MostrarPropietario = ComandPropietario.ExecuteReader();

                while (MostrarPropietario.Read())
                {
                    cmbCodigoTransaccion.Items.Add(MostrarPropietario.GetInt32(0));
                    cmbTransaccion.Items.Add(MostrarPropietario.GetString(1));
                }
                //se obtiene el codigo y el nombre del tipo de moneda y se asgina a los combos asignados
                string Moneda = "SELECT * FROM TIPO_MONEDA";
                OdbcCommand ComandMoneda = new OdbcCommand(Moneda, cn.conexion());
                OdbcDataReader MostrarMoneda = ComandMoneda.ExecuteReader();

                while (MostrarMoneda.Read())
                {
                    cmbCodigoMoneda.Items.Add(MostrarMoneda.GetInt32(0));
                    cmbMoneda.Items.Add(MostrarMoneda.GetString(1));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener datos de la tabla banco");
            }
        }


        void CargarDatos()
        {
            //procedimiento que carga los datos al dataGridView
            try
            {
                string cadena = " SELECT T.pk_id_transaccion AS CODIGO, C.pk_id_numero_cuenta_bancaria AS CUENTA_BANCARIA , T.monto_transaccion AS MONTO,TT.nombre_tipo_transaccion AS TIPO_DE_TRANSACCION ,T.descripcion_transaccion AS DESCRIPCION FROM transaccion T ,cuenta_bancaria C ,tipo_transaccion TT WHERE T.fk_id_numero_cuenta_bancaria = C.pk_id_numero_cuenta_bancaria AND T.fk_id_tipo_transaccion = TT.pk_id_tipo_transaccion;  ";
                OdbcDataAdapter datos = new OdbcDataAdapter(cadena, cn.conexion());
                DataTable dt = new DataTable();
                datos.Fill(dt);
                dgvDatos.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron mostrar los registros en este momento intente mas tarde" + ex);
            }

        }

        void procLimpiar()
        {

            cmbCodigoCuenta.Items.Clear();
            cmbTransaccion.Items.Clear();
            txtDescripcion.Text = "";
            cmbMoneda.Items.Clear();
            txtMonto.Text = "";
            txtSaldoActual.Text = "";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Este if verifica que no se deje ningun campo en blanco, si hay uno en blando muestra el mensaje de que se necesitan llenar los campos
            if (txtDescripcion.Text == "" || txtMonto.Text == "" || cmbCodigoCuenta.SelectedItem == null || cmbTransaccion.SelectedItem == null || cmbMoneda.SelectedItem == null)
            {
                MessageBox.Show("NO DEBE DEJAR CAMPOS VACIOS");
            }
            else
            {
                String Fecha = dtpFecha.Value.ToString("yyyy-MM-dd HH:MM");

                try
                {
                    //se realiza la consulta de insertar en tabla pelicula con sus respectivos campos
                    string Insertar = "INSERT INTO TRANSACCION (pk_id_transaccion,fk_id_numero_cuenta_bancaria,fecha_transaccion,fk_id_tipo_transaccion,fk_id_tipo_moneda,monto_transaccion,descripcion_transaccion) " +
                    "VALUES (" + codigoA + "," + Int32.Parse(cmbCodigoCuenta.SelectedItem.ToString()) + ",'" + Fecha + "'," + Int32.Parse(cmbCodigoTransaccion.SelectedItem.ToString()) + ",'" + Int32.Parse(cmbCodigoMoneda.SelectedItem.ToString()) + "', " + txtMonto.Text + ",'" + txtDescripcion.Text + "' )";
                    OdbcCommand comm = new OdbcCommand(Insertar, cn.conexion());
                    OdbcDataReader mostrarC = comm.ExecuteReader();
                    MessageBox.Show("Los datos se ingresaron correctamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);

                }
                procLimpiar();
                procCodigoA();
                CargarCombos();
                CargarDatos();
            }
        }

        private void cmbCuenta_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClsValidaciones VALIDAR = new ClsValidaciones();
            VALIDAR.funcSueldo(e);
        }

        private void cmbCodigoCuenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //Se obtine el monto actual de la cuenta
                string Banco = "SELECT * FROM CUENTA_BANCARIA WHERE pk_id_numero_cuenta_bancaria = " + Int32.Parse(cmbCodigoCuenta.SelectedItem.ToString());
                OdbcCommand ComandBanco = new OdbcCommand(Banco, cn.conexion());
                OdbcDataReader MostarBanco = ComandBanco.ExecuteReader();

                while (MostarBanco.Read())
                {
                    txtSaldoActual.Text = (MostarBanco.GetDouble(4)).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener Datos" + ex);
            }
        }

        private void cmbTransaccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCodigoTransaccion.SelectedIndex = cmbTransaccion.SelectedIndex;
        }

        private void cmbMoneda_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCodigoMoneda.SelectedIndex = cmbMoneda.SelectedIndex;
        }
    }
}

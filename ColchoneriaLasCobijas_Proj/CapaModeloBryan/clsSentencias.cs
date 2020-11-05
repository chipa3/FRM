
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModeloBryan
{
    public class clsSentencias
    {
        clsConexion Con = new clsConexion();
        //Esta funcion sirve para devolver a la capa controlador los datos que va contener el treeView de las cuentas
        public OdbcDataAdapter funcLlenarTree()
        {
            string Sql = "SELECT PK_ID_CUENTA_CONTABLE, NOMBRE_CUENTA_CONTABLE, NIVEL_CUENTA_CONTABLE, FK_CUENTA_PADRE_CUENTA_CONTABLE FROM CUENTA_CONTABLE;";
            OdbcDataAdapter DataTable = new OdbcDataAdapter(Sql, Con.conexion());
            return DataTable;
        }

        //Esta funcion sirve para obtener el codigo siguiente cuando se selecciona una cuenta del treeview
        public int funcInsertar(int Codigo)
        {
            string Sql = "SELECT MAX( PK_ID_CUENTA_CONTABLE) FROM CUENTA_CONTABLE WHERE PK_ID_CUENTA_CONTABLE LIKE '"+ Codigo +"%';";
            try
            {
                OdbcCommand Command = new OdbcCommand(Sql, Con.conexion());
                OdbcDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    Codigo = Reader.GetInt16(0);
                }

            }
            catch (Exception Ex) { Console.WriteLine(Ex.Message.ToString() + " \nError en asignarCombo, revise los parametros \n -\n -"); }
            return Codigo;
        }

        //Funcion para obtener el codigo siguiente de cuenta cuando se va insertar en la raiz
        public int funcInsertarNivel0()
        {
            int Codigo = 0;
            string Sql = "SELECT MAX( PK_ID_CUENTA_CONTABLE) FROM CUENTA_CONTABLE WHERE NIVEL_CUENTA_CONTABLE=1;";
            try
            {
                OdbcCommand Command = new OdbcCommand(Sql, Con.conexion());
                OdbcDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    Codigo = Reader.GetInt16(0);
                }

            }
            catch (Exception Ex) { Console.WriteLine(Ex.Message.ToString() + " \nError en asignarCombo, revise los parametros \n -\n -"); }
            return Codigo+1;
        }

        //Funcion para agregar una nueva cuenta contable a la tabla de cuentas contables
        public bool funcAgregar(int Codigo, string Nombre, int Nivel, int Padre, int TipoCuenta)
        {
            try
            {
                string InsertarCuenta = "INSERT INTO CUENTA_CONTABLE VALUES (" + Codigo + ",'" + Nombre + "'," + Nivel + "," + Padre + ",0,0,0,0,0,0,1," + TipoCuenta + ")";
                OdbcCommand Comm = new OdbcCommand(InsertarCuenta, Con.conexion());
                Comm.ExecuteNonQuery();
                return true;
            }
            catch (Exception Ex)
            {
                return false;
            }

        }

        //Funcion para devolver los datos para llenar los combos del form
        public string[] funcLlenarCmb(string Tabla, string Campo1)
        {
            string[] Campos = new string[100];
            int I = 0;
            string Sql = "SELECT " + Campo1 + " FROM " + Tabla +  "  ;";

            try
            {
                OdbcCommand Command = new OdbcCommand(Sql, Con.conexion());
                OdbcDataReader Reader = Command.ExecuteReader();
                while (Reader.Read())
                {

                    Campos[I] = Reader.GetValue(0).ToString();
                    I++;
                }
            }
            catch (Exception Ex) { Console.WriteLine(Ex.Message.ToString() + " \nError en asignarCombo, revise los parametros \n -" + Tabla + "\n -" + Campo1); }
            return Campos;
        }
    }
}

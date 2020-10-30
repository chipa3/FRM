using CapaModeloBryan;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaControladorBryan
{
    public class clsControlador
    {
        clsSentencias Sn = new clsSentencias();
        //Funcion para obtener los datos que se van a mostrar en el treeview y pasarlos a la capa vista
        public DataSet funcLlenarTree()
        {
            OdbcDataAdapter Dt = Sn.funcLlenarTree();
            DataSet Table = new DataSet();
            Dt.Fill(Table,"cuenta_contable");
            return Table;
        }

        //Funcion para obtener el codigo cuando se seleccciona una cuenta del treeview y pasarlo a la capa vista
        public int funcCodigoMax(int Codigo)
        {
            int CodigoNuevo = Sn.funcInsertar(Codigo);
            return CodigoNuevo;
        }

        //Funcion para obtener el codigo cuando no se seleccciona una cuenta del treeview y pasarlo a la capa vista
        public int funcCodigoMaxNivel0()
        {
            int CodigoNuevo = Sn.funcInsertarNivel0();
            return CodigoNuevo;
        }

        //Funcion para mandar los datos para ejecutar la consulta de agregar una nueva cuenta contable y devolver la respuesta a la capa vista
        public bool funcAgregar(int Codigo, string Nombre, int Nivel, int Padre, int TipoCuenta)
        {
            bool Respuesta = Sn.funcAgregar(Codigo, Nombre, Nivel, Padre, TipoCuenta);
            return Respuesta;
        }

        //Funcion para obtener los items con los que se van a llenar los combobox del form
        public string[] funcItems(string Tabla, string Campo1)
        {
            string[] Items = Sn.funcLlenarCmb(Tabla, Campo1);
            return Items;
        }
    }
}

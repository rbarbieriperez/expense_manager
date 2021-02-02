using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace gastos.Clases
{
    class InsertData
    {
        private MySqlDataAdapter _adaptor = new MySqlDataAdapter();
        private DBConection con = new DBConection();
        private Boolean estado = false;

        public Boolean InsertExpense(Datos datos)
        {
            try
            {
                con.conexion();
                _adaptor.InsertCommand = new MySqlCommand("INSERT INTO gasto(fecha,lugar,descripcion,importe) VALUES('"+datos.fecha+"','"+datos.lugar+"','"+datos.descripcion+"',"+datos.importe+")");
                _adaptor.InsertCommand.Connection = con._conexion;
                int rows_affected = _adaptor.InsertCommand.ExecuteNonQuery();
                if (rows_affected > 0)
                {
                    estado = true;
                }
                con.cerrar();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            return estado;
        }

        public Boolean InsertComerce(Datos datos)
        {
            try
            {
                con.conexion();
                _adaptor.InsertCommand = new MySqlCommand("INSERT INTO comercios(usuario,nombre_comercio,categoria,direccion,departamento,contacto,pais) VALUES('"+datos.user+"','"+datos.nombre_comercio+"','"+datos.categoria+"','"+datos.direccion+"','"+datos.departamento+"', "+datos.contacto+", '"+datos.pais+"')");
                _adaptor.InsertCommand.Connection = con._conexion;
                int result = _adaptor.InsertCommand.ExecuteNonQuery();
                if (result == 1)
                {
                    estado = true;
                }
                con.cerrar();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Error al ingresar los datos");
            }
            return estado;
        }
    }

    
}

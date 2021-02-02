using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace gastos.Clases
{
    class UpdateData
    {
        MySqlDataAdapter _adaptor = new MySqlDataAdapter();
        private Boolean estado = false;
        DBConection con = new DBConection();

        public Boolean UpdateExpense(Datos datos)
        {
            try
            {
                con.conexion();
                _adaptor.UpdateCommand = new MySqlCommand("UPDATE gasto SET fecha='"+datos.fecha+"', lugar='"+datos.lugar+"', descripcion='"+datos.descripcion+"', importe="+datos.importe+" WHERE cod_gasto= "+datos.cod_gasto+"");
                _adaptor.UpdateCommand.Connection = con._conexion;
                int result = _adaptor.UpdateCommand.ExecuteNonQuery();
                if (result == 1)
                {
                    estado = true;
                }
                con.cerrar();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Error al modificar los datos");
            }
            return estado;
        }

        public Boolean UpdateUserBase64Photo(Datos datos)
        {
            try
            {
                con.conexion();
                _adaptor.UpdateCommand = new MySqlCommand("UPDATE user SET foto='" + datos.foto + "' WHERE usuario = '" + datos.user + "';");
                _adaptor.UpdateCommand.Connection = con._conexion;
                int result = _adaptor.UpdateCommand.ExecuteNonQuery();
                if (result == 1)
                {
                    estado = true;
                }
                con.cerrar();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Error al realizar la consulta");
            }
            return estado;
        }

        public Boolean UpdateUserEmail(Datos datos)
        {
            try
            {
                con.conexion();
                _adaptor.UpdateCommand = new MySqlCommand("UPDATE user SET correo = '"+datos.correo+"' WHERE usuario='"+datos.user+"';");
                _adaptor.UpdateCommand.Connection = con._conexion;
                int result = _adaptor.UpdateCommand.ExecuteNonQuery();
                if (result == 1)
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
    }
}

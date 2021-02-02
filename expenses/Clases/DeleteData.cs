using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace gastos.Clases
{
    class DeleteData
    {
        private Boolean estado = false;
        MySqlDataAdapter _adaptor = new MySqlDataAdapter();
        DBConection con = new DBConection();
        public Boolean RemoveExpense(Datos datos)
        {
            try
            {
                con.conexion();
                _adaptor.DeleteCommand = new MySqlCommand("DELETE FROM gasto WHERE cod_gasto = "+datos.cod_gasto+";");
                _adaptor.DeleteCommand.Connection = con._conexion;
                int result = _adaptor.DeleteCommand.ExecuteNonQuery();
                if (result == 1)
                {
                    estado = true;
                }
                con.cerrar();
            }catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            return estado;
        }
    }
}

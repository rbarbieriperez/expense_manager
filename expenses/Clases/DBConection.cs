using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace gastos.Clases
{
    class DBConection
    {
        public string _cadena = "";
        public MySqlConnection _conexion;

        //Crear la conexión que nos conectará a la base de datos.

        public Boolean conexion()
        {
            //Boolean conexion();
            Boolean estado = true;
            try
            {
                _cadena = ("Server=localhost; User id= root; password=; Database= gastos;");
                _conexion = new MySqlConnection(_cadena);
                _conexion.Open();
            }
            catch (MySqlException ex)
            {

                System.Windows.Forms.MessageBox.Show(ex.Message, "Error de conexión");
                Application.Exit();
                estado = false;
            }

            return estado;
        }

        public void cerrar()
        {
            _conexion.Close();

        }

    }
}

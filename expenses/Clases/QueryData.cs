using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace gastos.Clases
{
    class QueryData
    {
         DBConection con = new DBConection();
         private Boolean estado = false;
         private string consulta;
         public DataTable Data = new DataTable();
         public List<String> Lista = new List<string>();
         public string[] userData = new string[6];
        public string[] commerceData = new string[5];
         public string usuario,nombre_comercio;
         public Boolean getExpenses()
        {
            try
            {
                con.conexion();
                consulta = "SELECT cod_gasto CODIGO,fecha FECHA,lugar LUGAR,descripcion DESCRIPCION, importe IMPORTE FROM gasto;";
                MySqlCommand cmd = new MySqlCommand(consulta, con._conexion);
                MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable();
                sda.Fill(table);
                con.cerrar();
                if (table.Rows.Count > 0)
                {
                    Data = table;
                    return estado = true;
                    
                }
                else
                {
                    return estado;
                }
                
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Error al consultar los datos");
                return estado;
            }

        }

         public Boolean getUserData()
        {
            try
            {
                con.conexion();
                consulta = "SELECT nombres NOMBRES, apellidos APELLIDOS, correo CORREO, cod_recuperacion CODIGO, foto FOTO, contrasenia CLAVE FROM user WHERE usuario='"+usuario+"'";
                MySqlCommand cmd = new MySqlCommand(consulta, con._conexion);
                MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable();
                sda.Fill(table);
                if (table.Rows.Count == 1)
                {
                    DataRow row = table.Rows[0];
                    userData[0] = (Convert.ToString(row["NOMBRES"]));
                    userData[1] = (Convert.ToString(row["APELLIDOS"]));
                    
                    if (Convert.ToString(row["CORREO"]) != string.Empty)
                    {
                        userData[2] = (Convert.ToString(row["CORREO"]));
                    }
                    if (Convert.ToString(row["CODIGO"]) != string.Empty)
                    {
                        userData[3] = Convert.ToString(row["CORREO"]);
                    }   
                    if (Convert.ToString(row["FOTO"]) != string.Empty)
                    {
                        userData[4] = (Convert.ToString(row["FOTO"]));
                    }
                    userData[5] = (Convert.ToString(row["CLAVE"]));
                    estado = true;
                }
                con.cerrar();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Error al ejecutar la consulta");
            }
            return estado;
        }

         public Boolean getComerceData()
        {
            try
            {
                con.conexion();
                consulta = "SELECT categoria CATEGORIA, direccion DIRECCION, departamento DEPARTAMENTO, contacto CONTACTO, pais PAIS FROM comercios WHERE nombre_comercio like '"+nombre_comercio+"%';";
                MySqlCommand cmd = new MySqlCommand(consulta, con._conexion);
                MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    commerceData[0] = Convert.ToString(row["CATEGORIA"]);
                    if (Convert.ToString(row["DIRECCION"]) != string.Empty)
                    {
                        commerceData[1] = Convert.ToString(row["DIRECCION"]);
                    }
                    if (Convert.ToString(row["DEPARTAMENTO"]) != string.Empty)
                    {
                        commerceData[2] = Convert.ToString(row["DEPARTAMENTO"]);
                    }
                    if (Convert.ToString(row["CONTACTO"]) != string.Empty)
                    {
                        commerceData[3] = Convert.ToString(row["CONTACTO"]);
                    }
                    if (Convert.ToString(row["PAIS"]) != string.Empty)
                    {
                        commerceData[4] = Convert.ToString(row["PAIS"]);
                    }
                    estado = true;
                }
                con.cerrar();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Error al consultar los datos");
            }
            return estado;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using gastos.Clases;
namespace gastos.Forms
{
    public partial class log_in : Form
    {
        public log_in()
        {
            InitializeComponent();
        }

        private int counter_close = 0;
        QueryData query = new QueryData();
        private void log_in_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
        }

        private void log_in_FormClosing(object sender, FormClosingEventArgs e)
        {
            //If the user do not log in we close the app.
            if (counter_close == 0)
            {
                Application.Exit();
            }
        }

        private void ingresar_btn_Click(object sender, EventArgs e)
        {
            //Function to login into the app.
            if (user_box.Text != string.Empty && password_box.Text != string.Empty)
            {
                query.usuario = user_box.Text;
                if (query.getUserData())
                {
                    if (query.userData[5] == password_box.Text)
                    {
                        counter_close = 1;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Usuario y/o contraseña incorrecta.", "Error al ingresar");
                    }
                }
                else
                {
                    MessageBox.Show("Usuario no registrado en el sistema", "Error al ingresar");
                }
            } else
            {
                MessageBox.Show("Los campos no pueden estar vacíos.","Error al ingresar");
            }
        }
    }
}

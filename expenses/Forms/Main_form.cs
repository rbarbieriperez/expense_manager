using gastos.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfSharp;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using System.IO;
using System.Threading;

namespace gastos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            //Agregamos al panel el form de agregar un gasto.-
            InsertExpenses form = new InsertExpenses() { 
                TopLevel = false , TopMost = true
            };
            if (FormContainer.Controls.Count > 0)
            {
                FormContainer.Controls.Clear();
            }
            FormContainer.Controls.Add(form);
            form.Show();
            if (FormContainer.Controls.Count > 0)
            {
                label_title.Text = "INGRESAR NUEVO GASTO";
                
            }

        }

        private void add_btn_MouseEnter(object sender, EventArgs e)
        {
            add_btn.BackColor = Color.White;
        }

        private void add_btn_MouseLeave(object sender, EventArgs e)
        {
            add_btn.BackColor = Color.Transparent;
        }

        private void ListRegistersBtn_MouseEnter(object sender, EventArgs e)
        {
            ListRegistersBtn.BackColor = Color.White;
        }

        private void ListRegistersBtn_MouseLeave(object sender, EventArgs e)
        {
            ListRegistersBtn.BackColor = Color.Transparent;
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            log_in form = new log_in();
            form.ShowDialog();
       
           
          
            AddBtnToolTip.SetToolTip(add_btn, "Agregar nuevo gasto");
            ListRegisterToolTip.SetToolTip(ListRegistersBtn, "Mostrar gastos ingresados");
            TopMenu.ForeColor = Color.White;
        }

        private void ListRegistersBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //Agregamos al panel el form de agregar un gasto.-
                ListRegisters form = new ListRegisters()
                {
                    TopLevel = false,
                    TopMost = true
                };
                if (FormContainer.Controls.Count > 0)
                {
                    FormContainer.Controls.Clear();
                }
                FormContainer.Controls.Add(form);

                if (FormContainer.Controls.Count > 0)
                {
                    label_title.Text = "VISUALIZAR REGISTROS";

                }
                form.Show();
            }
            catch (Exception ex)
            {
               // MessageBox.Show(ex.Message,"Error");
            }
           
        }

        private void cerrar_Top_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void imprimir_top_Click(object sender, EventArgs e)
        {
            PrintDialog.ShowDialog();
        }

        private void config_btn_Click(object sender, EventArgs e)
        {
            config_hub form = new config_hub()
            {
                TopLevel = false,
                TopMost = true
            };
            if (FormContainer.Controls.Count > 0)
            {
                FormContainer.Controls.Clear();
            }
            FormContainer.Controls.Add(form);
            form.Show();
            if (FormContainer.Controls.Count > 0)
            {
                label_title.Text = "CONFIGURACION DE USUARIO";

            }

        }
    }
}

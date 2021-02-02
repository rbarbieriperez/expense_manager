using gastos.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gastos.Forms
{
    public partial class InsertExpenses : Form
    {
        public InsertExpenses()
        {
            InitializeComponent();
        }
        //Declaramos las clases
        Datos datos = new Datos();
        InsertData insertar = new InsertData();
        //Función para validar los valores de los campos de texto
        private Boolean ValidateValues()
        {
            Boolean estado = true;
            try
            {
                if (fecha_picker.Value != null && lugar_box.Text != string.Empty && descripcion_box.Text != string.Empty && importe_box.Text != string.Empty)
                {
                    if (importe_box.Text.All(c => Char.IsDigit(c)) == false)
                    {
                        MessageBox.Show("El campo Importe solo admite números.","Error de tipo");
                        return false;
                    } 
                } else
                {
                    MessageBox.Show("Los campos no pueden estar vaciós", "Error");
                    return false;
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al validar los campos");
            }
            return estado;
        }
        private void ClearInputs()
        {
            lugar_box.Clear();
            descripcion_box.Clear();
            importe_box.Clear();
            fecha_picker.Focus();

        }

     
        
        private void insertar_btn_Click(object sender, EventArgs e)
        {
            try
            {

                if (ValidateValues())
                {
                    
                    datos.fecha = fecha_picker.Value.ToString("yyyy-MM-dd");
                    datos.lugar = lugar_box.Text;
                    datos.descripcion = descripcion_box.Text;
                    datos.importe = int.Parse(importe_box.Text);
                    if (insertar.InsertExpense(datos))
                    {
                        MessageBox.Show("Los datos han sido agregados correctamente");
                        ClearInputs();
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error al ingresar los datos", "Error al ingresar");
                    }
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Error de conversion de tipo");
                
            }
            
        }

        private void InsertExpenses_Load(object sender, EventArgs e)
        {
            GuardarToolTip.SetToolTip(insertar_btn, "Guardar el registro");
        }

        private void insertar_btn_MouseEnter(object sender, EventArgs e)
        {
            insertar_btn.BackColor = Color.White;
        }

        private void insertar_btn_MouseLeave(object sender, EventArgs e)
        {
            insertar_btn.BackColor = Color.Transparent;
        }
    }
}

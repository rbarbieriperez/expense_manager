using gastos.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gastos.Forms
{
    public partial class AddNewComerce : Form
    {
        public AddNewComerce()
        {
            InitializeComponent();
        }
        //Declare clases
        Datos datos = new Datos();
        InsertData insertar = new InsertData();
        QueryData query = new QueryData();
        //Global variables
        public string User;

    
        private void AddNewComerce_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
            //ToolTips
            find_tip.SetToolTip(find_btn, "Buscar comercio");
            reset_tip.SetToolTip(reset_form, "Limpiar los campos");
            agregar_tip.SetToolTip(Agregar, "Agregar el comercio");
            //Adding new Events to some controls.
            reset_form.Click += new EventHandler(reset_form_Click);
            
        }

        private Boolean ValidateContactData()
        {
            Boolean estado = true;
            try
            {
                if (contacto_box.Text.All(c => Char.IsDigit(c)) == false)
                {
                    estado = false;
                    MessageBox.Show("El campo contacto solo admite números");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("El campo contacto solo admite números");
            }
            return estado;
        }
        private Boolean CheckAllInputsNoEmpty()
        {
            Boolean estado = true;
            try
            {
                if (nombre_comercio_box.Text == string.Empty || categorias_box.SelectedItem.ToString() == string.Empty || direccion_box.Text == string.Empty || departamento_box.Text == string.Empty || pais_box.Text == string.Empty || contacto_box.Text == string.Empty )
                {
                    estado = false;
                    MessageBox.Show("Los campos no pueden estar vacíos","Error");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Los campos no pueden estar vacíos", "Error");
            }
            return estado;
        }

        private void ClearAllInputs()
        {
            nombre_comercio_box.Clear();
            categorias_box.SelectedIndex = 0;
            direccion_box.Clear();
            departamento_box.Clear();
            pais_box.Clear();
            contacto_box.Clear();
        }
        private void Agregar_Click(object sender, EventArgs e)
        {
            if (CheckAllInputsNoEmpty())
            {
                if (ValidateContactData())
                {
                    datos.user = User;
                    datos.nombre_comercio = nombre_comercio_box.Text;
                    datos.categoria = categorias_box.SelectedItem.ToString();
                    datos.direccion = direccion_box.Text;
                    datos.departamento = departamento_box.Text;
                    datos.contacto = int.Parse(contacto_box.Text);
                    datos.pais = pais_box.Text;
                    if (insertar.InsertComerce(datos))
                    {
                        MessageBox.Show("¡Comercio agregado correctamente!", "Éxito al agregar el comercio");
                        ClearAllInputs();
                        nombre_comercio_box.Focus();
                    }
                }
            }
        }
        static string FilePath;
        private void getImages(string image)
        {
            string rute = Application.StartupPath;
            rute = rute.Replace("bin", "");
            rute = rute.Replace("Debug", "");
            FilePath = rute.Remove(rute.Length - 1, 1) + image;
        }
        private void find_btn_Click(object sender, EventArgs e)
        {
            if (nombre_comercio_box.Text != string.Empty)
            {
                query.nombre_comercio = nombre_comercio_box.Text;
                if (query.getComerceData())
                {
                    MessageBox.Show("¡Comercio encontrado con éxito!", "Éxito");
                    //Turn off the nombre_comercio input
                    nombre_comercio_box.Enabled = false;
                    //Charge all data
                    categorias_box.SelectedItem = query.commerceData[0];
                    direccion_box.Text = query.commerceData[1];
                    departamento_box.Text = query.commerceData[2];
                    contacto_box.Text = query.commerceData[3];
                    pais_box.Text = query.commerceData[4];
                    //Change the button to cancel
                    getImages(@"\ProjectImages\icons8-circled-x-24.png");
                    reset_form.Image = Image.FromFile(FilePath);
                    find_panel.Controls.Remove(find_btn);
                    find_panel.Controls.Add(reset_form);
                    getImages(@"\ProjectImages\icons8-delete-64.png");
                    delete_comerce.Image = Image.FromFile(FilePath);
                    panel_delete.Controls.Add(delete_comerce);
                    //Disable button
                    Agregar.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("El campo Nombre Comercio no puede estar vacío.", "Error");
            }
        }

        private void reset_form_Click(object sender, EventArgs e)
        {
            nombre_comercio_box.Enabled = true;
            ClearAllInputs();
            find_panel.Controls.Remove(reset_form);
            find_panel.Controls.Add(find_btn);
        }

        //PictureBox to reset the form

        PictureBox reset_form = new PictureBox()
        {
            Width = 41,
            Height = 30,
            Cursor = Cursors.Hand,
            //Margin = new Padding(3, 0, 3, 6),
            Location = new Point(5, 6),
        };

        PictureBox delete_comerce = new PictureBox()
        {
            Width = 64,
            Height = 64,
            Cursor = Cursors.Hand,
        };

       
        
    }
}

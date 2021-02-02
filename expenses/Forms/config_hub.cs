using gastos.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
namespace gastos.Forms
{
    public partial class config_hub : Form
    {
        public config_hub()
        {
            InitializeComponent();
        }
        //
        //Declare clases
        //
        Datos datos = new Datos();
        QueryData query = new QueryData();
        UpdateData update = new UpdateData();

        //Change the picture of the user image when the mouse is over it.
        private void user_picture_MouseEnter(object sender, EventArgs e)
        {
            string rute = Application.StartupPath;
            rute = rute.Replace("bin", "");
            rute = rute.Replace("Debug", "");
            rute = rute.Remove(rute.Length - 1, 1);
            user_picture.Image = Image.FromFile(rute + "Images/icons8-camera-40.png");
            this.Cursor = Cursors.Hand;
        }
        
        //Update the user photo in the database calling a function of that class.
        private Boolean InsertPhoto(string photo)
        {
            Boolean estado = false;
            datos.foto = photo;
            datos.user = "rbarbieri";
            if (update.UpdateUserBase64Photo(datos))
            {
                MessageBox.Show("¡Foto actualizada correctamente!", "Éxito");
                estado = true;
            }
            return estado;
        }

        //Action of clicking the user picture to take a new from the user's PC.
        private void user_picture_Click(object sender, EventArgs e)
        {
            try
            {
                //Mostramos una imágen superpuesta sobre el contenido.-
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    string filePath = openFileDialog.FileName;
                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();
                    string base64String = "";
                    using (Image image = Image.FromFile(filePath))
                    {
                        using (MemoryStream m = new MemoryStream())
                        {
                            image.Save(m, image.RawFormat);
                            byte[] imageBytes = m.ToArray();

                            // Convert byte[] to Base64 String
                            base64String = Convert.ToBase64String(imageBytes);
                        }
                    }

                    //Insert the file into database.
                    if (InsertPhoto(base64String))
                    {
                        //Now we reload the form.

                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar la imágen", "Error");
            }
        }

        private void user_picture_MouseLeave(object sender, EventArgs e)
        {
            if (query.userData[4] != string.Empty)
            {
                ShowPhoto(); //If the User do not have a picture already, use default.
                //Note: Function ShowPhoto() does not recharge the database querys.
                this.Cursor = Cursors.Default;
            } else
            {
                string rute = Application.StartupPath;
                rute = rute.Replace("bin", "");
                rute = rute.Replace("Debug", "");
                rute = rute.Remove(rute.Length - 1, 1);
                user_picture.Image = Image.FromFile(rute + "Images/icons8-male-user-100.png");
                this.Cursor = Cursors.Default;
            }

        }

        private void config_hub_Load(object sender, EventArgs e)
        {
            query.usuario = "rbarbieri"; //We take it from the main form as owner.
            if (query.getUserData())
            {
                //Code when the form is functional.-
                ReloadForm(); //Now we charge all the things in the form.-
            }
            else
            {
                this.Close(); //We close the form because is not functional.
            }

            //Adding new Events to some controls.
            cancel_correo.Click += new EventHandler(cancel_correo_Click);
            change_correo.Click += new EventHandler(change_correo_Click);

            //Set the ToolTips of the form

            change_correo_tip.SetToolTip(change_correo, "Guardar el nuevo correo");
            cancel_correo_tip.SetToolTip(cancel_correo, "Cancelar");
            edit_correo_tip.SetToolTip(edit_correo_btn, "Cambiar el correo electrónico");
        }

        private void ReloadForm()
        {
            //Reload all data in the form.
            //Make sure that photo is not empty in the SQL query.-
            //If it's, verify that the app does not show up a error message in the function ShowPhoto().
            user_name.Text = query.userData[0] + " " + query.userData[1];
            correo_lbl.Text = query.userData[2];
            user_label.Text = query.usuario;
            ShowPhoto();

        }
        private void ShowPhoto()
        {
            try
            {
                string PhotoBase64 = query.userData[4];
                MessageBox.Show(PhotoBase64);
                byte[] bytes = Convert.FromBase64String(PhotoBase64);

                using (MemoryStream ms = new MemoryStream(bytes))
                {
                    user_picture.Image = Image.FromStream(ms);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void edit_correo_btn_Click(object sender, EventArgs e)
        {
            correo_panel.Controls.Remove(correo_lbl);
            correo_panel.Controls.Remove(edit_correo_btn);
            correo_panel.Controls.Add(change_correo_box);
            getImages(@"ProjectImages\icons8-instagram-check-mark-24.png");
            change_correo.Image = Image.FromFile(FilePath);
            correo_panel.Controls.Add(change_correo);
            getImages(@"ProjectImages\icons8-circled-x-24.png");
            cancel_correo.Image = Image.FromFile(FilePath);
            correo_panel.Controls.Add(cancel_correo);

        }

        private void cancel_correo_Click(object sender, EventArgs e)
        {
            CancelCorreo();
        }
        private void CancelCorreo()
        {
            correo_panel.Controls.Remove(change_correo_box);
            correo_panel.Controls.Remove(change_correo);
            correo_panel.Controls.Remove(cancel_correo);
            correo_panel.Controls.Add(correo_lbl);
            correo_panel.Controls.Add(edit_correo_btn);
        }

        //Load the form. With full new data from zero. 
        private void FreshFormLoad()
        {
            query.usuario = user_label.Text;
            if (query.getUserData())
            {
                ReloadForm();
                ShowPhoto();
            }
        }
        //Missing email validation.
        private void change_correo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cambiar el correo electrónico?","Cambiar correo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (change_correo_box.Text != "")
                {
                    datos.correo = change_correo_box.Text;
                    datos.user = user_label.Text;
                    if (update.UpdateUserEmail(datos))
                    {
                        MessageBox.Show("¡Correo actualizado con éxito!", "Correo actualizado");
                        CancelCorreo();
                        FreshFormLoad();
                    }
                }
                else
                {
                    MessageBox.Show("El campo correo no puede estar vacío", "Error al ingresar el correo");
                }
            }
            
        }

        //Variables
        private static string FilePath = "";
        //Functions

        //Get the startupPath of the application to get the system images.
        private void getImages(string image)
        {
            string rute = Application.StartupPath;
            rute = rute.Replace("bin", "");
            rute = rute.Replace("Debug", "");
            FilePath = rute.Remove(rute.Length - 1, 1) + image;
        }


        //Make new Controls.
        TextBox change_correo_box = new TextBox()
        {
            Width = 130,
            Height = 38,
            Visible = true,
            Font = new Font("Arial", 12),


        };
        PictureBox change_correo = new PictureBox()
        {
            Width = 24,
            Height = 24,
            Visible = true,
            Margin = new Padding(0, 4, 4, 0),
            Cursor = Cursors.Hand,
       
    };
        PictureBox cancel_correo = new PictureBox()
        {
            Width = 24,
            Height = 24,
            Visible = true,
            Margin = new Padding(0, 4, 0, 0),
            Cursor = Cursors.Hand,
            
        };

        

        private void agregar_comercios_btn_Click(object sender, EventArgs e)
        {
            AddNewComerce form = new AddNewComerce();
            form.Owner = this;
            form.User = user_label.Text;
            form.ShowDialog();
            
        }
    }
}

using gastos.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gastos.Forms
{
    public partial class ListRegisters : Form
    {
        public ListRegisters()
        {
            InitializeComponent();
        }
        QueryData query = new QueryData();
        Datos datos = new Datos();
        UpdateData update = new UpdateData();
        DeleteData delete = new DeleteData();
        private void ListRegisters_Load(object sender, EventArgs e)
        {
            LoadGridData();
            DisableAllInputs();
            ResizeGrid();
            deleteToolTip.SetToolTip(delete_btn, "Borrar este registro.");
            saveToolTip.SetToolTip(save_btn, "Modificar este registro.");
        }
        private void ResizeGrid()
        {
            if (RegistersGrid.Rows.Count != 0)
            {
                RegistersGrid.Columns[0].Width = 60;
                RegistersGrid.Columns[1].Width = 60;
                RegistersGrid.Columns[2].Width = 100;
                RegistersGrid.Columns[3].Width = 388;
                RegistersGrid.Columns[4].Width = 70;

            }
        }
        BindingSource bds = new BindingSource();
        private void LoadGridData()
        {
           
            if (query.getExpenses())
            {
                
                bds.DataSource = query.Data;
                RegistersGrid.DataSource = bds;
                int value = 0;
                for (int i = 0; i < RegistersGrid.Rows.Count; i++)
                {
                    value += Convert.ToInt32(RegistersGrid.Rows[i].Cells[4].Value.ToString());
                }
                
                
                total_gastado_lbl.Text = value.ToString() + " " + "UYU";
            } else
            {
                MessageBox.Show("No hay registros para mostrar", "Alerta");
                this.Close();
            }
        }
        private int SelectedCell;
        private void RegistersGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Marcamos toda la celda
            SelectedCell = e.RowIndex;

            foreach (DataGridViewRow row in RegistersGrid.Rows)
            {
                if (row.Index == SelectedCell)
                {
                    row.Selected = true;
                }
            }
            //Procedemos a mostrar los datos abajo.

            if (RegistersGrid.SelectedRows.Count == 1)
            {
                datos.cod_gasto = int.Parse(RegistersGrid.Rows[SelectedCell].Cells[0].Value.ToString());
                monto_box.Text = RegistersGrid.Rows[SelectedCell].Cells[4].Value.ToString();
                fecha_box.Text = RegistersGrid.Rows[SelectedCell].Cells[1].Value.ToString();
                lugar_box.Text = RegistersGrid.Rows[SelectedCell].Cells[2].Value.ToString();
                descripcion_box.Text = RegistersGrid.Rows[SelectedCell].Cells[3].Value.ToString() ;
                EnableAllInputs();
            }
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            if (CheckIfIsDifferentData())
            {
                if (MessageBox.Show("¿Desea modificar los datos?", "Modificar los datos", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (ValidateValues())
                    {
                        var fecha = DateTime.Parse(fecha_box.Text);
                        datos.fecha = fecha.ToString("yyyy-MM-dd");
                        datos.lugar = lugar_box.Text;
                        datos.importe = int.Parse(monto_box.Text);
                        datos.descripcion = descripcion_box.Text;
                        if (update.UpdateExpense(datos))
                        {
                            MessageBox.Show("¡Datos actualizados correctamente!", "Éxito");
                            ClearInputs();
                            DisableAllInputs();
                            LoadGridData();
                        }
                    }
                }
            }
           
            
        }
        private Boolean CheckIfIsDifferentData()
        {
            Boolean estado = false;
            if (RegistersGrid.Rows[SelectedCell].Cells[4].Value.ToString() == monto_box.Text && RegistersGrid.Rows[SelectedCell].Cells[1].Value.ToString() == fecha_box.Text && RegistersGrid.Rows[SelectedCell].Cells[2].Value.ToString() == lugar_box.Text && RegistersGrid.Rows[SelectedCell].Cells[3].Value.ToString() == descripcion_box.Text)
            {
                MessageBox.Show("No hay cambios en los datos ha ingresar","Error");
            }
            else
            {
                estado = true;
            }
            return estado;
        }
        private Boolean ValidateValues()
        {
            Boolean estado = true;
            try
            {
                if (fecha_box.Text != string.Empty && descripcion_box.Text != string.Empty && lugar_box.Text != string.Empty)
                {
                    if (monto_box.Text.All(c => Char.IsDigit(c)) == false)
                    {
                        MessageBox.Show("El campo Importe solo admite números.", "Error de tipo");
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Los campos no pueden estar vaciós", "Error");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al validar los campos");
            }
            return estado;
        }
        private void ClearInputs()
        {
            monto_box.Clear();
            lugar_box.Clear();
            fecha_box.Clear();
            descripcion_box.Clear();
        }
        private void DisableAllInputs()
        {
            monto_box.Enabled = false;
            fecha_box.Enabled = false;
            lugar_box.Enabled = false;
            descripcion_box.Enabled = false;
            save_btn.Enabled = false;
            delete_btn.Enabled = false;
        }
        private void EnableAllInputs()
        {
            monto_box.Enabled = true;
            fecha_box.Enabled = true;
            lugar_box.Enabled = true;
            descripcion_box.Enabled = true;
            save_btn.Enabled = true;
            delete_btn.Enabled = true;
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Realmente desea eliminar los datos?", "Eliminar los datos", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (delete.RemoveExpense(datos))
                {
                    if (RegistersGrid.Rows.Count == 1)
                    {
                        MessageBox.Show("¡Registro eliminado correctamente!", "Eliminar los datos");
                        this.Close();
                        
                    }
                    else
                    {

                        MessageBox.Show("¡Registro eliminado correctamente!", "Eliminar los datos");
                        ClearInputs();
                        DisableAllInputs();
                        LoadGridData();
                    }

                }
                else
                {
                    MessageBox.Show("No se han podido eliminar los datos","Error al eliminar los datos");
                }
            }
        }
    }
}

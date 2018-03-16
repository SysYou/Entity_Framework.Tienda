using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace wfa.Tienda.UI
{
    public partial class Form1 : Form
    {

        #region Atributos
        private cl.Tienda.DAL.Ropa ropa;
        #endregion

        public Form1()
        {
            InitializeComponent();
        }



        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        //Verifica si hay campos vacios en el formulario
        private int GetNulos()
        {

            int contador = 0;
            if (txtNombre.Text.Length == 0 ||
                cmbCategoria.Text.Length == 0 ||
                cmbGenero.Text.Length == 0 
                )
            {
                contador++;
                MessageBox.Show("Faltan Datos por Ingresar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return contador;

            }
            else
            {

                return contador;
            }


        }


        //Get de valores en el formulario

      


        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                cargarPersona(true);
                cl.Tienda.BL.Mantenimiento.Instancia.Insertar(ropa);
                mostrarGrid();
            }
            catch (Exception ee)
            {

                throw;
            }




        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            mostrarGrid();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                cargarPersona(false);
                cl.Tienda.BL.Mantenimiento.Instancia.Eliminar(ropa);
                mostrarGrid();
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            try
            {
                cargarPersona(false);
                cl.Tienda.BL.Mantenimiento.Instancia.Actualizar(ropa);
                mostrarGrid();
            }
            catch (Exception ee)
            {

                throw;
            }
        }


        //Llena los campos del formulario con la fila seleccionada en el Datagrid.
        private void dgvCompras_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvCompras.SelectedRows)
            {
                int value1 = Convert.ToInt32(row.Cells[0].Value.ToString());
                string value2 = row.Cells[1].Value.ToString();
                int value3 = Convert.ToInt32(row.Cells[2].Value.ToString());
                string value4 = row.Cells[3].Value.ToString();
                decimal value5 = Convert.ToDecimal(row.Cells[4].Value.ToString());
                Boolean value6 = Convert.ToBoolean(row.Cells[5].Value.ToString());


                nUDId.Value = value1;
                txtNombre.Text = value2;
                cmbGenero.SelectedIndex = value3;
                cmbCategoria.Text = value4;
                nudValor.Value = value5;
                cbDisponible.Checked = value6;
            }

            
        }

        #region Metodos

        /*private void GetValues()
        {

            ropa = new cl.Tienda.DAL.Ropa

            {
                Id = Convert.ToInt32(nUDId.Value),
                Nombre = txtNombre.Text,
                Genero = Convert.ToInt32(cmbGenero.SelectedValue),
                Categoria = cmbCategoria.Text,
                Valor = Convert.ToInt32(nudValor.Value),
                Disponible = cbDisponible.Checked,


            };



        }*/


        private void cargarPersona(bool esInsertar)
        {
            ropa = new cl.Tienda.DAL.Ropa();

            ropa.iId = (esInsertar ? 0 : Convert.ToInt32(nUDId.Value));
            ropa.vNombre = txtNombre.Text;
            ropa.iGenero = Convert.ToInt32(cmbGenero.SelectedIndex);
            ropa.vCategoria = cmbCategoria.Text;
            ropa.dValor = Convert.ToInt32(nudValor.Value);
            ropa.bDisponible = cbDisponible.Checked;
        }

        private void mostrarGrid()
        {
            try
            {
                dgvCompras.DataSource = cl.Tienda.BL.Mantenimiento.Instancia.Mostrar();
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        #endregion

    }
}

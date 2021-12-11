using ClassClinica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsClinica
{
    public partial class FormMedicos : Form
    {
        public FormMedicos()
        {
            InitializeComponent();
        }
        private void refresh()
        {
            dataGridView2.DataSource = null;
            var datos = Medicos.listMedicos();
            dataGridView2.DataSource = datos;

        }
        /// <summary>
        /// Metodo para ingresar nuevos medicos siempre que todos sus campos esten llenados correspondientemente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnAgregarMedicos_Click(object sender, EventArgs e)
        {
            if (textNombreM.Text != String.Empty &&
               textApellidoM.Text != String.Empty && !comboEspecialM.SelectedIndex.Equals(-1))
            {

                int id = 0;
                string nombre = textNombreM.Text;
                string apellido = textApellidoM.Text;


                int indicecmb = comboEspecialM.SelectedIndex;
                var especialidad = comboEspecialM.Items[indicecmb].ToString();

                Medicos.agregar(id, nombre, apellido, especialidad);
                textNombreM.Text = null;
                textApellidoM.Text = null;
              
                refresh();
            }
            else
            {
                _ = MessageBox.Show("Por favor complete todo los campos", "Medicos", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            refresh();
        }
        /// <summary>
        /// Se cargaran lo medicos harcodeados 1 sola vez al iniciar la aplicacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMedicos_Load(object sender, EventArgs e)
        {
           
            refresh();
        }

        /// <summary>
        /// Metodo para no poder editar el combox de Especialidades medicas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboEspecialM_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassClinica;
namespace FormsClinica
{
    public partial class FormPacientes : Form
    {
       
        
        public FormPacientes()
        {
            InitializeComponent();

         

        }


        /// <summary>
        /// Recarga el datagridview
        /// </summary>

        private void refresh()
        {
            dataGridView1.DataSource = null;
            var datos = Pacientes.listPaciente();
            dataGridView1.DataSource = datos;

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refresh();
           
        }

        /// <summary>
        /// Metodo para ingresar nuevos Pacientes siempre que todos sus campos esten llenados correctamente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
          
           
            if (textNombre.Text != String.Empty &&
                textApellido.Text != String.Empty && textEdad.Text != string.Empty
                && textDni.Text != string.Empty && !cmbObraSocial.SelectedIndex.Equals(-1))
            {

                int id = 0;
                string nombre = textNombre.Text;
                string apellido = textApellido.Text;
                int edad = int.Parse(textEdad.Text);
                string dni = textDni.Text;

                int indicecmb = cmbObraSocial.SelectedIndex;
                var obra = cmbObraSocial.Items[indicecmb].ToString();

                Pacientes.agregar(id, nombre, apellido, edad, dni, obra);

                textNombre.Text = null;
                textApellido.Text = null;
               
                textEdad.Text = null;
                textDni.Text = null;
                refresh();
                
            }
            else
            {
                _ = MessageBox.Show("Por favor complete todo los campos", "Pacientes", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK;
            }

        }

        private void FormPacientes_Load(object sender, EventArgs e)
        { 
             
              refresh();

        }

        private void cmbObraSocial_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;

        }
    }
}

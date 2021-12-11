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
    public partial class FormConsultas : Form
    {
        private static string nombrePaciente = "";
        private static string apellidoPaciente = "";
        private static string dniPaciente = "";
        public FormConsultas()
        {
            InitializeComponent();
        }

        public void actualizar()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Consultas.listaConsulta();
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = Pacientes.listaEspera1;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            actualizar();
        }

        public void AsignacionCorrecta(int resultado)
        {
            if (resultado.Equals(1))
            {
                _ = MessageBox.Show("El paciente de la lista de espera\nse asigno correctamente a la consulta", "Consulta", MessageBoxButtons.OK) == DialogResult.OK;
            }
            else if (resultado.Equals(0))
            {
                _ = MessageBox.Show("El consultorio quedo disponible, \npor favor asigne un nuevo paciente", "Consultas", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK;

            }
           
        }

        public void resultadoVaciarConsulta(int indice)
        {
            int mensaje = Consultas.vaciarConsulta(indice);
            if (mensaje == 1)
            {
                string nombreCompleto = nombrePaciente + " " + apellidoPaciente;
                _ = MessageBox.Show("Se finalizo la consulta", "Consultas", MessageBoxButtons.OK) == DialogResult.OK;

                var lista = Pacientes.listaEspera1;
                switch (indice)
                {
                    case 0:
                        lista = Pacientes.listaEspera1;
                        break;
                    case 1:
                        lista = Pacientes.listaEspera2;
                        break;
                    case 2:
                        lista = Pacientes.listaEspera3;
                        break;
                    case 3:
                        lista = Pacientes.listaEspera4;
                        break;
                    case 4:
                        lista = Pacientes.listaEspera5;
                        break;
                }

                ResultadoConsulta();


                        if (!(lista.Count() == 0))
                {
                    int resultado = Consultas.LlenarConsulta(1, nombreCompleto, "Exon Cabral", "Cardiologia", 0);
                    Pacientes.eliminarPacienteListaEspera(dniPaciente, indice + 1);
                    AsignacionCorrecta(resultado);
                }
            }
            else
            {
                _ = MessageBox.Show("El consultorio no tiene pacientes atendiendo", "Consultas", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK;
            }
            actualizar();
        }

        private void ResultadoConsulta()
        {
            Random random = new Random();
            int a= random.Next(1, 5);

            switch (a)
            {
                case 1:
                    _ = MessageBox.Show("El paciente requiere de una derivacion \na traumatologia", "Fin de la consulta", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK;
                    break;
                case 2:
                    _ = MessageBox.Show("El paciente debe realizar estudios de: \nRadiografia\nT.A.C Cerebral\nSangre", "Fin de la consulta", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK;
                    break;
                case 3:
                    _ = MessageBox.Show("El paciente requiere de una Internacion \nde 2 dias a partir del dia de la fecha", "Fin de la consulta", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK;
                    break;
                case 4:
                    _ = MessageBox.Show("El paciente requiere cirugia \n", "Fin de la consulta", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK;
                    break;
                case 5:
                    _ = MessageBox.Show("El paciente requiere de un tratamiento \nde 15 dias de duracion", "Fin de la consulta", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK;
                    break;
                
            }

        }

        private void btnEliminarConslta_Click(object sender, EventArgs e)
        {
            resultadoVaciarConsulta(0);
           
        }

        private void btnEliminarConsulta2_Click(object sender, EventArgs e)
        {
            resultadoVaciarConsulta(1);
        }

        private void btnEliminarConsulta3_Click(object sender, EventArgs e)
        {

            resultadoVaciarConsulta(2);
        }

        private void btnEliminarConsulta4_Click(object sender, EventArgs e)
        {
            resultadoVaciarConsulta(3);
        }

        private void btnEliminarConsulta5_Click(object sender, EventArgs e)
        {
            resultadoVaciarConsulta(4);
        }

        private void FormConsultas_Load(object sender, EventArgs e)
        {
            
            actualizar();
            if(dataGridView1.Rows.Count == 0)
            {
                _ = MessageBox.Show("No se cargo correctamente la base de datos.\nPor favor reinicie el programa e intentelo de nuevo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop) == DialogResult.OK;
                if (MessageBox.Show("Cerrar la aplicacion?", "Advertencia", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                apellidoPaciente = dataGridView2.Rows[e.RowIndex].Cells["Apellido"].Value.ToString();
                nombrePaciente = dataGridView2.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                dniPaciente = dataGridView2.Rows[e.RowIndex].Cells["Dni"].Value.ToString();
            }
            catch (Exception ex)
            {

                _ = MessageBox.Show("No puede seleccionar una columna, Por favor seleccione una fila", "Consultas", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK;
            }
        }

        private void dataGridView3_Click(object sender, EventArgs e)
        {
            MensajeSala();
        }
        private void MensajeSala()
        {
            _ = MessageBox.Show("La sala se encuentra fuera de uso", "Sala de espera", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK;
        }

        private void dataGridView4_Click(object sender, EventArgs e)
        {
            MensajeSala();
        }

        private void dataGridView5_Click(object sender, EventArgs e)
        {
            MensajeSala();
        }

        private void dataGridView6_Click(object sender, EventArgs e)
        {
            MensajeSala();
        }
    }
}

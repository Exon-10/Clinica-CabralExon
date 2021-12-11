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
    public partial class FormLlenarConsultas : Form
    {
        private static string nombrePaciente="";
        private static string apellidoPaciente="";
        private static string dniPaciente="";
       



        public FormLlenarConsultas()
        {
            
        InitializeComponent();
        }
        public void refresh()
        {
            dataConsultasP.DataSource = null;
            var datosP = Pacientes.listPaciente();
            dataConsultasP.DataSource = datosP;
        }

        private void btnActualizarC_Click(object sender, EventArgs e)
        {
            refresh();

        }
        /// <summary>
        /// Metodo para llenar las listas con los datos harcodeados anteriormente
        /// solo se cargaran una vez al iniciar la applicacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormLlenarConsultas_Load_1(object sender, EventArgs e)
        {
            refresh();
            
        }

        /// <summary>
        /// Metodo para poder seleccionar una fila del datagridview y utilizar sus datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataConsultasP_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                apellidoPaciente = dataConsultasP.Rows[e.RowIndex].Cells["Apellido"].Value.ToString();
                nombrePaciente = dataConsultasP.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                dniPaciente = dataConsultasP.Rows[e.RowIndex].Cells["Dni"].Value.ToString();
            }
            catch(Exception ex)
            {
                
                _ = MessageBox.Show("No puede seleccionar una columna, Por favor seleccione una fila", "Consultas", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK;
            }
            btnConsultorio1.Enabled = true;
            btnConsultorio2.Enabled = true;
            btnConsultorio3.Enabled = true;
            btnConsultorio4.Enabled = true;
            btnConsultorio5.Enabled = true;

        }

       public void AsignacionCorrecta(int resultado)
        {
            if (resultado.Equals(1))
            {
                _ = MessageBox.Show("Se asigno correctamente a la consulta", "Consulta", MessageBoxButtons.OK) == DialogResult.OK;
            }
            else if(resultado.Equals(0))
            {
                _ = MessageBox.Show("El consultorio esta ocupado.\nSe le asignara a una lista de espera", "Consultorio Ocupado", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK;
               
            }
            else
            {
                _ = MessageBox.Show("No se cargo correctamente la base de datos.\nPor favor reinicie el programa e intentelo de nuevo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop) == DialogResult.OK;
                if (MessageBox.Show("Cerrar la aplicacion?", "Advertencia", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombreCompleto = nombrePaciente + " " + apellidoPaciente;
            int resultado = Consultas.LlenarConsulta(1, nombreCompleto, "Exon Cabral", "Cardiologia", 0);
            AsignacionCorrecta(resultado);
            Pacientes.eliminarPaciente(dniPaciente,1);
            
          
            refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           string nombreCompleto = nombrePaciente + " " + apellidoPaciente;
           int resultado=Consultas.LlenarConsulta(2,nombreCompleto, "Jose Gomez", "Odontologia", 1);
           AsignacionCorrecta(resultado);
           Pacientes.eliminarPaciente(dniPaciente,2);
           refresh();
        }
        private void btnConsultorio3_Click(object sender, EventArgs e)
        {
            string nombreCompleto = nombrePaciente + " " + apellidoPaciente;
            int resultado= Consultas.LlenarConsulta(3, nombreCompleto, "Monica Guitierrez", "Pediatria", 2);
            AsignacionCorrecta(resultado);
            Pacientes.eliminarPaciente(dniPaciente,3);
            refresh();
        }

        private void btnConsultorio4_Click(object sender, EventArgs e)
        {
            string nombreCompleto = nombrePaciente + " " + apellidoPaciente;
            int resultado=Consultas.LlenarConsulta(4, nombreCompleto, "Carolina Robles", "Ginecologia", 3);
            AsignacionCorrecta(resultado);
            Pacientes.eliminarPaciente(dniPaciente,4);
            refresh();
        }

        private void btnConsultorio5_Click(object sender, EventArgs e)
        {
            string nombreCompleto = nombrePaciente + " " + apellidoPaciente;
            int resultado=Consultas.LlenarConsulta(5, nombreCompleto, "Marcos Ortega", "Dermatologia", 4);
            AsignacionCorrecta(resultado);
            Pacientes.eliminarPaciente(dniPaciente,5);
            refresh();
        }


    }
}

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
using System.Runtime.InteropServices;

namespace FormsClinica
{
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();

            Pacientes.agregar(1, "Exon", "Cabral", 18, "23434932", "No");
            Pacientes.agregar(2, "Jose", "Gomez", 22, "35452323", "Completa");
            Pacientes.agregar(3, "Monica", "Guitierrez", 32, "42453323", "Completa");
            Pacientes.agregar(4, "Ezequiel", "Pedraza", 12, "55542322", "Baisca");
            Pacientes.agregar(5, "Ramon", "Cortez", 54, "23454523", "Basica");
            Pacientes.agregar(6, "Josefiina", "Ocampo", 62, "65452565", "No");
            Pacientes.agregar(7, "Esteban", "Perez", 40, "2345233", "Completa");
            Pacientes.agregar(8, "Carolina", "Robles", 64, "25452709", "Completa");
            Pacientes.agregar(9, "Marcos", "Ortega", 66, "14352754", "No");
            Pacientes.agregar(10, "Roberto", "Molina", 36, "36452756", "Basica");

           

            Medicos.agregar(1, "Exon", "Cabral", "Cardiologia");
            Medicos.agregar(2, "Jose", "Gomez", "Odontologia");
            Medicos.agregar(3, "Monica", "Guitierrez", "Pediatria");
            Medicos.agregar(4, "Ezequiel", "Pedraza", "Oncología");
            Medicos.agregar(5, "Ramon", "Cortez", "Endocrinología");
            Medicos.agregar(6, "Josefiina", "Ocampo", "Gastroenterología");
            Medicos.agregar(7, "Esteban", "Perez", "Endocrinología");
            Medicos.agregar(8, "Carolina", "Robles", "Ginecología");
            Medicos.agregar(9, "Marcos", "Ortega", "Dermatologia");
            Medicos.agregar(10, "Monica", "Molina", "Ginecología");

            Consultas.cargar(1, "", "Cabral Exon", "Cardiologia");
            Consultas.cargar(2, "", "Gomez Jose", "Odontologia");
            Consultas.cargar(3, "", "Gutierrez Monica", "Pediatria");
            Consultas.cargar(4, "", "Robles Carolina", "Ginecologia");
            Consultas.cargar(5, "", "Ortega Marcos", "Dermatologia");
        }


        /// <summary>
        /// Bloque de codigo para poder mover la ventana desde la parte superior por todo el display de la pc
        /// </summary>
        /// 
        //----------------------------------------------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]

        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //----------------------------------------------------------------------------------------



        /// <summary>
        /// Metodo utilizado para poder cambiar de formularios dentro de un panel prinsipal
        /// </summary>
        /// <param name="formpacientes"></param>
        private void AbrirFormEnPanel(object formpacientes)
        {
            if (this.panel1.Controls.Count > 0) 
                this.panel1.Controls.RemoveAt(0);
            Form fp = formpacientes as Form;
            fp.TopLevel = false;
            fp.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(fp);
            this.panel1.Tag = fp;
            fp.Show();   
        }

        //------------------------------------------------------------------

       
        
        private void btnMenuConsultas_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormLlenarConsultas());
           
        }
      
           
        
        private void btnMenuMedicos_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormMedicos());
        }

        private void btnMenuInicio_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormInicio());
        }

        private void btnMenuPacientes_Click_1(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormPacientes());
        }

        private void btnMenuConsultas1_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormConsultas());
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            cerrarApp();
        }
        public void cerrarApp()
        {
            
            if (MessageBox.Show("Desea cerrar la aplicacion?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormInicio());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
               WindowState= FormWindowState.Minimized;
            }
            else if (WindowState == FormWindowState.Minimized)
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cerrarApp();
        }

        private void btnMenuEstadisticas_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormEstadisticas());
        }
    }
}

       

       

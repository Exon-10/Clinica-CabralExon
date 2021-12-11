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
    public partial class FormEstadisticas : Form
    {
        public FormEstadisticas()
        {
            InitializeComponent();
        }

        private void FormEstadisticas_Load(object sender, EventArgs e)
        {
           
                int medico1 = 4 * (Pacientes.listaEspera1.Count());
                button1.Size = new System.Drawing.Size(15, medico1);
                int medico2 = 4 * (Pacientes.listaEspera2.Count());
                button2.Size = new System.Drawing.Size(15, medico2);
                int medico3 = 4 * (Pacientes.listaEspera3.Count());
                button3.Size = new System.Drawing.Size(15, medico3);
                int medico4 = 4 * (Pacientes.listaEspera4.Count());
                button4.Size = new System.Drawing.Size(15, medico4);
                int medico5 = 4 * (Pacientes.listaEspera5.Count());
                button5.Size = new System.Drawing.Size(15, medico5);



        }
    }
}

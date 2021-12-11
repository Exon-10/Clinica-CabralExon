using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassClinica
{
    public class Consultas
    {
        private int consultorio;
        private string paciente;
        private string medico;
        private string especialidad;
        
        public static List<Consultas> Consulta1 = new();
        
        public Consultas(int consultorio, string paciente, string medico, string especialidad)
        {
            this.consultorio = consultorio;
            this.paciente = paciente;
            this.medico = medico;
            this.especialidad = especialidad;
            }
        public int Consultorio
        {
            get { return consultorio; }
            set { consultorio = value; }
        }
        public string Paciente
        {
            get { return paciente; }
            set { paciente = value; }
        }
        public string Medico
        {
            get { return medico ; }
            set { medico = value; }
        }
        public string Especialidad
        {
            get { return especialidad; }
            set { especialidad = value; }
        }

        public static object listaConsultas { get; private set; }


        /// <summary>
        /// Metodo para agregar instancias de consultas a una lista 
        /// se ingreso manualmente con los atribuidos vacios para ser asignados con los valores correspondientes
        /// </summary>
        public static void cargar(int consultorio, string paciente, string medico, string especialidad)
        {
            Consulta1.Add(new Consultas(consultorio, paciente, medico, especialidad));
           
        }
        /// <summary>
        /// Retorna la lista consulta1
        /// </summary>
        /// <returns></returns>
        public static object listaConsulta()
        {
            return Consulta1;
        }

        /// <summary>
        /// Metodo para llenar una consulta, si la consulta en la posicion dada con el atributo paciente esta vacio se
        /// asignara un nuevo paciente y se retornara un 1 que sera utilizado para mostrar un mensaje de que la 
        /// operacion se realizo con exito, de lo contrario mostrara un error
        /// </summary>
        /// <param name="consultorio"></param>
        /// <param name="paciente"></param>
        /// <param name="medico"></param>
        /// <param name="especialidad"></param>
        /// <param name="posicion"></param>
        /// <returns></returns>
        public static int LlenarConsulta(int consultorio, string paciente, string medico, string especialidad, int posicion)
        {
            try
            {
                if (Consulta1[posicion].paciente.Equals(""))
                {
                    Consulta1[posicion] = new Consultas(consultorio, paciente, medico, especialidad);
                    return 1;
                }

                else
                {
                    return 0;
                }
            }
            catch (Exception ex)
            {
                return 2;
            }

        }
        public static int vaciarConsulta(int indice)
        {
            if (Consulta1[indice].paciente == "")
            {
                return 0;
            }

            else
            {
                Consulta1[indice].paciente = "";
                return 1;
                
            }
        }

    }
}

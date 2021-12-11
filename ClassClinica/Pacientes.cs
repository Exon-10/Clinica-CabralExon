using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassClinica
{
    public class Pacientes : Persona
    {
        private int edad;
        private string dni;
        private string obraSocial;
        static List<Pacientes> Paciente = new();
        public static List<Pacientes> listaEspera1 = new();
        public static List<Pacientes> listaEspera2 = new();
        public static List<Pacientes> listaEspera3 = new();
        public static List<Pacientes> listaEspera4 = new();
        public static List<Pacientes> listaEspera5 = new();
        static int con1 = 0, con2 = 0, con3 = 0, con4 = 0, con5 = 0;

        public Pacientes(int id, String nombre, string apellido, int edad, string dni, string obraSocial) : base(id, nombre, apellido)
        {
            this.edad = edad;
            this.dni = dni;
            this.obraSocial = obraSocial;
        }

        public int Id
        {
            get { return setId(); }

        }
        public string Nombre
        {
            get { return setNombre(); }

        }
        public string Apellido
        {
            get { return setApellido(); }

        }
        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }
        public string DNI
        {
            get { return dni; }
            set { dni = value; }
        }
        public string ObraSocial
        {
            get { return obraSocial; }
            set { obraSocial = value; }
        }

        public static void RefreshId(List<Pacientes> Paci)
        {
            for (int i = 0; i < Paci.Count; i++)
            {
                Paci[i].id = i + 1;
            }
        }


        public static void eliminarPaciente(string dni, int consultorio)
        {


            for (int i = 0; i < Paciente.Count; i++)
            {
                if (Paciente[i].dni.Equals(dni))
                {

                    int indice = Paciente.IndexOf(Paciente[i]);

                    switch (consultorio)
                    {
                        case 1:
                            con1++;
                            if (con1 > 1)
                            {
                                listaEspera(indice, consultorio);
                            }
                            break;
                        case 2:
                            con2++;
                            if (con2 > 1)
                            {
                                listaEspera(indice, consultorio);
                            }
                            break;
                        case 3:
                            con3++;
                            if (con3 > 1)
                            {
                                listaEspera(indice, consultorio);
                            }
                            break;
                        case 4:
                            con4++;
                            if (con4 > 1)
                            {
                                listaEspera(indice, consultorio);
                            }
                            break;
                        case 5:
                            con5++;
                            if (con5 > 1)
                            {
                                listaEspera(indice, consultorio);
                            }
                            break;
                    }




                    Paciente.RemoveAt(indice);
                    RefreshId(Paciente);
                }
            }
        }
        public static void listaEspera(int indice, int consultorio)
        {
            switch (consultorio)
            {
                case 1:
                    listaEspera1.Add(new Pacientes(Paciente[indice].Id, Paciente[indice].Nombre, Paciente[indice].Apellido, Paciente[indice].edad, Paciente[indice].dni, Paciente[indice].obraSocial));
                    RefreshId(listaEspera1);
                    break;
                case 2:
                    listaEspera2.Add(new Pacientes(Paciente[indice].Id, Paciente[indice].Nombre, Paciente[indice].Apellido, Paciente[indice].edad, Paciente[indice].dni, Paciente[indice].obraSocial));
                    RefreshId(listaEspera2);
                    break;
                case 3:
                    listaEspera3.Add(new Pacientes(Paciente[indice].Id, Paciente[indice].Nombre, Paciente[indice].Apellido, Paciente[indice].edad, Paciente[indice].dni, Paciente[indice].obraSocial));
                    RefreshId(listaEspera3);
                    break;
                case 4:
                    listaEspera4.Add(new Pacientes(Paciente[indice].Id, Paciente[indice].Nombre, Paciente[indice].Apellido, Paciente[indice].edad, Paciente[indice].dni, Paciente[indice].obraSocial));
                    RefreshId(listaEspera4);
                    break;
                case 5:
                    listaEspera5.Add(new Pacientes(Paciente[indice].Id, Paciente[indice].Nombre, Paciente[indice].Apellido, Paciente[indice].edad, Paciente[indice].dni, Paciente[indice].obraSocial));
                    RefreshId(listaEspera5);
                    break;
            }
        }

        public static void eliminarPacienteListaEspera(string dni, int consultorio)
        {

            var lista = listaEspera1;
            switch (consultorio)
            {
                case 1:
                    lista = listaEspera1;
                    break;
                case 2:
                    lista = listaEspera2;
                    break;
                case 3:
                    lista = listaEspera3;
                    break;
                case 4:
                    lista = listaEspera4;
                    break;
                case 5:
                    lista = listaEspera5;
                    break;
            }


            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].dni.Equals(dni))
                {

                    int indice = lista.IndexOf(lista[i]);



                    lista.RemoveAt(indice);
                   
                }
            }
        }


        /// <summary>
        /// Retorna la lista Paciente Para poder ser usada por el datagridview
        /// </summary>
        /// <returns></returns>

        public static object listPaciente()
        {
            return Paciente;
        }

        /// <summary>
        /// Metodo para agregar una nueva instancia de Pacientes a la lista Paciente
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="edad"></param>
        /// <param name="dni"></param>
        /// <param name="obraSocial"></param>
        public static void agregar(int id, String nombre, string apellido, int edad, string dni, string obraSocial)
        {
            Paciente.Add(new Pacientes(id, nombre, apellido, edad, dni, obraSocial));
            RefreshId(Paciente);
        }

    }
}
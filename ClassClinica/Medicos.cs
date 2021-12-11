using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassClinica
{
    public class Medicos : Persona
    {
       
        private string especialidad;
        static List<Medicos> Medico = new();

        public Medicos(int id, string nombre, string apellido, string especialidad) : base(id, nombre, apellido)
        {
           this.especialidad = especialidad;
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
        public string Epecialidad
        {
            get { return especialidad; }
            set { especialidad = value; }
        }

        /// <summary>
        /// Retorna la lista Medicos Para poder ser usada por el datagridview
        /// </summary>
        /// <returns></returns>
        public static object listMedicos()
        {
            return Medico;
        }

        public static void RefreshId(List<Medicos> medi)
        {
            for (int i = 0; i < medi.Count; i++)
            {
                medi[i].id = i + 1;
            }
        }

        /// <summary>
        /// Metodo para agregar una nueva instancia de Medico a la lista Medicos
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="especialidad"></param>
        public static void agregar(int id, String nombre, string apellido, string especialidad)
        {
            Medico.Add(new Medicos(id, nombre, apellido, especialidad));
            RefreshId(Medico);
        }

    }




}

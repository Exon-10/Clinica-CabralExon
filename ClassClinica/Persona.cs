using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassClinica
{
    public class Persona
    {
        public int id;
        private string nombre;
        private string apellido;
       
        public Persona() 
        {
            
        }

        public Persona(int id, string nombre, string apellido)
        {
            this.id = id;  
            this.nombre= nombre;
            this.apellido = apellido;
           
        }

        public int setId()
        {
             return id;  
        }
        public string setNombre()
        {
            return nombre;

        }
        public string setApellido()
        {
            return apellido;

        }

       
       

    }
}

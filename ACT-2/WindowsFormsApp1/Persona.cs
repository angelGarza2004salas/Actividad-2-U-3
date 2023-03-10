using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Persona
    {
        /// <summary>
        /// Declaramos variables
        /// </summary>
        protected string nombre;
        protected DateTime? fechaN;
        /// <summary>
        /// Creamos las Propiedades
        /// </summary>

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public DateTime? FechaN
        {
            get { return fechaN; }
            set { fechaN = value; }
        }
        private int edad;

        public int Edad
        {
            get
            {
                int edad;
                edad = DateTime.Now.Year - fechaN.Value.Year;
                return edad;
            }

        }

        public Persona()
        {
            nombre = string.Empty;
            fechaN = null;
        }
        public Persona(string nombre, DateTime? fechaN)
        {
            this.nombre = nombre;
            this.fechaN = fechaN;
        }
        public override string ToString()
        {
            return nombre.ToUpper() + " " + fechaN + " " + edad;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenEjercicio2
{
    class Estudiante
    {
        private double examen1;
        private double examen2;
        private double final;

        // constructores para asignarles valores a las notas
        public double Examen1
        {
            get { return examen1; }
            set { examen1 = value; }
        }

        public double Examen2
        {
            get { return examen2; }
            set { examen2 = value; }
        }

        public double Final
        {
            get { return final; }
            set { final = value; }
        }
        // metodo para calular la nota final del estudiante:
        public void CalcularFinal()
        {
            Final = (Examen1 + Examen2) / 2;
        }

        /* este metodo lo utilice para compara la nota final, asigando un numero minimo para ver si pasaba o no el curso.
         * y mostrando el mensaje que corresponde
         */
        
        public void MostrarResultado()
        {
            Console.WriteLine($"Nota final: {Final}");
            if (Final >= 70)
            {
                Console.WriteLine("¡El estudiante aprobo el curso!");
            }
            else
            {
                Console.WriteLine("El estudiante reprobo el curso.");
            }
        }
    }
}

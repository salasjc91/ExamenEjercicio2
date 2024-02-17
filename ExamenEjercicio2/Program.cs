namespace ExamenEjercicio2
{
    internal class Program
    {
        /*
         * Este metodo lo que hace es solicitar al usuario las notas,
         * utiliza el metodo CalcularFinal para hacer el promedio de notas,
         * y en el metodo MostrarResultado nos brinda el mensaje si paso o no el curso. 
         * 
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la nota del primer examen:");
            double notaExamen1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la nota del segundo examen:");
            double notaExamen2 = Convert.ToDouble(Console.ReadLine());

            Estudiante estudiante = new Estudiante();
            estudiante.Examen1 = notaExamen1;
            estudiante.Examen2 = notaExamen2;
            estudiante.CalcularFinal();
            estudiante.MostrarResultado();
        }
    }
}

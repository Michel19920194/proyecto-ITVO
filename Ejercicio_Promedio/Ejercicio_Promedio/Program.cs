using System;

namespace Ejercicio_Promedio
{
    class Program
    {
        static void Main(string[] args)
        {
            int Alumno = 0;
            Console.WriteLine("Ingresar la cantidad de alumnos");
            Alumno = Convert.ToInt32(Console.ReadLine());
            decimal[,] arregloCalificaciones = new decimal[Alumno, 2];
            Console.WriteLine();
            for (int i = 0; i <= Alumno - 1; i++)
            {
                Console.WriteLine("Calificación del alumno #" + (i + 1).ToString());
                arregloCalificaciones[i, 0] = Convert.ToDecimal(Console.ReadLine());
                arregloCalificaciones[i, 1] = (i + 1);//Alumno
                Console.WriteLine();
            }
            decimal calificacion = 0;
            decimal alumno2 = 0;
            for (int i = 0; i <= Alumno - 1; i++)
            {
                if (arregloCalificaciones[i, 0] > calificacion)
                {
                    calificacion = arregloCalificaciones[i, 0];
                    alumno2 = arregloCalificaciones[i, 1] = (i + 1);
                }

            }
            Console.WriteLine("El alumno con el mejor promedio es el alumno #{0} con una calificación de:{1}",
               alumno2.ToString(),
               calificacion.ToString());
            Console.WriteLine();

            calificacion = 10;
            alumno2 = 0;
            for (int i = 0; i <= Alumno - 1; i++)
            {
                if (arregloCalificaciones[i, 0] < calificacion)
                {
                    calificacion = arregloCalificaciones[i, 0];
                    alumno2= arregloCalificaciones[i, 1] = (i + 1);
                }

            }
            Console.WriteLine("El alumno con el peor promedio es el alumno #{0} con una calificación de:{1}",
               alumno2.ToString(),
               calificacion.ToString());

            Console.ReadKey();
        }
    }
}

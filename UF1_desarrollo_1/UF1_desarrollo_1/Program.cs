using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UF1_desarrollo_1
{
    class Program

        /* 1.- Arrays
Realiza un programa que tenga un array de 100 números aleatorios, entre los valores
-100 y 100, y mediante una criba, cree dos arrays. Uno de ellos tendrá únicamente
los números positivo, y el otro, los números negativos. */
    {
        static void Main(string[] args)
        {                                   // Primero declaro mis arrays y mis variables//
            int[] array100 = new int[100];

            Random aleatorio = new Random();

            int[] array_pos = new int[100];
            int numeroPositivos = 0;
            int[] array_neg = new int[100];
            int numeroNegativos = 0;

          for (int i=0; i< array100.Length; i++)            //Creo el bucle que introduce los valores aleatorios en el array
            {
                array100[i] = aleatorio.Next(-100, 100);

            }

            for (int i=0 ; i<array100.Length; i++ )         // Creo el bucle que va a filtrar dichos valores aleatorios como positivos y como negativos
            {
                if (array100[i] > 0)
                {
                    array_pos[numeroPositivos++] = array100[i];

                }
                else if (array100[i] < 0)
                {
                    array_neg[numeroNegativos++] = array100[i];

                }
   
            }


            Console.WriteLine("Los 100 números son ");      //A partir de aquí creo las salidas en pantalla de los números, y sus bucles correspondientes
            for (int i=0; i < array100.Length; i++)
            {

                string salida = " ";
                salida = salida + "" + array100[i];
                Console.Write(salida);
               

            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Los positivos son ");
            for (int i=0; i< array_pos.Length; i++)
            {
                if (array_pos[i] != 0)                      /* Aquí le digo al programa que muestre sólo aquellos números distintos a 0, 
                    porque de lo contrario me mostraría todos los números restantes del array  (es decir, muchos 0)
                    (porque le dijimos que tenía un rango de hasta 100 números) */
                {
                    string salida = " ";
                    salida = salida + "" + array_pos[i];
                    Console.Write(salida);


                }
                else
                    break;

            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Los negativos son ");
            for (int i=0; i < array_neg.Length; i++)
            {
                if (array_neg[i] != 0)              //Lo mismo que en el comentario anterior
                {

                    string salida = " ";
                    salida = salida + "" + array_neg[i];
                    Console.Write(salida);

                }
                else
                    break;

            }
            Console.WriteLine();
            Console.WriteLine();
        }
        // VICTOR FERNANDEZ RUIZ. ILERNA
    }
}

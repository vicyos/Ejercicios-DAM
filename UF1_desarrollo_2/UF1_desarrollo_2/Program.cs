using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UF1_desarrollo_2
{
    class Program
    {/*2.- Cadenas
Realiza un programa que permita al usuario introducir una cadena, 
cuente los caracteres que tiene y la cantidad de letras ‘a’ que tiene. 
Después, el usuario podrá introducir una letra, y le dirá en qué posiciones aparece.*/



        static void Main(string[] args)
        {
            Console.WriteLine("Introduce la frase que desees");

            string cadena = Convert.ToString(Console.ReadLine());               //El usuario introduce la frase que desee

            Console.WriteLine("La frase que has introducido tiene " + cadena.Length + " caracteres ");          //Se muestra en pantallas el número de caracteres 

            char caracter = 'a';

            int veces_a = 0;

            for (int i=0; i< cadena.Length; i++)        //Creo el bucle que va a contar las veces que aparece la letra "a"
            {
                if (caracter == cadena[i])

                    veces_a++;

            }
            Console.WriteLine("El caracter {0} aparece {1} veces", caracter, veces_a);


            Console.WriteLine("Introduce la letra que deseas comprobar su posición ");      //El usuario introduce una letra y el programa comprobará sus posiciones

            char letra = Convert.ToChar(Console.ReadLine());

            for (int i = 0; i < cadena.Length; i++)         //El bucle que va a buscar la letra introducida por el usuario en el texto anterior. Mostrará sus posiciones en pantalla
            {
                if (cadena[i] == letra)

                    Console.WriteLine("Hay una " + letra + " en la posición " + i);
                    
            }

        }

            }

    // VICTOR FERNANDEZ RUIZ. ILERNA
        }

    


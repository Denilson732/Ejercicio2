using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    class Program
    {
        static void Main(string[] args)
        {

            string nombre, sexo;
            int edad;
            Console.WriteLine("Escribe tu nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Hola {0}, ¿cuantos años tienes?", nombre);
            edad = int.Parse(System.Console.ReadLine());
            Console.WriteLine("Escribe tu sexo(Hombre=M, Mujer=F)");
            sexo = Console.ReadLine();
            if (sexo == "M" || sexo == "m")
            {
                Console.WriteLine("\nEl Sr {0} ha sido registrado, edad:{1} años,sexo:{2}", nombre,edad,sexo);

            }
            else
            {
                Console.WriteLine("\nLa Sra {0} ha sido registrada, edad:{1} años, sexo:{2}", nombre, edad, sexo);
            }
            Console.Read();

        }


    }
}

    


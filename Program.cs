using System;
using System.Collections;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {

            //Realizar un programa que al ingresar el número del mes del primer semestre donde
            //Enero es el mes 1 y julio el mes 6 mostrando el nombre del mes
            Console.WriteLine("Elija un numero del mes del primer mes del año: del 1 al 6");
            Console.WriteLine("Mes de Enero 1");
            Console.WriteLine("Mes de Febrero 2");
            Console.WriteLine("Mes de Marzo 3");
            Console.WriteLine("Mes de Abril 4");
            Console.WriteLine("Mes de Mayo 5");
            Console.WriteLine("Mes de Junio 6");

           Console.WriteLine("\nIngresa un numero del al  1 y 6");
           int mes = Convert.ToInt32(Console.ReadLine());

          switch (mes)
        {

        case 1:
               Console.WriteLine("Ingrese el numero del primer " +mes+ " el numero de mes es Enero");
        break;

        case 2:
              Console.WriteLine("Ingrese el numero del segundo " +mes+ " el numero de mes es Febrero");
        break;

        case 3:
             Console.WriteLine("Ingrese el numeo del tercer"  +mes+ " el numero de mes es Marzo");
        break;

        case 4:
            Console.WriteLine("Ingrese el numero del cuarto" +mes+ " el numero de mes es Abril");
        break;

        case 5:
            Console.WriteLine("Ingrese el numero del quinto" +mes+ " el numero de mes es Mayo");
        break;

        case 6:
           Console.WriteLine("Ingrese el numero del sexto" +mes+ " el numero de mes es Junio");
        break;
            
          }
        Console.ReadKey();
        }
    }
}
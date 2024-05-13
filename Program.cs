// See https://aka.ms/new-console-template for more information


using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            const int  DIA1 = 45000, DIA2 =60000 , DIA3 = 30000, FULL_DIAS = 100000;
            while (true)
            {
                Console.WriteLine("Seleccione una opcion ");
                Console.WriteLine("1 Nueva Inscripción 1 ");
                Console.WriteLine("2 Obtener Estadísticas del Evento 2 ");
                Console.WriteLine("3 Buscar Cliente 3 ");
                Console.WriteLine("4 Cambiar entrada de un Cliente 4 ");
                Console.WriteLine("5 Salir 5 ");
            }
            while (opcion <= 5)
            {
                 switch (opcion)
            {
                case 1 :
                ingresaDias(opcion);
                break;
                case 2 :

                break;
            }
            }
           

        }
        public static void ingresaDias(int opcion){
            const int DIA1 = 45000, DIA2 = 60000 , DIA3 = 30000, FULL_DIAS = 100000;
            int resultado = 0;
            while (opcion > 4)
            {
                switch (opcion)
                {
                    case 1 :
                    if (opcion == 1)
                    {
                        Console.WriteLine($"deberas abonar {DIA1} ");
                    }
                    else if (opcion == 1 && opcion == 2)
                    {
                        resultado = DIA1 + DIA2;
                        Console.WriteLine($"deberas abonar {resultado}  ");
                    }
                    else if (opcion == 1 && opcion == 3)
                    {
                        resultado = DIA1 + DIA3;
                        Console.WriteLine($"lo que debes abonar es {resultado} ");
                    }
                    break;
                    case 2 : 
                    if (opcion == 2)
                    {
                        Console.WriteLine($"Lo que debes abonar es {DIA2} ");
                    }

                    else if (opcion == 2 && opcion == 3)
                    {
                        resultado = DIA2 + DIA3;
                        Console.WriteLine($"lo que debes abonar es {resultado} ");
                    }
                    
                    break;
                    case 3 :
                    if (opcion == 3)
                    {
                        Console.WriteLine($"lo que debes abonar es {DIA3} ");
                    }
                    break;
                    case 4 :
                    if (opcion == 4)
                    {
                        Console.WriteLine($"Lo que debes abonar es {FULL_DIAS} ");
                    }
                    break;
                    default:
                    break;
                }
                if (opcion > 4)
                {
                    Console.WriteLine("no hay tantas opciones debe ser del 1 al 4 ");
                }
            }
        }
    }
    
}


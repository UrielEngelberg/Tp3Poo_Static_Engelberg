// See https://aka.ms/new-console-template for more information
using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion, dni, tipoEntrada, cantidad;
            string nombre, apellido;
            double fechaDeInscripcion;

            while (true)
            {
                Console.WriteLine("Seleccione una opción:");
                Console.WriteLine("1. Nueva Inscripción");
                Console.WriteLine("2. Obtener Estadísticas del Evento");
                Console.WriteLine("3. Buscar Cliente");
                Console.WriteLine("4. Cambiar entrada de un Cliente");
                Console.WriteLine("5. Salir");

                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ingrese su nombre ");
                        nombre = Console.ReadLine();
                        Console.WriteLine("Ingrese su apellido ");
                        apellido = Console.ReadLine();
                        Console.WriteLine("Ingrese su DNI ");
                        dni = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese la fecha de inscripción ");
                        fechaDeInscripcion = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el tipo de entrada (1, 2, 3 o 4) ");
                        tipoEntrada = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese la cantidad de entradas ");
                        cantidad = int.Parse(Console.ReadLine());

                        int UltimoIDEntrada = Tiketera.AgregarCliente(nombre, apellido, dni, fechaDeInscripcion, tipoEntrada, cantidad);
                        Console.WriteLine($"Se ha agregado el cliente con ID {UltimoIDEntrada} ");
                        break;
                    case 2:
                        Tiketera.EstadisticasDelEvento();
                        break;
                    case 3:
                        Console.Write("Ingrese el ID del cliente a buscar ");
                        UltimoIDEntrada = int.Parse(Console.ReadLine());
                        Tiketera.BuscarCliente(UltimoIDEntrada);
                        break;
                    case 4:
                        Console.Write("Ingrese el ID del cliente a cambiar ");
                        UltimoIDEntrada = int.Parse(Console.ReadLine());
                        Cliente cliente = Tiketera.BuscarCliente(UltimoIDEntrada);

                        if (cliente != null)
                        {
                            Console.Write("Ingrese el nuevo tipo de entrada (1, 2, 3 o 4): ");
                            int nuevoTipoEntrada = int.Parse(Console.ReadLine());

                            Tiketera.CambiarEntrada(cliente, nuevoTipoEntrada);
                        }
                        break;
                    case 5:
                        Console.WriteLine("Saliendo del programa ");
                        return;
                    default:
                        Console.WriteLine("Esta opcion no existe por favor seleccione una opción valida ");
                        break;
                }
            }
        }
    }
}


public class Tiketera
    {
        private static int UltimoIDEntrada = 0;
        private static Dictionary<int, Cliente> DicCliente = new Dictionary<int, Cliente>();

        public static int DevolverUltimoID()
        {
            return UltimoIDEntrada;
        }

        public static int AgregarCliente(string nombre, string apellido, int dni, double fechaDeInscripcion, int tipoEntrada, int cantidad)
        {
            Cliente clienteCompleto = new Cliente(dni, nombre, apellido, fechaDeInscripcion, tipoEntrada, cantidad);
            DicCliente.Add(UltimoIDEntrada, clienteCompleto);
            return UltimoIDEntrada++;
        }

        public static Cliente BuscarCliente(int idCliente)
        {
            if (DicCliente.ContainsKey(idCliente))
            {
                return DicCliente[idCliente];
            }
            return null;
        }

        public static bool CambiarEntrada(Cliente cliente, int nuevoTipoEntrada)
        {
            double importe, importeFinal;
            Console.WriteLine("Ingrese el importe de la entrada actual:");
            importe = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el importe de la entrada a la que desea cambiar:");
            importeFinal = double.Parse(Console.ReadLine());

            if (importe < importeFinal)
            {
                return false;
            }
            else
            {
                cliente.TipoEntrada = nuevoTipoEntrada;
                return true;
            }
        }

        public static void EstadisticasDelEvento()
        {
            int cantidadClientesDia1 = 0, cantidadClientesDia2 = 0, cantidadClientesDia3 = 0, cantidadClientesFullPass = 0;
            double importeTotal = 0;

            foreach (var cliente in DicCliente.Values)
            {
                switch (cliente.TipoEntrada)
                {
                    case 1:
                        cantidadClientesDia1++;
                        importeTotal += cliente.Cantidad * 45000;
                        break;
                    case 2:
                        cantidadClientesDia2++;
                        importeTotal += cliente.Cantidad * 60000;
                        break;
                    case 3:
                        cantidadClientesDia3++;
                        importeTotal += cliente.Cantidad * 30000;
                        break;
                    case 4:
                        cantidadClientesFullPass++;
                        importeTotal += cliente.Cantidad * 100000;
                        break;
                }
            }

            Console.WriteLine($"Cantidad de clientes con entrada dia 1: {cantidadClientesDia1}");
            Console.WriteLine($"Cantidad de clientes con entrada dia 2: {cantidadClientesDia2}");
            Console.WriteLine($"Cantidad de clientes con entrada dia 3: {cantidadClientesDia3}");
            Console.WriteLine($"Cantidad de clientes con entrada Full Pass: {cantidadClientesFullPass}");
            Console.WriteLine($"Importe total recaudado: {importeTotal}");
        }
    }

 
    
   

 


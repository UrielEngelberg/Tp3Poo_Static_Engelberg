public class tiketera{
    private static int UltimoIDEntrada = 0;

    private static Dictionary<int, Cliente> DicCliente = new Dictionary<int, Cliente>();

    public static int devolverUltimoID(){
        
        return UltimoIDEntrada;
    } 

    
    public static int agregarCliente(string nombre, string apellido,int dni,double fechaDeInscripcion,int tipoEntrada, int cantidad){
        Cliente clienteCompleto = new Cliente(dni, nombre, apellido, fechaDeInscripcion,tipoEntrada,cantidad);
        DicCliente.Add(UltimoIDEntrada,clienteCompleto);
        return UltimoIDEntrada;
    }

    public static int buscarCliente(int UltimoIDEntrada){
        if (DicCliente.ContainsKey(UltimoIDEntrada))
        {
            
        }
        return UltimoIDEntrada;
    }

    public static bool CambiarEntrada(int UltimoIDEntrada,int tipoEntrada){
        double importe,importeFinal;
        Console.WriteLine("ingresa el importe de la primer entrada ");
        importe = double.Parse(Console.ReadLine());

        Console.WriteLine("ingresa el importe de la entrada a cual vas a cambiar ");
        importeFinal = double.Parse(Console.ReadLine());

        if (importe < importeFinal)
        {
            return false;
        }
        else 
        {
            return true;
        }
    }
    List<string> estadisticasDelEvento = new List<string>();
    public static void EstadisticasDelEvento(string nombre, string apellido,int dni,double fechaDeInscripcion,int tipoEntrada, int cantidad){
         Cliente clienteCompleto = new Cliente(dni, nombre, apellido, fechaDeInscripcion,tipoEntrada,cantidad);
         Console.WriteLine( "La cant de clientes que se inscribieron fueron " + clienteCompleto);
    }

}
 
    
   

 


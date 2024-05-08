public class Cliente{

public int Dni { get; private set; }
public string Nombre { get; private set; }

public string Apellido { get; private set; }

public double FechaDeInscripcion {get; set;}

public int TipoEntrada {get; set;}

public int Cantidad {get; set;}

public Cliente (int dni, string nombre, string apellido, double fechaDeInscripcion, int tipoEntrada, int cantidad) {
    Dni = dni;
    Nombre = nombre;
    Apellido = apellido;
    FechaDeInscripcion = fechaDeInscripcion;
    TipoEntrada = tipoEntrada;
    Cantidad = cantidad;
}




}
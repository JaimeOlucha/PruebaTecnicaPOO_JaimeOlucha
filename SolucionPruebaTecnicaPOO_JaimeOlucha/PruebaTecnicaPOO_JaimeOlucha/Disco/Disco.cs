namespace PruebaTecnicaPOO_JaimeOlucha.Disco;

public class Disco
{
    // ATRIBUTOS: Declaramos los atributos de Disco;
    private string tipo = SIN_VALOR_STRING;
    private string nombre = SIN_VALOR_STRING;
    private string contenido = SIN_VALOR_STRING;
    private double capacidad = 0;
    private double velocidad = 0;

    // Constante con valor por defecto en el caso que los atributos no tengan valor
    public const string SIN_VALOR_STRING = "POR DEFINIR";

    // CONSTRUCTOR: Con los parámetros para crear el objeto;
    public Disco(string tipo, string nombre, string contenido, double capacidad, double velocidad)
    {
        Tipo = tipo;
        Nombre = nombre;
        Contenido = contenido;
        Capacidad = capacidad;
        Velocidad = velocidad;
    }
    // CONSTRUCTOR: También el constructor vacío por si creamos el Objeto aún sin saber todos los datos;
    public Disco() { }

    // METODOS: GET Y SET Para poder llamar y poner un valor al atributo;

    // Get y Set de tipo;
    public string Tipo
    {
        get { return tipo; }
        set { tipo = value; }
    }

    // Get y Set de Nombre: No acepta campo vacío o nulo, el valor será "POR DEFINIR";
    public string Nombre
    {
        get { return nombre; }
        set 
        {

            if (string.IsNullOrWhiteSpace(value))
            {
                nombre = SIN_VALOR_STRING;
            }
            else 
            {
                nombre = value;
            }
        }
    }

    // Get y Set de Contenido: No acepta campo vacío o nulo, el valor será "POR DEFINIR";
    public string Contenido
    {
        get { return contenido; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                contenido = SIN_VALOR_STRING;
            }
            else
            {
                contenido = value;
            }
        }
    }

    // Get y Set de Capacidad: No acepta negativos, si el valor asignado es inferior a 0, mostramos error y tendrá 0 por defecto;
    public double Capacidad
    {
        get { return capacidad; }
        set 
        {
            if( value < 0)
            {
                ErrorMenorCero("capacidad", Tipo); 
                capacidad = 0;
            }
            else
            {
                capacidad = value;
            }
        }
    }

    // Get y Set de Velocidad: No acepta negativos, si el valor asignado es inferior a 0, mostramos error y tendrá 0 por defecto;
    public double Velocidad
    {
        get { return velocidad; }
        set
        {
            if (value < 0)
            {
                ErrorMenorCero("velocidad", Tipo);
                velocidad = 0;
            }
            else
            {
                velocidad = value;
            }
        }
    }

    

    // METODO: Muestra la información general del Objeto;
    public void InformacionGeneralMultimedia()
    {
        Console.WriteLine();
        Console.WriteLine("--------------------------");
        Console.WriteLine($"INFORMACION DEL OBJETO TIPO: {Tipo.ToUpper()}");
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Contenido: {Contenido}");
        Console.WriteLine($"Capacidad: {Capacidad} GB");
        Console.WriteLine($"Velocidad: {Velocidad} RPM");
    }

    // METODO: Muestra información completa, la marcamos como virtual para poder hacer "override" en cada clase hijo;
    public virtual void MostrarInformacionCompleta() {}

    // METODO: Mostramos ERROR Cuando valor sea infrior a 0;
    public static void ErrorMenorCero(string dato, string tipo)
    {
        Console.WriteLine();
        Console.WriteLine("--------------------------");
        Console.WriteLine($"¡ERROR EN {tipo.ToUpper()}!");
        Console.WriteLine($"El valor de {dato} no puede  ser inferior a 0, por favor actualizar valor a uno válido.");
        Console.WriteLine("-  -  -  -  -  -  -  -");
    }
}

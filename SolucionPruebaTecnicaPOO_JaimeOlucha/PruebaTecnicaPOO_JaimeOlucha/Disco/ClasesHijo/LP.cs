using PruebaTecnicaPOO_JaimeOlucha.Interfaces;

namespace PruebaTecnicaPOO_JaimeOlucha.Disco.ClasesHijo;

// ¡¡CLASE LP BONUS!!


// Creamos Clase Hijo, que hereda de Padre e implementa las interfaces necesarias;

internal class LP : Disco, IGirar, IEscritura, ILectura, IDimension, IReproducir
{
    // ATRIBUTO: Creamos un atributo específico para esta clase;
    private int tamañoDisco;



    // CONSTRUCTOR: Creamos el contructor, los parámetros los enlazamos a los atributos del padre con "base";
    public LP(string nombre, string contenido, double capacidad, double velocidad, int tamañoDisco) : base("LP", nombre, contenido, capacidad, velocidad)
    {
        // Asignamos por defecto el TIPO "LP" pasándolo como parámetro en el contructor del padre, y quitamos del parámetro del hijo la llamada del TIPO; 


        TamañoDisco = tamañoDisco;
    }
    public LP()
    {
        // Si creamos el objeto vacío, asignamos por defecto el TIPO "LP";
        Tipo = "LP";
    }



    // Get y Set de DuracionPelicula: No acepta negativos, si el valor asignado es inferior a 0, mostramos error y tendrá 0 por defecto;
    public int TamañoDisco
    {
        get { return tamañoDisco; }

        set
        {
            if (value < 0)
            {
                ErrorMenorCero("tamaño del disco", Tipo);
                tamañoDisco = 0;
            }
            else
            {
                tamañoDisco = value;
            }
        }
    }



    // METODO PADRE: Rellenamos el metodo mostrar información con todo lo que queramos;
    public override void MostrarInformacionCompleta()
    {
        // Mostramos la información general del objeto;
        InformacionGeneralMultimedia();

        // Mostramos la información de las acciones de las interfaces;
        DefinirDimension();
        GirarObjeto();
        EscribirObjeto();
        LeerObjeto();
        ReproduciendoDisco();
    }



    // METODOS INTERFACES: Implementamos los métodos de las interfaces;
    public void DefinirDimension()
    {
        Console.WriteLine($"Tamaño vinilo LP: {TamañoDisco} cm.");
    }
    public void GirarObjeto()
    {
        Console.WriteLine($"- GIRANDO: El vinilo LP está girando a {Velocidad} RPM.");
    }
    public void EscribirObjeto()
    {
        Console.WriteLine("- ESCRIBIENDO: El vinilo LP esta escribiendo los datos mediante la aguja en el tocadiscos.");
    }
    public void LeerObjeto()
    {
        Console.WriteLine("- LEYENDO: El vinilo LP esta leyendo los datos mediante la aguja en el tocadiscos.");
    }
    public void ReproduciendoDisco()
    {
        Console.WriteLine("- REPRODUCIENDO: El vinilo LP se está reproduciendo con éxito.");
    }
}

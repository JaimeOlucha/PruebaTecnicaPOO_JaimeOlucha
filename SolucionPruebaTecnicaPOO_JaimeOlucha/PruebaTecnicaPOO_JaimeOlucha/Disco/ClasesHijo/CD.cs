using PruebaTecnicaPOO_JaimeOlucha.Interfaces;

namespace PruebaTecnicaPOO_JaimeOlucha.Disco.ClasesHijo;

// Creamos Clase Hijo, que hereda de Padre e implementa las interfaces necesarias;
public class CD : Disco, IGirar, IEscritura , ILectura, IPistas, IReproducir
{
    // ATRIBUTO: Creamos un atributo específico para esta clase;
    private int numeroCanciones;



    // CONSTRUCTOR: Creamos el contructor, los parámetros los enlazamos a los atributos del padre con "base";
    public CD(string nombre, string contenido, double capacidad, double velocidad, int numeroCanciones) : base("CD", nombre, contenido, capacidad, velocidad)
    {
        // Asignamos por defecto el TIPO "CD" pasándolo como parámetro en el contructor del padre, y quitamos del parámetro del hijo la llamada del TIPO; 

    
        NumeroCanciones = numeroCanciones;
    }
    public CD()
    {
        // Si creamos el objeto vacío, asignamos por defecto el TIPO "CD";
        Tipo = "CD"; 
    }



    // Get y Set de NumeroCanciones: No acepta negativos, si el valor asignado es inferior a 0, mostramos error y tendrá 0 por defecto;
    public int NumeroCanciones
    {
        get { return numeroCanciones; }

        set
        {
            if (value < 0)
            {
                ErrorMenorCero("numero de canciones", Tipo);
                numeroCanciones = 0;
            }
            else
            {
                numeroCanciones = value;
            }
        }
    }



    // METODO PADRE: Rellenamos el metodo mostrar información con todo lo que queramos;
    public override void MostrarInformacionCompleta()
    {
        // Mostramos la información general del objeto;
        InformacionGeneralMultimedia();

        // Mostramos la información de las acciones de las interfaces;
        CantidadPistas();
        GirarObjeto();
        EscribirObjeto();
        LeerObjeto();
        ReproduciendoDisco();
    }



    // METODOS INTERFACES: Implementamos los métodos de las interfaces;
    public void CantidadPistas()
    {
        Console.WriteLine($"Canciones: {NumeroCanciones} Totales.");
    }
    public void GirarObjeto()
    {
        Console.WriteLine($"- GIRANDO: El CD está girando a {Velocidad} RPM.");
    }
    public void EscribirObjeto()
    {
        Console.WriteLine("- ESCRIBIENDO: El CD esta escribiendo los datos mediante el uso de un laser rojo.");
    }
    public void LeerObjeto()
    {
        Console.WriteLine("- LEYENDO: El CD esta leyendo los datos mediante el uso de un laser rojo.");
    }
    public void ReproduciendoDisco()
    {
        Console.WriteLine("- REPRODUCIENDO: El CD se está reproduciendo con éxito.");
    }
}   

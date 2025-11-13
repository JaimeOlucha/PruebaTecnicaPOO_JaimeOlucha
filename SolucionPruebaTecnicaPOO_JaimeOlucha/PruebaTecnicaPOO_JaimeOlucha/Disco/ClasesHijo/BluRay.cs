using PruebaTecnicaPOO_JaimeOlucha.Interfaces;

namespace PruebaTecnicaPOO_JaimeOlucha.Disco.ClasesHijo;

// ¡¡CLASE BLU-RAY BONUS!!


// Creamos Clase Hijo, que hereda de Padre e implementa las interfaces necesarias;
public class BluRay : Disco, IGirar, IEscritura, ILectura, IDuracion, IReproducir
{
    // ATRIBUTO: Creamos un atributo específico para esta clase;
    private int duracionPelicula;



    // CONSTRUCTOR: Creamos el contructor, los parámetros los enlazamos a los atributos del padre con "base";
    public BluRay(string nombre, string contenido, double capacidad, double velocidad, int duracionPelicula) : base("Blu-Ray", nombre, contenido, capacidad, velocidad)
    {
        // Asignamos por defecto el TIPO "Blu-Ray" pasándolo como parámetro en el contructor del padre, y quitamos del parámetro del hijo la llamada del TIPO; 


        DuracionPelicula = duracionPelicula;
    }
    public BluRay()
    {
        // Si creamos el objeto vacío, asignamos por defecto el TIPO "Blu-Ray";
        Tipo = "Blu-Ray";
    }



    // Get y Set de DuracionPelicula: No acepta negativos, si el valor asignado es inferior a 0, mostramos error y tendrá 0 por defecto;
    public int DuracionPelicula
    {
        get { return duracionPelicula; }

        set
        {
            if (value < 0)
            {
                ErrorMenorCero("duracion de película", Tipo);
                duracionPelicula = 0;
            }
            else
            {
                duracionPelicula = value;
            }
        }
    }



    // METODO PADRE: Rellenamos el metodo mostrar información con todo lo que queramos;
    public override void MostrarInformacionCompleta()
    {
        // Mostramos la información general del objeto;
        InformacionGeneralMultimedia();

        // Mostramos la información de las acciones de las interfaces;
        TiempoDuracion();
        GirarObjeto();
        EscribirObjeto();
        LeerObjeto();
        ReproduciendoDisco();
    }



    // METODOS INTERFACES: Implementamos los métodos de las interfaces;
    public void TiempoDuracion()
    {
        Console.WriteLine($"Duración película: {DuracionPelicula} Minutos.");
    }
    public void GirarObjeto()
    {
        Console.WriteLine($"- GIRANDO: El disco Blu-Ray está girando a {Velocidad} RPM");
    }
    public void EscribirObjeto()
    {
        Console.WriteLine("- ESCRIBIENDO: El disco Blu-Ray esta escribiendo los datos mediante el uso de un laser azul.");
    }
    public void LeerObjeto()
    {
        Console.WriteLine("- LEYENDO: El disco Blu-Ray esta leyendo los datos mediante el uso de un laser azul.");
    }
    public void ReproduciendoDisco()
    {
        Console.WriteLine("- REPRODUCIENDO: El disco Blu-Ray se está reproduciendo con éxito.");
    }
}

using PruebaTecnicaPOO_JaimeOlucha.Interfaces;

namespace PruebaTecnicaPOO_JaimeOlucha.Disco.ClasesHijo;

// Creamos Clase Hijo, que hereda de Padre e implementa las interfaces necesarias;
public class DiscoDuro : Disco, IGirar, IEscritura, ILectura, IConexion
{
    // ATRIBUTO: Creamos un atributo específico para esta clase;
    private string tipoConexion = SIN_VALOR_STRING;
   


    // CONSTRUCTOR: Creamos el contructor, los parámetros los enlazamos a los atributos del padre con "base";
    public DiscoDuro(string nombre, string contenido, double capacidad, double velocidad, string tipoConexion) : base("Disco Duro",nombre, contenido, capacidad, velocidad)
    {
        // Asignamos por defecto el TIPO "Disco Duro" pasándolo como parámetro en el contructor del padre, y quitamos del parámetro del hijo la llamada del TIPO; 
   
    
        TipoConexion = tipoConexion;
    }
    public DiscoDuro()
    {
        // Si creamos el objeto vacío, asignamos por defecto el TIPO "CD"
        Tipo = "Disco Duro";
    }



    // Get y Set de TipoConexion: No acepta campo vacío o nulo, el valor será "POR DEFINIR";
    public string TipoConexion
    {
        get { return tipoConexion; }
        set 
        {
            if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
            {
                tipoConexion = SIN_VALOR_STRING;
            }
            else
            {
                tipoConexion = value;
            }
        }
    }


    // METODO PADRE: Rellenamos el metodo mostrar información con todo lo que queramos;
    public override void MostrarInformacionCompleta()
    {
        // Mostramos la información general del objeto;
        InformacionGeneralMultimedia();

        // Mostramos la información de las acciones de las interfaces;
        ConectarObjeto();
        GirarObjeto();
        EscribirObjeto();
        LeerObjeto();

        // Mostramos la información del método propio;
        Formatear();
    }



    // METODOS INTERFACES: Implementamos los métodos de las interfaces;
    public void ConectarObjeto()
    {
        Console.WriteLine($"Conexion: {TipoConexion}.");
    }
    public void GirarObjeto()
    {
        Console.WriteLine($"- GIRANDO: Los platos del disco duro están girando a {Velocidad} RPM.");
    }
    public void EscribirObjeto()
    {
        Console.WriteLine("- ESCRIBIENDO: El disco duro esta escribiendo los datos mediante el uso de un cabezal magnético.");
    }
    public void LeerObjeto()
    {
        Console.WriteLine("- LEYENDO: El disco duro esta leyendo los datos mediante el uso de un cabezal magnético.");
    }



    // METODO PROPIO: Creamos un método propio de la clase Disco Duro;
    public void Formatear()
    {
        Console.WriteLine($"- FORMATEANDO: El disco duro se ha formateado con éxito, {Capacidad} GB listos para usar.");
    }
}

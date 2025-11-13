using PruebaTecnicaPOO_JaimeOlucha.Interfaces;

namespace PruebaTecnicaPOO_JaimeOlucha.ClasesExtra;


// CLASE BONUS: Implementamos la misma interfaz que hemos usado para las clases hijo de Disco;
public class Rueda : IGirar
{
    public void GirarObjeto()
    {
        Console.WriteLine("La rueda está girando.");
    }
}

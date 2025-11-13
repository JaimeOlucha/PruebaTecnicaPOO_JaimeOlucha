using PruebaTecnicaPOO_JaimeOlucha.Interfaces;

namespace PruebaTecnicaPOO_JaimeOlucha.ClasesExtra;


// CLASE BONUS: Implementamos la misma interfaz que hemos usado para las clases hijo de Disco;
public class Frisbees : IGirar
{
    public void GirarObjeto()
    {
        Console.WriteLine("¡Han lanzado el Frisbee, está girando!");
    }
}

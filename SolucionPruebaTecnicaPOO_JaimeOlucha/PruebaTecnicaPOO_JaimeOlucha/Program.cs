namespace PruebaTecnicaPOO_JaimeOlucha;

using PruebaTecnicaPOO_JaimeOlucha.Disco.ClasesHijo;
using PruebaTecnicaPOO_JaimeOlucha.ClasesExtra;

public class Program
{
    // MÉTODO DE ENTRADA A LA APLICACIÓN;
    public static void Main(string[]args)
    {
        PresentacionPruebaTecnica();
        /* * * * * * * * * * * * * */


        // * CREACION DE LOS OBJETOS - CD Y DISCO DURO *;
        // Creamos Objeto CD;
        CD cdQueen = new CD("Queen", "Disco Remasterizado de Queen", 0.7, 350, 10);
        cdQueen.MostrarInformacionCompleta();

        // Creamos Objeto Disco Duro;
        DiscoDuro discoHDD = new DiscoDuro("HDD", "Disco HDD de 2,5 pulgadas", 1000, 6000, "USB");
        discoHDD.MostrarInformacionCompleta();


        // * ¡BONUS (PARTE 1)! CREACION OBJETOS - BLU-RAY Y LP *;
        // Creamos Objeto BluRay
        MensajeCodigoBonus();
        BluRay bluRayIronMan = new BluRay("Iron Man", "Pelicula extendida de Iron Man en formato Blu-Ray", 30, 500, 120);
        bluRayIronMan.MostrarInformacionCompleta();

        // Creamos Objeto LP
        LP lpSinatra = new LP("Frank Sinatra", "My Way", 0.3, 33, 15);
        lpSinatra.MostrarInformacionCompleta();


        // * ¡BONUS (PARTE 2)! CREACION OBJETOS - RUEDA Y FRISBEES *;
        // Creamos Objeto Rueda
        MensajeCodigoBonus();
        Rueda rueda = new Rueda();
        rueda.GirarObjeto();

        // Creamos Objeto Frisbees
        Frisbees frisbees = new Frisbees();
        frisbees.GirarObjeto();
    }




    //
    // ** MÉTODO EXTRA: Mensajes presentando la aplicación; 
    public static void PresentacionPruebaTecnica()
    {
        Console.WriteLine("* * * * * * * * * * * * * * * * * * * *");
        Console.WriteLine();
        Console.WriteLine("PRUEBA TÉCNICA PROCESO SELECCIÓN 2025"); 
        Console.WriteLine("- Autor: Jaime Olucha Buendía");
        Console.WriteLine("- Destinatario: Cuatroochenta");
        Console.WriteLine();
        Console.WriteLine("* * * * * * * * * * * * * * * * * * * *");
    }

    public static void MensajeCodigoBonus()
    {
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("------------CODIGO BONUS--------------");


    }
}
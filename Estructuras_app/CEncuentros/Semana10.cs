public class vacunas
{
    public static void run()
    {
        Random random = new Random();

        HashSet<string> pfizer = new HashSet<string>();

        for (int i = 0; i < 75; i++)
        {
            pfizer.Add("persona " + random.Next(1, 500));
        }

        HashSet<string> astrazeneca = new HashSet<string>();

        for (int i = 0; i < 75; i++)
        {
            astrazeneca.Add("persona " + random.Next(1, 500));
        }

        

        //listado 500
        //pfizer 75
        //astrazeneca 75

        //noVacunado = listado 500 - pfizer - astraseneca
        //ambasdosis = pfizer insterseccion astraseneca
        //soloPifzer = pfizer - astrazeneca
        HashSet<string> soloPizer = new HashSet<string>();
        soloPizer.UnionWith(pfizer);
        soloPizer.ExceptWith(astrazeneca);
        foreach (var item in soloPizer)
        {
            System.Console.WriteLine(item);
        }
        Console.WriteLine("Vacunados con solo pfizer: " + soloPizer.Count);
        //soloAstra = astrazeneca - pfizer

    }


    // private static HashSet<string>()(string vacuna, int cantida){

    // }
    


}
using System;

namespace Maison_Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            Terrain GareGronde = new Terrain("Gare de Gronde Argent", 150f, 4, false);
            Terrain Zola = new Terrain("Village de Zola a Flot Rilége", 400f, 5, true);
            Terrain Mille = new Terrain("Millenia", 555f, 8, false);
            
            Maison RubyMaison = new Maison("1er Rue des yeux d'or, Cité d'or", 80f, 5, true);
            Maison EilliMaison = new Maison("83 Rue du Sablier, Cité d'or", 50f, 5, true);
            Maison SilverMaison = new Maison("f Rue de l'Ange des Sable, Gronde Argent", 1500f, 10, false);

            Bien[] Habitation = new Bien[] { RubyMaison, EilliMaison, SilverMaison, GareGronde, Zola, Mille};

            foreach(Bien LeBien in Habitation) {
                Console.WriteLine(LeBien);
                Console.WriteLine();
            }

            Propriétaire Bill = new Propriétaire("Bill", "Truvendus", new Bien[] { GareGronde, SilverMaison });
            Console.WriteLine(Bill);

            Propriétaire Kolyma = new Propriétaire("Kolyma", "Volga", new Bien[] {Zola});
            Console.WriteLine(Kolyma);

            Propriétaire Ruby = new Propriétaire("Ruby", "Bianka", new Bien[] { RubyMaison, Mille });
            Console.WriteLine(Ruby);

            Propriétaire Eilli = new Propriétaire("Eilli", "Howl", new Bien[] {EilliMaison});
            Console.WriteLine(Eilli);
        }
    }
}

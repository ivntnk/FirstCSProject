using System;
using System.Collections.Generic;

public class MarketPlace
{
    public static void marketplace()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("==========++++ BIENVENUE SUR LE MARKETPLACE ++++==========");
        Console.WriteLine(@"| /-----------------------\ | /-----------------------\ |");
        Console.WriteLine(@"| |   1. BOUSSOLE INDICE  | | |   2. COEUR +5 ESSAIS  | |");
        Console.WriteLine(@"| |                       | | |                       | |");
        Console.WriteLine(@"| |         .---.         | | |        ( <3 )         | |");
        Console.WriteLine(@"| |        /  |  \        | | |       /  v v  \       | |");
        Console.WriteLine(@"| |        | -O- |        | | |       \  ---  /       | |");
        Console.WriteLine(@"| |        \  |  /        | | |        '---'          | |");
        Console.WriteLine(@"| |         '---'         | | |                       | |");
        Console.WriteLine(@"| |  Révèle Pair/Impair   | | |  +5 Essais en jeu     | |");
        Console.WriteLine(@"| |  Prix : 50 Pièces     | | |  Prix : 100 Pièces    | |");
        Console.WriteLine(@"| \-----------------------/ | \-----------------------/ |");
        Console.WriteLine(@"|---------------------------|---------------------------|");
        Console.WriteLine(@"| /-----------------------\ | /-----------------------\ |");
        Console.WriteLine(@"| |   3. LOUPE MAGIQUE    | | |   4. COFFRE AU TRÉSOR | |");
        Console.WriteLine(@"| |                       | | |                       | |");
        Console.WriteLine(@"| |          .-.          | | |        .-------.      | |");
        Console.WriteLine(@"| |         (( ))         | | |       /   $   /|      | |");
        Console.WriteLine(@"| |          '-'          | | |      +-------+ |      | |");
        Console.WriteLine(@"| |           \\          | | |      |  (o)  | /      | |");
        Console.WriteLine(@"| |            \\         | | |      +-------+'       | |");
        Console.WriteLine(@"| |  Réduit l'intervalle  | | |  x2 Pièces gagnées    | |");
        Console.WriteLine(@"| |  Prix : 150 Pièces    | | |  Prix : 250 Pièces    | |");
        Console.WriteLine(@"| \-----------------------/ | \-----------------------/ |");
        Console.WriteLine(@"|---------------------------|---------------------------|");

        Console.WriteLine("== Vous avez fait votre choix ? Veuillez indiqué quel extension");
        Console.WriteLine("vous aimeriez ==");

        Console.Write(">>>");
        string extChoice = Console.ReadLine();
        

        switch (extChoice)
        {
            case "1":
            Thread.Sleep(500);
            Console.WriteLine("Bon choix ! L'extension sera ajouté a votre compte d'ici peux");
            Thread.Sleep(800);

            for (int i = 0; i <= 100; i += 10)
                {
                    int progression = i / 5;
                    int diminution = 20 - progression;

                    string barreProgression = new string ('=', progression);
                    string barreDiminution = new string ('-', diminution);

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write($"\r{i}% | {barreProgression}{barreDiminution} |");
                    Thread.Sleep(500);
                }
                Console.WriteLine();
                Console.WriteLine("Instalation términé, vous pouvez retrouvé votre extension sur votre profil");
                Console.ResetColor();
                Thread.Sleep(1000);
                Console.WriteLine("Redirection vers RandomGame...");

            break;

            case "2":
            Thread.Sleep(500);
            Console.WriteLine("Bon choix ! L'extension sera ajouté a votre compte d'ici peux");
            break;

            case "3":
            Thread.Sleep(500);
            Console.WriteLine("Bon choix ! L'extension sera ajouté a votre compte d'ici peux");
            break;

            case "4":
            Thread.Sleep(500);
            Console.WriteLine("Bon choix ! L'extension sera ajouté a votre compte d'ici peux");
            break;

            default:
            Thread.Sleep(500);
            Console.WriteLine("L'extension choisie n'exste pas, veuillez recommencer?");
            Thread.Sleep(1500);
            Console.Clear();
            MarketPlace.marketplace();
            break;
        }
    }
}

// Made with ♥ and ♬ by ivn_tnk
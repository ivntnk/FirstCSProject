using System.Threading;
using System;
using System.ComponentModel;
using System.Collections;
using System.Runtime.Serialization.Formatters;

void OpenGame()
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("===============================");
    Console.WriteLine("=====---- RandomGame ----======");
    Console.WriteLine("===============================");
    Console.ResetColor();
}
void PhraseDebut(string name)
{
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine($"Bienvenue a toi {name} !");
}
void Difficulty(out int maxLevel, out int maxEssaie)
{   
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("===============================");
    Console.WriteLine("=====---- RandomGame ----======");
    Console.WriteLine("===============================");
    Console.WriteLine("===--- CHOIX DES NIVEAUX ---===");
    Console.WriteLine("|Niveaux 1 | 1 a 50  - 15 essai");;
    Console.WriteLine("|Niveaux 2 | 1 a 100 - 10 essai");
    Console.WriteLine("|Niveaux 3 | 1 a 200 - 7  essai");
    Console.WriteLine("|Autre (4) | Marketplace       ");
    Console.WriteLine("|Autre (5) | Profil            ");
    Console.WriteLine("===============================");

    string choix = Console.ReadLine();

    switch (choix)
    {
        case "1":
        maxLevel = 50;
        maxEssaie = 15;
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("Choix 1 séléctionné ! \n");
        Console.ResetColor();
        break;

        case "3":
        maxLevel = 200;
        maxEssaie = 7;
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("Choix 3 séléctionné ! \n");
        Console.ResetColor();
        break;

        case "4":
        maxLevel = 0;
        maxEssaie = 0;
        Console.WriteLine("Etes vous sur de vouloir rentrer dans le marketplace ? (Y/N)");
        string ynMarket = Console.ReadLine();

        if (ynMarket.ToUpper() == "Y")
            {
                Console.WriteLine("Entrez dans le marketplace...");
                Thread.Sleep(1000);
                Console.WriteLine("Redirection...");
                MarketPlace.marketplace();
                Environment.Exit(0);
            } else
            {
                Console.WriteLine("Redirection anullé.");
                return;
            }
        
        break;

        case "102030":
        maxLevel = 0;
        maxEssaie = 0;
        Console.BackgroundColor = ConsoleColor.Magenta;
        Console.WriteLine("Veuillez entrée le code A2F :");

        string staffCode = "2011";
        string saisieStaffCode = Console.ReadLine();
        bool staffYN = false;

        if (saisieStaffCode == staffCode)
            {   
                staffYN = true;
                Console.ResetColor();
                Console.WriteLine($"Entrez dans le mode staff...");
                Thread.Sleep(1500);
                StaffMode.MainStaffMode();
                Environment.Exit(0);
            }
            else
            {
                Console.ResetColor();
                Environment.Exit(0);
            }
        break;
        
        case "5":
        maxLevel = 0;
        maxEssaie = 0;

        for (int i = 1; i<= 3; i++)
            {
                int nbPoints = (i / 10) % 3 + 1;
                string points = new string ('.', nbPoints);

                Console.Write($"{points}");
                Thread.Sleep(400);
            }
        Profil.ProfilPage();
        Console.WriteLine();
        break;

        default:
        maxLevel = 100;
        maxEssaie = 10;
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("Choix 2 séléctionné par default ! \n");
        Console.ResetColor();
        break;
    }
}

Random generateur = new Random();

int nombreMin = 1;

OpenGame();
PhraseDebut("Jeune Programmer");

Thread.Sleep(1000);
Console.WriteLine($"Le jeu va bientot démarée, Merci de patienter");

Console.ResetColor();

for (int i =0; i <= 100; i += 50)
    {
        int progression = i / 5;
        int diminution = 20 - progression;

        string barreProgression = new string ('=', progression);
        string barreDiminution = new string ('-', diminution);

        Console.Write($"\r{i}%   | {barreProgression}{barreDiminution} |");
        Thread.Sleep(1000);
    }

Console.WriteLine();
Console.WriteLine("Fini !");
Thread.Sleep(1000);
Console.Clear();

if (generateur.Next(0, 3) == 0)
{
    Console.BackgroundColor = ConsoleColor.Red;
    Console.WriteLine("Une ereur est survenue, veuillez redémarée le programe");
    Console.ResetColor();
    Environment.Exit(0);
}

bool Rejouer = true;

do
{

int nombreMax;
int TentativesMax;

Difficulty(out nombreMax, out TentativesMax);
int nombreSecret = generateur.Next(1, nombreMax + 1);
int Tentatives = 0;
int proposition = 0;

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"Bienvenue sur RandomGame, Tapez un nombre entre {nombreMin} et {nombreMax}.");
Thread.Sleep(800);
Console.WriteLine($"Vous avez {TentativesMax} chances pour trouvé le nombre");
Console.ResetColor();

bool abandon = false;

while (proposition != nombreSecret && Tentatives < TentativesMax)
{   

    string saisieTexte = Console.ReadLine();

    if (saisieTexte.ToLower() == "stop")
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Parti stoper ! Retour au menu principale...");
            Console.ResetColor();
            Thread.Sleep(3000);
            abandon = true;
            break;
        }

    if (int.TryParse(saisieTexte, out proposition))
    {
        Tentatives++;

        if (proposition < nombreSecret)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Le nombre est trop petit ! ({Tentatives} Tentatives)");
            Console.ResetColor();
        }
        else if (proposition > nombreSecret)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"Le nombre est trop grand ! ({Tentatives} Tentatives)");
            Console.ResetColor();
        }
    }

    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Veuillez entrée un nombre valide.");
        Console.ResetColor();  
    }
}
if (!abandon)
    {
        if (proposition == nombreSecret)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Félicitations ! tu as trouvé le nombre secret en {Tentatives} tentatives!");
            Thread.Sleep(500);
            Console.ResetColor();
        }

        else
        {
        Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Perdu ! tu as dépassé le nombre max de tentatives ({TentativesMax})");
            Console.WriteLine($"Le nombre secret etait {nombreSecret}");
            Thread.Sleep(500);
            Console.ResetColor();
    }

        Console.WriteLine("voulez vous rejouez ? (Y/N)");
        string reponse = Console.ReadLine().ToUpper();

        if (reponse != "Y")
        {
            Rejouer = false;
        }
    } 
} while (Rejouer);

Console.WriteLine("Merci d'avoir jouée, a bientot :D");

// Made with ♥ and ♬ by ivn_tnk
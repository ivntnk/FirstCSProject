using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;

public static class StaffMode
{
    public static void MainStaffMode()
    {
        bool rejouez = false;
        Console.Clear();
        Console.WriteLine("Bienvenue dans le staffmode du jeu RandomGame, veuillez vous identifié.");
        string nameStaff = Console.ReadLine();
        Console.WriteLine($"Bon retour {nameStaff}...");
        Thread.Sleep(2000);

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("=========================================================");
        Console.WriteLine("++++++++++++++++ STAFFMODE - RANDOM GAME +++++=++++++++++");
        Console.WriteLine("=========================================================");
        Console.WriteLine("Que voulez vous faire ?    | Crédit : ivn_tnk - kynera   ");
        Console.WriteLine("1.                         |2.                           ");
        Console.WriteLine("3.                         |4.                           ");
        Console.WriteLine("5.                         |6.                           ");
        Console.WriteLine("7.                         |8.                           ");
        Console.WriteLine("8.                         |9.                           ");
        Console.WriteLine("9.                         |10.                          ");
        Console.WriteLine("=========================================================");

        Console.Write($"\ncore-01p-<$>{nameStaff}>>> ");
        string choix = Console.ReadLine();
    }
}

// Made with ♥ and ♬ by ivn_tnk
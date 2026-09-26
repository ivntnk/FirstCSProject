using System;
using System.Collections.Generic;

public class Profil
{
    public static void ProfilPage()
    {
        bool rejouez = false;
        bool staffYN = true;

        Console.Clear();
        
        void profilASCII()
        {
            Console.WriteLine("=================================");
            Console.WriteLine("====----===== PROFIL ====----====");
            Console.WriteLine("=================================");
        }
        Console.WriteLine();

    Thread.Sleep(1000);
    Console.WriteLine($"Status du compte : {(staffYN ? "staff" : "joueur")}");
    Console.WriteLine($"Stats : ");

    }
}

// Made with ♥ and ♬ by ivn_tnk
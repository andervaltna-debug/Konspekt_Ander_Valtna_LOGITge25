// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main(string[] args)
    {
        Tervitus();

        
        double[] arvud = { 6.5, 2.1, 5.3, 4.1, 7.2 };
        double tulemus = jagaArvud(arvud);
        Console.WriteLine("Jagamise tulemus on: " + tulemus);


        Console.WriteLine("Sisesta oma perekonnanimi: ");
        string perekonnaNimi = Console.ReadLine();
        int aArv = LoeA(perekonnaNimi);
        Console.WriteLine("Sinu perekonnanimi sisaldab a tähte " + aArv + " korda");


        Console.WriteLine("Kui kaugele sa täna jalgsi liikusid?");
        double kõndimisKaugus = Convert.ToDouble(Console.ReadLine());
        string kõndimisTulemus = jalgsiKõndimine(kõndimisKaugus);
        Console.WriteLine(kõndimisTulemus);
    
    }

    //Ülesanne 1
    static void Tervitus()
    {
        Console.WriteLine("Tere tulemast!");
    }

    
    //Ülesanne 2
    static double jagaArvud(double[] massiiv)
    {
        double tulemus = massiiv[0];

        for (int i = 1; i < massiiv.Length; i++)
        {
            tulemus = tulemus / massiiv[i];
        }

        return tulemus;
    }


    //Ülesanne 3
    static int LoeA(string nimi)
    {
        int loendur = 0;

        for (int i = 0; i < nimi.Length; i++)
        {
            if (nimi[i] == 'a' || nimi[i] == 'A')
            {
                loendur++;
            }
        }

        return loendur;
    }


    //Ülesanne 4

    static string jalgsiKõndimine(double kaugus)
    {
        if (kaugus < 0)
        {
            return "Vigane sisend";
        }
        else if (kaugus == 0)
        {
            return "Paigalseisuga tervist ei hoia";
        }
        else if (kaugus > 0 && kaugus <= 5)
        {
            return "Tubli tulemus, kontorirotid tavaliselt nii palju ei liigu";
        }
        else if (kaugus > 5 && kaugus <= 10)
        {
            return "pool linna kõnnib sellega maha";
        }
        else if (kaugus > 10 && kaugus <= 15)
        {
            return "Wow see võtab üksjagu aega";
        }
        else if (kaugus > 15)
        {
            return "ära kiirusta >_<!!!";
        }
        return "";

    }
}








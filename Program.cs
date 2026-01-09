

using Microsoft.Win32.SafeHandles;

namespace A_Valtna_LOGITge25
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //int palk = 2345;
            //int kulud = 1122;

            //Console.WriteLine("Kas see kuu kulusid või väljaminekuid oli? (jah/ei)");
            //string kasutajaVastus = "";
            //kasutajaVastus = Console.ReadLine();
            //if (kasutajaVastus == "jah") {
            //    Console.WriteLine ("Sisesta kõik kulutused ühe arvuna\");
            //    kulud = int.Parse (Console.ReadLine()); 
            //}

            //int kontojääk = palk - kulud;
            //Console.WriteLine(kontojääk + " puulehte on alles."); //print (kontojääk + " puulehte on alles")
            //int bonus = int.Parse(Console.ReadLine()); // boonus = int(intput"(Palun sisesta oma hästi tehtud töö boonus:"))
            //kontojääk = kontojääk + bonus; // sane python
            //Console.WriteLine("Sinu lõppväljavõte on: " + kontojääk+" puulehte"); 


            /*
             näiteprogramm 3:
            klient tahab et programm teeks:
            - küsib kasutajalt tema kasutajaNime
            - küsib kasutajalt tema parooli
            - logib kasutaja sisse kui mõlemad on õiged
            */





            /*   -= L I H T A N D M E T Ü Ü B I D =-
                    }string tekst = "mingisugune inimloetav tekstike"; //tekst
                    char täht = 'A';
                    int arv = 1; //täisarv
                    float komakohagaarv = 1.5f; //32bit
                    double suuremkomakohagaarv = 1.5d; //64bit
                    decimal kümnendsüsteemiskomakohagaarv = 1.5M;
                    var x = 123; //Umbmäärase andmetüübiga ajutine muutuja
                    var y = "ABC";
                    bool jahvõiei = false; //kas true või false.
                    /**/
            //string string = "abc"; //is bäd
            //string sõne = "abc"; //is gud 

            ///*
            // * programm küsib kasutajalt tema vanust
            // * kui ta on noorem kui 18 öeldakse kasutajale "alaealisi sisse ei lasta"
            // * kui on vanem kui 18, pakutakse mojitot
            // */
            //int kasutajaVanus = 0;
            //Console.WriteLine("Kui vana sa oled?");
            //kasutajaVanus = int.Parse(Console.ReadLine());
            //if (kasutajaVanus > 18)
            //{
            //    Console.WriteLine("Tere, siin on sinu mojito");
            //}


            //else

            //    Console.WriteLine("Alaealisi sisse ei lasta, mine vembutembumaale.");
            //string kasutajaNimi = "";

            /*
             näiteprogramm 3:
            klient tahab et programm teeks:
            - küsib kasutajalt tema kasutajaNime
            - küsib kasutajalt tema parooli
            - logib kasutaja sisse kui mõlemad on õiged
            */
            //Console.WriteLine("Palun sisesta oma kasutajanimi");
            //kasutajaNimi = Console.ReadLine();

            //Console.WriteLine("Palun sisesta oma parool");
            //string kasutajaParool = Console.ReadLine();

            //if (kasutajaNimi == "user1" && kasutajaParool == "qwerty")
            //{
            //    Console.WriteLine("Tere tulemast " + kasutajaNimi + ", olete edukalt sisseloginud.");
            //}
            //else
            //{
            //    Console.WriteLine("Kasutajanimi või parool ei ole õige, sissepääs keelatud");
            //}

            //Console.ReadKey();

            //    int mingiArv = 4;
            //mingiArv = mingiArv + 15;

            //    mingiArv += 15;

            //    mingiArv *=15;

            //    mingiArv -= 15;

            //    mingiArv /= 15;

            //    /* näiteülesanne 4 */
            //    Console.WriteLine("Palun sisesta om vanus");
            //    int kasutajavanus = int.Parse(Console.ReadLine());
            //Console.WriteLine("Palun sisesta oma vanavanaema vanus");
            //    int kasutajaVanavanaemaVanus = int.Parse(Console.ReadLine());
            //int vanusteVahe = kasutajaVanavanaemaVanus - kasutajavanus;
            //Console.WriteLine(kasutajaVanavanaemaVanus - kasutajavanus);
            //    Console.WriteLine("Kas oled nüüd vanem?");
            //    kasutajavanus += int.Parse(Console.ReadLine());
            //Console.WriteLine("vanuste vahe nüüd:  "+(kasutajaVanavanaemaVanus - kasutajavanus));

            ///*   -= O M I S T U S O P E R A A T O R I D =-       */
            //// =  - üksik võrdusmärk omistab muutja sisse väärtuse, mida adresseeritakse muutjua enda nimega
            //int muutuja = 1;
            //// += - võrdusmärk mille ees on pluss, automaatselt liidab muutujale otsa võrdusmärgi teisel pool oleva väärtuse
            //muutuja += 2;
            //// -= - võrdusmärk mille ees on miinus, automaatselt lahutab muutujale otsa võrdusmärgi teisel pool oleva väärtuse
            //muutuja -= 1;
            //// võrdusmärk mille ees on korrutusmärk, automaatselt korrutab muutujale otsa võrdusmärgi teisel pool oleva väärtuse kordi
            //muutuja *= 3;
            //// /= - võrdusmärk, mille ees on jagamismärk, automaatselt jagab muutuja sisu võrdusmärgi teisel pool oleva värtuse osadeks
            //muutuja /= 4;
            //// %= - võrdusmärk mille ees on modulus, automaatselt jätab muutuja jäägi.
            //muutuja %= 2;

            ////++ - on kiirtehe, mis muutjate liidab ainult ühe juurde.
            //muutuja++;
            //// -- - on kiirtehe, mis muutjast lahutab ainult ühe maha.
            //muutuja--;

            /* näiteülesanne 5 */

            //Console.WriteLine("Kui kaugele oli su viimane kuulitõuge (m)?");
            //float kaugus = float.Parse(Console.ReadLine());
            //if ( kaugus <= 1.00 && kaugus >= 0.00 )
            //{
            //    Console.WriteLine("Sa suudad kindlasti rohkem, cmon bruh");
            //}
            //else if (kaugus <= 2.00 || kaugus >=1.01)
            //{
            //    Console.WriteLine("Noh tuleb juba, jõuad veel!");
            //}
            //else if (kaugus <= 3.00 && kaugus >= 2.01 )
            //{
            //    Console.WriteLine("TUBLI kolm meetrit umbes, peaaegu, vist... not sure");
            //}
            //else if (kaugus < 0)
            //{
            //    Console.WriteLine("MIKS SA TAGURPIDI VISKAD?!?!");
            //}
            //else
            //{

              
            // Console.WriteLine("Ossaraks, seda on varsti orbiidilt näha");
            //}

            ///*   -= V Õ R D L U S O P E R A A T O R I D =-       */
            // == - on täpselt sama Võrdusmärkide ühel pool olev objekt peab vastama oma olemuselt täpselt võrdusmärkide teisel pool oleva objektiga
            // > - on suurem kui - Märgist vasakul pool olev objekt peaks olema suurem kui paremal pool olev objekt
            // < - on väiksem kui - Märgist vasakul pool olev objekt peaks olema väiksem kui paremal pool olev objekt
            // >= on suurem kui, või samavõrdne - Märgist vasakul pool olev objekt peaks olema vähemalt sama suur või suurem
            // <= - on väiksem kui või samavõrdne - Märgist vasakul pool olev objekt peaks olema maksimaalselt sama suur või väiksem
            // ! = - ei tohi olla võrdusmärgi vasakul pool olev objekt ei tohi omada IDENTSET kuju paremal pool oleva objektiga, kõik muud väärtused on lubatud
            
            /* -= LOOGILISED TEHTED =- */
            // && AND loogiline tehe, mida kasutatakse tingimuste kirjeldamisel, ning mis annab positiivse vastuse TRUE juhul kui mõlemal pool märki && olevad tingimused omakorda annavad oma avalduse TRUE või teisisõnu: TRUE + TRUE = TRUE
            // - OR loogiline tehe, mida kasutatakse tingimuste kirjeldamisel, ning mis annab positiivse vastuse TRUE juhul kui ühel pool märki || olev tingimus annab oma avaldise tulemusena TRUE ei ole vahet millisel pool märki või teisisõnu: TRUE + FALSE = TRUE
            // ! - NOT  loogiline tehe, mida kasutab tingimuse avaldise tulemuse inverteerimiseks. Tulemus mis on muidu tagstaks TRUE, hüüumärgi abil nüüd tagastab false, ja vastupidi - tulemus mis muidu tagastaks false , nüüd tagastab TRUE ehk teisisõnu

            

        }
    }
}










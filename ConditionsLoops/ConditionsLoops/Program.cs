using System;

namespace ConditionsLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;

            //Tehtävä 3, tein suoraan yhteen. Konsoli pyytää numeroa ja tallentaa annetun luvun muuttujaan. 
            Console.WriteLine("Please input number:");
            number = int.Parse(Console.ReadLine());
            
            //Katsastelee lukua funktion avulla
            CheckNum(number);
        }

        //Funktio annetun luvun tarkastelua varten.
        static void CheckNum(int number_given)
        {
            //Luodaan tarvittavat muuttujat
            int number = number_given;
            string odd_even = "N/A";
            string pos_neg = "N/A";
            string result = "N/A";

            //Tarkistetaan, onko luku positiivinen vai negatiivinen. Jos nolla, annetaan tulos suoraan.
            if (number == 0)
            {
                result = "Luku on nolla";

            } else if (number > 0)
            {
                pos_neg = "positiivinen";
            } else
            {
                pos_neg = "negatiivinen";
            }

            //Tarkistetaan, onko luku kahdella tasan jaollinen, eli parillinen. 
            if (number % 2 == 0)
            {
                odd_even = "parillinen";
            } else
            {
                odd_even = "pariton";
            }

            //Kasataan tulokset yhteen, jos tulos annettu aikaisemmin (eli nolla) hypätään yli.
            if (result == "N/A")
            {
                result = "Luku on " + pos_neg + " ja " + odd_even + ".";
            }

            //Kirjoittaa konsoliin vastauksen
            Console.WriteLine(result);

        }
    }
}

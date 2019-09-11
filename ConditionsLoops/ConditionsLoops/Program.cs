using System;

namespace ConditionsLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int number1;
            int number2;
            int number3;

            //Tehtävä 3, tein suoraan yhteen. Konsoli pyytää numeroa ja tallentaa annetun luvun muuttujaan. 
            Console.WriteLine("Please input number:");
            number = int.Parse(Console.ReadLine());
            
            //Katsastelee lukua funktion avulla.
            CheckNum(number);

            //Tehtävä 4, konsoli pyytää järjesteltävät luvut yksi kerrallaan.
            Console.WriteLine("Please input the first number;");
            number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please input the second number;");
            number2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please input the third number;");
            number3 = int.Parse(Console.ReadLine());

            //Järjestellään luvut funktion avulla.
            OrderNumbers(number1, number2, number3);
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
                result = "The number is zero";

            } else if (number > 0)
            {
                pos_neg = "positive";
            } else
            {
                pos_neg = "negative";
            }

            //Tarkistetaan, onko luku kahdella tasan jaollinen, eli parillinen. 
            if (number % 2 == 0)
            {
                odd_even = "even";
            } else
            {
                odd_even = "odd";
            }

            //Kasataan tulokset yhteen, jos tulos annettu aikaisemmin (eli nolla) hypätään yli.
            if (result == "N/A")
            {
                result = "Your number is " + pos_neg + " and " + odd_even + ".";
            }

            //Tulosetetaan vastaus.
            Console.WriteLine();
            Console.WriteLine(result);
            Console.WriteLine();
        }

        //Funktio numerojen järjestelyä varten.
        static void OrderNumbers(int a, int b, int c)
        {
            //Luodaan käytetyt muuttujat: 1 on pienin, 3 suurin ja 2 siitä väliltä.
            int num1;
            int num2;
            int num3;

            //Etsitään ensin suurin numero muuttujien joukosta vertaamalla niitä toisiinsa.
            if (a > b && a > c)
            {
                num3 = a;
            } else if ( b > a && b > c)
            {
                num3 = b;
            } else
            {
                num3 = c;
            }

            //Etsitään pienin vertaamalla lukuja toisiinsa.
            if (a < b && a < c)
            {
                num1 = a;
            } else if (b < a && b < c)
            {
                num1 = b;
            } else
            {
                num1 = c;
            }

            //Etsitään väliluku tarkastelemalla jo arvioituja lukuja:
            //Jos luvut 1 ja 3 ovat luvut b ja c, on luvun 2 oltava a, jne.
            if (num1 == b && num3 == c || num3 == b && num1 == c)
            {
                num2 = a;
            } else if (num1 == a && num3 == c || num3 == a && num1 == c)
            {
                num2 = b;
            } else
            {
                num2 = c;
            }

            //Tulostetaan luvut suuruusjärjestyksessä.
            Console.WriteLine();
            Console.WriteLine("Your inputted numbers in ascending order:");
            Console.WriteLine(num1 + ", " + num2 + ", " + num3 + ".");
        }
    }
}

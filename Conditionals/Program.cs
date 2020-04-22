using System;

namespace Conditionals
    {
    class Program
        {
        static void Main(string[] args)
            {
            var number = 11;
            if (number == 10)
                {
                Console.WriteLine("Number is 10");
                }
            else
                {
                Console.WriteLine("Number is not 10\n");
                }

            // Single Line If Sample

            var pay = 30;
            Console.WriteLine(pay == 30 ? "Number is 30" : "Number is not 30\n");       // eşitlik Koşulu "True" ise ?  -  Koşul "False" ise :  tarafı çalışır!.     

            // IF ELSE Sample

            var cost = 50;
            if (cost == 50)
                {
                Console.WriteLine("\nNumber is 50");
                }
            else if (cost == 60)
                {
                Console.WriteLine("\nNumber is not 60");
                }
            else
                {
                Console.WriteLine("\nNumber is not 50 OR 60");
                }

            // Switch Block example

            var block = 20;
            switch (block)
                {
                case 15:
                    Console.WriteLine("\nNumber is 15");
                    break;
                case 20:
                    Console.WriteLine("\nNumber is 20");
                    break;
                default:
                    Console.WriteLine("\nNumber is not 15 OR 20");
                    break;
                }

            // Example for Multiple Condition (Çoklu Koşul Örneği) (Şart Sınırlarının DOĞRU tasarlanması!)

            var price = 201;
            if (price >= 0 && price <= 100)               //   >= 0 (Sıfıra eşit ya da büyük ise...  "<= 100" (100 e eşit ya da küçük ise anlamına gelir.)
                {
                Console.WriteLine("\nSayı 0-100 arasında.");
                }
            else if (price > 100 && price <= 200)         // Çift Ampersand  &&  işareti VE anlamına gelir.
                {
                Console.WriteLine("\nSayı 101-200 arasında.");
                }
            else if (price > 200 || price < 0)            // Çift Pipe ||  işareti VEYA anlamına gelir.
                {
                Console.WriteLine("\nSayı 0'dan küçük veya 200'den büyük.");
                }

            Console.ReadLine();
            }
        }
    }

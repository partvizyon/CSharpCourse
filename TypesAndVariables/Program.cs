using System;

namespace TypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            // Value Data Types (Veri Tipleri)

            // Console.WriteLine("Hello Earth");
            // 4. Kuşak Programlama dillerinde Index (Index ler Sıfırdan başlar!)


            int number1 = 10;                               // (32 bit) 'int' alabileceği tamsayı sınırı: -2147483648 ile 2147483647 arası TAM SAYILAR'dır!

            long number2 = 20;                              // (64 bit) 'long' alabileceği tamsayı sınırı: -9223372036854775808 ile 9223372036854775807 arası TAM SAYILAR'dır!

            short number3 = 30;                             // (16 bit) 'short' alabileceği tamsayı sınırı: -32768 ile 32768 arası TAM SAYILAR'dır!

            byte number4 = 40;                              // (8 bit) 'byte' alabileceği tamsayı sınırı: 0 ile 255 arası DOĞAL SAYILAR'dır!

            double number5 = 10.4;                          // (64 bit) 'double' alabileceği değerler: -1.7976931348623157E+308 ile 1.7976931348623157E+308;

            decimal number6 = 10.2m;                        // 'int' ve 'long' -> 'double' ve 'desimal' ilişkisi aynıdır. Min -79228162514264337593543950335M ile 79228162514264337593543950335M.                                                      Parasal vb değerler için virgülden sonra  29 haneli sayı tutabilir. Sayının sonuna M  harfi eklenir!
                                                            
            char character = 'A';                           // ASCII  karakter setinin sayısal değerlerini alır       alabileceği Max Value : '\uffff'      MinValue = '\0' 

            bool condition = false;                         // (1 bit) "boolean" alabileceği değer (true) 1 yada (false) 0'dır!

            var number7 = 60;                               // var değişkenine atanan ilk değer ne ise o tipi saklar! int -> int devam eder. number7 ye sonra char atanamaz!

            Console.WriteLine("Number1 is {0}", number1);   // Print komutunun index ile yazdırılmasına örnek!
            Console.WriteLine("\nNumber2 is {0}", number2);
            Console.WriteLine("\nNumber3 is {0}", number3);
            Console.WriteLine("\nNumber4 is {0}", number4);
            Console.WriteLine("\nNumber5 is {0}", number5);
            Console.WriteLine("\nNumber6 is {0}", number6);
            Console.WriteLine("\nNumber7 is {0}", number7);
            Console.WriteLine("\nCondition Type is {0}", condition + " kinda like; -Yes- OR -No- ");
            Console.WriteLine("\nCharacter is {0}", character);

            Console.WriteLine("\nCharacter ASCII value is {0}", (int)character);  //  Tip Dönüşümüne ÖRNEK!

            Console.WriteLine("\n" + (int)Days.Cuma);  //  enum veri tipinde sabitler Sıfır'dan başlar Fakat sabitlere =1 gibi sıra atanabilir!

            Console.ReadLine();         // Bu komut C programlamadaki <conio.h> kutuphanesi ile kullanılan getch(); komutu gibi - bir tuşa basmanızı bekler ve ondan sonra programı sonlandırır!
        }

        // enum  veri tipleri
        enum Days
            {
            Pazartesi=1, Salı, Çarşamba, Perşembe, Cuma, Cumartesi, Pazar
            }
        }
}

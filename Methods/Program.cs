using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
    {
    class Program
        {
        static void Main(string[] args)
            {
            Add();
            Add();
            Add();
            var result = Add2(20,10);   // İkinci parametre olan 10 burada girilmezse 26. satırdaki 2. parametre DEFAULT olarak işlem görür!
            Console.WriteLine(result);
            Console.ReadLine();
            }

        static void Add()
            {
            Console.WriteLine("Eklendi!");
            }

        static int Add2(int number1, int number2=70) // Defaılt değerler her zaman son parametrede olmalıdır! (Bu Örnekte son parametre number2)
            {
            var result = number1 + number2;
            return result;
            }

        }
    }

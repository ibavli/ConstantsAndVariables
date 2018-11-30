using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "message";
            string message2 = "message2";

            Console.WriteLine(message);
            Console.WriteLine(message2);

            //message değişkeni metoda ref parametresi ile gönderildiği için değeri değişti
            WriteMessage(ref message, message2);

            Console.WriteLine(message);
            Console.WriteLine(message2);
            Console.ReadLine();
        }

        private static void WriteMessage(ref string message, string message2)
        {
            message = "message metot tarafından değiştildi";
            message2 = "message2 metot tarafından değiştildi";
        }
    }
}

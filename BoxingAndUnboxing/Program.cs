using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingAndUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            //Boxing : Değer türünden bir değişkeni referans türünden bir değişkene aktarmaktadır. Unboxing ise bunun tam tersi, yani referans türünden bir değşikeni değer türünden bir değişkene aktarmaktır.  

            #region Boxing İşlemi

            string message;
            object boxing;

            message = "message";
            boxing = message;

            Console.WriteLine("message  => " + message);
            Console.WriteLine("object   => " + boxing);

            message = "new message";
            Console.WriteLine("message  => " + message);
            Console.WriteLine("object   => " + boxing);

            #endregion

            Console.WriteLine("---");

            #region Unboxing İşlemi

            string message2 = null;
            object boxing2 = null;

            message2 = "message2";
            boxing2 = message2;

            Console.WriteLine("message2  => " + message2);
            Console.WriteLine("boxing2   => " + boxing2);

            message2 = "new message2";

            Console.WriteLine("message2  => " + message2);
            Console.WriteLine("boxing2   => " + boxing2);

            string newMessage = (string)boxing2;
            Console.WriteLine("newMessage => " + newMessage);

            #endregion

            Console.ReadLine();
        }
    }
}

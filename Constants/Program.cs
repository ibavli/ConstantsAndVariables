using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constants
{
    class Program
    {
        public static readonly string sentence = "readonly'ye çalışma zamanında değer atanabilir.";
        public static readonly DateTime datetime = DateTime.Now;



        //Çalışma zamanında değer aktarımı yapılamaz. Ancak derleme zamanında yapılabilir.
        const DateTime datetime2 = DateTime.Now;
        const string sentence2 = "const'a çalışma zamanında değer atanamaz!!!";



        static void Main(string[] args)
        {
            const int number = 45;//Tanımladığımız yerde değer atamak zorundayız.
            const int number2 = number;//Başka bir değeri atayabiliriz.

            //const'ta bu aşağıdaki gibi bir kullanım yoktur. Tanımlandığı anda değer ataması yapılmak zorunda.
            //const int number3;
            //sayi3 = 15;

            Console.WriteLine(number.ToString());
            Console.WriteLine(number2.ToString());

            Console.WriteLine("-----");

            Console.WriteLine(sentence);
            Console.WriteLine(datetime.ToString());
            Console.WriteLine(sentence2);


            Console.ReadLine();
        }
    }
}

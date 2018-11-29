using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        /*
            İsimlendirme biçimleri
            Pascal Case = ForeColor, MessageBox, ReadLine
            Camel Case = foreColor, messageBox, readLine
            Uppar Case = System.IO, System.Web.UI
        */


        /*
            Değişkenler ikiye ayrılı; 
            1 ) DEĞER TİPİ
            2 ) REFERANS TİPİ
            olarak ikiye ayrılır. Değer tipi değişkenler bellekte stack adı verilen alanlarda saklanırken, referans tipi değişkenler ise heap adı verilen alanlarda saklanır.

            Stack içerisinde saklanacak verinin boyutu bilinmelidir.
            Heap içerisinde saklanacak verinin boyutu ise, dinamik olarak belirlenip, çalışma zamanında kullanıma göre belirlenir.

            Heap bölgesi, stack bölgesine göre daha büyük boyuttaki verileri saklayabilir.

            Stack içerisinde saklanan değişkenlerin kullanımı bittikten sonra otomatik olarak bellekten düşer. Heap içerisinde tanımlanan değişkenlerin kullanımı bittikten sonra garbage collector yardımı bile bellekten düşer.

            Heap içerisinde gerçekleşen işlemler, stack içerisindeki gerçekleşen işlemlere göre daha yavaş gerçekleşir.

            Referans tipi değişkenlerde değişkenin değeri heap içerisinde, heap içerisinde saklanan bu değere erişim için kullanılan referans hafıza adresi ise stack bölümünde saklanır. Örneğin; string değişken tipi referans türde bir değişkendir.


            string x = "test";

            x => stack içerisinde test kelimesinin hafıza adresi,
            test => bu değer kadar alan heap içerisinde ayrıldı
             

            DEĞER TİPLERİ
            sbyte	
            byte	
            short	
            ushort	
            int
            uint	
            long	
            ulong	
            float
            double
            decimal
            bool
            char

            REFERANS TİPLERİ
            string
            object
            dynamic



            DEĞİŞKENLERİN VARSAYILAN DEĞERLERİ
            bool false
            byte 0
            char '\0'
            decimal 0.0M
            double 0.0D
            float 0.0F
            int 0
            long 0L
            sbyte 0
            short 0
            uint 0
            ulong 0
            ushort 0
            string Null
            */
        static void Main(string[] args)
        {
            ////Object ve dynamic arasındaki fark
            //object number = 10;
            //Console.WriteLine(number.GetType());
            //Console.ReadKey();
            ////Ekrana System.Int32 yazdı


            //dynamic number2 = 10;
            //Console.WriteLine(number2.GetType());
            //Console.ReadKey();
            ////Ekrana System.Int32 yazdı


            object number3 = 10;
            //Bu aşağıdakinde hata verdi
            //number3 = number3 + 10;
            //Bu aşağıdaki gibi yazınca çalıştı
            number3 = (int)number3 + 10;

            Console.WriteLine(number3.ToString());
            Console.WriteLine(number3.GetType());


            dynamic number4 = 5;
            number4 = number4 + 15;
            Console.WriteLine(number4.ToString());
            Console.WriteLine(number4.GetType());


            Console.ReadLine();
        }
    }
}

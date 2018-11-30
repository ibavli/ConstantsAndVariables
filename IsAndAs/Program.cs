using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsAndAs
{
    class Program
    {
        static void Main(string[] args)
        {
            Object _object = 12;
            Customer customer = null;

            //Is operatörü cast işlemi ile dönüşüm yapılacak değişken tiplerini kontrol eder. Kontrol sonrasında geriye bool bir değer döndürür.
            //Burada Deger değişkeninin tipi is operatörü ile kontrol edilmektedir. Eğer sonuc true olursa cast işlemi yapılacaktır. Bu sadeye Exception hatasının önüne geçilmiş olunacaktır.
            if (_object is Customer)
                customer = (Customer)_object;



            //As operatörü ise is operatörü ile benzer bir şekilde çalışmaktadır. Arasındaki fark, is operatörü kontrol ile bool bir değer döndürürken as operatörü ilgili tipin referansını döndürmektedir. Eğer yapılan cast işlemi hatalı ise null değerini döndürmektedir.

            Customer customer2 = new Customer();
            customer2.Name = "Ali";
            customer2.Surname = "Veli";


            Object Obj = customer2 as Customer;

            if (Obj != null)
                Console.WriteLine("Çeviri başarılı.");
            else
                Console.WriteLine("Çeviri başarısız.");


            Console.ReadLine();
        }

        public class Customer
        {
            public string Name { get; set; }
            public string Surname { get; set; }

        }


    }
}

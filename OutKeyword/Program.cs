using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            int w;
            //out'ta en başta değer atanmasa da olur.
            OutDegistir(out w);
            Console.WriteLine("w => " + w.ToString());


            bool islemSonucu;
            Donustur("4c", out islemSonucu);
            Console.WriteLine(islemSonucu.ToString());

            Console.ReadLine();
        }

        private static void OutDegistir(out int w)
        {
            w = 10;
        }

        private static int Donustur(string sayi, out bool islemSonucu)
        {
            try
            {
                int donusturulen = Convert.ToInt32(sayi);
                islemSonucu = true;
                return donusturulen;
            }
            catch
            {
                islemSonucu = false;
                return 0;
            }
        }

    }
}

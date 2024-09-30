using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratik3
{
    //Pratik3 If / Else
    internal class Program
    {
        static void Main(string[] args)
        {
            int num=0;
            string numDurum = "a Esittir";
            Console.Write("Lütfen bir sayı Giriniz:");
            int.TryParse(Console.ReadLine(),out num);
            if (num != 10)//Sayı eşit ise iki kontrol yapmaya gerek olmasın diye esiitlik bakıyoruz
            {
                numDurum = num > 10 ? "dan Büyüktür" : "dan Küçüktür";//  if else tanımı yerine kontrol edip degerin türünü alıyoruz
            }
            Console.WriteLine($"Girilen sayı 10'{numDurum} ");//Sayının şuanki durumunu yazıyoruz
            numDurum = num%2==0 ? "çifttir" : "tektir";//sayının hangi durumda oldugunu büyük,kücük,esitlik tekrar degiştiriyiroz ve  tek çift yapıyoruz
            Console.WriteLine($"Girilen sayı {numDurum}");

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratik4
{
    internal class Program
    {
        //Pratik 4  If / Else ve Switch-Case
        static void Main(string[] args)
        {
            //Kullanım olarak switch case daha dogru bir yaklasim daha okunabilir if else yapısına göre

            int apple = 2;
            int pine = 3;
            int straw = 2;
            int banana = 3;
            int other = 4;

            Console.WriteLine("Rüya Manavına Hoşgeldiniz");
            Console.WriteLine($"Elma={apple}");
            Console.WriteLine($"Armut={pine}");
            Console.WriteLine($"Çilek={straw}");
            Console.WriteLine($"Muz={banana}");
            Console.WriteLine($"Diger bütün meyveler={other}");
            Console.WriteLine();
            Console.Write("Hangi meyveyi satın almak istersiniz? (Elma/Armut/Çilek/Muz/Diger):");

            string currentFruits=Console.ReadLine().ToLower();//Kullanıcıdan aldıgımız meyveyi direkmen küçük harfelere çeviriyoruz

            int currentFruitsPrice= other;// ilk deger  olarak diger meyvelerin parasını temsil ediyoruz ve ifelse yapısına eklemiyoruz

            if(currentFruits=="elma")
            {
                currentFruitsPrice = apple;
            }
            else if (currentFruits == "armut")
            {
                currentFruitsPrice = pine;
            }
            else if (currentFruits == "çilek")
            {
                currentFruitsPrice = straw;
            }
            else if (currentFruits == "muz")
            {
                currentFruitsPrice = banana;
            }
            Console.WriteLine($"Seçtiginiz meyvenin fiyatı:{currentFruitsPrice} TL");//Degeri if içinde olamdan yazdırıyoruz
            Console.ReadLine();
            //Switch Case version 
            Console.WriteLine("Switch Version");
            switch (currentFruits)//if else yapısının switch yapısı olarak tekrar yazılışı
            {
                case "elma":
                {
                        currentFruitsPrice = apple;
                        break;
                }
                case "armut":
                {
                        currentFruitsPrice = pine;
                        break;
                }
                case "çilek":
                {
                        currentFruitsPrice = straw;
                        break;
                }
                case "muz":
                {
                        currentFruitsPrice = banana;
                        break;
                }
                default://son atamayı other yapıyoruz
                { 
                        currentFruitsPrice =other ;
                        break;
                }

            }
            Console.WriteLine($"Seçtiginiz meyvenin fiyatı:{currentFruitsPrice} TL");

            Console.ReadLine();

        }

    }
}

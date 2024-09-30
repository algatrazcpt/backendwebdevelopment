using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratik2
{
    //Pratik2 - Değişkenler ile Uygulama
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //Degisken tanımlamaları ve atamaları yapıldı
            Int64 tcNo=1;
            string name="";
            string surname="";
            Int64 tel = 1;
            byte age=0;
            double price1=0;
            double price2=0;

            Console.WriteLine("Aşagıda istene bilgileri giriniz");
            Console.Write("Tc Kimlik Numarası:");
            //Hata olmaması için tryparse ile çevirme yapıldı degiskenler
            Int64.TryParse(Console.ReadLine(), out tcNo);
            Console.Write("Ad:");
            name= Console.ReadLine();
            Console.Write("Soyad:");
            surname = Console.ReadLine();
            Console.Write("Telefon:");
            Int64.TryParse(Console.ReadLine(), out tel);
            Console.Write("Yas:");
            byte.TryParse(Console.ReadLine(), out age);
            Console.Write("İlk aldıgınız ürün fiyatı:");
            double.TryParse(Console.ReadLine(),out price1);
            Console.Write("İkinci aldıgınız ürün fiyatı:");
            double.TryParse(Console.ReadLine(), out price2);
            Console.WriteLine("----------------------------------------");
            //Kolay yazım için $ ile metne eklenmiştir degiskenler
            Console.WriteLine($"{tcNo} Tc numarılı {name} {surname} isimli kişi için kayıt oluşturulmuştur.");
            Console.WriteLine($"{tel} telefon numarasına bildirim mesajı gönderilmiştir.");
            double priceSum=  price1 + price2;
            Console.WriteLine($"{priceSum} toplam harcama karşılığı kazanılan %10 patika puan miktarı -> {priceSum * 0.10} TL'dir.");


            Console.ReadKey();
            
        }
    }
}

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
            Int64 tcNo=1;//gelecek veri boyutu yüksek ama ondaklı olmayacagı icin kullanıldı
            string name="";
            string surname="";
            Int64 tel = 1;
            byte age=0;//Gelebilecek veri boyutu düsük oldugu icin
            double price1=0;//gelecek veri boyutu yüksek ve ondalıklı olabilecegi icin kullanıldı
            double price2=0;

            Console.WriteLine("Lütfen asagıdaki bilgileri giriniz");
            Console.Write("Tc Kimlik Numarası:");
            //Hata olmaması için tryparse ile çevirme yapıldı degiskenler
            Int64.TryParse(Console.ReadLine(), out tcNo);
            Console.Write("Adı:");
            name= Console.ReadLine();
            Console.Write("Soyadı:");
            surname = Console.ReadLine();
            Console.Write("Telefon numarası:");
            Int64.TryParse(Console.ReadLine(), out tel);
            Console.Write("Yas:");
            byte.TryParse(Console.ReadLine(), out age);
            Console.Write("İlk aldıgı ürünün fiyatı:");
            double.TryParse(Console.ReadLine(),out price1);
            Console.Write("İkinci aldıgı ürünün fiyatı:");
            double.TryParse(Console.ReadLine(), out price2);
            Console.WriteLine("----------------------------------------");

            //Kolay yazım için $ ile metne eklenmiştir degiskenler
            Console.WriteLine($"{tcNo} Tc numarılı {name} {surname} isimli kişi için kayıt olusturulmustur.");
            Console.WriteLine($"{tel} telefon numarasına bildirim mesajı gönderilmistir.");
            double priceSum=  price1 + price2;
            Console.WriteLine($"{priceSum} toplam harcama karsılıgı kazanılan %10 patika puan miktarı -> {priceSum * 0.10} TL'dir.");


            Console.ReadKey();
            
        }
    }
}

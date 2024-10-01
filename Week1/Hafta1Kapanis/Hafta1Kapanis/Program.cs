using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta1Kapanis
{
    internal class Program
    { 

        //Hafta1 Kapanis





        //Enum tipi içerde tanımlanmadıgı için main dışında tanımladım
        enum days
        {
            pazartesi=1,
            salı = 2,
            çarşamba = 3,
            perşembbe = 4,
            cuma = 5,
            cumartesi = 6,
            pazar = 7,
            gecersizgün=0
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1.) Konsola \"Merhaba Dünya\" yazdıran bir program yazın.");
                Console.WriteLine("2.) Kullanıcıdan iki tam sayı alın ve bu sayıların toplamını konsola yazdırın.");
                Console.WriteLine("3.) Kullanıcıdan yaşını isteyin. Eğer yaş 18 veya daha büyükse \"Yetişkinsiniz\" yazdırın, aksi takdirde \"Çocuksunuz\" yazdırın.");
                Console.WriteLine("4.) Kullanıcıdan bir tam sayı alın. Eğer sayı çift ise \"Çift sayıdır\" yazdırın, tek ise \"Tek sayıdır\" yazdırın.");
                Console.WriteLine("5.) Kullanıcıdan bir sıcaklık değeri alın (Celsius cinsinden). Eğer sıcaklık 0'dan küçükse \"Donuyor\", 0 ile 30 arasında ise \"Normal\", 30'dan büyükse \"Sıcak\" yazdırın.");
                Console.WriteLine("6.) Kullanıcıdan 1 ile 7 arasında bir sayı alın. Bu sayı günlerden birini temsil ediyor. Sayıya göre \"Pazartesi\", \"Salı\", vb. gün adlarını yazdırın. Geçersiz bir sayı girildiğinde \"Geçersiz gün\" yazdırın.");
                Console.WriteLine("7.) Kullanıcıdan bir not (0-100 arasında) alın. Notun aralığına göre \"Başarılı\", \"Orta\", \"Başarısız\" yazdırın. (0-60 başarısız, 61-80 orta, 81-100 başarılı)");
                Console.WriteLine("8.) Kullanıcıdan bir ay numarası (1-12) alın ve bu ayın kaç gün olduğunu yazdırın. Şubat ayı için 28 gün, diğer aylar için gün sayısını kontrol edin.");
                Console.WriteLine("9.) Kullanıcıdan bir şifre isteyin. Eğer şifre \"12345\" ise \"Giriş Başarılı\" yazdırın, değilse \"Giriş Başarısız\" yazdırın.");
                Console.WriteLine("10.) Kullanıcıdan iki sayı ve bir işlem (+, -, *, /) alın. Seçilen işleme göre sonucu hesaplayın ve yazdırın. Eğer geçersiz bir işlem girilirse \"Geçersiz işlem\" yazdırın.");

                Console.Write("Belirtilen soru numaralarından birini girin:");

                //Gelcek veri en fazla 10 oldugu  için byte ile aldım
                byte questId = byte.Parse(Console.ReadLine());

                switch (questId)
                {
                    case 1:
                        {
                            Console.WriteLine("1.) Konsola \"Merhaba Dünya\" yazdıran bir program yazın.");
                            Console.WriteLine("Hello World");
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("2.) Kullanıcıdan iki tam sayı alın ve bu sayıların toplamını konsola yazdırın.");
                            Console.Write("Birinci sayı:");
                            int num1 = int.Parse(Console.ReadLine());
                            Console.Write("İkinci sayı:");
                            int num2 = int.Parse(Console.ReadLine());
                            Console.WriteLine($"{num1}+{num2}={num1 + num2}");//sayıları uygun format için ayırdım
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("3.) Kullanıcıdan yaşını isteyin. Eğer yaş 18 veya daha büyükse \"Yetişkinsiniz\" yazdırın, aksi takdirde \"Çocuksunuz\" yazdırın.");
                            Console.Write("Yaşınız:");
                            Console.WriteLine(byte.Parse(Console.ReadLine()) >= 18 ? "Yetişkinsiniz" : "Çocuksunuz");//if else kullanımın alternatif olarak kullanımdım ?
                                                                                                                     //işaretinden sonra ilki dogru ikinci deger ise yanlışta çalışıyor

                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("4.) Kullanıcıdan bir tam sayı alın. Eğer sayı çift ise \"Çift sayıdır\" yazdırın, tek ise \"Tek sayıdır\" yazdırın.");
                            Console.Write("Sayınız:");
                            Console.WriteLine(int.Parse(Console.ReadLine()) % 2 == 0 ? "Çift" : "Tek");//if else kullanımın alternatif olarak kullanımdım ?
                                                                                                       //işaretinden sonra ilki dogru ikinci deger ise yanlışta çalışıyor
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("5.) Kullanıcıdan bir sıcaklık değeri alın (Celsius cinsinden). Eğer sıcaklık 0'dan küçükse \"Donuyor\", 0 ile 30 arasında ise \"Normal\", 30'dan büyükse \"Sıcak\" yazdırın.");
                            Console.Write("Sıcaklık(Celcius):");
                            float heat = float.Parse(Console.ReadLine());
                            string heatText = "Donuyor";//İlk deger olarak donuyor veriyor fazladan bir if  kullanımını kaldırıyorum
                            if (heat > 0)
                            {
                                heatText = heat > 31 ? "Sıcak" : "Normal";
                            }
                            Console.WriteLine($"{heatText}");
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("6.) Kullanıcıdan 1 ile 7 arasında bir sayı alın. Bu sayı günlerden birini temsil ediyor. Sayıya göre \"Pazartesi\", \"Salı\", vb. gün adlarını yazdırın. Geçersiz bir sayı girildiğinde \"Geçersiz gün\" yazdırın.");
                            Console.Write("Sayı Giriniz:");
                            byte currentDayNum = byte.Parse(Console.ReadLine());

                            currentDayNum = (currentDayNum < 8) && (currentDayNum > 0) ? currentDayNum : (byte)0;//sayının büğyük veya küçük olma durmunu kontrolediyorum
                                                                                                                 //degeri saglıyorsa kendisini kullanmasnı isteim
                                                                                                                 //byte(0)yazımında degisken int olarak gözüktügü için yaptım


                            string currentDayText = ((days)currentDayNum).ToString();//enums içindeki verilerin hepsinde sayılara eşitledim burda ise (int)(degisken)
                                                                                     //gibi kullanarak days tipine döüştürdüm çıktı int tipinde oldugu için stringe çevirdim ayırca

                            Console.WriteLine($"{currentDayText}");
                            break;
                        }
                    case 7:
                        {
                            Console.WriteLine("7.) Kullanıcıdan bir not (0-100 arasında) alın. Notun aralığına göre \"Başarılı\", \"Orta\", \"Başarısız\" yazdırın. (0-60 başarısız, 61-80 orta, 81-100 başarılı)");
                            Console.Write("Not Giriniz:");

                            byte point = byte.Parse(Console.ReadLine());
                            if (point >= 0 && point <= 100)
                            {

                                string notText = "Başarısız";//if kullanımı azaltmak için atamadan sonra ayırlıyorum

                                if (81 <= point)
                                {
                                    notText = "Başarılı";
                                }
                                else if (61 <= point)//else bilerek kullanmadım fazla bir tanımlama yapmama için
                                {
                                    notText = "Orta";
                                }
                                Console.WriteLine(notText);
                                break;
                            }
                            Console.WriteLine("Sayı(0-100) arısında degil");

                            break;
                        }
                    case 8:
                        {
                            Console.WriteLine("8.) Kullanıcıdan bir ay numarası (1-12) alın ve bu ayın kaç gün olduğunu yazdırın. Şubat ayı için 28 gün, diğer aylar için gün sayısını kontrol edin.");
                            Console.Write("Ay numarasını Giriniz:");
                            byte currentMont = byte.Parse(Console.ReadLine());
                            if ((currentMont >= 0 && currentMont <= 12))
                            {
                                byte currentMontİnDays = 28;
                                if (currentMont != 2)//şubat ayı degilse işleme giriyor
                                {
                                    currentMontİnDays = (byte)DateTime.DaysInMonth(2024, currentMont);//bu method belli yıldakı bir ayın içindeki günleri veriyor
                                }

                                Console.WriteLine($"{currentMontİnDays}");
                                break;// işleme girdiyse tekrardan aşagıya gitmemsi için ccase burdada bitiroyrum
                            }
                            Console.WriteLine("1-12 arasında degil sayı");

                            break;
                        }
                    case 9:
                        {
                            Console.WriteLine("9.) Kullanıcıdan bir şifre isteyin. Eğer şifre \"12345\" ise \"Giriş Başarılı\" yazdırın, değilse \"Giriş Başarısız\" yazdırın.");
                            Console.Write("Şifrenizi sadece sayılar:");
                            int password = int.Parse(Console.ReadLine());
                            Console.WriteLine(password == 12345 ? "Giriş Başarılı" : "Giriş Başarısız");

                            break;
                        }
                    case 10:
                        {
                            Console.WriteLine("10.) Kullanıcıdan iki sayı ve bir işlem (+, -, *, /) alın. Seçilen işleme göre sonucu hesaplayın ve yazdırın. Eğer geçersiz bir işlem girilirse \"Geçersiz işlem\" yazdırın.");
                            Console.Write("Sayi1:");
                            int num1 = int.Parse(Console.ReadLine());
                            Console.Write("Sayi1:");
                            int num2 = int.Parse(Console.ReadLine());
                            Console.Write("Bir işlem giriniz");
                            char progresstype = char.Parse(Console.ReadLine());
                            string progressText = "Gecersiz islem";
                            switch (progresstype)
                            {
                                case '+':
                                    {

                                        progressText = $"{num1} {progresstype} {num2} = {num1 + num2}";//Burdaki işlemde stringe verileri yerleştiriyiyorum "$" ile 
                                        break;
                                    }
                                case '-':
                                    {
                                        progressText = $"{num1} {progresstype} {num2} = {num1 - num2}";
                                        break;
                                    }
                                case '*':
                                    {
                                        progressText = $"{num1} {progresstype} {num2} = {num1 * num2}";
                                        break;
                                    }
                                case '/':
                                    {
                                        progressText = $"{num1} {progresstype} {num2} = {num1 / num2}";
                                        break;
                                    }
                                default:
                                    {
                                        progressText = "Gecersiz islem";
                                        break;
                                    }
                            }
                            Console.WriteLine(progressText);


                            break;
                        }
                
                }
                
                Console.WriteLine("------------------------------------------------------------------");
                Console.Write("Devam etmek için E çıkmak için H (E/H):");
                char exitKey= char.ToLower(char.Parse(Console.ReadLine()));
                if(exitKey=='h')
                {
                    break;
                }
                Console.Clear();//Consolu temizliyorum
            }
        }
    }
}

namespace Pratik4YolArkadasıTatiluygulaması
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string bodrumInfo = "Bodrum Kalesi, Antik Tiyatro, Turgutreis gidebilirsiniz";
            string marmarisInfo = "Marmaris Plajı, Marmaris Kalesi, İçmeler gidebilirsiniz";
            string cesmeInfo = "Çeşme Kalesi, Alaçatı, Ildır, Delikli Koy gidebilirsiniz";
            string playerCity;
            int people;
            int currentPayment;
            string currentInfo;
            char retryProgram;
            byte playerChoosenTransport;
            //DEgiskenleri her dönngüde oluşturmamak için dışarda tanımladım
            while (true)
            {
                //Her döngüde sıfırlardım tekarar çalışmada hata çıkmasın diye
                playerCity = "";
                people = 0;
                currentPayment = 0;
                currentInfo = "Sehir Bulunamadı (Bodrum/Marmaris/Cesme) bu şehirlerden birini seçiniz";
                while (true)//sonsuz döngü kullnarak istedigim degerler gelene kadar çalıştırıyorum
                {
                    Console.Clear();
                    Console.WriteLine("1 - Bodrum (Paket başlangıç fiyatı 4000 TL)");
                    Console.WriteLine("2 - Marmaris (Paket başlangıç fiyatı 3000 TL)");
                    Console.WriteLine("3 - Cesme (Paket başlangıç fiyatı 5000 TL)");
                    Console.Write("Hangi şehre gitmek istersiniz(Bodrum/Marmaris/Cesme):");
                    playerCity = Console.ReadLine().ToLower();

                    if (playerCity == "bodrum")
                    {
                        currentPayment = 4000;
                        currentInfo = bodrumInfo;//her seferinde console writeline yerine tek bir veriyi yazdıyorum
                        break;
                    }
                    else if (playerCity == "marmaris")
                    {
                        currentPayment = 3000;
                        currentInfo = marmarisInfo;
                        break;
                    }
                    else if (playerCity == "cesme")
                    {
                        currentPayment = 5000;
                        currentInfo = cesmeInfo;
                        break;
                    }
                    Console.WriteLine(currentInfo);

                }
                do//kişiyi her zaman girmesini beklliyorum
                {
                    Console.Write("Kişi Giriniz:");
                    if(int.TryParse(Console.ReadLine(), out people))//try parse ile hata olmasını önüne geçiyorum herhan gib bir hata döngü çalışmaz
                    {
                        if (people > 0)
                        {
                            break;
                        }
                    }
                }
                while (true);

                Console.WriteLine(currentInfo);
                Console.WriteLine("Tatile Ne şekilde Gitmek istersiniz:");
                Console.WriteLine("1 - Kara yolu(Kişi başı ulaşım tutarı gidiş - dönüş 1500 TL)");
                Console.WriteLine("2 - Hava yolu(Kişi başı ulaşım tutarı gidiş - dönüş 4000 TL)");
                playerChoosenTransport = 0;
                while (true)
                {
                    Console.Write("Ulaşım Yolu (1 veya 2) Giriniz:");
                    byte.TryParse(Console.ReadLine(),out playerChoosenTransport);
                    if (playerChoosenTransport == 1 || playerChoosenTransport == 2)//1 veya 2 degilse işleme almıyorum
                    {
                        currentPayment = playerChoosenTransport == 1 ? currentPayment + (1500 * people) : currentPayment + (4000 * people);// if else yazımı yerine kullandım
                                                                                                                                           //1500 hesaplayıpp kendisyle topluyorum 
                                                                                                                                           //diger adımda ise 4000 ile çarpıp topluyorum
                        Console.WriteLine($"{playerCity} varış noktanız toplam ücret {currentPayment}");
                        break;
                    }
                    Console.WriteLine(" Lütfen yukarıdaki seçeneklerden bir tanesini seçiniz diyerek cevabı kullanıcıdan");
                }
                Console.Write("Yeni rezervasyon istermisiniz E(evet)/ Çıkmak için 'E' dışında bir tuş:");
                char.TryParse(Console.ReadLine(),out retryProgram);
                if (Char.ToLower(retryProgram) != 'e')
                {
                    Console.WriteLine("iyi günler");
                    break;//ana program döngüsünü  bitiriyorum
                }
            }
        }
    }
}

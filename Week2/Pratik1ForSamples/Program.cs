namespace Pratik1ForSamples
{
    //Pratik1For samples 
    internal class Program
    {
        static void Main(string[] args)
        {
            for (bool loopAviable = true; loopAviable;)
            {
                //burda  for(degisken; kosul,degiskenIslemleri) seklindeki yapıyı ele alarak kosul degeri true veya false dönderir
                // kosul vermek zorunlu degil yani,aynı sekide bir artırma veya azaltmada gerekmiyor
                // kosul vermeyip true yaparak sonsuz döngü yaptık loopAviable degiskenini degeri degişince sonsuz döngümüzden çıkıyoruz
                //degisken ve koşulun sonucunun olması zorunlu içinde for(bool loopAviable=true;) şeklinde bir çalışma olmaz

                Console.WriteLine("1 -> Konsol ekranına 10 kere \"Kendime inanıyorum, ben bu yazılım işini hallederim!\" yazdırınız.");
                Console.WriteLine("2 -> 1 ile 20 arasındaki sayıları konsol ekranına yazdırınız.");
                Console.WriteLine("3 -> 1 ile 20 arasındaki çift sayıları konsol ekranına yazdırınız.");
                Console.WriteLine("4 -> 50 ile 150 arasındaki sayıların toplamını ekrana yazdırınız.");
                Console.WriteLine("5 -> 1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız.");
                Console.Write("Proje Numarası:");
                byte projectId = byte.Parse(Console.ReadLine());//switch case yapısı ile projeleri ayırıdım deger yüksek olmadıgı için byte yaptım


                switch (projectId)
                {
                    case 1:
                        {
                            Console.WriteLine("1 -> Konsol ekranına 10 kere \"Kendime inanıyorum, ben bu yazılım işini hallederim!\" yazdırınız.");

                            for (int i = 0; i < 10; i++)//döngüyü 10 ye kadar ayarlayıp 1 er 1 er artırdım
                            {
                                Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
                            }
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("2 -> 1 ile 20 arasındaki sayıları konsol ekranına yazdırınız.");

                            for (int i = 1; i < 20; i++)//döngüyü 20 ye kadar ayarlayıp 1 er 1 er artırdım
                            {
                                Console.WriteLine(i);
                            }
                            break;

                        }
                    case 3:
                        {
                            Console.WriteLine("3 -> 1 ile 20 arasındaki çift sayıları konsol ekranına yazdırınız.");

                            for (int i = 2; i < 20; i += 2)//döngüyü 2 şer 2 şer artırıyoruz burda döngüyü bilerek 2 den başlattıp 1 dahil olmadıgı için
                            {
                                Console.WriteLine(i);
                            }

                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("4 -> 50 ile 150 arasındaki sayıların toplamını ekrana yazdırınız.");
                            Int64 numSums = 0;
                            for (int i = 50; i < 150; i++)
                            {
                                numSums += i;//SAyıların hepsini önce kendisiyle toplayıp eşitliyoruz
                            }
                            Console.WriteLine(numSums);
                            break;
                        }
                    case 5:
                        {
                            double numSumsP = 0;
                            double numSumsN = 0;
                            Console.WriteLine("5 -> 1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız.");
                            for (int index = 1; index < 120; index++)
                            {
                                //burda if else yerine matematiksel işlem yaptık burdaki işlem her sayı arttıgında digerini geçiyor
                                numSumsN += (index % 2) * index;//sayı 1%2 den gelen sonuç 1 olcak kendisiyle çarpıp ekleyincede indexteki degeriyle aynı olcak
                                numSumsP += ((index + 1) % 2) * index;//sayı (1+1)%2 ise gelen sonuç sıfır olacak bü yüzden çarpım 0 oldugu için eklmede sıfır olcak 
                            }
                            Console.WriteLine($"Tek sayıların toplamı={numSumsN} / Çift sayıların toplamı={numSumsP}");
                            break;
                        }
                }
                Console.Write("Çıkma için e dışında bir tuşa basın:");
                loopAviable = Char.ToLower(Console.ReadKey().KeyChar) == 'e' ? loopAviable : false;//if else yerine ? işareti ile koşulu kontrol ediyrumn
                                                                                                   //Console.readkey ile klavyeden gelen tuşu alıp küçük harf yaptım
                                                                                                   //bastki for döngümüzün koşulunu gelen key e degilse false yapıp biyiriyorum
                                                                                                   //burda döngüyü break ilede durdurabilirdik ama onun için if else yapısı gerekirdi
                                                                                                   //break bir veri döndermedigi için loopAviable daki degerinin degistirdik
                Console.Clear();


            }
        }

    }
}

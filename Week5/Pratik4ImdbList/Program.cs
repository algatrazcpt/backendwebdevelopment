using System.Runtime.CompilerServices;

namespace Pratik4ImdbList
{
    internal class Program
    {
        enum FilmListTypeEnum
        {
            DefaultList=1,
            ImdbPointList=2,
            NameStartList=3
        }
        public class FilmProperties
        {
            double imdPoint;
            string filmName;

            bool isImdPointRange = false;
            bool isSpecialCharControl = false;
            public FilmProperties(string filmNameP, double imdPointP)
            {
                //Consturctor methodun içinde encapsullü verileri çagırdım
                FilmName = filmNameP;
                ImdPoint = imdPointP;
            }
            public double ImdPoint
            {
                get => imdPoint;
              private   set
                {
                   //Degerlerin anlamsız olmaması için kısıtladım
                    if (value > 10)
                    {
                        imdPoint = 9.9;
                        Console.WriteLine("İmdPuanı 10dan büyük olamaz puan artık=" + imdPoint);
                    }
                    else if (value < 0)
                    {
                        imdPoint = 0;
                        Console.WriteLine("İmdPuanı 0 dan küçük olamaz puan artık=" + imdPoint);
                    }
                    else
                    {
                        imdPoint = value;
                    }
                    //Her tanımlamada daha sonra lazım olcagı için hangi durumda oldugun kaydettim
                    isImdPointRange = value > 4 && value < 9 ? true : false;
                }
            }
            public string FilmName { get => filmName;
                private set
                {
                    filmName = value;
                    isSpecialCharControl = value.ToLower().StartsWith('a') ? true : false;
                }
            }
            public bool IsImdPointRange { get => isImdPointRange; }
            public bool IsSpecialCharControl { get => isSpecialCharControl; }
            public override string ToString()
            {
                //Tostringi ezip göster methodu olarak kullandım
                return $"Film Adı={filmName} | İmdPuan={imdPoint}";
            }
        }
        public static bool LoopInput(out object loopOutPut, string loopMessage, string failMessage, bool isNumber = false)
        {
            //çıktı tipini object yaptım içinde bütün tipleri tutabildigi, için
            string input="";
            while (true)
            {
                Console.Write(loopMessage);
                input = Console.ReadLine();
                if (isNumber)
                {
                    //tür çevirme oldugu için out object alamıyoruz
                    if (double.TryParse(input, out double convertedInput))
                    {
                        loopOutPut = convertedInput;
                        return true;
                    }
                }
                else if (!isNumber&&input != "")
                {
                    loopOutPut = input;
                    return true;
                }
                Console.Clear();
                Console.WriteLine(failMessage);
            }
            
        }
        static void ShowFilmsResearch(List<FilmProperties> filmList)
        {
            Console.WriteLine($"1 -Bütün listeler listelensin-");
            Console.WriteLine($"2 -Imdb puanı 4 ile 9 arasında olan bütün filmler listelensin-");
            Console.WriteLine($"3 - İsmi 'A' ile başlayan filmler ve imdb puanları listelensin-");
            int typeIndex = 0;
            do
            {
                Console.WriteLine("1-3 listeleme yöntemlerinden birini seçiniz");
                Console.Write("listeleme tercihi=");
                //kullanıcıdan gelen sayıları daha önceden oluşturudugum enum için tutuyorum
                int.TryParse(Console.ReadLine(), out typeIndex);
                Console.Clear();
            }
            while (!(0 < typeIndex && typeIndex < 4));


            FilmListTypeEnum filmListType = new FilmListTypeEnum();
            //daha okunaklı olması için 1 gibi kaydetmedim her birini ayrı ayrı tanımladım sayıyı filmtype çevirdim
            filmListType = (FilmListTypeEnum)typeIndex;
            foreach (FilmProperties film in filmList)
            {
                if (filmListType == FilmListTypeEnum.DefaultList)
                {
                    Console.WriteLine(film.ToString());
                    continue;
                }
                if (filmListType == FilmListTypeEnum.NameStartList)
                {
                    if (film.IsSpecialCharControl)
                    {
                        Console.WriteLine(film.ToString());
                    }
                    continue;
                }
                if (filmListType == FilmListTypeEnum.ImdbPointList)
                {
                    if (film.IsImdPointRange)
                    {
                        Console.WriteLine(film.ToString());
                    }
                    continue;
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Film Yöneticisi");
            //2 farklı tip degisken tuttugumuz için ayrı bir class yaptım
            List<FilmProperties> filmList = new List<FilmProperties>();
            string filmName ;
            //ilk atama olmazsa if içi olmazsa diye null hatası veriyor
            double imdPoint=0;
            while (true)
            {
                //birden fazlakez tekrarlana  veri alma ve kontrolu için method oluşturdum
                LoopInput(out object loopOutPut, "Bir film adı Giriniz:", "film adı boş olamaz");
                {
                    filmName = (string)loopOutPut;
                }
                if (LoopInput(out object loopOutPut2, "Bir puan giriniz:", "Bir puan girmelisiniz", true))
                {
                    //Object her türlü veriyi tutabiliyor ama tutulan formatı çevirmek gerekiyor
                    imdPoint = (double)loopOutPut2;
                }

                filmList.Add(new FilmProperties(filmName, imdPoint));
                Console.Write("Yeni film eklemek istermisiniz? E(vet)/H(ayır)");
                if (Console.ReadLine().ToLower() == "h")
                {
                    break;
                }
                Console.Clear();
            }
                ShowFilmsResearch(filmList);
            
           }
        }
    }






        
    


using System.Linq;

namespace Pratik3PatikaFilix
{
    public enum DiziType
    {
        Komedi=1,
        Tarihi=2,
        Dram=3,
        Polisiye=4
    }


    public class Dizi
    {
        private string diziName;
        private int productTime;
        private List<DiziType> diziType;
        private int showTime;
        private string managerName;
        private string firstPlatform;

        public string DiziName { get => diziName; private set => diziName = value; }
        public int ProductTime { get => productTime; private set => productTime = value; }
        public List<DiziType> DiziType { get => diziType; private set => diziType = value; }
        public int ShowTime { get => showTime; private set => showTime = value; }
        public string ManagerName { get => managerName; private set => managerName = value; }
        public string FirstPlatform { get => firstPlatform; private set => firstPlatform = value; }

        public Dizi(string diziName, int productTime, List<DiziType> diziType, int showTime, string managerName, string firstPlatform)
        {
            this.DiziName = diziName;
            this.ProductTime = productTime;
            this.DiziType = diziType;
            this.ShowTime = showTime;
            this.ManagerName = managerName;
            this.FirstPlatform = firstPlatform;
        }
        public Dizi()
        {

        }
        public override string ToString()
        {



            return $"Dizi Adı:{DiziName}\tDizi Üretim Zamanı:{ProductTime}\tDizi türleri:{string.Join(',',diziType)}\tGösterim Yılı:{ShowTime}\tYönetmen Adı:{ManagerName}\tİlk Çıkış Platformu{FirstPlatform}";
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            List<Dizi> allDiziList = new List<Dizi>
            {
                new Dizi("Stranger Things", 60, new List<DiziType> { DiziType.Dram, DiziType.Komedi }, 2016, "The Duffer Brothers", "Netflix"),
                new Dizi("Breaking Bad", 50, new List<DiziType> { DiziType.Dram, DiziType.Polisiye }, 2008, "Vince Gilligan", "AMC"),
                new Dizi("Money Heist", 45, new List<DiziType> { DiziType.Polisiye, DiziType.Dram }, 2017, "Álex Pina", "Netflix"),
                new Dizi("The Crown", 60, new List<DiziType> { DiziType.Tarihi }, 2016, "Peter Morgan", "Netflix"),
                new Dizi("The Mandalorian", 40, new List<DiziType> { DiziType.Tarihi, DiziType.Dram }, 2019, "Jon Favreau", "Disney+"),
                new Dizi("Friends", 22, new List<DiziType> { DiziType.Komedi }, 1994, "David Crane & Marta Kauffman", "NBC"),
                new Dizi("The Witcher", 60, new List<DiziType> { DiziType.Dram, DiziType.Tarihi }, 2019, "Lauren Schmidt Hissrich", "Netflix"),
                new Dizi("Sherlock", 60, new List<DiziType> { DiziType.Polisiye }, 2010, "Mark Gatiss & Steven Moffat", "BBC"),
                new Dizi("Peaky Blinders", 60, new List<DiziType> { DiziType.Polisiye, DiziType.Dram }, 2013, "Steven Knight", "BBC"),
                new Dizi("Narcos", 50, new List<DiziType> { DiziType.Dram }, 2015, "Chris Brancato & Carlo Bernard", "Netflix"),
                new Dizi("Game of Thrones", 60, new List<DiziType> { DiziType.Tarihi }, 2011, "David Benioff & D.B. Weiss", "HBO"),
                new Dizi("The Office", 22, new List<DiziType> { DiziType.Komedi }, 2005, "Greg Daniels", "NBC"),
                new Dizi("Better Call Saul", 50, new List<DiziType> { DiziType.Dram }, 2015, "Vince Gilligan & Peter Gould", "AMC"),
                new Dizi("Black Mirror", 60, new List<DiziType> { DiziType.Dram }, 2011, "Charlie Brooker", "Netflix"),
                new Dizi("Dark", 60, new List<DiziType> { DiziType.Dram }, 2017, "Baran bo Odar & Jantje Friese", "Netflix"),
                new Dizi("The Boys", 60, new List<DiziType> { DiziType.Dram }, 2019, "Eric Kripke", "Amazon Prime"),
                new Dizi("Westworld", 60, new List<DiziType> { DiziType.Tarihi }, 2016, "Jonathan Nolan & Lisa Joy", "HBO"),
                new Dizi("The Umbrella Academy", 50, new List<DiziType> { DiziType.Dram }, 2019, "Steve Blackman", "Netflix"),
                new Dizi("Vikings", 60, new List<DiziType> { DiziType.Tarihi }, 2013, "Michael Hirst", "History Channel")
            };

            string diziName= "";
            int productTime=-1;
            List<DiziType> diziTypesList=new List<DiziType>();
            int exitTime = -1;
            string productManagerName = "";
            string platformName = "";

            Dizi userDizi = new Dizi();
            while (true)
            {

                if (diziName == string.Empty)
                {
                    Console.Write("Dizi Adı:");
                    diziName=StringControl(Console.ReadLine());
                }
                if (productTime == -1)
                {
                    Console.Write("Üretim Zamanı:");
                    productTime =NumControl(Console.ReadLine());
                }
                if (diziTypesList.Count<=0)
                {
                    Console.Write("Tür tercihi yapınız 1(Komedi)/2(Tarihi)/3(Dram)/4(Polisiye) türün numaralarını yazınız birden fazla  tür için  virgül ile tür numaralarını ayırınız:");
                    if(DiziTypeControl(Console.ReadLine(), out List<DiziType> userDiziTypeOut))
                    {
                        diziTypesList = userDiziTypeOut;
                    }
                }
                if(exitTime==-1)
                {
                    Console.Write("dizini çıkış tarihini giriniz:");
                    exitTime=NumControl(Console.ReadLine());
                }
                if (productManagerName==string.Empty)
                {
                    Console.Write("Yönetmen adını giriniz:");
                    productManagerName=StringControl(Console.ReadLine());
                }
                if(platformName==string.Empty)
                {
                    Console.Write("İlk yayınlandıgı platform adını giriniz:");
                    platformName=StringControl(Console.ReadLine());
                }

                if(platformName != string.Empty&& productTime != -1&& diziTypesList.Count > 0&&exitTime != -1&& productManagerName != string.Empty)
                {
                    ChangeColorText("İşlem Terchi", ConsoleColor.Blue);
                    Console.WriteLine("Bütün Listeyi Görmek için 1");
                    Console.WriteLine("Özel Listeyi Görmek için 2");
                    Console.WriteLine("Yeni Dizi eklemek için 3");
                    Console.Write("Çıkmak için 4 dışında bir tuşa basınız:");
                    string userKey = Console.ReadLine();
                    if (userKey=="1")
                    {
                        Console.Clear();
                        userDizi = new Dizi(diziName, productTime, diziTypesList, exitTime, productManagerName, platformName);
                        allDiziList.Add(userDizi);
                        //Clear
                        diziName = "";
                        productTime = -1;
                        diziTypesList = new List<DiziType>();
                        exitTime = -1;
                        productManagerName = "";
                        platformName = "";
                        userDizi = new Dizi();
                        ShowList(allDiziList);
                        break;
                        
                    }
                    else if ((userKey=="2"))
                    {
                        Console.Clear();
                        userDizi = new Dizi(diziName, productTime, diziTypesList, exitTime, productManagerName, platformName);
                        allDiziList.Add(userDizi);
                        //Clear
                        diziName = "";
                        productTime = -1;
                        diziTypesList = new List<DiziType>();
                        exitTime = -1;
                        productManagerName = "";
                        platformName = "";
                        userDizi = new Dizi();
                        ComplexShowList(allDiziList);
                        break;
                    }
                    else if ((userKey=="3"))
                    {
                         userDizi = new Dizi(diziName, productTime, diziTypesList, exitTime, productManagerName, platformName);
                         allDiziList.Add(userDizi);
                         //Clear
                         diziName = "";
                         productTime = -1;
                         diziTypesList = new List<DiziType>();
                         exitTime = -1;
                         productManagerName = "";
                         platformName = "";
                         userDizi =new Dizi();
                         Console.Clear();
                        ChangeColorText("Dizi Kaydedildi,Yeni Dizi Oluşturuluyor", ConsoleColor.Blue);

                    }
                    else if((userKey == "4"))
                    {
                        userDizi = new Dizi(diziName, productTime, diziTypesList, exitTime, productManagerName, platformName);
                        allDiziList.Add(userDizi);
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        ChangeColorText("1-4 arasında bir deger girmediniz");
                    }
                }
            }

        }
        public static void ShowList<T>(List<T>list)
        {
            ChangeColorText("Bütün dizileri listeler",ConsoleColor.Blue);
            Console.WriteLine('*' + new string('-', 100) + '*');
            foreach (var v in list)
            {
                Console.WriteLine(v.ToString());
            }
        }
        public static void ComplexShowList(List<Dizi> diziList)
        {
            ChangeColorText("Komedi dizileri için özelleştirilmiş listeleme",ConsoleColor.Blue);
            var funnDizilerList = diziList.Where(dizi => dizi.DiziType.Contains(DiziType.Komedi)).OrderBy(diziOrder => diziOrder.DiziName).ThenBy(diziOrder => diziOrder.ManagerName).SelectMany(dizi => new[] { new object[] { dizi.DiziName, dizi.DiziType, dizi.ManagerName } });
            //üstteki lingq yapısını basit hali
            //diziList.Where(dizi => dizi.diziType.Contains(DiziType.Komedi));
            //OrderBy(diziOrder => diziOrder.diziName)
            //ThenBy(diziOrder=>diziOrder.managerName)
            //SelectMany(dizi => new[]{ new object[] { dizi.diziName, dizi.diziType, dizi.managerName } })
            string info = "";
            foreach (var funnDizi in funnDizilerList)
            {
                info = "";
                foreach (var funnDiziDetaylari in funnDizi)
                {
                    if (funnDiziDetaylari is IEnumerable<DiziType> diziTypeList)
                    {
                        info += (string.Join('-', diziTypeList.Select(typeName => typeName.ToString()))) + " ";
                    }
                    else
                    {
                        info += funnDiziDetaylari.ToString() + "\t";
                    }

                }
                Console.WriteLine('*' + new string('-', 100) + '*');
                Console.WriteLine(info);
            }
        }
        public static string StringControl(string value)
        {
            string userString = "";
            if (value == string.Empty)
            {
                ChangeColorText("Boş metin girilemez");
                return userString;
            }
            else
            {

                userString = value;
                return userString;
            }
        }
        public static int NumControl(string value)
        {
            if(int.TryParse(value,out int userNumber))
            {
                if (userNumber >= 0)
                {
                    return userNumber;
                }
                ChangeColorText("Sayı 0 dan büyük olmalıdır");
                return -1;
            }
            else
            {
                ChangeColorText("Sayı formatına uygun degildir");
                return -1;
            }
        }
        public static void ChangeColorText(string value,ConsoleColor clr=ConsoleColor.Red)
        {
            Console.ForegroundColor = clr;
            Console.WriteLine(value);
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static bool DiziTypeControl(string value,out List<DiziType> diziTypes)
        {
            diziTypes =new List<DiziType>();
            value = value.Replace(" ", "");
            string []diziGet = value.Split(',');
            if(0>diziGet.Length||diziGet.Length>5)
            {
                ChangeColorText("en fazla 4 tür seçilebilir");
                return false;
            }
            foreach(var v in diziGet.GroupBy(group=>group).Select(num=>num.Count()).Where(num=>num>1))
            {
                ChangeColorText("Aynı tür iki kez yazılamaz");
                return false;
            }
            if (diziGet.Select(nums  => nums == "1" || nums == "2" || nums == "3" || nums == "4").Where(numb=>numb==false).Count()>0)
            {
                ChangeColorText("tür degişimi başırısız");
                return false;
            }
            foreach(int numValue in diziGet.Select(num => int.Parse(num)).ToList())
            {
                diziTypes.Add((DiziType)numValue);
            }
            return true;
        }
    }
}

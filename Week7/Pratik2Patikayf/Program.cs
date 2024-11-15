using System.Linq;
namespace Pratik2Patikayf
{
    public enum MusicType
    {
        Pop,
        TürkHalk,
        Rap
    }
    public class Music
    {
        string name;
        string surname;
        List<MusicType> musicTypes;
        int exitMusicTime;
        double albumShareCount;
        public Music(string name, string surname, List<MusicType> musicTypes, int exitMusicTime, double albumShareCount)
        {
            this.Name = name;
            this.Surname = surname;
            this.MusicTypes = musicTypes;
            this.ExitMusicTime = exitMusicTime;
            this.AlbumShareCount = albumShareCount;
        }

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public List<MusicType> MusicTypes { get => musicTypes; set => musicTypes = value; }
        public int ExitMusicTime { get => exitMusicTime; set => exitMusicTime = value; }
        public double AlbumShareCount { get => albumShareCount; set => albumShareCount = value; }

        public override string ToString()
        {
            return ($"Ad:{name} {surname}\tMuzik Türleri={string.Join(",",musicTypes)}\tÇıkış Tarihi:{exitMusicTime}\tAlbüm Satış Miktarı:{albumShareCount}");

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Music> singersList = new List<Music>
            {
                new Music("Tarkan", "Tevetoglu", new List<MusicType> { MusicType.Pop }, 1997, 2000000000), // 2 milyar
                new Music("Sezen", "Aksu", new List<MusicType> { MusicType.Pop, MusicType.TürkHalk }, 1976, 3500000000), // 3.5 milyar
                new Music("Sibel", "Can", new List<MusicType> { MusicType.Pop }, 1990, 15200000), // 15.2 milyon
                new Music("Barış", "Manço", new List<MusicType> { MusicType.TürkHalk, MusicType.Pop }, 1971, 30100000), // 30.1 milyon
                new Music("Mahsun", "Kırmızıgül", new List<MusicType> { MusicType.TürkHalk, MusicType.Pop }, 1995, 18700000), // 18.7 milyon
                new Music("Candan", "Erçetin", new List<MusicType> { MusicType.Pop }, 1971, 13400000), // 13.4 milyon
                new Music("Bergen", "Alkız", new List<MusicType> { MusicType.TürkHalk }, 1985, 25600000), // 25.6 milyon
                new Music("Mabel", "Matiz", new List<MusicType> { MusicType.Pop }, 2010, 8900000), // 8.9 milyon
                new Music("Eylem", "Aktaş", new List<MusicType> { MusicType.Rap }, 2008, 2500000), // 2.5 milyon
                new Music("Ezhel", "Özkaya", new List<MusicType> { MusicType.Rap }, 2011, 10300000), // 10.3 milyon
                new Music("Ceza", "Akan", new List<MusicType> { MusicType.Rap }, 2004, 20100000), // 20.1 milyon
                new Music("Fikri", "Karayel", new List<MusicType> { MusicType.Rap, MusicType.Pop }, 2013, 5400000), // 5.4 milyon
                new Music("Gökhan", "Özen", new List<MusicType> { MusicType.Pop }, 1994, 12600000), // 12.6 milyon
                new Music("Sertab", "Ereyan", new List<MusicType> { MusicType.Pop }, 1997, 25800000), // 25.8 milyon
                new Music("Demet", "Akalın", new List<MusicType> { MusicType.Pop }, 1999, 22700000), // 22.7 milyon
                new Music("Büyük", "Şahin", new List<MusicType> { MusicType.Pop }, 2007, 6200000), // 6.2 milyon
                new Music("Murat", "Boz", new List<MusicType> { MusicType.Pop }, 2003, 17100000), // 17.1 milyon
                new Music("Kenan", "Doğulu", new List<MusicType> { MusicType.Pop }, 2003, 24400000), // 24.4 milyon
                new Music("Haluk", "Levent", new List<MusicType> { MusicType.TürkHalk }, 1994, 20900000), // 20.9 milyon
                new Music("Yıldız", "Tilbe", new List<MusicType> { MusicType.Pop, MusicType.TürkHalk }, 1994, 27800000) // 27.8 milyon
            };

            ShowList("S harfi ile baslayan sarkıcılar", singersList.Where(singer => singer.Name.ToLower().StartsWith('s')).ToList());
            ShowList("10000000 satışa sahip şarkıcılar", singersList.Where(singer => singer.AlbumShareCount > 10000000).ToList());
            ShowList("En çok album satışı yapan", new List<Music> { singersList.Where(singer => singer.AlbumShareCount == (singersList.Max(singer => singer.AlbumShareCount))).First()});
            ShowList("En yeni çıkış yapan sanatçı ile en geç çıkış yapan sanatçı",new List<Music> { singersList.Where(singer => singer.ExitMusicTime == singersList.Min(minS => minS.ExitMusicTime)).First(), singersList.Where(singer => singer.ExitMusicTime == singersList.Max(maxS => maxS.ExitMusicTime)).First() });
            //Üstteki linq yapısını adımları
            //singersList.Where(singer => singer.ExitMusicTime == singersList.Min(minS => minS.ExitMusicTime)).First()
            //singersList.Where(singer => singer.ExitMusicTime == singersList.Max(maxS => maxS.ExitMusicTime).First()

            var complexListResearch = singersList.Where(singer => singer.ExitMusicTime > 2000 && singer.MusicTypes.Contains(MusicType.Pop)).OrderBy(singer => singer.Name).GroupBy(singer => singer.ExitMusicTime).OrderBy(singer => singer.Key).ToList();
            //Üstteki linq yapısını adımları
            //singersList.Where(singer => singer.ExitMusicTime > 2000 && singer.MusicTypes.Contains(MusicType.Pop));
            //OrderBy(singer => singer.Name)
            //GroupBy(singer => singer.ExitMusicTime);
            //OrderBy(singer => singer.Key).ToList();

            TableShowBetter("2000 yılından sonra çıkan pop türündeki sanatçılar çıkış yılına göre gruplu ve ad sırasına göre listeli");
            foreach (var group  in complexListResearch)
            {
                ShowList(group.Key.ToString(), group.ToList());
            }
        }
        public static void TableShowBetter(string listName)
        {
            Console.WriteLine(listName);
        }
        public static void ShowList<T>(string listName,List<T> lists,bool defaultShowValue=true)
        {
            if (defaultShowValue)
            {
                TableShowBetter(listName);
            }
            foreach (T value in lists)
            {
                Console.WriteLine(value);
            }
        }
    }
}

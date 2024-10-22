namespace Pratik4IlkSinifimiziOlusturuyoruz
{
    public class Person
    {
        private string name;
        private string surName;
        private int birtyDay;
        //kurucu method oluşturdum
        public Person(string name, string surName, int birtyDay)
        {
            this.name = name;
            this.surName = surName;
            this.birtyDay = birtyDay;
        }

        //Alan özelliklerini atadık
        public string Name { get => name; set => name = value; }
        public string SurName { get => surName; set => surName = value; }
        public int BirtyDay { get => birtyDay; set => birtyDay = value; }

        public void ShowInfo()
        {
            Console.WriteLine($"Adınız={name} SoyAdınız{surName}Dogum Tarihiniz={birtyDay}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Sınıfı olutururukun degiskenleri tanımlıyoruz
            Person teacher = new Person("Fen ögretmeninADı", "fen ögretmenin soy adı", 1777);
            //Sınıfın içindeki bilgi yazdırma methodu ile gösteriyoruz
            teacher.ShowInfo();
            //tek tek atam yapmak yerine ilkdefa oluşuturu gibi atama yapıyıoruz
            teacher = new Person("Biyoloji ögretmeninADı", "Biyoloji ögretmenin soy adı", 1877);
            teacher.ShowInfo();
            Person student = new Person("Ögrenci1", "Ögrenci1 soyadi", 2000);
            student.ShowInfo();
            student = new Person("Ögrenci2", "Ögrenci2 soyadi", 2001);
            student.ShowInfo();
            Console.ReadLine();
        }
    }
}

namespace Pratik7Absraction
{
    public abstract class People
    {
        string name="Belirtmemiş";
        string surName="Belirtmemiş";
        string departmanName= "Belirtmemiş";

        public string Name { get => name; set => name = value; }
        public string SurName { get => surName; set => surName = value; }
        public string DepartmanName { get => departmanName; set => departmanName = value; }
        public string ShowInfo() => $"Id bilgiler[ad={name} soyad={surName} departman={departmanName} ]";
        //Sınıfı soyut yaptık diger sınıflarda kullanabilmek için
        public abstract void Gorev();

    }
    public class ProjectManager : People
    {
        public override void Gorev()
        {
            Console.WriteLine(ShowInfo()+ " Proje yöneticisi olarak çalışıyorum ");
        }
    }
    public class Developer : People
    {
        public override void Gorev()
        {
            Console.WriteLine(ShowInfo() + " Geliştirici  olarak çalışıyorum ");
        }
    }
    public class Tester : People
    {
        public override void Gorev()
        {
            Console.WriteLine(ShowInfo() + " Tester olarak  çalışıyorum ");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Şirket çalışanlarımız");

            //burda kalıtım yapılan sınıftan bir liste yaptım
            List<People> departmen = new List<People>();


            ProjectManager projectManager = new ProjectManager();
            projectManager.Name = "Atakan";
            projectManager.DepartmanName = "Proje Yöneticisi";

            Developer developer = new Developer();
            developer.Name = "Developer1";
            developer.SurName = "Developer1 surname";
            developer.DepartmanName = "DeveloperYöneticisi";

            Tester tester = new Tester();
            tester.Name = "Tester1";
            tester.SurName = "Tester1 surname";
            tester.DepartmanName = "DeveloperYöneticisi";
            //kalıtımdan türettiklerimizi kalıtımlı sınıfa ekleyebiliriz
            departmen.Add(projectManager);
            departmen.Add(developer);
            departmen.Add(tester);

            foreach(People a in departmen)
            {
                a.Gorev();
            }
            Console.ReadLine();

        }
    }
}

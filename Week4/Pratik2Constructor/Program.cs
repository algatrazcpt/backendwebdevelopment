namespace Pratik2Constructor
{
    public class Baby
    {
        int birthDay=0;
        string name="AdYok";
        string surname="SoyadYok";
        public Baby() { Console.WriteLine("Ingaaaa"); birthDay = DateTime.Now.Year; }
        public Baby(int birthDay, string name, string surname) { }
        public int BirthDay { get => birthDay; set => birthDay = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public void ShowInfo()
        {
            Console.WriteLine($"{name} {surname} {birthDay}");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Baby baby1=new Baby();
            baby1.ShowInfo();
            Baby baby2=new Baby(10,"Bebek1 ad","Bebek1 soyad");
            baby2.ShowInfo();
            Console.ReadLine();
        }
    }
}

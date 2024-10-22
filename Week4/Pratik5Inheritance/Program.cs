namespace Pratik5Inheritance
{

    public class BasePeople
    {
        string name;
        string surName;

        //Erişim methodu public  yaptım çagırıken sorun yaşamamak için
        public string Name { get => name; set => name = value; }
        public string SurName { get => surName; set => surName = value; }

        public void ShowInfo()
        {
            Console.WriteLine($"Ad= {Name} Soyad= {SurName}");
        }
    }
    public class Student : BasePeople//Kalıtım yapılan sınıf
    {
        int no;

        public int No { get => no; set => no = value; }

        public void ShowInfo()
        {
            Console.WriteLine($"Ad= {Name} Soyad= {SurName} Numara {No}");
        }
    }
    public class Teacher : BasePeople
    {
        double salary;

        public double Salary { get => salary; set => salary = value; }

        public void ShowInfo()
        {
            Console.WriteLine($"Ad={Name} Soyad= {SurName} Maaş={Salary}");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Teacher musicTeacher= new Teacher();
            musicTeacher.Name = "Yamus";
            musicTeacher.SurName = "Eylül";
            musicTeacher.Salary = 55000;
            musicTeacher.ShowInfo();

            Student physicsStudent = new Student();
            physicsStudent.Name = "Lara";
            physicsStudent.SurName = "Croft";
            physicsStudent.No = 1834;
            physicsStudent.ShowInfo();
            Console.ReadLine();

        }
    }
}

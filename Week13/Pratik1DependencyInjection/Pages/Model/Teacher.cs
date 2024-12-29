namespace Pratik1DependencyInjection.Pages.Model
{
    public interface ITeacher
    {
        public string GetInfo();
    }

    public class Teacher:ITeacher
    {
        string firstName = "İlk Ad";
        string lastName = "Soyad";

        public string GetInfo()
        {
            return firstName + "-" + lastName;
        }
    }
}

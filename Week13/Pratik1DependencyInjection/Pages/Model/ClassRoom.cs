namespace Pratik1DependencyInjection.Pages.Model
{
    public class ClassRoom
    {
        private ITeacher teacher;

        public ClassRoom (ITeacher teacher)
        {
            this.teacher = teacher;
        }
        public void StartClass()
        {
            Console.WriteLine("Class Started");
            teacher.GetInfo();
        }
    }
}

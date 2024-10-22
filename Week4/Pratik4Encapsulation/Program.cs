using System.Drawing;

namespace Pratik4Encapsulation
{

    public class Car
    {

        string _marka = "";
        string _model = "";
        string _color="";
        private int _doorCount=0;
        public Car() { }
        public void Added(string marka,string model, string color,int doorCount)
        {
            _marka = marka;
            _model = model;
            _color = color;
            DoorControl(doorCount);
        }
        void DoorControl(int doorCount)
        {
            if(doorCount==2||doorCount==4)
            {
                _doorCount = doorCount;
            }
            else
            {
                _doorCount = -1;
                Console.WriteLine("Kapı sayısı 2 ve ya 4 olabilir"); ;
            }
        }
        public void ShowInfo()
        {
            Console.WriteLine($"{_marka} {_model} {_color} {_doorCount}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            Console.WriteLine("Laranın arabası");
            myCar.Added("Nissan","GTR","Metalik gri",4);
            myCar.ShowInfo();
            Console.WriteLine("Yamus arabası");
            myCar.Added("Porsche", "911", "Pembe", 3);
            myCar.ShowInfo();
            Console.ReadLine();
        }
    }
}

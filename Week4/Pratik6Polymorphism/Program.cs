using System.Formats.Asn1;

namespace Pratik6Polymorphism
{
    public class BaseShape
    {
         double widht;
         double height;

        public double Widht { get => widht; set => widht = value; }
        public double Height { get => height; set => height = value; }

        public virtual void RegionCalculate()
        {
        }


    }
    public class Square : BaseShape 
    {

        public override void RegionCalculate()//BaseShapeten gelen RegionCalculate ezip tekrar kullanıyoruz
        {
            Console.WriteLine($" Karenin alanı={Widht * Height}");
        }
    }
    public class Rectangle : BaseShape
    {
        public override void RegionCalculate()
        {
            Console.WriteLine($" Dikdörtgenin alanı={Widht * Height}");
        }
    }
    public class Triangle : BaseShape
    {

        public override void RegionCalculate()
        {
            Console.WriteLine($" Ücgein alanı={(Widht * Height)/2}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Square square= new Square();
            square.Height = 4;//BaseShapeten miras olan uzunlugu degiştiriyoruz
            square.Widht = 4;
            square.RegionCalculate();
            Rectangle rectangle= new Rectangle();
            rectangle.Widht = 4;
            rectangle.Height = 8;
            rectangle.RegionCalculate();
            Triangle triangle= new Triangle();
            triangle.Widht = 4;
            triangle.Height = 8;
            triangle.RegionCalculate();
            Console.ReadLine();


        }
    }
}

namespace Pratik5TryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir sayı giriniz:");
            try
            {
                double number = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(number*number);
            }
            catch 
            {
                Console.WriteLine("Geçersiz giriş! Lütfen bir sayı giriniz.");
            }


        }
    }
}

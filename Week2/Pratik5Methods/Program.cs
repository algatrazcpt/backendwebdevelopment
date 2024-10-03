namespace Pratik5Methods
{
    internal class Program
    {
        //Pratik5 - İlk Metot Uygulamamız
        static void Main(string[] args)
        {
            Method1SongsWriter();
            Console.WriteLine(new string('*', 14));
            //
            Console.WriteLine($"Rastgele sayınız:{PlayerRandomNumberCreate()}");
            Console.WriteLine(new string('*', 14));
            //
            Console.WriteLine("2 Tane sayı giriniz çarpılcak");
            Console.Write("Birinci sayıyı giriniz:");
            double.TryParse(Console.ReadLine(),out double num1);
            Console.Write("İkinci sayıyı giriniz:");
            double.TryParse(Console.ReadLine(), out double num2);
            TwoNumsMultiply(num1,num2);
            Console.WriteLine(new string('*', 14));
            //
            Console.Write("Adınızı giriniz:");
            string name=Console.ReadLine();
            Console.Write("SoyAdınız giriniz:");
            string surName = Console.ReadLine();
            HelloWorld(name, surName);

        }
        static void Method1SongsWriter()//ana methodumuz static  oldugu için çagırabilmemiz için static ekledim
        {
            Console.WriteLine("Geriye Değer Döndürmeyen Bir void metot.");

            Console.WriteLine("Önüme çizili rota");
            Console.WriteLine("Dikilip dönüştüm bi’ tripota");
            Console.WriteLine("Zihinler zehirli, fikirler sihirli");
            Console.WriteLine("Kimisi kendince bi’ Harry Potter");
        }
        static int PlayerRandomNumberCreate()
        {
            Console.WriteLine("Geriye Tamsayı Döndüren Bir metot");
            return new Random().Next()%2;//rastgele sayı oluşturup 2 ye bölümünden kalanını dönderiyorum
        }
        static double TwoNumsMultiply(double num1, double num2)//2 parametre alıyorum
        {
            Console.WriteLine("Parametre Alan ve Geriye Değer Döndüren Bir Metot");
            return num1 * num2;//sonucu dönderiyorum
        }
        static void HelloWorld(string name ,string surname)
        {
            Console.WriteLine("Parametre Alan ve Geriye Değer Döndürmeyen bir Metot");
            Console.WriteLine($"Hoş geldiniz {name} {surname}");
        }
    }
}

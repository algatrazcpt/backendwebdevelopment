namespace Pratik3DowhileDoDiffrence
{
    internal class Program
    {

        static void Main(string[] args)
        {

            int counter = 0;
            Console.Write("Bir sayı giriniz:");
            int num=int.Parse(Console.ReadLine());

            //döngüdeki koşul saglanmasada birr defa her zamaan çalışır
            Console.WriteLine("DoWhile Döngüsü");
            do
            {
                Console.WriteLine("Ben bir Patika'lıyım");
                counter++;
            }
            while ( counter<num);
            //
            //
            //
            //döngüdeki koşul saglanmasaı zorunludur
            counter = 0;
            Console.WriteLine("While Döngüsü");
            while( counter<num)
            {
                Console.WriteLine("Ben bir Patika'lıyım");
                counter++;
            }
            Console.ReadLine();

            //koşul saglanmadıgı durumda do while bir kere çalışır while döngüsünde böyle bir durum olamaz
        }
    }
}

namespace Pratik3List2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int coffeCount = 5;
            Console.WriteLine($"{coffeCount} tane kahve giriniz");
            List<string> coffeList = new List<string>();
            for (int index = 0; index < coffeCount; index++) 
            {
                Console.Write($"Kahve {index+1}:");
                //listeye ekleme ile gelen verileri aktarıyorum
                coffeList.Add(Console.ReadLine());
            }
            Console.WriteLine("Kahve Listesi");
            foreach (string coffe in coffeList)
            {
                Console.WriteLine(coffe);
            }
        }
    }
}

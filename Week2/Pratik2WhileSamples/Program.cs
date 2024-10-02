namespace Pratik2WhileSamples
{
    //Pratik5 WhileSamples
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 -> Konsol ekranına 10 kere \"Kendime inanıyorum, ben bu yazılım işini hallederim!\" yazdırır.");
            Console.WriteLine("2 -> 1 ile 20 arasındaki sayıları konsol ekranına yazdırır.");
            Console.WriteLine("3 -> 1 ile 20 arasındaki çift sayıları konsol ekranına yazdırır.");
            Console.WriteLine("4 -> 50 ile 150 arasındaki sayıların toplamını ekrana yazdırır.");
            Console.WriteLine("5 -> 1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırır.");
            Console.WriteLine("1 ila 5 arasında bir proje seçebilirsiniz");
            Console.Write("ProjeId:");
            byte projectId =byte.Parse(Console.ReadLine());

            switch (projectId)
            {
                case 1:
                    {
                        Console.WriteLine("1 -> Konsol ekranına 10 kere \"Kendime inanıyorum, ben bu yazılım işini hallederim!\" yazdırır.");
                        int num = 1;
                        while (num<20)
                        {
                            num++;
                            Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim");
                        }
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("2 -> 1 ile 20 arasındaki sayıları konsol ekranına yazdırır.");
                        int num = 1;
                        while (num < 20)
                        {
                           
                            Console.WriteLine(num);
                            num++;
                        }
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("3 -> 1 ile 20 arasındaki çift sayıları konsol ekranına yazdırır.");
                        int num = 2;
                        while (num < 20)
                        {
                            num += 2;
                            Console.WriteLine(num);
                        }
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("4 -> 50 ile 150 arasındaki sayıların toplamını ekrana yazdırır.");
                        int num = 50;
                        int numSums = 0;
                        while (num < 150)
                        {
                            numSums += num;
                            num++;
                        }
                        Console.WriteLine(numSums);
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("5 -> 1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırır.");
                        int num = 1;
                        int numCift = 0;
                        int numTek = 0;
                        while (num < 120)
                        {
                            numTek += (num % 2) * num;//Sayı tek ise kalan 1 olcak ve kendisyle çarpıp ekliyoprum
                            numCift += ((num + 1) % 2) * num;//Sayı çift ise kalan 1 olcak ve kendisyle çarpıp ekliyoprum
                            num++;
                        }
                        Console.WriteLine($"Çift={numCift} Tek={numTek}");
                        break;
                    }
            }
            Console.ReadLine();
        }
    }
}

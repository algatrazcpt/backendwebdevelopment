namespace Pratik2Lists1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> infulanceList;
            //Bütün ünlüleri tek bir strinte tuttum
            string infulances= "Bülent Ersoy,Ajda Pekkan,Ebru Gündeş,Hadise,Hande Yener,Tarkan,Funda Arar,Demet Akalın";
            //ünlüleri virgüle göre böldürüp diziyi Generice çevirdim
            infulanceList = new List<string>(infulances.Split(","));
            Console.WriteLine("** Davetliler **");
            for (int index=0;index<infulanceList.Count;index++)
            {
                Console.WriteLine($"{index+1} - {infulanceList[index]}");
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Numerics;


namespace Pratik1Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numsList = RandomListGenerate(10);
            ShowList("Rastgele liste", "sayı:", numsList);
            ShowList("Çift Sayılar","Çift sayı:", numsList.Where(num => num % 2 == 0).ToList());
            ShowList("Tek Sayılar", "Tek sayı:", numsList.Where(num => num % 2 != 0).ToList());
            ShowList("Pozitif Sayılar", "pozitif sayı:", numsList.Where(num => num >0).ToList());
            ShowList("Negatif sayilar", "Negatif sayı:", numsList.Where(num => num<0).ToList());
            ShowList("Sayıların kareleri", "", numsList.Select(num => $"sayi={num} karesi={(num*num)}").ToList());
            ShowList("10'dan büyük ve 50'den küçük sayılar", "sayı:", numsList.Where(num => num>10 && num<50).ToList());
        }
        static List<int> RandomListGenerate(int maxValue)
        {

            List<int> randomList= new List<int>();
            for(int value=0;value< maxValue;value++)
            {
                randomList.Add(Random.Shared.Next(-100,100));
            }
            return randomList;
        }
        static void ShowList <T>(string listName,string listIdName,List <T> listNumb)
        {
            //??
            //Console.WriteLine($"*{new string('-', 40)}*");
            //Console.WriteLine("*---------------------------------*");
            Console.WriteLine(listName);
            if (listNumb.Count > 0)
            {
                foreach (T num in listNumb)
                {
                    if (listIdName != string.Empty)
                    {
                        Console.WriteLine($"{listIdName} {num}");
                    }
                    else
                    {
                        Console.WriteLine($"{num}");
                    }
                }
            }
            else
            {
                Console.WriteLine("Arama degerlerine uyan hiç bir deger yok");
            }
        }
    }
}

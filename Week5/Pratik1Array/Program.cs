using System;
using System.Data;

namespace Pratik1Array
{
    internal class Program
    {
        //toplam kaç adımda büyügü sıraladıgını göstermesi için degisken tanımladım
        public static int shortingProgresCount= 0;
        static void Shorting(ref int[] dizi,int size)
        {
           
            int dynamicsize;
            for (int index1 = 0; index1 < size-1; index1++)
            {
                shortingProgresCount++;
                if (dizi[index1] < dizi[index1 + 1])
                {
                    //degiskenlerin yerlerini degiştirip atıyorum
                    dynamicsize = dizi[index1];
                    dizi[index1]= dizi[index1+1];
                    dizi[index1 + 1] = dynamicsize;
                }
            }
            if(size>0)
            {
                size -= 1;
                //Yapı olarak sıralama işlemini
                //ilk buldugu degişkeni son sıraya kadar kontrol ediyor
                //Her seferinde son sırya kadar yapması gerekmedigi için boyutunu 1 azaltıyorum
                //diziyi döndürmek yerine referansını alıp degiştiroyrum
                Shorting(ref dizi, size);
            }
            else
            {
                Console.WriteLine("Shorting Array Bigger");
                Console.WriteLine("Shorting calculate progres size=" + shortingProgresCount);
                shortingProgresCount = 0;
            }

        }
        static void ShowIntDizi(int[] dizi)
        {
            Console.WriteLine("Dizi Gösterliyor");
            foreach(int i in dizi)
            {
                Console.Write($"[{i}],");
            }
            

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Diziye sayı giriniz 10 tane");
            int[] dizi = new int[10];
            for(int a=0;a<dizi.Length;a++)
            {
                Console.Write($"Sayı {(a+1)}:");
                int.TryParse(Console.ReadLine(),out int num);
                dizi[a]= num;

            }
            ShowIntDizi(dizi);
            
            //dizini boyutunu yükseltiyorum
            Array.Resize(ref dizi, 11);
            Console.WriteLine("Diziye sayı giriniz 1 tane");
            Console.Write($"Sayı {(11)}:");
            
            int.TryParse(Console.ReadLine(), out int num1);
            dizi[10] = num1;
            //Diziyi sıralıyoruz
            Shorting(ref dizi,dizi.Length);
            ShowIntDizi(dizi);
            Console.WriteLine();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratik5
{
    internal class Program
    {
        // Pratik 5 Kim Milyoner Olmak İster ?
        static void Main(string[] args)
        {
            //Temel degiskenleri tanımlayıop  ilk degerlerini tanımlıyorum
            int maxFaultCount = 2;
            int maxQuestion = 3;
            int currentQuestion=1;
            int currentTrueQuestion =0;
            bool gamePlayAble = true;


            //İlk Soru tanımlama
            string question1 = "Şıklardan dogru yazımlı olanı seçin";
            string answer1 = "int num=10%2==0 ? 100 : 0";
            string answer2 = "int num=10%2=0 : 100 ? 0";
            char correctAnswer = 'A';


            //Şartlı döngü ile istedigim kadar çalışmasını saglıyorum
            while (gamePlayAble)
            {
                    //Soruları yazdırıyoruz
                    Console.WriteLine($"{currentQuestion})Soru {question1}");
                    Console.Write($"A){answer1} B){answer2} \n");
                    Console.Write("Cevabınız:");
                    char currentAnswer = char.Parse(Console.ReadLine());


                    //Dogru cevaplar yerine yanlıs cevapları kontrol ediyorum
                    if (Char.ToLower(currentAnswer) != Char.ToLower(correctAnswer))
                    {
                        //Yanlıs sayısını azaltıp devam edebilecek hakkı kalmadıgını kontrol ediyoruz
                        maxFaultCount--;

                        if (maxFaultCount < 1)
                        {
                            Console.WriteLine("Oyunu kaybettiniz");
                            gamePlayAble = false;
                            Console.ReadLine();
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"{maxFaultCount} yanlış hakkınız kaldı");
                        }
                    }
                    else
                    {
                        //dogru sayısını artırıyoruz
                         currentTrueQuestion++;
                        
                    }

                currentQuestion++;
                if(maxQuestion>currentQuestion)
                {
                    Console.WriteLine("Yeni Soru");
                }
                if (maxQuestion == currentQuestion)
                {
                    Console.WriteLine("Son Soru");
                }

                //islemlerden sonrası soru sayını artırıyorum 
                
                //Yeni Soruları swicth için de tutup tanımlıyorum
                switch (currentQuestion)
                    {
                        case 2:
                            {
                            //Yeni degiskenler olusturmadan degsikenleri düzenleyip tekrar kullanıyorum
                                question1 = " Switch case kullanımında break kullanımı zorunlumudur ?";
                                answer1 = "Zorunludur";
                                answer2 = "Zorunlu degildir";
                                correctAnswer = 'A';
                                break;
                            }
                        case 3:
                            {
                                question1 = "float veri tipi olarak ondalıklı sayı alamaz?";
                                answer1 = "Dogru";
                                answer2 = "Yanlış";
                                correctAnswer = 'B';
                                break;
                            }
                     default: //Oyun bitimini defaul ile baglantılı yapıyoruz
                        {
                            Console.WriteLine("Tebrikler yarışmayı kazandınız");
                            Console.WriteLine($"Toplam {currentTrueQuestion} dogrunuz var");
                            gamePlayAble = false;//While döngüsünün daha fazla devam etmesine gerek kalmadıgı için false yapıyoruz
                            Console.ReadLine();
                            break;
                        }
                }
            }



        }
    }
}

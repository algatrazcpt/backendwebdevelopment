namespace Hafta2Kapanis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte taskId;
            while (19!= UserKeyControl(out taskId))//degiskeni methot içinden altdıktan sonra kullancagım için out yaptım
            {                                      //out olmadıgı durumda degsikenin degerini tutma gerekrirdi
            

                MethodSwitchSystem(taskId);
                Console.WriteLine("Devat etmek için herhangi bir tuşa basın");
                Console.ReadLine();
            }
        }
       
            static byte UserKeyControl(out byte taskId)//paramtereyi  hem kullanıp hemde döndermek için kullandım;
            {
                Console.Clear();
                Console.WriteLine("1 - HelloWorld yazdırır");
                Console.WriteLine("2 - Bir adet metinsel , bir adet tam sayı verisi tutmak için 2 adet değişken tanımlayınız. Bunların değerlerini atayıp , ekrana yazdırınız.");
                Console.WriteLine("3 - Rastgele bir sayı üretip , ekrana yazdırınız.");
                Console.WriteLine("4 - Rastgele bir sayı üretip , bunun 3’e bölümünden kalanı ekrana yazdırınız.");
                Console.WriteLine("5 - Kullanıcıya yaşını sorup , 18'den büyükse '+' küçükse '-' yazdıran bir uygulama.");
                Console.WriteLine("6 - Ekrana 10 defa \"Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem.\" yazan bir uygulama.");
                Console.WriteLine("7 - Kullanıcıdan 2 adet metinsel değer alıp \"Gülse Birsel\", \"Demet Evgar\", bunların yerlerini değiştiriniz.");
                Console.WriteLine("8 - Değer döndürmeyen ismi BenDegerDondurmem olan bir metot tanımlayınız. Ekrana \"Ben değer döndürmem, benim bir karşılığım yok, beni değişkene atamaya çalışma\" yazsın.");
                Console.WriteLine("9 - İki sayıyı alıp bunların toplam değerini geriye döndüren bir metot yazınız.");
                Console.WriteLine("10 - Kullanıcıdan true ya da false değeri alıp string bir değer dönen bir metot tanımlayınız.");
                Console.WriteLine("11 - 3 kişinin yaşlarını alıp en yaşlı olanının yaş bilgisini dönen bir metot yazınız.");
                Console.WriteLine("12 - Kullanıcıdan sınırsız sayıda sayı alıp , bunlardan en büyüğünü ekrana yazdıran ve aynı zamanda geriye dönen bir metot yazınız.");
                Console.WriteLine("13 - Bir metot yardımıyla kullanıcıdan alınan 2 ismin yerlerini değiştiren uygulamayı yazınız.");
                Console.WriteLine("14 - Kullanıcıdan alınan sayının tek mi yoksa çift mi olduğu bilgisini (true/false) dönen bir metot.");
                Console.WriteLine("15 - Kullanıcıdan alınan hız ve zaman bilgileriyle , gidilen yolu hesaplayan bir metot yazınız.");
                Console.WriteLine("16 - Yarıçap bilgisi verilen bir dairenin alanını hesaplayan bir metot yazınız.");
                Console.WriteLine("17 - Zaman bir GeRi SayIm cümlesini alıp , hepsi büyük harf ve hepsi küçük harfle yazdırınız.");
                Console.WriteLine("18 - \"    Selamlar   \" metnini bir değişkene atayıp , başındaki ve sonundaki boşlukları siliniz. Kalıcı olarak.");
                Console.WriteLine("19 - Programdan Çıkmak için 19 yazınız");
                do
                {
                    Console.Write("1-19 arasındaki taskları seçebilirsiniz:");
                    byte.TryParse(Console.ReadLine(), out taskId);
                }
                while (0 >= taskId || taskId > 19);

                return taskId;
            }

            static void MethodSwitchSystem(byte currentTask)
            {
                switch (currentTask)
                {
                    case 1:
                        {
                            Task1HelloWorld();
                            break;
                        }
                    case 2:
                        {
                            Task2VariableDefinitive(10, "degisken");
                            break;
                        }
                    case 3:
                        {
                            Task3RandomNumGenerate();
                            break;
                        }
                    case 4:
                        {
                            Task4RandomNumGenerateAndControl();
                            break;
                        }
                    case 5:
                        {
                            Task5AgeCalculate();
                            break;
                        }
                    case 6:
                        {
                            Task6NumWriter();
                            break;
                        }
                    case 7:
                        {
                            Task7StringValueDefaultChanger("degismeyen string1", "degismeyen string2");
                            break;
                        }
                    case 8:
                        {
                            Task8BenDegerDondurmem();
                            break;
                        }
                    case 9:
                        {
                            Console.WriteLine(Task9NumSum(10, 20));
                            break;
                        }
                    case 10:
                        {
                            Console.WriteLine(Task10TrueFalseConvertString(true));
                            break;
                        }
                    case 11:
                        {
                            Console.WriteLine(Task11MaxAgeCalculate(24, 32, 26));
                            break;
                        }
                    case 12:
                        {
                            Console.WriteLine("Her girilen sayıdan sonra virgu latıp diger sayıya geçiniz örnek(1,5) \n Toplanmasını istediginiz sayılar:");
                            Console.WriteLine(Task12AllNumsMax(Console.ReadLine()));
                            break;
                        }
                    case 13:
                        {
                            Task13StringValueChange("Atakan", "Hello");
                            break;
                        }
                    case 14:
                        {
                            Console.WriteLine("Bir sayı Giriniz");
                            int.TryParse(Console.ReadLine(), out int num);
                            Console.WriteLine($"sayınız {num} {Task14NumOddEvenControl(num)}");
                            break;
                        }
                    case 15:
                        {
                            Console.Write("Hızınızı Giriniz:");
                            int.TryParse(Console.ReadLine(), out int speed);
                            Console.Write("Kaç saat gitceginizi Giriniz:");
                            int.TryParse(Console.ReadLine(), out int time);
                            Task15RoadCalculate(speed, time);
                            break;
                        }
                    case 16:
                        {
                            Console.Write("Dairenin yarı çapını Giriniz:");
                            int.TryParse(Console.ReadLine(), out int num);
                            Task16RegionCalculate(num);
                            break;
                        }
                    case 17:
                        {
                            Task17DefaultStringValueUpperLower();
                            break;
                        }
                    case 18:
                        {
                            Task18DefaultStringValueClearSpace();
                            break;
                        }
                }
        }
            static void Task1HelloWorld()
            {
                Console.WriteLine("Aşağıdaki çıktıyı yazan bir program.");
                Console.WriteLine("Merhaba\r\nNasılsın ?\r\nİyiyim\r\nSen nasılsın ?");
            }
            static void Task2VariableDefinitive(int num, string commet)
            {
                Console.WriteLine("2 - Bir adet metinsel , bir adet tam sayı verisi tutmak için 2 adet değişken tanımlayınız. Bunların değerlerini atayıp , ekrana yazdırınız.");
                num = 34;
                commet = "Task2";
                Console.WriteLine($"{num}  {commet}");
            }
            static void Task3RandomNumGenerate()
            {
                Console.WriteLine("\r\n3 - Rastgele bir sayı üretip , ekrana yazdırınız.");
                Console.WriteLine($"rastgele sayınız:{new Random().Next()}");
            }
            static void Task4RandomNumGenerateAndControl()
            {
                Console.WriteLine("4 - Rastgele bir sayı üretip , bunun 3'e bölümünden kalanı ekrana yazdırınız.");
                int numRandom = new Random().Next();
                Console.WriteLine($"rastgele sayınız:{numRandom} %3 = {numRandom % 3} ");
            }
            static void Task5AgeCalculate()
            {
                Console.WriteLine("5 - Kullanıcıya yaşını sorup , 18'den büyükse \"+\" küçükse \"-\" yazdıran bir uygulama.");
                Console.Write("Yaşınızı Giriniz:");
                byte.TryParse(Console.ReadLine(), out byte age);
                Console.WriteLine(age > 18 ? "+" : "-");
            }
            static void Task6NumWriter()
            {
                Console.WriteLine("6 - Ekrana 1- 10 kadar yazdırır");
                for (int num = 1; num < 10; num++)
                {
                    Console.WriteLine($"Sayı {num}");
                }
            }
            static void Task7StringValueDefaultChanger(string inputName1, string inputName2)
            {
                Console.WriteLine("7 - Kullanıcıdan 2 adet metinsel değer alıp \"Gülse Birsel\" , \"Demet Evgar\" , bunların yerlerini değiştiriniz.");
                Console.WriteLine($" Degismeden önce {inputName1} {inputName2}");
                inputName1 = "Demet Evgar";
                inputName2 = "Gülse Birsel";
                Console.WriteLine($"Degisimden sonra{inputName1} {inputName2}");
            }
            static void Task8BenDegerDondurmem()
            {
                Console.WriteLine("8 - Değer döndürmeyen ismi BenDegerDondurmem olan bir metot tanımlayınız. Ekrana \"Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma\" yazsın.");
                Console.WriteLine("Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma");
            }
            static int Task9NumSum(int num1, int num2)
            {
                Console.WriteLine("9 -  İki sayıyı alıp bunların toplam değerini geriye döndüren bir metot yazınız.");
                return num1 + num2;
            }
            static string Task10TrueFalseConvertString(bool aviableProgram)
            {
                Console.WriteLine("10 - Kullanıcıdan true ya da false değeri alıp string bir değer dönen bir metot tanımlayınız.");
                return aviableProgram ? "Hello world" : "Ower World";
            }
            static int Task11MaxAgeCalculate(int age1, int age2, int age3)
            {
                Console.WriteLine("11 - 3 Kişinin yaşlarını alıp en yaşlı olanının yaş bilgisini dönen bir metot yazınız.");
                int maxAge = Math.Max(Math.Max(age1, age2), age3);

                return maxAge;
            }
            static int Task12AllNumsMax(string allNumsString)
            {
                int[] allNums = Array.ConvertAll(allNumsString.Split(','), Convert.ToInt32);

                Console.WriteLine("12 - Kullanıcıdan sınırsız sayıda sayı alıp , bunlardan en büyüğünü ekrana yazdıran ve aynı zamanda geriye dönen bir metot yazınız.");
                return allNums.Max();
            }
            static void Task13StringValueChange(string inputName1, string inputName2)
            {
                Console.WriteLine("13- Bir metot yardımıyla kullanıcıdan alınan 2 ismin yerlerini değiştiren uygulamayı yazınız.");
                Console.WriteLine($" Degismeden önce {inputName1} {inputName2}");
                string tempName = inputName1;
                inputName1 = inputName2;
                inputName2 = tempName;
                Console.WriteLine($"Degisimden sonra {inputName1} {inputName2}");
            }
            static bool Task14NumOddEvenControl(int num)
            {
                Console.WriteLine("14 - Kullanıcıdan alınan sayının tek mi yoksa çift mi olduğu bilgisini (true/false) dönen bir metot.");
                return num % 2 == 0 ? true : false;//if else olsayı 2 tane return  lazımdı onunyerine  ? saglandıgında true dönderiyorum yoksa false
            }
            static void Task15RoadCalculate(int speed, int time)
            {
                Console.WriteLine("15 - Kullanıcıdan alınan hız ve zaman bilgileriyle , gidilen yolu hesaplayan bir metot yazınız.");
                Int64 roadCalc = speed * time;
                Console.WriteLine($"Aracın Hızı:{speed} geçen zaman:{time} gidilen yol {roadCalc}");
            }
            static void Task16RegionCalculate(double num)
            {
                Console.WriteLine("16 - Yarıçap bilgisi verilen bir dairenin alanını hesaplayan bir metot yazınız.");
                double region = Math.PI * (num * num);//Math fonksiyonun içinde pi degiskeni tanımlıydı hesaplarken onu kullanıdm üstlü işlemlerde
                                                      //tam sayı gerekir bilerek kendiyle çarptım
                Console.WriteLine($"Yarı çapınız:{num} Dairenin alanı{region}");
            }
            static void Task17DefaultStringValueUpperLower()
            {
                Console.WriteLine("17 - \"Zaman bir GeRi SayIm\" cümlesini alıp , hepsi büyük harf ve hepsi küçük harfle yazdırınız.");
                string comment = "Zaman bir GeRi SayIm";
                Console.WriteLine(comment.ToUpper());//Bütün harfleri büyüttüm
                Console.WriteLine(comment.ToLower());//Bütün harfleri küçülttümm
            }
            static void Task18DefaultStringValueClearSpace()
            {
                Console.WriteLine("18 - \"    Selamlar   \" metnini bir değişkene atayıp , başındaki ve sonundaki boşlukları siliniz. Kalıcı olarak.");
                string comment = "    Selamlar   ";
                comment = comment.Trim();//Trim işlemi kalıcı degildir degiskene atadım
                Console.WriteLine(comment);
            }


        }
    }

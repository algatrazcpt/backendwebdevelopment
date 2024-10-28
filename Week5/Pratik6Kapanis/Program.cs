using System.Diagnostics.Contracts;
using System.Drawing;

namespace Pratik6Kapanis
{
    public enum CarFuelType
    {
        Gasoline=1,
        Diesel = 2
    }
    public class Car
    {
        //bütün ddegiskenleri dışarıya kapalı yatım
        //sabit degiskenler oluştudum const ile
        private const double motorCost = 1250;
        private const double sunRoofCostX = 1.10;
        private const double doorCountCostX = 1;

        private DateTime productTime;

        private string modelName;

        private int doorCount;
        private decimal price;
        private double motorPower;
        private bool haveSunRoof;
        private CarFuelType fuelType;
        
        

        public Car(DateTime productTime, string modelName, int doorCount , double motorPower, bool haveSunRoof,CarFuelType fuelType)
        {
            this.productTime = productTime;
            this.modelName = modelName;
            this.doorCount = doorCount;
            this.motorPower = motorPower;
            this.haveSunRoof = haveSunRoof;
            this.fuelType = fuelType;
            PriceCalculate();
        }

        void PriceCalculate()
        {
            //para işlemleri için decimale çeviriyorum

           price = (decimal)((doorCountCostX / doorCount) * (motorCost * motorPower) * (haveSunRoof ? sunRoofCostX : 1));
           price *= (fuelType == CarFuelType.Diesel ? 2 : 1);
        }
        public override string ToString()
        {
            return $"Üretim Tarihi:{productTime}| Model:{modelName} | Motor Gücü:{motorPower} | SunRoof:{(haveSunRoof?"Var":"Yok")}| Yakıt Tipi:{(fuelType==CarFuelType.Gasoline?"Benzin":"Dizel")}| Fiyatı:{price} ";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> carList = new List<Car>();
            string modelName = string.Empty;
            int? doorCount = null;
            int? fuelType = null;
            bool? haveSunRoof = null;
            double? motorPower = null;
            string? choosen = string.Empty;

            while (true)
            {
                try
                {
                    //degiskene atama yapılmadıysa  çalışıyor
                    if (modelName == "")
                    {
                        ChangeForeGroundColorTextShow("Modeli Giriniz:", ConsoleColor.Blue);
                        modelName = Console.ReadLine();
                        //Gelen deger boş ise hata oluşturuyorum
                        if (modelName == "")
                        {
                            modelName = null;
                            throw new Exception("Model boş olamaz");
                        }
                    }
                    if (doorCount == null)
                    {
                        ChangeForeGroundColorTextShow("Kapı Sayısını Giriniz 2-4:", ConsoleColor.Blue);
                        doorCount = int.Parse(Console.ReadLine());
                        if (doorCount != 2 && doorCount != 4)
                        {
                            doorCount = null;
                            //format exception hatası vermezse sayılara göre kontrol edip hata veriyorum
                            throw new Exception("Kapı sayısı 2 veya 4 olabilir");
                        }
                    }
                    if (haveSunRoof == null)
                    {
                        ChangeForeGroundColorTextShow("Sunroof varmı E(vet)/H(ayır):", ConsoleColor.Blue);
                        string input = Console.ReadLine().ToLower();
                        if (input != "e" && input != "h")
                        {
                            haveSunRoof = null;
                            throw new Exception("E/H harflerinden birini yazınız");
                        }
                        //bir üstte zaten e ve h harflerinin kontrol ettik e harfi yeterli olcaktır
                        haveSunRoof = input == "e";
                    }
                    if (fuelType == null)
                    {
                        ChangeForeGroundColorTextShow("Benzin için 1 Dizel İçin 2\n(1/2) Yakıt Tipiniz::", ConsoleColor.Blue);
                        fuelType = int.Parse(Console.ReadLine());
                        if (fuelType != 1 && fuelType != 2)
                        {
                            fuelType = null;
                            throw new Exception("Benzinli için 1 Dizel için 2 sayısı girilebilir sadece");
                        }
                    }

                    if (motorPower == null)
                    {
                        ChangeForeGroundColorTextShow("Motor gücünü Giriniz:", ConsoleColor.Blue);
                        motorPower = double.Parse(Console.ReadLine());
                        //En son kontrolden sonra listeye ekliyruz
                        //herhangib bir hata da exceptiona gider
                        //burda tip dönüşümü yapmak zorundayız çünkü degiskenleri oluşturuken boş olarak oluşturduk
                        carList.Add(new Car(DateTime.Now, modelName, (int)doorCount, (double)motorPower,(bool)haveSunRoof,(CarFuelType)fuelType));
                    }
                    //Bütün işlemler hatasız ise buraya gelir


                    ChangeForeGroundColorTextShow("Başka araba daha eklemek istermisiniz E(vet)/H(ayır)", ConsoleColor.Blue);
                    choosen = Console.ReadLine();
                    if (choosen != "")
                    {
                        if (choosen == "e")
                        {
                            modelName = string.Empty;
                            doorCount = null;
                            fuelType = null;
                            haveSunRoof = null;
                            motorPower = null;
                            continue;
                        }
                        else if (choosen == "h")
                        {
                            Console.Clear();
                            break;
                        }
                    }
                }
                catch (FormatException e)
                {
                    
                    ChangeForeGroundColorTextShow("Bir sayı girmelisiniz\n");
                }
                catch (Exception e)
                {
                    //Genel hataalarımız buraya düşüyor format exception sonra yazdık çünkü daha kapsamlı bir yakalar
                    //Gelen verideki sadce hata mesajını alıyoruz
                    ChangeForeGroundColorTextShow(e.Message.ToString() + "\n");
                    continue;
                }
            }
            ShowListItems(carList);
        }
        static void ShowListItems(List<Car> carList)
        {
            foreach (Car car in carList)
            {
                ChangeForeGroundColorTextShow(car.ToString()+"\n", ConsoleColor.Blue);
            }
        }
        static void ChangeForeGroundColorTextShow(string value, ConsoleColor customColor = ConsoleColor.Red)
        {
            Console.ForegroundColor = customColor;
            Console.Write(value);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }

}
    


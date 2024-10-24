using System.ComponentModel;
using System.Xml.Linq;

namespace Hafta4Kapanis
{
 
    abstract class BaseMachine
    {
        DateTime productTime;
        string serialNumber;
        string name;
        string info;
        string systemName;

        public DateTime ProductTime { get => productTime; set => productTime = value; }
        public string SerialNumber { get => serialNumber; set => serialNumber = value; }
        public string Name { get => name; set => name = value; }
        public string Info { get => info; set => info = value; }
        public string SystemName { get => systemName; set => systemName = value; }

        public BaseMachine()
        {

        }
        protected BaseMachine(DateTime productTime, string serialNumber , string name , string info , string systemName )
        {
            ProductTime = productTime;
            SerialNumber = serialNumber;
            Name = name;
            Info = info;
            SystemName = systemName;
        }

        protected virtual string GetItemInfo()
        {
            //productTime.ToString("d") datetime basit sekilde göstermek için içined yazdık
            //$"" işaretiile tanımlanmış bir veri içine {} şekilde bir atama yapamayacım için ekstradan işlemden sonra ekledim
            string a = "{0}//"+$"adı={Name}|üretim tarihi={ProductTime.ToString("d")}|seri numarası={SerialNumber}|detaylar={Info}|isletim sistemi={SystemName}"+"|{1} ";
            return a;
        }
        //Bütün türetilmiş sınıflarda add olcak ve diger atamaları tekrar atamak yerine burda tnaımlıyoruz
        public virtual void Add()
        {
            //AutoAdded productime
            ProductTime = DateTime.Now;
            Console.Write("Ürünün Adı=");
            Name = Console.ReadLine();
            Console.Write("Ürünün Seri Numarası=");
            SerialNumber = Console.ReadLine();
            Console.Write("Ürünün Detayları=");
            Info = Console.ReadLine();
            Console.Write("Ürünün İşletim Sistemi=");
            SystemName = Console.ReadLine();
        }
        public virtual void ShowInfo() { }
    }
    class Phone: BaseMachine
    {
        bool lisansAcces;

        public bool LisansAcces { get => lisansAcces; set => lisansAcces = value; }

        public Phone()
        {

        }

        //Phone sınıfının constructır kalıtım ypaılan sınıfa parametre olarak gönderiyorum
        public Phone(DateTime productTime, string serialNumber, string name, string info, string systemName,bool lisansAcces) : base(productTime, serialNumber, name, info, systemName)
        {
            LisansAcces = lisansAcces;
        }
        protected override string GetItemInfo()
        {
            //base.GetItemInfo ile öncdeki gelen veriyi alıp ekstra veri ekleyip  tekrardan override ediyorum
            return string.Format(base.GetItemInfo(),"Telefonunuzun Özellikleri",$"lisas Durumu={(LisansAcces?"Tr lisans vardır":"Tr lisans yoktur")}");
        }

        public override void Add()
        {
            //kalıtımla gelen add kullanıldı ve kullanıldıktan sonra özelliştirip eziyorum
            base.Add();
            Console.Write("Tr Lisans V(ar)/Y(ok)=");
            //degisken olarak string tutmak yerine gen stringi bool yapısı için özelleştirdim
            string bluetoothStateString = Console.ReadLine().ToLower();
            if (bluetoothStateString == "v")
            {
                LisansAcces = true;
            }
            else if (bluetoothStateString == "y")
            {
                LisansAcces = false;
            }
            else
            {
                //degisken atamalarını capsulenen method üzerinden yaptım bu sayede kapsuldeki bir kontrol yapısı var çalışcak
                LisansAcces = false;
            }
        }

        public override void ShowInfo()
        {
            Console.WriteLine(GetItemInfo());
        }
    }
    class Computer : BaseMachine
    {
        int usbPortCount;
        bool bluetoothHas;

        public int UsbPortCount
        {
            get => usbPortCount;
            set
            {
                usbPortCount=value;

                if (value != 2&& value != 4)
                {
                    usbPortCount = -1;
                    Console.WriteLine("Port Sayısı uygun degil");
                }
            }
        }
        public bool BluetoothHas { get => bluetoothHas; set => bluetoothHas = value; }

        public Computer()
        {

        }

        public Computer(DateTime productTime, string serialNumber, string name, string info, string systemName, int usbPortCount, bool bluetoothHas) : base(productTime, serialNumber, name, info, systemName)
        {
            //Degisken atamaları için capsullere yolladım bu sayede kendi içindeki kontrol çalıaşabilecek
            UsbPortCount = usbPortCount;
            this.bluetoothHas = bluetoothHas;
        }
        protected override string GetItemInfo()
        {
            return string.Format(base.GetItemInfo(), "Bilgisayarınızın Özellikleri", $"{"usbPort sayisi="+usbPortCount +"|"+(bluetoothHas? "bluetooth var":"blutooth yok")}");
        }

        public override void ShowInfo()
        {
            Console.WriteLine(GetItemInfo());
        }
        public override void Add()
        {
            base.Add();
            Console.Write("UsbPortCount=");
            int.TryParse(Console.ReadLine(), out int _usbPortCount);
            UsbPortCount = _usbPortCount;
            Console.Write("bluetooth V(ar)/Y(ok)=");
            string bluetoothStateString = Console.ReadLine().ToLower();
            if(bluetoothStateString=="v")
            {
                BluetoothHas = true;
            }
            else if(bluetoothStateString == "y")
            {
                BluetoothHas = false;
            }
            else
            {
                Console.WriteLine("Belirtilien degerlerden birini girmediniz  yokmus gibi kaydedildi");
                BluetoothHas = false;
            }
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Computer computer;
            Phone phone;
            List<BaseMachine> allProduct=new List<BaseMachine>();
            int productId = 0;
            bool programState = true;
            while (programState) 
            {
                Console.WriteLine("Bilgisayar Üretmek için 1");
                Console.WriteLine("Telefon Üretmek için 2");
                int.TryParse(Console.ReadLine(),out productId);
                if(productId==1||productId==2)
                {
                    if(productId==1)
                    {
                        computer = new Computer();
                        computer.Add();
                        allProduct.Add(computer);
                        Console.WriteLine("ekleme yapııldı");
                    }
                    else
                    {
                        phone = new Phone();
                        phone.Add();
                        allProduct.Add(phone);
                        Console.WriteLine("ekleme yapııldı");
                    }
                    do
                    {
                        Console.WriteLine("Yeni ürün eklemek istermisiniz E(vet)/H(ayır)");
                        string userChoose = Console.ReadLine().ToLower();
                        if(userChoose=="e")
                        {
                            break;
                        }
                        else if(userChoose=="h")
                        {
                            programState = false;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Uygun olmayan kullanıcı girdisi E/H");
                        }
                    }
                    while (true);
                }
                else
                {
                    Console.WriteLine("1-2 arasında bir tercih yapabilirsiniz");
                }

            }
            foreach (var producted in allProduct)
            {
                producted.ShowInfo();

            }
        }
    }
}

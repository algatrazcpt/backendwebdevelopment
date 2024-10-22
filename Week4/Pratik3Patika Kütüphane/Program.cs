using System.Collections;


namespace Pratik3Patika_Kütüphane
{

    public  class Library
    {
        string bookName = "";
        string bookPublisher = "";
        string bookNameWriterName = "";
        string bookNameWriterSurName = "";
        int bookPageCount = 0;

        DateTime bookAddTime = DateTime.Now;
        //degiskenleri dışardan erişlebilmesi için methodlara baglıyoruz
        public string BookName { get => bookName; set => bookName = value; }
        public string BookPublisher { get => bookPublisher; set => bookPublisher = value; }
        public string BookNameWriterName { get => bookNameWriterName; set => bookNameWriterName = value; }
        public string BookNameWriterSurName { get => bookNameWriterSurName; set => bookNameWriterSurName = value; }
        public int BookPageCount { get => bookPageCount; set => bookPageCount = value; }
        public DateTime BookAddTime { get => bookAddTime; set => bookAddTime = value; }

        //Boş constructur oluşturdum
        public Library() {  }

        //burda degiskenleri ilk oluşturdugumuzdas atıyoruz
        public Library(string bookName, string bookPublisher, string bookNameWriterName, string bookNameWriterSurName, int bookPageCount, DateTime bookAddTime)
        {
            this.bookName = bookName;
            this.bookPublisher = bookPublisher;
            this.bookNameWriterName = bookNameWriterName;
            this.bookNameWriterSurName = bookNameWriterSurName;
            this.bookPageCount = bookPageCount;
            this.bookAddTime = bookAddTime;
        }
        public string BookShowInfo()
        {
            string outPutFormat = $"{bookName} | {bookNameWriterName} {bookNameWriterSurName} | {bookPageCount} | {bookPublisher} | {bookAddTime}";
            return outPutFormat;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<Library> patikaLibrary = new List<Library>();
            patikaLibrary.Add(new Library("The Great Gatsby","Charles Scribner's Sons","F. Scott","Fitzgerald",218,DateTime.Now));
            patikaLibrary.Add(new Library("To Kill a Mockingbird", "J.B. Lippincott & Co.", "Harper", "Lee", 281, DateTime.Now));
            patikaLibrary.Add(new Library("1984", "Secker & Warburg", "George", "Orwell", 328, DateTime.Now));
            patikaLibrary.Add(new Library("Pride and Prejudice", "T. Egerton", "Jane", "Austen", 279, DateTime.Now));
            patikaLibrary.Add(new Library("Moby-Dick", "Harper & Brothers", "Herman", "Melville", 635, DateTime.Now));
            Console.WriteLine("Ad, Yazar Adı, Yazar Soyadı, Sayfa Sayısı, Yayınevi, Kayit Tarihi");
            foreach(Library book in patikaLibrary)
            {
                Console.WriteLine(book.BookShowInfo());
                Console.WriteLine(new String('*',book.BookShowInfo().Length));
            }
            Console.ReadLine();

        }
    }
}

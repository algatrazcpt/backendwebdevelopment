using System.Linq;

namespace Pratik4LinqJoin
{
    public class Author
    {
        public int authorId;
        public string authorName;

        public Author(int authorId, string authorName)
        {
            this.authorId = authorId;
            this.authorName = authorName;
        }
    }
    public class Book
    {
        public int authorId;
        public int bookId;
        public string bookTitle;

        public Book(int authorId, int bookId, string bookTitle)
        {
            this.authorId = authorId;
            this.bookId = bookId;
            this.bookTitle = bookTitle;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            List<Author> authorsList=new List<Author>();
            List<Book> booksList = new List<Book>();

            authorsList.Add(new Author(1,"Yazar1"));
            authorsList.Add(new Author(2, "Yazar2"));
            authorsList.Add(new Author(3, "Yazar3"));
            booksList.Add(new Book(1, 1, "Kitap1"));
            booksList.Add(new Book(1, 2, "Kitap2"));
            booksList.Add(new Book(1, 3, "Kitap3"));
            booksList.Add(new Book(1, 4, "Kitap4"));
            booksList.Add(new Book(2, 5, "Kitap1"));
            booksList.Add(new Book(2, 6, "Kitap2"));
            booksList.Add(new Book(3, 7, "Kitap1"));

            foreach (var values in booksList.Join(authorsList, booksListed => booksListed.authorId, authorsList2 => authorsList2.authorId, (booksListed, authorlist2) => new {bookName= booksListed.bookTitle,authorName=authorlist2.authorName}))
            {
                Console.WriteLine("Yazar Adi:"+values.authorName + "\t Kitap Adi:"+values.bookName);
            }
            

        }
    }
}


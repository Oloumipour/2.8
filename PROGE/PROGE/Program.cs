using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROGE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // تعریف شی
            Book book1 = new Book("bahar", " ahmadi", 12345678, true);
            Book book2 = new Book(" darya", "sharafi", 23456789, true);



            
            Console.WriteLine("hi");
            Console.ReadKey();
            
        }
    }
}
class Library
{// کپسوله سازی
    private string book;// field
    private string person;
    public string Book// property
    {
        get { return Book; }
        set { Book = value; }
    }
    public string Person
    {
        get { return person; }
        set { person = value; }
    }


    //سازنده
    public Library (string book, string person)
    {
        this.Book = book;
        this.Person = Person;
    }

    // method

    private List<Book> Books = new List<Book>();
    public void AddBook(Book book)
    {
        BookS add(book);
        Console.WriteLine($";ketabe {book.Title} be ketabkhaneh azafeh shod. ");

    }
    public void removeBook(string isbn)
    {
        var book = Books.Find(b => b.ISBN ==isbn);
        if (book != null)
        {
            Books.Remove(book);
            Console.WriteLine($"ketabe {book.Title}  hazf shod.");
            
        }
        else
        {
            Console.WriteLine($"ketab yaft nashod!");

        }
    }
    public Book FindBook(string title)
    {
        return Books.Find(b => b.Title.ToLower() == title.ToLower());
    }
    public void listBooks()
    {
        Console.WriteLine($"list ketabhaye mojid:   ");
        foreach (var  book in Books)
        {
            book.DisplayInfo();
        }
    }

}
class Book 
{
    private string title;//field
    private string author;
    private int isbn;
    private bool isAvailable;

    public string Title//proprty
    {
        get { return Title; }
        set { Title = value; }
    }
    public string Author
    {
        get { return Author; }
        set { Author = value; }
    }
    public int ISBN
    {
        get { return ISBN; }
        set { ISBN = value; }
    }
    public bool IsAvailable
    {
        get { return IsAvailable; }
        set { IsAvailable = value; }
    }

    //سازنده
    public  Book (string title,string athour,int ISBN,bool IsActive)
    {
        this.Title = title;
        this.Author= author;
        this.ISBN = ISBN;
        this.IsAvailable = isAvailable;
    }

    //method

   

        public void DisplayInfo ()
    {
      
        Console.WriteLine($"name ketab{Title} in ketab navashte {Author} ba kod shabak{ISBN} mojod { IsAvailable} ");


    }

    public void BorrowBook ()
    {
        if (IsAvailable)
        {
            IsAvailable = false;
            Console.WriteLine($"{Title} amanat garefte shode.");

        }
        else
        {
            Console.WriteLine($"{Title} dar dastras nist!");

        }
    }


    public void returnBook()
    {
        IsAvailable = true;
        Console.WriteLine($"{Title} baz gardande shod");
    }
    
        



    }

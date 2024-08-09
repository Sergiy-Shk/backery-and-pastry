using System;
using System.Collections.Generic;

namespace ConsoleApp4
{

    public class Author
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }

        public Author(string name, DateTime birthDate)
        {
            Name = name;
            BirthDate = birthDate;
        }


        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Birthday date: {BirthDate.ToString("dd.MM.yyyy")}");
        }
    }



    public class Book
    {
        public string Title { get; set; }
        public Author Author { get; set; }
        public int Year { get; set; }

        public Book(string title, Author author, int year)
        {
            Title = title;
            Author = author;
            Year = year;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Caption: {Title}");
            Console.WriteLine($"Autor: {Author.Name}");
            Console.WriteLine($"Publishing year: {Year}");
        }
    }


    public class Library
    {
        private List<Book> books;

        public Library()
        {
            books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void DisplayBooks()
        {
            Console.WriteLine("Books in the library:\n");
            foreach (var book in books)
            {
                book.DisplayInfo();
                Console.WriteLine();
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Author author1 = new Author("J.K. Rowling", new DateTime(1965, 7, 31));

            Author author2 = new Author("Mark Twain", new DateTime(1835, 11, 30));

            Book book1 = new Book("Harry Potter and the Philosopher's Stone", author1, 1997);

            Book book2 = new Book("The Adventures of Tom Sawyer", author2, 1876);

            Library library = new Library();

            library.AddBook(book1);

            library.AddBook(book2);

            library.DisplayBooks();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Lesson_12
{
    internal class Library
    {
        private List<Book> books = new List<Book>();
        public Library() { }
        public void Add(Book b)
        {
            if (b == null) return;
            books.Add(b);
        }

        public void Remove(Book b)
        {
            foreach (var book in books)
            {
                if(book.Title.Equals(b.Title) && book.Author.Equals(b.Author) && 
                    book.Year == b.Year && book.Genre.Equals(b.Genre))
                {
                    books.Remove(book);
                    Console.WriteLine("Книга удалена.");
                    break;
                }
            }
           
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            foreach(Book b in books)
            {
                result = new StringBuilder(b.ToString() + '\n') ;
            }
            return result.ToString();
        }

        public List<Book> SearchByAuthor(string author)
        {
            List<Book> books_ = new List<Book>();
            foreach (Book b in books)
            {
                if(b.Author.Equals(author))
                {
                    books_.Add(b);
                }
            }
            return books_;
        }

        public List<Book> SearchByTitle(string title)
        {
            List<Book> books_ = new List<Book>();
            foreach (Book b in books)
            {
                if (b.Title.Equals(title))
                {
                    books_.Add(b);
                }
            }
            return books_;
        }

        public void DisplayAllBooks()
        {
            foreach(Book b in books)
            {
                Console.WriteLine(b.ToString());
            }
        }
    }
}

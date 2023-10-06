using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BookLib
{
    public class BookRepository
    {
        private List<Book> books = new List<Book>()
        {
            (new Book(1, "Spiderdyret",69) ),
            (new Book(2, "Spiderdyret part 2",79) ),
            (new Book(3, "Spiderdyret part 3",89) ),
            (new Book(4, "Spiderdyret part 4",99) ),
            (new Book(5, "Spiderdyret return of the king",109) )

        };
        public List<Book> GetAllBooks()
        {
            return new List<Book> (books);
        }
        public Book Getbyid(int id)
        {
            foreach (Book book in books)
            {
                if (book.Id == id)
                return book;

            }
            return null;
        }

        public Book Add(Book book)
        {
            int newId = books.Count > 0 ? books.Max(b => b.Id) +1: 1;
            book.Id = newId;
            books.Add(book);
            return book;
        }

            
       
        public Book SortbyTitle()
        {
            foreach (Book book in books)
            {
                GetAllBooks();
                if (book.Title != null)
                    return book;
            }
            return null;
        }



        public Book SortbyPrice()
        {
          foreach (var x in books)
            {
                if (250 <= x.Pris)
                {
                    return x;
                }
            }
            return null;
        }
        
    public Book delete(int id)
        {
            Book booksdelete = Getbyid(id);
            if (booksdelete != null)
            {
                books.Remove(booksdelete);
            }
            return booksdelete;
        }
    public Book Update (int id, Book updatetbook)
        {
            Book? existingBook = books.Find(x => x.Id == id);
            if (existingBook != null)
            {
                existingBook.Title = updatetbook.Title;
                existingBook.Pris = updatetbook.Pris;
                return existingBook;
            }
            return null;
        }

       
    }
}

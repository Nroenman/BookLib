using Microsoft.VisualStudio.TestTools.UnitTesting;
using BookLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLib.Tests
{
    [TestClass()]
    public class BookTests
    {

        private Book book;
        private BookRepository Repo;
        [TestInitialize]

        public void BeforeEachTest()
        {
            book = new Book();
            Repo = new BookRepository();
        }

        [TestMethod()]
        public void BookTest()
        {
            Assert.Fail();
        }
        Book reference = new Book()
        {
            Pris = 8

        };

        [TestMethod()]

        public void ToStringTest()
        {
            string s = reference.ToString();
            Assert.AreEqual<string>("Pris:8", s);
        }

        [TestMethod()]
        public void GetTestOk()
        {
            int expetedcount = 5;
            List<Book> actual = Repo.GetAllBooks();
            Assert.AreEqual(expetedcount, actual.Count());

        }
        [TestMethod()]
        public void GetbyIDTest()
        {
            Book expectedBook = new Book(1, "Spiderdyret", 69);
            Book actual = Repo.Getbyid(expectedBook.Id);
            
            Assert.AreEqual(expectedBook.Id, actual.Id);
            Assert.AreEqual(expectedBook.Title, actual.Title);
            Assert.AreEqual(expectedBook.Pris, actual.Pris);
        }

        [TestMethod]
        public void GetByIDTestReturnNull()
        {
            int expetedID = 0;
            Book actualBook = Repo.Getbyid(expetedID);
            
            Assert.IsNull(actualBook);

        }

        
        [TestMethod()]
        public void BookTitleTest()
        {
            Book Spiderman = new Book();


            Spiderman.Title = "Spiderdyret";

           
            Assert.IsTrue(Spiderman.Title.Length >= 3);
        }


        [TestMethod]
        public void AddTestok()
        {
            int FirstCount = Repo.GetAllBooks().Count;
            Book newBook = new Book(0, "Spiderman from junkyland",169);
            Book addedbook = Repo.Add(newBook);

            Assert.IsNotNull(addedbook);
            Assert.IsTrue(addedbook.Id > 0);
            Assert.IsTrue(addedbook.Id == Repo.GetAllBooks().Max(b => b.Id));
            Assert.AreEqual("Spiderman from junkyland",addedbook.Title);
            Assert.AreEqual(169, addedbook.Pris);

            int finalCount = Repo.GetAllBooks().Count;
            Assert.AreEqual(FirstCount +1, finalCount);
        }



    }
}


    

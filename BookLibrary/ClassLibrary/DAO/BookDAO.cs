using ClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.DAO
{
    
    public class BookDAO
    {
        private static BookDAO instance = null;
        private static readonly object instanceLock = new object();
        public BookDAO() { }
        public static BookDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new BookDAO();

                    }
                    return instance;
                }
            }
        }
        public List<Book> GetBookList()
        {
            List<Book> book = null;
            try
            {
                using BookLibrariContext context = new BookLibrariContext();
                book = context.Books.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return book;

        }
        public List<Book> GetBookListByName(string pattern)
        {
            var bookList = new List<Book>();
            try
            {
                BookLibrariContext context = new BookLibrariContext();
                bookList = (context.Books).Where(p => p.BookName.Contains(pattern)).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return bookList;

        }
        public Book GetBookInfor(int id)
        {
            var book = new Book();
            try
            {
                BookLibrariContext context = new BookLibrariContext();
                book = context.Books.FirstOrDefault(b => b.BookId == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return book;

        }
        public List<Book> GetBookListByCategory(string category)
        {
            var bookList = new List<Book>();
            try
            {
                BookLibrariContext context = new BookLibrariContext();
                bookList = (context.Books).Where(p => p.Category.Contains(category)).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return bookList;

        }

        public void InsertBook(Book book)
        {
            try
            {
                using BookLibrariContext context = new BookLibrariContext();
                context.Books.Add(book);
                context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public void UpdateBook(Book book)
        {
            try
            {
                using BookLibrariContext context = new BookLibrariContext();
                context.Entry<Book>(book).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public void DeleteBook(Book book)
        {
            try
            {
                using BookLibrariContext context = new BookLibrariContext();
                var b = context.Books.SingleOrDefault(e => e.BookId == book.BookId);
                context.Books.Remove(b);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
    
}

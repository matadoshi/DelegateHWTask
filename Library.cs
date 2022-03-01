using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateHWTask
{
    internal class Library
    {
        private List<Book> _books;
        public List<Book> Books => _books;
        public Library()
        {
            _books=new List<Book>();
        }
        public void AddBooks(string bookname,string authorname,int pagecount)
        {
           
            Book book=new Book(bookname,authorname,pagecount);
            
            _books.Add(book);
        }
        public List<Book> FindAllBooksByName(string name)
        {
            List <Book> result= new List<Book>();
            //foreach (var book in _books)
            //{
            //    if (book.BookName.Contains(name))
            //    {
            //        result.Add(book);
            //    }
            //}
            _books.ForEach(item => 
            {
                if (item.BookName.Contains(name))
                {
                    result.Add(item);
                }
            }
            );
            return result;
        }
        public List<Book> RemoveAllBookByName(string name)
        {
            List<Book> result = new List<Book>();

            foreach (var item in _books)
            {
                if(item.BookName.Contains(name))
                {
                    result.Add(item);
                }
            }
            foreach (var book in result)
            {
                _books.Remove(book);
            }
            return _books;
        }
        public List<Book> SearchBooks(string search)
        {
            List<Book> result = new List<Book>() { null};

            _books.ForEach(item =>
            {
                if (item.BookName.Contains(search) || item.AuthorName.Contains(search) || item.PageCount.ToString().Contains(search))
                {
                    result.Add(item);
                }
            }
            );

            return result;
        }
        public List<Book> FindAllBooksByPageCountRange(int min, int max)
        {
            List<Book> result = new List<Book>();
            _books.ForEach(item => 
            {
                if(item.PageCount>min && item.PageCount < max)
                {
                    result.Add(item);
                }



            });

            return result;
        }
        public List<Book> RemoveByNo(string code)
        {
            List<Book> result = new List<Book>();

            _books.ForEach(item =>
            {
                if (item.Code.Contains(code))
                {
                    result.Add(item);
                }
            });
            result.ForEach(res =>_books.Remove(res));
            return result;
        }

    }

}

using System;
using System.Collections.Generic;
using System.Text;


namespace DelegateHWTask
{
    class Program
    {
        
        static void Main(string[] args)
        {

            Library library = new Library();

            library.AddBooks("Vikings", "Thomas Shelby", 300);
            library.AddBooks("Suc ve Ceza", "John Shelby", 300);
            library.AddBooks("Spiderman", "Arthur Shelby", 300);
            library.AddBooks("Jack Sparrow", "Grace Burgess", 300);
            string aa = "300";

            foreach (var item in library.SearchBooks(aa))
            {
                Console.WriteLine(item);
            }


            //Func<string, List<Book>> func = new Func<string, List<Book>>(library.FindAllBooksByName);
            ////func += library.SearchBooks;
            ////func += library.RemoveAllBookByName;
            ////func += library.RemoveByNo;

            //func.Invoke("Vikings");




        }
    }
   
    
}

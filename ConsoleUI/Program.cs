using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            
            BookManager bookManager = new BookManager(new EfBookDal());
            bookManager.Add(new Book { Id = 1, AuthorId = 1 });

            
        }
    }
}

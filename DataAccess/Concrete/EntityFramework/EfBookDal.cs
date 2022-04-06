using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTO_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBookDal : EfEntityRepositoryBase<Book, LibraryContext>, IBookDal
    {
        public List<BookDetailDto> GetBookDetail(Book book)
        {
            using (LibraryContext context = new LibraryContext())
            {
                var result = from b in context.Books
                             join a in context.Authors
                             on b.AuthorId equals a.Id
                             join p in context.Publishers
                             on b.PublisherId equals p.Id
                             join bt in context.BookTypes
                             on b.BookTypeId equals bt.Id
                             where b.Id == book.Id
                             select new BookDetailDto { AuthorName = a.FirstName + a.LastName, BookId = b.Id, BookName = b.Name, BookType = bt.Type, PublisherName = p.PublisherName, YearOfPublication = b.YearOfPublication };
                return result.ToList();
            }
        }
    }
}

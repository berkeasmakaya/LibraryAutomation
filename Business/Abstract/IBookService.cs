using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBookService
    {
        //will be added GetBookDetails function by using Data Transformation Object.
        IDataResult<List<Book>> GetAll();
        IDataResult<List<Book>> GetAllByTypeId(int bookTypeId);
        IDataResult<Book> GetByAuthorId(int authorId);
        IDataResult<Book> GetById(int bookId);
        IResult Add(Book book);
        IResult Delete(Book book);
        IResult Update(Book book);
    }
}

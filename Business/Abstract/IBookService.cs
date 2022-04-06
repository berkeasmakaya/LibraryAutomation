using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTO_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBookService
    {
        IDataResult<List<BookDetailDto>> GetBookDetail(Book book);
        IDataResult<List<Book>> GetAll();
        IDataResult<List<Book>> GetAllByTypeId(int bookTypeId);
        IDataResult<Book> GetByAuthorId(int authorId);
        IDataResult<Book> GetById(int bookId);
        IResult Add(Book book);
        IResult Delete(Book book);
        IResult Update(Book book);
    }
}

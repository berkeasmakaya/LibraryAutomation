using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBookTypeService
    {
        IDataResult<List<BookType>> GetAll();
        IDataResult<BookType> GetById(int bookTypeId);
        IResult Add(BookType bookType);
        IResult Delete(BookType bookType);
        IResult Update(BookType bookType);
    }
}

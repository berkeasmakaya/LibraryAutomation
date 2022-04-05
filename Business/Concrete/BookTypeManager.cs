using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BookTypeManager:IBookTypeService
    {
        IBookTypeDal _bookTypeDal;
        public BookTypeManager(IBookTypeDal bookTypeDal)
        {
            _bookTypeDal = bookTypeDal;
        }

        public IResult Add(BookType bookType)
        {
            _bookTypeDal.Add(bookType);
            return new SuccessResult(Messages.BookTypeAdded);
        }

        public IResult Delete(BookType bookType)
        {
            _bookTypeDal.Delete(bookType);
            return new SuccessResult(Messages.BookTypeDeleted);
        }

        public IDataResult<BookType> GetById(int bookTypeId)
        {
            return new SuccessDataResult<BookType>(_bookTypeDal.Get(bt => bt.Id == bookTypeId));
        }

        public IDataResult<List<BookType>> GetAll()
        {
            return new SuccessDataResult<List<BookType>>(_bookTypeDal.GetAll());
        }

        public IResult Update(BookType bookType)
        {
            _bookTypeDal.Update(bookType);
            return new SuccessResult(Messages.BookTypeUpdated);
        }
    }
}

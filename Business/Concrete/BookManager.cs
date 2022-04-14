using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTO_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Validation.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation.FluentValidation;

namespace Business.Concrete
{
    public class BookManager : IBookService
    {
        IBookDal _bookDal;
        public BookManager(IBookDal bookDal)
        {
            _bookDal = bookDal;
        }

        [ValidationAspect(typeof(BookValidator))]
        public IResult Add(Book book)
        {

            _bookDal.Add(book);
            return new SuccessResult(Messages.BookAdded);
        }

        public IResult Delete(Book book)
        {
            _bookDal.Delete(book);
            return new SuccessResult(Messages.BookDeleted);
        }

        public IDataResult<List<Book>> GetAll()
        {
            return new SuccessDataResult<List<Book>>(_bookDal.GetAll());
        }

        public IDataResult<Book> GetByAuthorId(int authorId)
        {
            return new SuccessDataResult<Book>(_bookDal.Get(b => b.AuthorId == authorId));
        }

        public IDataResult<List<Book>> GetAllByTypeId(int bookTypeId)
        {
            return new SuccessDataResult<List<Book>>(_bookDal.GetAll(b => b.BookTypeId == bookTypeId));
        }

        public IDataResult<Book> GetById(int bookId)
        {
            return new SuccessDataResult<Book>(_bookDal.Get(b=>b.Id==bookId));
        }

        public IResult Update(Book book)
        {
            _bookDal.Update(book);
            return new SuccessResult(Messages.BookUpdated);
        }

        public IDataResult<List<BookDetailDto>> GetBookDetail(Book book)
        {
            return new SuccessDataResult<List<BookDetailDto>>(_bookDal.GetBookDetail(book));
        }
    }
}

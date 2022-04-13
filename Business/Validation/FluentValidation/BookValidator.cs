using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Business.Validation.FluentValidation
{
    public class BookValidator:AbstractValidator<Book>
    {
        public BookValidator()
        {
            RuleFor(b => b.Name).NotEmpty();
            RuleFor(b => b.Name).Length(2, 100);
            RuleFor(b => b.NumberOfPages).GreaterThan(0);
            RuleFor(b => b.Summary).Length(0,300);
        }
    }
}

using EasyBook.Domain.Models;
using EasyBook.Exceptions.Messages;
using FluentValidation;

namespace EasyBook.Server.Validations
{
    public class BookValidation: AbstractValidator<BookModel>
    {
        public BookValidation()
        {
            RuleFor(e => e.Name).NotEmpty().WithMessage(ExceptionMessage.REQUIRED_NAME);
            RuleFor(e => e.Author).NotEmpty().WithMessage(ExceptionMessage.REQUIRED_AUTHOR);
            RuleFor(e => e.BookstoreId).NotEmpty().WithMessage(ExceptionMessage.REQUIRED_BOOKSTORE_ID);
        }
    }
}

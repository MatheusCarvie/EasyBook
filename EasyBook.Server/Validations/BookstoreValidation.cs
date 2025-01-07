using EasyBook.Domain.Models;
using EasyBook.Exceptions.Messages;
using FluentValidation;

namespace EasyBook.Server.Validations
{
    public class BookstoreValidation : AbstractValidator<BookstoreModel>
    {
        public BookstoreValidation()
        {
            RuleFor(e => e.Name).NotEmpty().WithMessage(ExceptionMessage.REQUIRED_NAME);
            RuleFor(e => e.Image).NotEmpty().WithMessage(ExceptionMessage.REQUIRED_IMAGE);
            RuleFor(e => e.Address).NotEmpty().WithMessage(ExceptionMessage.REQUIRED_ADDRESS);
            RuleFor(e => e.Phone).NotEmpty().WithMessage(ExceptionMessage.REQUIRED_PHONE);
        }
    }
}

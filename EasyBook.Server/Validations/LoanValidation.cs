using EasyBook.Domain.Models;
using EasyBook.Exceptions.Messages;
using FluentValidation;

namespace EasyBook.Server.Validations
{
    public class LoanValidation: AbstractValidator<LoanModel>
    {
        public LoanValidation()
        {
            RuleFor(e => e.UserId).NotEmpty().WithMessage(ExceptionMessage.REQUIRED_USER_ID);
            RuleFor(e => e.BookId).NotEmpty().WithMessage(ExceptionMessage.REQUIRED_BOOK_ID);
            RuleFor(e => e.Date).NotEmpty().WithMessage(ExceptionMessage.REQUIRED_DATE);
        }
    }
}

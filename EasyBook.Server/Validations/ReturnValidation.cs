using EasyBook.Domain.Models;
using EasyBook.Exceptions.Messages;
using FluentValidation;

namespace EasyBook.Server.Validations
{
    public class ReturnValidation : AbstractValidator<ReturnModel>
    {
        public ReturnValidation()
        {
            RuleFor(e => e.LoanId).NotEmpty().WithMessage(ExceptionMessage.REQUIRED_LOAN_ID);
            RuleFor(e => e.Date).NotEmpty().WithMessage(ExceptionMessage.REQUIRED_DATE);
        }
    }
}

using FluentValidation;
using EasyBook.Exceptions.Messages;
using EasyBook.Domain.Models;

namespace EasyBook.Server.Validations
{
    public class UserValidation : AbstractValidator<UserModel>
    {
        public UserValidation()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(ExceptionMessage.REQUIRED_NAME);
            RuleFor(x => x.Email).NotEmpty().WithMessage(ExceptionMessage.REQUIRED_EMAIL).EmailAddress().WithMessage(ExceptionMessage.INVALID_EMAIL);
            RuleFor(x => x.Password).NotEmpty().WithMessage(ExceptionMessage.REQUIRED_PASSWORD).MinimumLength(8).WithMessage(ExceptionMessage.INVALID_PASSWORD);
        }
    }
}

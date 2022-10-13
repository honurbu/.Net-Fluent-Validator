using FluentValidation.Web.Models;

namespace FluentValidation.Web.FluentValidators
{
    public class CustomerValidator:AbstractValidator<Customer>
    {
        public string NotEmptyMessage { get; } = "{PropertyName} Field Cannot be Empty";
        public CustomerValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(NotEmptyMessage);
            RuleFor(x => x.EMail).NotEmpty().WithMessage(NotEmptyMessage).EmailAddress().WithMessage("E-Mail Must be in the Correct Format");
            RuleFor(x => x.Age).NotEmpty().WithMessage(NotEmptyMessage).InclusiveBetween(18, 65).WithMessage("Age Range Must Be Between 18 and 65"); ;
            RuleFor(x => x.BirthdayDate).NotEmpty().WithMessage(NotEmptyMessage).Must(x =>
            {
                return DateTime.Now.AddYears(-18) >= x;
            }).WithMessage("You Must Older Than 18 Years Old !");

            RuleFor(x => x.Gender).IsInEnum().WithMessage(" {PropertyName} You Must Choice for Man = 1, Women = 2");

            RuleForEach(x=>x.Addresses).SetValidator(new AddressValidator());

        }
    }
}

using FluentValidation.Web.Models;

namespace FluentValidation.Web.FluentValidators
{
    public class AddressValidator:AbstractValidator<Address>
    {
        public string NotEmptyMessage { get; } = "{PropertyName} Field Cannot be Empty";
        public AddressValidator()
        {
            RuleFor(x=>x.Content).NotEmpty().WithMessage(NotEmptyMessage);
            RuleFor(x=>x.Province).NotEmpty().WithMessage(NotEmptyMessage);
            RuleFor(x=>x.Postcode).NotEmpty().WithMessage(NotEmptyMessage).MaximumLength(5).WithMessage("The {PropertyName} Field Must be Maximum of {MaxLength} Characters");
        }
    }
}

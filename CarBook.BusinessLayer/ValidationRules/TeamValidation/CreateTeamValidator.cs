using CarBook.EntityLayer.Concrete;
using FluentValidation;

namespace CarBook.BusinessLayer.ValidationRules.TeamValidation
{
    public class CreateTeamValidator : AbstractValidator<Team>
    {
        public CreateTeamValidator()
        {
            RuleFor(x => x.FullName).NotEmpty().WithMessage("İsim Alanı Boş Geçilemez");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Yorum Alanı Boş Geçilemez");
            RuleFor(x => x.FullName).MinimumLength(3).WithMessage("Lütfen en az 3 karakter veri girişi yapınız");
            RuleFor(x => x.FullName).MaximumLength(30).WithMessage("Lütfen en fazla 30 karakter veri girişi yapınız");
            RuleFor(x => x.Description).MinimumLength(10).WithMessage("Lütfen en az 10 karakter veri girişi yapınız");
            RuleFor(x => x.Description).MaximumLength(200).WithMessage("Lütfen en fazla 200 karakter veri girişi yapınız");
        }
    }
}
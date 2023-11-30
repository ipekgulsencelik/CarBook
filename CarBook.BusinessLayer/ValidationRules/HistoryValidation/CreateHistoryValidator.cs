﻿using CarBook.EntityLayer.Concrete;
using FluentValidation;

namespace CarBook.BusinessLayer.ValidationRules.HistoryValidation
{
    public class CreateHistoryValidator : AbstractValidator<History>
    {
        public CreateHistoryValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Başlık Alanı Boş Bırakılamaz");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama Alanı Boş Bırakılamaz");
            RuleFor(x => x.Title).MinimumLength(3).WithMessage("Lütfen en az 3 karakter veri girişi yapınız");
            RuleFor(x => x.Title).MaximumLength(30).WithMessage("Lütfen en fazla 30 karakter veri girişi yapınız");
            RuleFor(x => x.Description).MinimumLength(10).WithMessage("Lütfen en az 10 karakter veri girişi yapınız");
            RuleFor(x => x.Description).MaximumLength(200).WithMessage("Lütfen en fazla 200 karakter veri girişi yapınız");
        }
    }
}
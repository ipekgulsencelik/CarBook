﻿using CarBook.EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.BusinessLayer.ValidationRules.TestimonialValidation
{
	public class CreateTestimonialValidator : AbstractValidator<Testimonial>
    {
        public CreateTestimonialValidator()
        {
            RuleFor(x => x.FullName).NotEmpty().WithMessage("İsim Alanı Boş Geçilemez");
            RuleFor(x => x.Comment).NotEmpty().WithMessage("Yorum Alanı Boş Geçilemez");
            RuleFor(x => x.FullName).MinimumLength(3).WithMessage("Lütfen en az 3 karakter veri girişi yapınız");
            RuleFor(x => x.FullName).MaximumLength(30).WithMessage("Lütfen en fazla 30 karakter veri girişi yapınız");
            RuleFor(x => x.Comment).MinimumLength(10).WithMessage("Lütfen en az 10 karakter veri girişi yapınız");
            RuleFor(x => x.Comment).MaximumLength(200).WithMessage("Lütfen en fazla 200 karakter veri girişi yapınız");
        }
    }
}

using CarBook.EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.BusinessLayer.ValidationRules.CarFeatureValidation
{
    public class CreateCarFeatureValidator : AbstractValidator<CarFeature>
    {
        public CreateCarFeatureValidator()
        {
           
        }
    }
}
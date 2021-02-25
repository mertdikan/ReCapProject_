using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator:AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(ca => ca.CarName).NotEmpty();
            RuleFor(ca => ca.CarName).MinimumLength(2).WithMessage("Araç adı en az 2 karakter uzunluğunda olmalıdır.");
            RuleFor(ca => ca.DailyPrice).NotEmpty().WithMessage("Aracın  fiyatı 0'dan büyük olmalıdır.");
            RuleFor(ca => ca.DailyPrice).GreaterThan(0);
            RuleFor(ca => ca.CarName).Must(StartWithA).WithMessage("Ürünler A harfi ile başlamalıdır.");
        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}

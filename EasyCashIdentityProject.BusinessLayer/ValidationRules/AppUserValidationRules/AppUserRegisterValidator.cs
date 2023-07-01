using EasyCashIdentityProject.DTOLayer.Dtos.AppUserDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.BusinessLayer.ValidationRules.AppUserValidationRules
{
    public class AppUserRegisterValidator : AbstractValidator<AppUserRegisterDto>
    {
        public AppUserRegisterValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ad alanı boş geçilemez");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("SoyAd alanı boş geçilemez");
            RuleFor(x => x.Email).NotEmpty().WithMessage("email alanı boş geçilemez");
            RuleFor(x => x.Password).NotEmpty().WithMessage("şifre alanı boş geçilemez");
            RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("şifre tekrar alanı boş geçilemez");
            RuleFor(x => x.Name).MaximumLength(30).WithMessage("Maksimum 30 karakter");
            RuleFor(x => x.Password).Equal(y => y.ConfirmPassword).WithMessage("eşleşmeyen şifre");//equal parametreleri karşılaştırıyor
            RuleFor(x => x.Name).MinimumLength(2).WithMessage("en az 2 karakter");
            RuleFor(x => x.Email).EmailAddress().WithMessage("Lütfen geçerli bir email adresi giriniz");
        }
    }
}

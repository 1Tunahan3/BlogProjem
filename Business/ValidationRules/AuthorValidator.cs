using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Concrete;
using FluentValidation;

namespace Business.ValidationRules
{
  public  class AuthorValidator:AbstractValidator<Author>
    {
        public AuthorValidator()
        {
            RuleFor(x => x.AuthorName).NotEmpty().WithMessage("Ad Soyad kısmı boş olamaz");
            RuleFor(x => x.AuthorMail).NotEmpty().WithMessage("Mail kısmı boş olamaz");
            RuleFor(x => x.AuthorPassword).NotEmpty().WithMessage("Şifre kısmı boş olamaz");
            RuleFor(x => x.AuthorName).MinimumLength(2).WithMessage("en az 2 karakter olabilir");
        }
    }
}

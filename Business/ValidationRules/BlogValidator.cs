using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Concrete;
using FluentValidation;

namespace Business.ValidationRules
{
  public class BlogValidator:AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(x => x.BlogTitle).NotEmpty().WithMessage("This cannot be empty");
            RuleFor(x => x.BlogContent).NotEmpty().WithMessage("This cannot be empty");
            RuleFor(x => x.BlogTitle).MaximumLength(50).WithMessage("Cannot exceed length limit");
        }
    }
}

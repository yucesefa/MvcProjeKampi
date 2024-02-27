using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules_FluentValidation
{
    public class HeadingValidator:AbstractValidator<Heading>
    {
        public HeadingValidator()
        {
            RuleFor(x => x.HeadingName).NotEmpty().WithMessage("Lütfen başlık ksımını boş geçmeyiniz!");
            RuleFor(x => x.CategoryID).NotEmpty().WithMessage("Lütfen Yazar soyadını boş geçmeyiniz!");
            RuleFor(x => x.WriterID).NotEmpty().WithMessage("Lütfen Yazar  ismini boş geçmeyiniz!");
        }
    }
}

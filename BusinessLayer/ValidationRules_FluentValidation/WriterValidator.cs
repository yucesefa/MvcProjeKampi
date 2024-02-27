using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules_FluentValidation
{
    public class WriterValidator:AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Lütfen Yazar adını boş geçmeyiniz!");
            RuleFor(x => x.WriterSurname).NotEmpty().WithMessage("Lütfen Yazar soyadını boş geçmeyiniz!");
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Lütfen Yazar  ismini boş geçmeyiniz!");
            RuleFor(x => x.WriterSurname).NotEmpty().WithMessage("Lütfen Yazar  soyismini boş geçmeyiniz!");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Lütfen en az 2 karakter veri girişi yapınız.!");
            RuleFor(x => x.WriterName).MaximumLength(20).WithMessage("Lütfen 20 karakterden fazla veri girişi yapmayınız.!");
            RuleFor(x => x.WriterSurname).MinimumLength(2).WithMessage("Lütfen en az 2 karakter veri girişi yapınız.!");
            RuleFor(x => x.WriterSurname).MaximumLength(20).WithMessage("Lütfen 20 karakterden fazla veri girişi yapmayınız.!");
            RuleFor(x => x.WriterAbout).MaximumLength(200).WithMessage("Lütfen yazar açıklama kısmını 200 karakterden fazla veri girişi yapmayınız.!");
        }
    }
}

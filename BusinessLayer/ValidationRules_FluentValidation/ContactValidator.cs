using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules_FluentValidation
{
    public class ContactValidator : AbstractValidator<Contact>
    {
        public ContactValidator()
        {
            RuleFor(x => x.UserMail).NotEmpty().WithMessage("Lütfen Mail adresini boş geçmeyiniz!");
            RuleFor(x => x.Subeject).NotEmpty().WithMessage("Lütfen konu ksımını boş geçmeyiniz!");
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Lütfen kullanıcı adını boş geçmeyiniz!");
            RuleFor(x => x.UserName).MinimumLength(3).WithMessage("Lütfen en az 3 karakter veri girişi yapınız.!");
            RuleFor(x => x.Subeject).MaximumLength(50).WithMessage("Lütfen 50 karakterden fazla veri girişi yapmayınız.!");
        }
    }
}

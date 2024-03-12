using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules_FluentValidation
{
    public class MessageValidator : AbstractValidator<Message>
    {
        public MessageValidator()
        {
            RuleFor(x => x.ReceiverMail).NotEmpty().WithMessage("Lütfen Mail adresini boş geçmeyiniz!");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Lütfen konu ksımını boş geçmeyiniz!");
            RuleFor(x => x.MessageContent).NotEmpty().WithMessage("Lütfen mesajı boş geçmeyiniz!");
            RuleFor(x => x.Subject).MinimumLength(3).WithMessage("Lütfen en az 3 karakter veri girişi yapınız.!");
            RuleFor(x => x.Subject).MaximumLength(100).WithMessage("Lütfen 50 karakterden fazla veri girişi yapmayınız.!");
        }
    }
}

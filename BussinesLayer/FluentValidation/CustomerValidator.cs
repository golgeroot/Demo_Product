using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.FluentValidation
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(x=>x.City).NotEmpty().WithMessage("Şehir bilgisi boş geçilemez");
            RuleFor(x => x.City).MaximumLength(30).WithMessage("Şehir 30 karakterden fazla olamaz");
            RuleFor(x => x.City).MinimumLength(3).WithMessage("Şehir 3 karakterden az olamaz");
            RuleFor(x=>x.Name).NotEmpty().WithMessage("İsim bilgisi boş geçilemez");
            RuleFor(x => x.Name).MaximumLength(30).WithMessage("İsim bilgisi 30 karakterden fazla olamaz");
            RuleFor(x => x.Name).MinimumLength(3).WithMessage("İsim 3 karakterden az olamaz");
        }
    }
}

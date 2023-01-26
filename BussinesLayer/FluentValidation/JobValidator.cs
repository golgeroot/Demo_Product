using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.FluentValidation
{
    public class JobValidator : AbstractValidator<Job>
    {
        public JobValidator()
        {
            RuleFor(x=> x.Name).MinimumLength(3).WithMessage("Meslek 3 Karakterden az olamaz");
            RuleFor(x => x.Name).NotEmpty().WithMessage("Meslek boş olamaz");
            RuleFor(x => x.Name).MaximumLength(30).WithMessage("Meslek 50 karakterden fazla olamaz");
        }
    }
}

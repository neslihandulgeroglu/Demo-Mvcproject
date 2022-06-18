using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.FluentValidation
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Müşteri ismi boş " +
                "geçilemez.");
            RuleFor(x => x.City).NotEmpty().WithMessage("Şehir ismi boş geçilemez.");

        }
    }
}

using FluentValidation;
using FuzulCase.Domain.Entities.Estate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuzulCase.Application.Validators.Estate
{
    public class EstateFilterDtoValidator : AbstractValidator<EstateFilterDto>
    {
        public EstateFilterDtoValidator() {


            RuleFor(x => x.MinPrice)
                .GreaterThanOrEqualTo(0).WithMessage("MinPrice can't be negative");

            RuleFor(x => x.MaxPrice)
                .GreaterThanOrEqualTo(x => x.MinPrice).WithMessage("MaxPrice can't be less than MinPrice");

            RuleFor(x => x.MinM2)
                .GreaterThanOrEqualTo(0).WithMessage("MinM2 can't be negative");

            RuleFor(x => x.MaxM2)
                .GreaterThanOrEqualTo(x => x.MinM2).WithMessage("MaxM2 can't be less than MinM2");

        }
    }
}

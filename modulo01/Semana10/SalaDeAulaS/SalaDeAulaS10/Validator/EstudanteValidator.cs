using FluentValidation;
using SalaDeAulaS10.Controllers;
using SalaDeAulaS10.Dto;
using SalaDeAulaS10.Models;
using static SalaDeAulaS10.Dto.EstudanteDto;

namespace SalaDeAulaS10.FluentValidation
{
    public class EstudanteValidator : AbstractValidator<EstudanteAlteraçãoDto>
    {
            public EstudanteValidator() 
        {
            RuleFor(x => x.Periodo).NotEmpty().WithMessage("Por favor descreva um número").NotNull().WithMessage("Valor não informado").ExclusiveBetween(1, 9).WithMessage("O numero deve ser de 1 a 9");
            RuleFor(x => x.RA).NotEmpty().WithMessage("Por favor descreva um número").NotNull().WithMessage("Valor não informado").LessThanOrEqualTo(0).ExclusiveBetween(10, 100);
        }
    }
    public class EstudanteSaidaDtoValidator : AbstractValidator<EstudanteCriacaoDto>
    {
        public EstudanteSaidaDtoValidator()
        {
            RuleFor(x => x.Periodo).NotEmpty().WithMessage("Por favor descreva um número").NotNull().WithMessage("Valor não informado").ExclusiveBetween(1, 9).WithMessage("O numero deve ser de 1 a 9");
            RuleFor(x => x.RA).NotEmpty().WithMessage("Por favor descreva um número").NotNull().WithMessage("Valor não informado").LessThanOrEqualTo(0).ExclusiveBetween(10, 100);
        }
    }
}

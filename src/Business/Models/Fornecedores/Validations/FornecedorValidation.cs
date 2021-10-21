using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Core.Validations.Documentos;

namespace Business.Models.Fornecedores.Validations
{
    public class FornecedorValidation : AbstractValidator<Fornecedor>
    {
        public FornecedorValidation()
        {
            RuleFor(f => f.Nome)
                .NotEmpty().WithMessage("Campo {PropertyName} precisa ser fornecido!")
                .Length(2,100)
                .WithMessage("Campo {PropertyName} precisa ter entre {MinLenght} e {MaxLenght} caracteres");

            When(f => f.TipoFornecedor == TipoFornecedor.PessoaFisica, () =>
            {
                RuleFor(f => f.Documento.Length).Equal(CpfValidacao.TamanhoCpf)
                .WithMessage("Campo {PropertyName} precisa ter {ComparisonValue} Caracteres e foi fornecido {PropertyValue}.");
               
                RuleFor(f => CpfValidacao.Validar(f.Documento)).Equal(true)
                .WithMessage(" o campo {PropertyName} fornecido é inválido!");
            });
            When(f => f.TipoFornecedor == TipoFornecedor.PessoaJuridica, () =>
            {
                RuleFor(f => f.Documento.Length).Equal(CnpjValidacao.TamanhoCnpj)
               .WithMessage("Campo {PropertyName} precisa ter {ComparisonValue} Caracteres e foi fornecido {PropertyValue}.");

                RuleFor(f => CnpjValidacao.Validar(f.Documento)).Equal(true)
                .WithMessage(" o campo {PropertyName} fornecido é inválido!");
            });
        }

    }
}

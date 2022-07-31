using System.ComponentModel;

namespace MyBank.Business.Enums;

public enum TipoConta
{
    [Description("Pessoa Física")]
    PessoaFisica,
    [Description("Pessoa Jurídica")]
    PessoaJuridica
}
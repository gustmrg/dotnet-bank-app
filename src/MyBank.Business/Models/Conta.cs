using MyBank.Business.Enums;

namespace MyBank.Business.Models;

public class Conta : Entidade
{
    public string Nome { get; set; }
    public decimal Saldo { get; set; }
    public TipoConta TipoConta { get; set; }
    public DateTime? DataAbertura { get; set; }
}
namespace MyBank.Web.ViewModels;

public class ContaViewModel
{
    public string Nome { get; set; }
    public decimal Saldo { get; set; }
    public int TipoConta { get; set; }
    public DateTime DataAbertura { get; set; }
    public DateTime? DataEncerramento { get; set; }
    public bool Ativa { get; set; }
}
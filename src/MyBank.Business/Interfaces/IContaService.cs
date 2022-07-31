namespace MyBank.Business.Interfaces;

public interface IContaService
{
    Task Depositar(Guid idConta, decimal valor);
    Task Sacar(Guid idConta, decimal valor);
    Task Transferir(Guid idContaOrigem, Guid idContaDestino, decimal valor);
}
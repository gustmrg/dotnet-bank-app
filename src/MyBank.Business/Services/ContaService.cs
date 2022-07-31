using MyBank.Business.Interfaces;

namespace MyBank.Business.Services;

public class ContaService : IContaService
{
    private readonly IContaRepository _contaRepository;

    public async Task Depositar(Guid idConta, decimal valor)
    {
        throw new NotImplementedException();
    }

    public async Task Sacar(Guid idConta, decimal valor)
    {
        throw new NotImplementedException();
    }

    public async Task Transferir(Guid idContaOrigem, Guid idContaDestino, decimal valor)
    {
        throw new NotImplementedException();
    }
}
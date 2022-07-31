namespace MyBank.Business.Interfaces;

public interface IRepository<TEntity> : IDisposable
{
    Task<List<TEntity>> ObterTodas();
    Task<TEntity> ObterPorId(Guid id);
    Task Adicionar(TEntity entity);
    Task Atualizar(TEntity entity);
    Task Remover(Guid id);
}
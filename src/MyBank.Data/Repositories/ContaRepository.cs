using Microsoft.EntityFrameworkCore;
using MyBank.Business.Interfaces;
using MyBank.Business.Models;
using MyBank.Data.Contexts;

namespace MyBank.Data.Repositories;

public class ContaRepository : IContaRepository
{
    private readonly ApplicationDbContext _context;

    public ContaRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<List<Conta>> ObterTodas()
    {
        return await _context.Contas.ToListAsync();
    }

    public async Task<Conta> ObterPorId(Guid id)
    {
        return await _context.Contas.FindAsync(id);
    }

    public async Task Adicionar(Conta conta)
    {
        _context.Add(conta);
        await _context.SaveChangesAsync();
    }

    public async Task Atualizar(Conta conta)
    {
        _context.Update(conta);
        await _context.SaveChangesAsync();
    }

    public async Task Remover(Guid id)
    {
        _context.Remove(id);
        await _context.SaveChangesAsync();
    }
    
    public void Dispose()
    {
        _context?.Dispose();
    }
}
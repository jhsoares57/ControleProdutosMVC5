using Business.Models.Produtos;
using Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Data.Repository
{
    public class ProdutoRepository : Repository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(ControleProdutoDbContext context) : base(context) { }
        public async Task<Produto> ObterProdutoFornecedor(Guid id)
        {
            return await Db.Produtos.AsNoTracking().Include(f => f.Fornecedor)
                .FirstOrDefaultAsync(f => f.Id == id);
        }

        public async Task<IEnumerable<Produto>> ObterProdutoPorFornecedores(Guid fornecedorId)
        {
            return await Buscar(p => p.FornecedorID == fornecedorId);
        }

        public async Task<IEnumerable<Produto>> ObterProdutosFornecedores()
        {
            return await Db.Produtos.AsNoTracking().Include(f => f.Fornecedor)
                .Include(f=>f.Fornecedor)
                 .OrderBy(p => p.Nome).ToListAsync();
        }
    }
}

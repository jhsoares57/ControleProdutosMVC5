using Business.Models.Fornecedores;
using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infra.Data.Context;

namespace Infra.Data.Repository
{
    public class FornecedoreRepository : Repository<Fornecedor>, IFornecedorRepository
    {
        public FornecedoreRepository(ControleProdutoDbContext context) : base(context) { }
        public async Task<Fornecedor> ObterFornecedorEndereco(Guid id)
        {
            return await Db.Fornecedores.AsNoTracking()
                 .Include(f => f.Endereco)
                 .FirstOrDefaultAsync(f => f.Id == id);
        }

        public  async Task<Fornecedor> ObterFornecedorProdutosEndereco(Guid id)
        {
            return await Db.Fornecedores.AsNoTracking()
                 .Include(f => f.Endereco)
                 .Include(f=>f.Produtos)
                 .FirstOrDefaultAsync(f => f.Id == id);
        }

        /*Ajustando metodo remover para que não exclua do banco o registro, apenas modifique a opção ATIVO*/
        public async override Task Remover(Guid id)
        {
            var fornecedor = await ObterPorId(id);
            fornecedor.Ativo = false;

            await Atualizar(fornecedor);
        }
    }
}

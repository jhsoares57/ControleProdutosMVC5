using Business.Models.Produtos;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Data.Mappings
{
    public class ProdutoConfig : EntityTypeConfiguration<Produto>
    {
        public ProdutoConfig()
        {
            HasKey(p => p.Id);

            Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(200);
            Property(p => p.Descricao)
                .IsRequired()
                .HasMaxLength(1000);
            Property(p => p.Imagem)
                .IsRequired()
                .HasMaxLength(100);


            /*relacionamento da tabela produtos com fornecedore onde fornecedor pode ter N produtos*/
            HasRequired(p => p.Fornecedor)
                .WithMany(f=>f.Produtos)
                /*definindo a chave estrangeira do relacionamento*/
                .HasForeignKey(p=>p.FornecedorID);

            ToTable("Produtos");
        }
    }
}

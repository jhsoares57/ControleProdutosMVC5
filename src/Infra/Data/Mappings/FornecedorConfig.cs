using Business.Models.Fornecedores;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Data.Mappings
{
    public class FornecedorConfig : EntityTypeConfiguration<Fornecedor>
    {
        /*Contrutor*/
        public FornecedorConfig()
        {
            /*Mapeando a propriedade de Chave primaria, utilizando expressão lambda*/
            HasKey(f => f.Id);

            /*Mapeando a propriedade nome, utilizando expressão lambda */
            Property(f => f.Nome)
                .IsRequired()
                .HasMaxLength(200);
            /*Mapeando a propriedade documento, utilizando expressão lambda */
            Property(f => f.Documento)
                .IsRequired()
                .HasMaxLength(14)
                /*Criando um index para o campo documento*/
                .HasColumnAnnotation("Index",
                new IndexAnnotation(new IndexAttribute { IsUnique = true }));

            /*Informando que o campo Endereço seja obrigatorio*/
            /*També é feito o relacionamento de endereco com produto*/
            HasRequired(f => f.Endereco)
                .WithRequiredPrincipal(e => e.Fornecedor);

            /*Informando o nome da tabela a ser criada na banco de dados*/
            ToTable("Fornecedores");
        }
    }
}

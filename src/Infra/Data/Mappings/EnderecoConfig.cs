﻿using Business.Models.Fornecedores;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Data.Mappings
{
    public class EnderecoConfig : EntityTypeConfiguration<Endereco>
    {
        /*Criando o construto*/
        
        public EnderecoConfig()
        {

            /*Mapeando a propriedades, utilizando expressão lambda */
            HasKey(p => p.Id);

            Property(c => c.Logradouro)
                .IsRequired()
                .HasMaxLength(200);

            Property(c => c.Numero)
               .IsRequired()
               .HasMaxLength(50);

            Property(c => c.Cep)
               .IsRequired()
               .HasMaxLength(8)
               .IsFixedLength();

            Property(c => c.Complemento)
              .HasMaxLength(250);

            Property(c => c.Bairro)
              .IsRequired()
              .HasMaxLength(100);

            Property(c => c.Cidade)
              .IsRequired()
              .HasMaxLength(100);

            Property(c => c.Estado)
              .IsRequired()
              .HasMaxLength(100);

            ToTable("Enderecos");
        }
    }
}

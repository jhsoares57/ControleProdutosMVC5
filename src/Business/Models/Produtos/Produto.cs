using Business.Core.Models;
using Business.Models.Fornecedores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Produtos
{
    public class Produto : Entity
    {

        public Guid FornecedorID { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Imagem { get; set; }
        public decimal Valor { get; set; }

        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }

        /*EF relations*/
        public Fornecedor Fornecedor { get; set; }

    }
}

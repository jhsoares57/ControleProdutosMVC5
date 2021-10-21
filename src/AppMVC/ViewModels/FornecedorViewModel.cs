using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AppMVC.ViewModels
{
    public class FornecedorViewModel
    {
        public FornecedorViewModel()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }

        [Required(ErrorMessage = "O Campo {0} é obrigatório!")]
        [StringLength(100, ErrorMessage = "O Campo {0} precisa ter entre {2} e {1} Caracteres", MinimumLength = 2)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O Campo {0} é obrigatório!")]
        [StringLength(14, ErrorMessage = "O Campo {0} precisa ter entre {2} e {1} Caracteres", MinimumLength = 11)]
        public string Documento { get; set; }

        [DisplayName("Tipo")]
        public int TipoFornecedor { get; set; }
        public EnderecoViewModel Endereco { get; set; }
        public bool Ativo { get; set; }

        public IEnumerable<ProdutoViewModel> Produtos { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppMVC.ViewModels
{
    public class EnderecoViewModel
    {

        public EnderecoViewModel()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }


        [Required(ErrorMessage = "O Campo {0} é obrigatório!")]
        [StringLength(200, ErrorMessage = "O Campo {0} precisa ter entre {2} e {1} Caracteres", MinimumLength = 2)]
        public string Logradouro { get; set; }

        [Required(ErrorMessage = "O Campo {0} é obrigatório!")]
        [StringLength(50, ErrorMessage = "O Campo {0} precisa ter entre {2} e {1} Caracteres", MinimumLength = 1)]
        public string Numero { get; set; }

        public string Complemento { get; set; }

        [Required(ErrorMessage = "O Campo {0} é obrigatório!")]
        [StringLength(200, ErrorMessage = "O Campo {0} precisa ter entre {2} e {1} Caracteres", MinimumLength = 2)]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "O Campo {0} é obrigatório!")]
        [StringLength(100, ErrorMessage = "O Campo {0} precisa ter entre {2} e {1} Caracteres", MinimumLength = 2)]
        public string Cep { get; set; }

        [Required(ErrorMessage = "O Campo {0} é obrigatório!")]
        [StringLength(100, ErrorMessage = "O Campo {0} precisa ter entre {2} e {1} Caracteres", MinimumLength = 2)]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "O Campo {0} é obrigatório!")]
        [StringLength(50, ErrorMessage = "O Campo {0} precisa ter entre {2} e {1} Caracteres", MinimumLength = 2)]
        public string Estado { get; set; }

        [HiddenInput]
        public Guid FornecedorId { get; set; }
    }
}
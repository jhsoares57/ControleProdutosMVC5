﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Core.Notificacoes
{
    public class Notificador : INotificador
    {
        private List<Notificacao> _notificacaos;

        public Notificador()
        {
            _notificacaos = new List<Notificacao>();
        }
        public void Handle(Notificacao notificacao)
        {
            _notificacaos.Add(notificacao);
        }

        public List<Notificacao> ObterNotificacoes()
        {
            return _notificacaos;
        }

        public bool TemNotificacao()
        {
            return _notificacaos.Any();
        }
    }
}

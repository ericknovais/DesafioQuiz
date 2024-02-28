﻿using Quiz.DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.DomainModel.Repositories
{
    public interface IRespostaRepository : IRepositoryBase<Resposta>
    {
        IList<Resposta> ObterRespostaPorPerguntaID(int IdPergunta);
    }
}
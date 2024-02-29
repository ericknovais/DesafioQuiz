using Quiz.DataAccess.Database;
using Quiz.DomainModel.Models;
using Quiz.DomainModel.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.DataAccess.Repositories
{
    class PerguntaRepository : GenericAbstract<Pergunta>, IPerguntaRepository
    {
        ContextoDB ctx = new ContextoDB();
        public PerguntaRepository(ContextoDB contextoDB) : base(contextoDB)
        {
            ctx = contextoDB;
        }
    }
}

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
    class RespostaRepository : GenericAbstract<Resposta>, IRespostaRepository
    {
        ContextoDB ctx = new ContextoDB(); 
        public RespostaRepository(ContextoDB contextoDB) : base(contextoDB)
        {
            ctx = contextoDB;
        }

        public IList<Resposta> ObterRespostaPorPerguntaID(int idPergunta)
        {
            return ctx.Respostas.Where(x => x.PerguntaID.Equals(idPergunta)).ToList();
        }
    }
}

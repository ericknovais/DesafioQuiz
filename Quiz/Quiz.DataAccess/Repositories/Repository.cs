using Quiz.DataAccess.Database;
using Quiz.DomainModel.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.DataAccess.Repositories
{
    public class Repository : IRepository
    {
        ContextoDB ctx = new ContextoDB();
        public Repository()
        {
            ctx = new ContextoDB();
        }

        IPerguntaRepository perguntaRepository;
        public IPerguntaRepository Pergunta { get { return perguntaRepository ?? (perguntaRepository = new PerguntaRepository(ctx)); } }

        IRespostaRepository respostaRepository;
        public IRespostaRepository Resposta { get { return respostaRepository ?? (respostaRepository = new RespostaRepository(ctx)); } }

        public void SaveChanges()
        {
            ctx.SaveChanges();
        }
    }
}

using Quiz.DomainModel.Models;

namespace Quiz.DomainModel.Repositories
{
    public interface IRespostaRepository : IRepositoryBase<Resposta>
    {
        IList<Resposta> ObterRespostaPorPerguntaID(int idPergunta);
    }
}

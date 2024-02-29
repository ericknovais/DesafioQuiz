using Quiz.DomainModel.Models;

namespace Quiz.DomainModel.Repositories
{
    public interface IRepositoryBase<T> where T : EntityBase
    {
        void Salvar(T entity);
        void Excluir(T entity);
        T ObterPorID(int id);
        IList<T> ObterTodos();
    }
}

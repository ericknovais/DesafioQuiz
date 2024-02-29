namespace Quiz.DomainModel.Repositories
{
    public interface IRepository
    {
        void SaveChanges();
        public IPerguntaRepository Pergunta { get; }
        public IRespostaRepository Resposta { get; }
    }
}

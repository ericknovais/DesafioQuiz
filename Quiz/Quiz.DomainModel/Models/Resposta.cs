using System.ComponentModel.DataAnnotations.Schema;

namespace Quiz.DomainModel.Models
{
    [Table("Respostas")]
    public class Resposta : EntityBase
    {
        public Pergunta Pergunta { get; set; } = new Pergunta();
        public int PerguntaID { get; set; }
        public string Descricao { get; set; } = string.Empty;
        public bool Correto { get; set; }
        public int Ordem { get; set; }

        public override void ValidarCampos()
        {
            ValidaCampoTexto(Descricao, "Descrição");
            base.ValidarCampos();
        }
    }
}

using System.ComponentModel.DataAnnotations.Schema;

namespace Quiz.DomainModel.Models
{
    [Table("Perguntas")]
    public class Pergunta : EntityBase
    {
        public string Descricao { get; set; } = string.Empty;

        public override void ValidarCampos()
        {
            ValidaCampoTexto(this.Descricao, "Descrição");
            base.ValidarCampos();
        }
    }
}

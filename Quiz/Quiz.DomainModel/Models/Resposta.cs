using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.DomainModel.Models
{
    [Table("Respostas")]
    public class Resposta : EntityBase
    {
        public Pergunta Pergunta { get; set; }
        public int PerguntaID { get; set; }
        public string Descricao { get; set; }
        public bool Correto { get; set; }
        public int Ordem { get; set; }

        public override void ValidarCampos()
        {
            ValidaCampoTexto(Descricao, "Descrição");
            base.ValidarCampos();
        }
    }
}

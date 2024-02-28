using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.DomainModel.Models
{
    [Table("Perguntas")]
    public class Pergunta : EntityBase
    {
        public string Descricao { get; set; }

        public override void ValidarCampos()
        {
            ValidaCampoTexto(this.Descricao, "Descrição");
            base.ValidarCampos();
        }
    }
}

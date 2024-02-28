using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.DomainModel.Models
{
    public abstract class EntityBase
    {
        public int ID { get; set; }
        public DateTime DataCadatro { get; set; }
        public DateTime DataAtualizacao { get; set; }

        public StringBuilder _msgErro = new StringBuilder()
        public virtual void ValidarCampos()
        {
            if (_msgErro.Length > 0)
                throw new Exception(_msgErro.ToString());
        }
    }
}

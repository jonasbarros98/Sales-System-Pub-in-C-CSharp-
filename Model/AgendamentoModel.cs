using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudExemplos.Model
{
    public class AgendamentoModel
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Cliente { get; set; }

        public string Servico { get; set; }

        public string Status { get; set; }

        public string Funcionario { get; set; }
        public string Data { get; set; }
    }
}

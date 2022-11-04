using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Medicamento
{
    internal class Lote
    {
        public int id { get; set; }
        public int qtd { get; set; }
        public DateTime venc { get; set; }

        public Lote()
        {
        }

        public Lote(int id, int qtd, DateTime venc)
        {
            this.id = id;
            this.qtd = qtd;
            this.venc = venc;
        }

        public override string ToString()
        {
            return "\n" + id + "-" + qtd + "-" + venc;
        }

    }
}

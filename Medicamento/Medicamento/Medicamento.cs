using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Medicamento
{

    internal class Medicamento
    {



        public int id { get; set; }
        public string nome { get; set; }
        public string laboratorio { get; set; }
        public Queue<Lote> lotes = new Queue<Lote>();

        public Medicamento()
        {
        }


        public Medicamento(int id, string nome, string laboratorio)
        {
            this.id = id;
            this.nome = nome;
            this.laboratorio = laboratorio;
        }

        public int qtdeDisponivel()
        {
            int qtd = 0;

            foreach (Lote lote in lotes)
            {
                qtd += lote.qtd;
            }
            return qtd;

        }

        public String pesquisaLotes()
        {
            string listalotes = "";

            foreach (Lote lote in lotes)
            {
                listalotes+= lote;
            }
            return listalotes;



        }


        public void comprar(Lote lote)
        {

            lotes.Enqueue(lote);

        }

        public bool vender(int qtde)
        {
            return false;
        }


        public override string ToString()
        {
            return
                "ID: " + id + "\n" +
                "Nome: " + nome + "\n" +
                "Laboratório: " + laboratorio + "\n" +
                "Quantidade Disponível: " + qtdeDisponivel() + "\n" +
                   "----------------------------";

        }

        public bool Equals(object obj)
        {
            return false;
        }





    }


}

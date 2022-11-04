using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Medicamento
{
    internal class Medicamentos
    {

        public List<Medicamento> listaMedicamentos = new List<Medicamento>();

        public Medicamentos()
        {
        }

        public bool podeAdicionar(int id)
        {
            bool podeCadastrar = true;

            foreach (Medicamento remedio in listaMedicamentos)
            {

                if (remedio.id == id)
                {
                    podeCadastrar = false;
                }

            }
            return podeCadastrar;
        }

        public void adicionar(Medicamento medicamento)
        {

            listaMedicamentos.Add(medicamento);

        }

        public bool deletar(Medicamento medicamento)
        {
            return false;
        }

        public Medicamento pesquisar(int id)
        {
            foreach (Medicamento remedio in listaMedicamentos)
            {
                if (remedio.id == id)
                {

                    return remedio;

                }
            }
            return null;

        }
    }
}

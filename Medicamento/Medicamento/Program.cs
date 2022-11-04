using Projeto_Medicamento;

internal class Program
{
    private static void Main(string[] args)
    {


        Medicamentos listaRemedios = new Medicamentos();
        Medicamento medicamento = new Medicamento();


        int opcao = -1;

        while (opcao != 0)
        {
            Console.WriteLine("\n0. Finalizar processo\n" + "1. Cadastrar medicamento\n" +
                "2. Consultar medicamento (sintético)\n" + "3. Consultar medicamento(analítico)\n" +
                "4. Comprar medicamento\n" + "5. Vender medicamento\n" +
                "6. Listar medicamentos");

            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    {

                        Console.WriteLine("Digite o ID do medicamento: ");
                        int id_medicamento = int.Parse(Console.ReadLine());

                        if (listaRemedios.podeAdicionar(id_medicamento) == true)
                        {
                            Console.WriteLine("Digite o nome do medicamento: ");
                            string nome_medicamento = Console.ReadLine();

                            Console.WriteLine("Digite o laboratório do medicamento: ");
                            string lab = Console.ReadLine();

                            Medicamento remedio = new Medicamento(id_medicamento, nome_medicamento, lab);

                            listaRemedios.adicionar(remedio);

                            Console.WriteLine("QTD: " + listaRemedios.listaMedicamentos.Count);
                        }
                        else
                        {
                            Console.WriteLine("---------------------");
                            Console.WriteLine("Medicamento já existe no CADASTRO ! / Cadastre um NOVO medicamento ! ");
                            Console.WriteLine();
                            Console.WriteLine("---------------------");
                        }

                        break;
                    }
                case 2:
                    {

                        Console.WriteLine("Pesquisar pelo ID do medicamento - Sintético: ");
                        int id_medicamento = int.Parse(Console.ReadLine());

                        Medicamento pesquisado =  listaRemedios.pesquisar(id_medicamento);

                        if (pesquisado != null)
                        {
                            Console.WriteLine("---------------------");
                            Console.WriteLine(pesquisado);

                        }


                        else
                        {
                            Console.WriteLine("Medicamento não encontrado na base de dados!!");
                            Console.WriteLine();
                        }
  

                        break;
                    }

                case 3:
                    {

                        Console.WriteLine("Pesquisar pelo ID do medicamento - Analítico:");
                        int id_medicamento = int.Parse(Console.ReadLine());

                        Medicamento pesquisado = listaRemedios.pesquisar(id_medicamento);

                        if (pesquisado != null)
                        {
                            Console.WriteLine("---------------------");
                            Console.WriteLine(pesquisado + "\n" + "LOTES: " + pesquisado.pesquisaLotes());
                            Console.WriteLine("---------------------");
                        }
                        else
                        {
                            Console.WriteLine("Medicamento não encontrado na base de dados!!");
                            Console.WriteLine();
                        }

                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Digite o numero do Lote: ");
                        int id_lote = int.Parse(Console.ReadLine());

                        Console.WriteLine("Digite a quantidade de remédios: ");
                        int qtd_med = int.Parse(Console.ReadLine());

                        Console.WriteLine("Digite a data de vencimento do lote: ");
                        DateTime dt_venc_lote = DateTime.Parse(Console.ReadLine());

                        Lote lote = new Lote(id_lote, qtd_med, dt_venc_lote);

                        Console.WriteLine("Digite o ID do medicamento: ");
                        int id_medicamento = int.Parse(Console.ReadLine());

                        foreach (Medicamento remedio in listaRemedios.listaMedicamentos)
                        {
                            if (remedio.id == id_medicamento)
                            {
                                remedio.comprar(lote);

                            }
                        }

                        break;
                    }
                case 5:
                    {




                        break;
                    }

                case 6:
                    {

                        Console.WriteLine("----------------------------");
                        foreach (Medicamento remedio in listaRemedios.listaMedicamentos)
                        {

                            Console.WriteLine(remedio);

                        }

                        break;
                    }

            }
        }
    }
}


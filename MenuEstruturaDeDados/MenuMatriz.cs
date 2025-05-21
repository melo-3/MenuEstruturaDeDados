using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuEstruturaDeDados
{
    public static class MenuMatriz
    {
        public static void Exibir()
        {
            Console.Write("Digite o número de linhas: ");
            int linhas;
            while (!int.TryParse(Console.ReadLine(), out linhas) || linhas <= 0)
                Console.Write("Valor inválido. Digite um número de linhas (>0): ");

            Console.Write("Digite o número de colunas: ");
            int colunas;
            while (!int.TryParse(Console.ReadLine(), out colunas) || colunas <= 0)
                Console.Write("Valor inválido. Digite um número de colunas (>0): ");

            Matriz matriz = new Matriz(linhas, colunas);

            int opcao;
            do
            {
                Console.WriteLine("======= MENU MATRIZ =======");
                Console.WriteLine("1 - Inserir elemento");
                Console.WriteLine("2 - Remover elemento");
                Console.WriteLine("3 - Exibir matriz");
                Console.WriteLine("4 - Buscar elemento");
                Console.WriteLine("0 - Voltar");
                Console.Write("Escolha uma opção: ");
                int.TryParse(Console.ReadLine(), out opcao);

                switch (opcao)
                {
                    case 1:
                        Console.Write("Linha (0 a {0}): ", linhas - 1);
                        int linhaIns;
                        if (!int.TryParse(Console.ReadLine(), out linhaIns))
                        {
                            Console.WriteLine("Linha inválida!");
                            break;
                        }
                        Console.Write("Coluna (0 a {0}): ", colunas - 1);
                        int colunaIns;
                        if (!int.TryParse(Console.ReadLine(), out colunaIns))
                        {
                            Console.WriteLine("Coluna inválida!");
                            break;
                        }
                        Console.Write("Valor: ");
                        int valorIns;
                        if (!int.TryParse(Console.ReadLine(), out valorIns))
                        {
                            Console.WriteLine("Valor inválido!");
                            break;
                        }
                        if (matriz.Inserir(linhaIns, colunaIns, valorIns))
                            Console.WriteLine("Valor inserido!");
                        else
                            Console.WriteLine("Posição inválida!");
                        break;
                    case 2:
                        Console.Write("Linha (0 a {0}): ", linhas - 1);
                        int linhaRem;
                        if (!int.TryParse(Console.ReadLine(), out linhaRem))
                        {
                            Console.WriteLine("Linha inválida!");
                            break;
                        }
                        Console.Write("Coluna (0 a {0}): ", colunas - 1);
                        int colunaRem;
                        if (!int.TryParse(Console.ReadLine(), out colunaRem))
                        {
                            Console.WriteLine("Coluna inválida!");
                            break;
                        }
                        if (matriz.Remover(linhaRem, colunaRem))
                            Console.WriteLine("Elemento removido (zerado)!");
                        else
                            Console.WriteLine("Posição inválida!");
                        break;
                    case 3:
                        matriz.Exibir();
                        break;
                    case 4:
                        Console.Write("Valor a buscar: ");
                        int valorBusca;
                        if (!int.TryParse(Console.ReadLine(), out valorBusca))
                        {
                            Console.WriteLine("Valor inválido!");
                            break;
                        }
                        var pos = matriz.BuscarPosicao(valorBusca);
                        if (pos.HasValue)
                            Console.WriteLine($"Valor encontrado na linha {pos.Value.Item1}, coluna {pos.Value.Item2}");
                        else
                            Console.WriteLine("Valor não encontrado!");
                        break;
                    case 0:
                        Console.WriteLine("Voltando ao menu principal...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
                Console.WriteLine();
            } while (opcao != 0);
        }
    }
}

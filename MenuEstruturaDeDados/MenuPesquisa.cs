using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuEstruturaDeDados
{
    public static class MenuPesquisa
    {
        public static void Exibir()
        {
            Console.WriteLine("Digite a quantidade de elementos da lista: ");
            int n = int.Parse(Console.ReadLine());
            var lista = new ListaEstatica<int>(n);

            bool sair = false;
            while (!sair)
            {
                Console.WriteLine("======= MENU PESQUISA =======");
                Console.WriteLine("1 - Inserir elemento");
                Console.WriteLine("2 - Exibir lista");
                Console.WriteLine("3 - Busca sequencial");
                Console.WriteLine("4 - Busca binária (lista precisa estar ordenada)");
                Console.WriteLine("5 - Ordenar lista");
                Console.WriteLine("0 - Voltar");
                Console.Write("Escolha uma opção: ");
                int.TryParse(Console.ReadLine(), out int opcao);

                switch (opcao)
                {
                    case 1:
                        if (lista.Tamanho < n)
                        {
                            Console.Write("Digite o valor inteiro: ");
                            if (int.TryParse(Console.ReadLine(), out int valor))
                            {
                                lista.Inserir(valor);
                                Console.WriteLine("Inserido!");
                            }
                            else
                            {
                                Console.WriteLine("Valor inválido!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Lista cheia!");
                        }
                        break;
                    case 2:
                        lista.Exibir();
                        break;
                    case 3:
                        Console.Write("Digite o valor a ser buscado: ");
                        if (int.TryParse(Console.ReadLine(), out int valorBuscaSeq))
                        {
                            int resultado = lista.BuscaSequencial(valorBuscaSeq);
                            if (resultado != -1)
                                Console.WriteLine($"Elemento {valorBuscaSeq} encontrado na posição {resultado} (busca sequencial)");
                            else
                                Console.WriteLine($"Elemento {valorBuscaSeq} não encontrado (busca sequencial)");
                        }
                        else
                        {
                            Console.WriteLine("Valor inválido!");
                        }
                        break;
                    case 4:
                        Console.Write("Digite o valor a ser buscado: ");
                        if (int.TryParse(Console.ReadLine(), out int valorBuscaBin))
                        {
                            int resultado = lista.BuscaBinaria(valorBuscaBin);
                            if (resultado != -1)
                                Console.WriteLine($"Elemento {valorBuscaBin} encontrado na posição {resultado} (busca binária)");
                            else
                                Console.WriteLine($"Elemento {valorBuscaBin} não encontrado (busca binária)");
                        }
                        else
                        {
                            Console.WriteLine("Valor inválido!");
                        }
                        break;
                    case 5:
                        lista.Ordenar();
                        Console.WriteLine("Lista ordenada!");
                        break;
                    case 0:
                        sair = true;
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
                Console.WriteLine();
            }
        }
    }
}

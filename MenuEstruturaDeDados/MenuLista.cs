using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuEstruturaDeDados
{
    public static class MenuLista
    {
        public static void Exibir()
        {
            Lista lista = new Lista();
            int opcao;
            do
            {
                Console.WriteLine("======= MENU LISTA =======");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("1 - Inserir");
                Console.WriteLine("2 - Remover por valor");
                Console.WriteLine("3 - Remover por posição");
                Console.WriteLine("4 - Tamanho");
                Console.WriteLine("5 - Exibir lista");
                Console.WriteLine("6 - Exibir item por posição");
                Console.WriteLine("7 - Verificar se valor existe");
                Console.WriteLine("8 - Limpar lista");
                Console.Write("Escolha uma opção: ");
                int.TryParse(Console.ReadLine(), out opcao);

                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("Saindo do menu lista...");
                        break;
                    case 1:
                        Console.Write("Digite o valor: ");
                        char valorInserir = Console.ReadKey().KeyChar;
                        Console.WriteLine();
                        lista.Inserir(valorInserir);
                        break;
                    case 2:
                        Console.Write("Digite o valor a ser removido: ");
                        char valorRemover = Console.ReadKey().KeyChar;
                        Console.WriteLine();
                        if (lista.Remover(valorRemover))
                            Console.WriteLine("Removido com sucesso!");
                        else
                            Console.WriteLine("Valor não encontrado!");
                        break;
                    case 3:
                        Console.Write("Digite a posição para remover: ");
                        int posRemover;
                        if (int.TryParse(Console.ReadLine(), out posRemover))
                        {
                            if (lista.RemoverPorPosicao(posRemover))
                                Console.WriteLine("Removido com sucesso!");
                            else
                                Console.WriteLine("Posição inválida!");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Tamanho da lista: " + lista.Tamanho());
                        break;
                    case 5:
                        lista.ExibirLista();
                        break;
                    case 6:
                        Console.Write("Digite a posição: ");
                        int pos;
                        if (int.TryParse(Console.ReadLine(), out pos))
                        {
                            var item = lista.ItemEmPosicao(pos);
                            if (item.HasValue)
                                Console.WriteLine("Valor na posição " + pos + ": " + item.Value);
                            else
                                Console.WriteLine("Posição inválida!");
                        }
                        break;
                    case 7:
                        Console.Write("Digite o valor a ser verificado: ");
                        char valorBuscar = Console.ReadKey().KeyChar;
                        Console.WriteLine();
                        if (lista.Contem(valorBuscar))
                            Console.WriteLine("Valor encontrado na lista!");
                        else
                            Console.WriteLine("Valor não encontrado!");
                        break;
                    case 8:
                        lista.Limpar();
                        Console.WriteLine("Lista limpa!");
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

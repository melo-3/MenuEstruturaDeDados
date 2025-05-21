using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuEstruturaDeDados
{
    public static class MenuPilha
    {
        public static void Exibir()
        {
            Pilha pilha = new Pilha();
            char opcao;
            do
            {
                Console.WriteLine("======= MENU PILHA =======");
                Console.WriteLine("1- Inserir elemento");
                Console.WriteLine("2- Remover elemento");
                Console.WriteLine("3- Exibir elementos");
                Console.WriteLine("4- Mostrar topo");
                Console.WriteLine("5- Mostrar tamanho");
                Console.WriteLine("0- Voltar");
                Console.Write("Escolha uma opção: ");
                opcao = Console.ReadKey().KeyChar;
                Console.WriteLine();

                switch (opcao)
                {
                    case '1':
                        Console.Write("Digite um caractere para empilhar: ");
                        char caractere = Console.ReadKey().KeyChar;
                        Console.WriteLine();
                        pilha.Inserir(caractere);
                        break;
                    case '2':
                        var removido = pilha.Remover();
                        if (removido.HasValue)
                            Console.WriteLine("Elemento removido: " + removido.Value);
                        else
                            Console.WriteLine("Pilha vazia!");
                        break;
                    case '3':
                        pilha.ExibirTodos();
                        break;
                    case '4':
                        var topo = pilha.Topo();
                        if (topo.HasValue)
                            Console.WriteLine("Topo da pilha: " + topo.Value);
                        else
                            Console.WriteLine("Pilha vazia!");
                        break;
                    case '5':
                        Console.WriteLine("Tamanho da pilha: " + pilha.Tamanho());
                        break;
                    case '0':
                        Console.WriteLine("Voltando ao menu principal...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
                Console.WriteLine();

            } while (opcao != '0');
        }
    }
}

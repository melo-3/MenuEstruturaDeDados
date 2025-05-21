using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuEstruturaDeDados
{
    public static class MenuFila
    {
        public static void Exibir()
        {
            Fila fila = new Fila();
            int opcao;
            do
            {
                Console.WriteLine("======= MENU FILA =======");
                Console.WriteLine("0 - Voltar");
                Console.WriteLine("1 - Enfileirar");
                Console.WriteLine("2 - Início da fila");
                Console.WriteLine("3 - Desenfileirar");
                Console.WriteLine("4 - Tamanho da fila");
                Console.WriteLine("5 - Exibir fila");
                Console.Write("Escolha uma opção: ");
                int.TryParse(Console.ReadLine(), out opcao);

                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("Voltando ao menu principal...");
                        break;
                    case 1:
                        Console.Write("Digite valor para enfileirar: ");
                        char valor = Console.ReadKey().KeyChar;
                        Console.WriteLine();
                        fila.Enfileirar(valor);
                        break;
                    case 2:
                        var inicio = fila.Inicio();
                        if (inicio.HasValue)
                            Console.WriteLine("Início da fila: " + inicio.Value);
                        else
                            Console.WriteLine("Fila vazia");
                        break;
                    case 3:
                        var removido = fila.Desenfileirar();
                        if (removido.HasValue)
                            Console.WriteLine("Elemento desenfileirado: " + removido.Value);
                        else
                            Console.WriteLine("Fila vazia");
                        break;
                    case 4:
                        Console.WriteLine("Quantidade de elementos na fila: " + fila.Tamanho());
                        break;
                    case 5:
                        fila.ExibirFila();
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }

                Console.WriteLine();
            } while (opcao != 0);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuEstruturaDeDados
{
    public static class Menu
    {
        public static void Exibir()
        {
            int opcao;
            do
            {
                Console.Clear();
                Console.WriteLine("======= MENU PRINCIPAL =======");
                Console.WriteLine("1. Vetores");
                Console.WriteLine("2. Matrizes");
                Console.WriteLine("3. Trabalhar com Lista");
                Console.WriteLine("4. Trabalhar com Fila");
                Console.WriteLine("5. Trabalhar com Pilha");
                Console.WriteLine("6. Algoritmos de Pesquisa");
                Console.WriteLine("0. Encerrar");
                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine() ?? "0");

                switch (opcao)
                {
                    case 1:
                        MenuVetor.Exibir();
                        break;
                    case 2:
                        MenuMatriz.Exibir();
                        break;
                    case 3:
                        MenuLista.Exibir();
                        break;
                    case 4:
                        MenuFila.Exibir();
                        break;
                    case 5:
                        MenuPilha.Exibir();
                        break;
                    case 6:
                        MenuPesquisa.Exibir();
                        break;
                    case 0:
                        Console.WriteLine("Encerrando...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            } while (opcao != 0);
        }
    }
}

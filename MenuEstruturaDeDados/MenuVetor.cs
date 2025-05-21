using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuEstruturaDeDados
{
    public static class MenuVetor
    {
        public static void Exibir()
        {
            Console.Write("Digite a capacidade máxima do vetor: ");
            int capacidade = int.Parse(Console.ReadLine());
            Vetor vetor = new Vetor(capacidade);

            int opcao;
            do
            {
                Console.WriteLine("======= MENU VETOR =======");
                Console.WriteLine("1 - Inserir elemento");
                Console.WriteLine("2 - Remover elemento");
                Console.WriteLine("3 - Exibir elementos");
                Console.WriteLine("4 - Buscar elemento");
                Console.WriteLine("0 - Voltar");
                Console.Write("Escolha uma opção: ");
                int.TryParse(Console.ReadLine(), out opcao);

                switch (opcao)
                {
                    case 1:
                        Console.Write("Digite o valor inteiro para inserir: ");
                        if (int.TryParse(Console.ReadLine(), out int valorIns))
                            vetor.Inserir(valorIns);
                        else
                            Console.WriteLine("Valor inválido!");
                        break;
                    case 2:
                        Console.Write("Digite o valor inteiro para remover: ");
                        if (int.TryParse(Console.ReadLine(), out int valorRem))
                        {
                            if (vetor.Remover(valorRem))
                                Console.WriteLine("Valor removido!");
                            else
                                Console.WriteLine("Valor não encontrado!");
                        }
                        else
                            Console.WriteLine("Valor inválido!");
                        break;
                    case 3:
                        vetor.Exibir();
                        break;
                    case 4:
                        Console.Write("Digite o valor inteiro para buscar: ");
                        if (int.TryParse(Console.ReadLine(), out int valorBusca))
                        {
                            int pos = vetor.Buscar(valorBusca);
                            if (pos >= 0)
                                Console.WriteLine("Valor encontrado na posição: " + pos);
                            else
                                Console.WriteLine("Valor não encontrado!");
                        }
                        else
                            Console.WriteLine("Valor inválido!");
                        break;
                    case 0:
                        Console.WriteLine("Voltando ao menu principal...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
                Console.WriteLine();
            }
            while (opcao != 0);
        }
    }
}
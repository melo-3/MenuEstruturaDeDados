using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuEstruturaDeDados
{
    public class ListaEstatica<T> where T : IComparable<T>
    {
        private T[] elementos;
        private int tamanho;
        private int capacidade;

        public ListaEstatica(int capacidade)
        {
            this.capacidade = capacidade;
            elementos = new T[capacidade];
            tamanho = 0;
        }

        public void Inserir(T valor)
        {
            if (tamanho == capacidade)
            {
                Console.WriteLine("Lista cheia");
                return;
            }
            elementos[tamanho] = valor;
            tamanho++;
        }

        public void Exibir()
        {
            if (tamanho == 0)
            {
                Console.WriteLine("Lista vazia");
                return;
            }
            Console.Write("Lista: ");
            for (int i = 0; i < tamanho; i++)
            {
                Console.Write(elementos[i] + " ");
            }
            Console.WriteLine();
        }

        public int BuscaSequencial(T valor)
        {
            for (int i = 0; i < tamanho; ++i)
            {
                if (elementos[i].CompareTo(valor) == 0)
                {
                    return i;
                }
            }
            return -1;
        }

        public int BuscaBinaria(T valor)
        {
            int inicio = 0;
            int fim = tamanho - 1;

            while (inicio <= fim)
            {
                int meio = (inicio + fim) / 2;

                if (elementos[meio].CompareTo(valor) == 0)
                {
                    return meio;
                }
                if (elementos[meio].CompareTo(valor) > 0)
                {
                    fim = meio - 1;
                }
                else
                {
                    inicio = meio + 1;
                }
            }
            return -1;
        }

        public void Ordenar()
        {
            Array.Sort(elementos, 0, tamanho);
        }

        public int Tamanho => tamanho;
    }
}

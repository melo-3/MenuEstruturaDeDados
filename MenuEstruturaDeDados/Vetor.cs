using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuEstruturaDeDados
{
    public class Vetor
    {
        private int[] vetor;
        private int tamanho;
        private int capacidade;

        public Vetor(int capacidade)
        {
            this.capacidade = capacidade;
            vetor = new int[capacidade];
            tamanho = 0;
        }

        public void Inserir(int valor)
        {
            if (tamanho == capacidade)
            {
                Console.WriteLine("Vetor cheio!");
                return;
            }
            vetor[tamanho] = valor;
            tamanho++;
        }

        public bool Remover(int valor)
        {
            int index = Array.IndexOf(vetor, valor, 0, tamanho);
            if (index >= 0)
            {
                for (int i = index; i < tamanho - 1; i++)
                    vetor[i] = vetor[i + 1];
                tamanho--;
                return true;
            }
            return false;
        }

        public void Exibir()
        {
            if (tamanho == 0)
            {
                Console.WriteLine("Vetor vazio!");
                return;
            }
            Console.Write("Vetor: ");
            for (int i = 0; i < tamanho; i++)
                Console.Write(vetor[i] + " ");
            Console.WriteLine();
        }

        public int Buscar(int valor)
        {
            for (int i = 0; i < tamanho; i++)
            {
                if (vetor[i] == valor)
                    return i;
            }
            return -1;
        }

        public int Tamanho => tamanho;
    }
}

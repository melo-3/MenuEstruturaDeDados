using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuEstruturaDeDados
{
    public class Lista
    {
        private List<char> lista = new List<char>();

        public void Inserir(char valor)
        {
            lista.Add(valor);
        }

        public bool Remover(char valor)
        {
            return lista.Remove(valor);
        }

        public bool RemoverPorPosicao(int posicao)
        {
            if (posicao >= 0 && posicao < lista.Count)
            {
                lista.RemoveAt(posicao);
                return true;
            }
            return false;
        }

        public int Tamanho()
        {
            return lista.Count;
        }

        public void ExibirLista()
        {
            if (lista.Count == 0)
            {
                Console.WriteLine("Lista vazia");
            }
            else
            {
                Console.Write("Lista: ");
                foreach (char c in lista)
                {
                    Console.Write(c + " ");
                }
                Console.WriteLine();
            }
        }

        public char? ItemEmPosicao(int posicao)
        {
            if (posicao >= 0 && posicao < lista.Count)
                return lista[posicao];
            return null;
        }

        public bool Contem(char valor)
        {
            return lista.Contains(valor);
        }

        public void Limpar()
        {
            lista.Clear();
        }
    }
}

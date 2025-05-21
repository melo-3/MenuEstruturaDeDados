using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuEstruturaDeDados
{
    public class Pilha
    {
        private Stack<char> pilha = new Stack<char>();

        public void Inserir(char elemento)
        {
            pilha.Push(elemento);
        }

        public char? Remover()
        {
            if (pilha.Count > 0)
                return pilha.Pop();
            return null;
        }

        public void ExibirTodos()
        {
            if (pilha.Count == 0)
                Console.WriteLine("Pilha vazia! >:(");
            else
            {
                Console.WriteLine("Elementos na pilha:");
                foreach (var item in pilha)
                    Console.WriteLine(" " + item);
            }
        }

        public char? Topo()
        {
            if (pilha.Count > 0)
                return pilha.Peek();
            return null;
        }

        public int Tamanho()
        {
            return pilha.Count;
        }
    }
}

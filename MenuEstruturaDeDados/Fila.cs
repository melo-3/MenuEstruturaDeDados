using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuEstruturaDeDados
{
    public class Fila
    {
        private Queue<char> queue = new Queue<char>();

        public void Enfileirar(char valor)
        {
            queue.Enqueue(valor);
        }

        public char? Desenfileirar()
        {
            if (queue.Count > 0)
                return queue.Dequeue();
            return null;
        }

        public char? Inicio()
        {
            if (queue.Count > 0)
                return queue.Peek();
            return null;
        }

        public int Tamanho()
        {
            return queue.Count;
        }

        public void ExibirFila()
        {
            if (queue.Count == 0)
                Console.WriteLine("Fila vazia");
            else
            {
                Console.Write("Fila: ");
                foreach (var item in queue)
                    Console.Write(item + " ");
                Console.WriteLine();
            }
        }
    }
}

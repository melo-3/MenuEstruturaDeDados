using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuEstruturaDeDados
{
    public class Matriz
    {
        private int[,] matriz;
        private int linhas;
        private int colunas;

        public Matriz(int linhas, int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            matriz = new int[linhas, colunas];
        }

        public bool Inserir(int linha, int coluna, int valor)
        {
            if (linha >= 0 && linha < linhas && coluna >= 0 && coluna < colunas)
            {
                matriz[linha, coluna] = valor;
                return true;
            }
            return false;
        }

        public bool Remover(int linha, int coluna)
        {
            if (linha >= 0 && linha < linhas && coluna >= 0 && coluna < colunas)
            {
                matriz[linha, coluna] = 0;
                return true;
            }
            return false;
        }

        public void Exibir()
        {
            Console.WriteLine("Matriz:");
            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        public (int, int)? BuscarPosicao(int valor)
        {
            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    if (matriz[i, j] == valor)
                        return (i, j);
                }
            }
            return null;
        }
    }
}

# Menu Interativo de Estruturas de Dados

Este projeto implementa um menu interativo em terminal/console para manipulação de diferentes estruturas de dados em C#.

## Objetivo

Permitir que o usuário escolha entre operações sobre:

- Vetores
- Matrizes
- Listas
- Filas
- Pilhas
- Algoritmos de Pesquisa

Cada estrutura oferece operações como inserir, remover, exibir todos e buscar/consultar elementos.

## Como Rodar o Sistema

### Pré-requisitos

- [.NET SDK 6.0 ou superior](https://dotnet.microsoft.com/download)

### Passos para execução

1. Clone este repositório:
   ```bash
   git clone https://github.com/melo-3/MenuEstruturaDeDados.git
   cd MenuEstruturaDeDados
   ```

2. Compile o projeto:
   ```bash
   dotnet build
   ```

3. Execute o programa:
   ```bash
   dotnet run
   ```

## Estrutura do Menu

- **Menu Principal**
  - Vetores
  - Matrizes
  - Trabalhar com Lista
  - Trabalhar com Fila
  - Trabalhar com Pilha
  - Algoritmos de Pesquisa
  - Voltar ao Menu Principal / Encerrar

Cada opção redireciona para um submenu com:

- Inserir elemento
- Remover elemento
- Exibir todos os elementos
- Consultar/Buscar elemento

## Exemplos de uso

```text
======= MENU PRINCIPAL =======
1. Vetores
2. Matrizes
3. Trabalhar com Lista
4. Trabalhar com Fila
5. Trabalhar com Pilha
6. Algoritmos de Pesquisa
0. Encerrar
Escolha uma opção: 3

======= MENU LISTA =======
1. Inserir elemento
2. Remover elemento
3. Exibir todos os elementos
4. Buscar elemento
0. Voltar
```

---

## Organização do Código

O código está modularizado em classes separadas por estrutura de dados, facilitando manutenção e leitura.

---

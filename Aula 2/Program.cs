using System;
using Aula_2.classes;

namespace Aula_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p1 = new Produto();
            p1.Codigo = 1;
            p1.Nome   = "Lapis";
            p1.Preco  = 1.50f; 

            Produto p2 = new Produto();
            p2.Codigo = 2;
            p2.Nome   = "Branquinho";
            p2.Preco  = 3.00f;

            Produto p3 = new Produto();
            p3.Codigo = 3;
            p3.Nome   = "Caneta";
            p3.Preco  = 2.50f; 

            Carrinho carrinho = new Carrinho();

            Console.ForegroundColor = ConsoleColor.Green;
            carrinho.Cadastrar(p1);
            carrinho.Listar();

            Console.WriteLine($"--------");

            Console.ForegroundColor = ConsoleColor.Red;
            carrinho.Alterar(1, p3);
            carrinho.Cadastrar(p2);
            carrinho.Listar();

            Console.WriteLine($"----------");

            Console.ForegroundColor = ConsoleColor.Blue;
            carrinho.Deletar(p1);
            carrinho.Listar();
            







                       
        }
    }
}

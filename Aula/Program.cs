using System;
using Aula.classes;

namespace Aula
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p1 = new Produto();
            p1.Codigo = 1;
            p1.Nome   = "Mouse";
            p1.Preco  = 100f;

            Produto p2 = new Produto();
            p2.Codigo = 2;
            p2.Nome   = "Teclado";
            p2.Preco  = 500f;

            Produto p3 = new Produto();
            p3.Codigo = 3;
            p3.Nome   = "Fone";
            p3.Preco  = 250f;

            Carrinho carrinho = new Carrinho();

            Console.ForegroundColor = ConsoleColor.Red;
            carrinho.Cadastrar(p1);
            carrinho.Cadastrar(p2);
            carrinho.Listar();

            Console.WriteLine($"-------------");

            Console.ForegroundColor = ConsoleColor.Yellow;
            carrinho.Alterar(1, p3);
            carrinho.Deletar(p2);
            carrinho.Listar();
            

        }
    }
}

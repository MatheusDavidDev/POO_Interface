using System;
using POO_Interface.classes;

namespace POO_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p1 = new Produto();
            p1.Codigo = 1;
            p1.Nome   = "Coca-Cola";
            p1.Preco  = 10.00f;

            Produto p2 = new Produto();
            p2.Codigo = 2;
            p2.Nome   = "Fanta";
            p2.Preco  = 8.00f;

            Produto p3 = new Produto();
            p3.Codigo = 3;
            p3.Nome   = "Pepsi";
            p3.Preco  = 9.00f;

            Produto p4 = new Produto();
            p4.Codigo = 4;
            p4.Nome   = "Guarana";
            p4.Preco  = 6.00f;

            Carrinho carrinho = new Carrinho();
            
            Console.ForegroundColor = ConsoleColor.Red;
            carrinho.Cadastrar(p1);
            carrinho.Cadastrar(p2);
            carrinho.Cadastrar(p3);
            carrinho.Listar();

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            carrinho.Alterar(1, p4);
            carrinho.Deletar(p3);
            carrinho.Listar();
        }
    }
}

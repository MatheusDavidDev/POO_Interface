using System;
using System.Collections.Generic;

namespace Aula_2.classes
{
    public class Carrinho : ICarrinho
    {   
        List<Produto> carrinho = new List<Produto>();

        public void Alterar(int code, Produto produto)
        {
            carrinho.Find(x => x.Codigo == code).Nome = produto.Nome;
            carrinho.Find(x => x.Codigo == code).Preco = produto.Preco;
        }

        public void Cadastrar(Produto produto)
        {
            carrinho.Add(produto);
        }

        public void Deletar(Produto produto)
        {
            carrinho.Remove(produto);
        }

        public void Listar()
        {
            foreach (Produto item in carrinho)
            {
                Console.WriteLine($"Código: {item.Codigo} \n Produto: {item.Nome} \n Preço: R${item.Preco}");
                
            }
        }
    }
}
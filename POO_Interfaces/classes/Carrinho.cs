using System;
using System.Collections.Generic;

namespace POO_Interface.classes
{
    public class Carrinho : ICarrinho
    {
        //ctrl + . = incrementar
        public float ValorTotal { get; set; }

        List<Produto> carrinho = new List<Produto>();

        public void Alterar(int cod, Produto produto)
        {
            carrinho.Find(x => x.Codigo == cod).Nome = produto.Nome;
            carrinho.Find(x => x.Codigo == cod).Preco = produto.Preco;
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
            foreach (var item in carrinho)
            {
                Console.WriteLine($"Produto: {item.Nome} \n Preço: {item.Preco} \n Código: {item.Codigo}");
                
            }
        }
    }
}
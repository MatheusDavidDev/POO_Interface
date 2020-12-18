namespace Aula_2.classes
{
    public interface ICarrinho
    {
         //CRUD

         void Cadastrar(Produto produto);

         void Listar();

         void Alterar(int code, Produto produto);

         void Deletar(Produto produto);
    }
}
namespace Aula.classes
{
    public interface ICarrinho
    {
        //CRUD
        //Creat - Cadastar 
        void Cadastrar(Produto produto); 
        //Read - Listar
        void Listar();
        //Updade - Alterar
        void Alterar(int cod, Produto produto);

        //Delete - Deletar
        void Deletar(Produto produto);
    }

}
namespace Chapterturma9.Interfaces
{
    public class 
    {
        List<Usuario> Listar();

        Usuario BuscarPorId();

        void Cadastrar(Usuatrio novoUsuario);

        void Atuliazar(int, Usuario usuario);

        void Deletar(int id);

        Usuario Login(string email,string senha);
    }
}

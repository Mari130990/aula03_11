using Chapterturma9.Contexts;
using Chapterturma9.Models;

namespace Chapterturma9.Repositories
{
    public class LivroRepository
    {
        private readonly SqlContext _Context;
        public LivroRepository(SqlContext context)
        {
            _Context = context;     
        }

        public List<Livro> Listar()
        {
            return _Context.Livros.ToList();
        }
    }
}

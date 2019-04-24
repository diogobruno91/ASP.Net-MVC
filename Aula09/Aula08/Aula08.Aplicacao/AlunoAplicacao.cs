using Aula08.Dominio;
using System.Collections.Generic;
using Aula08.Dominio.contrate;

namespace Aula08.Aplicacao
{
    public class AlunoAplicacao
    {
        private readonly IRepositorio<Editora> repositorio;

        public AlunoAplicacao(IRepositorio<Editora> repo)
        {
            repositorio = repo;
        }

        public void Salvar(Editora editora)
        {
            repositorio.Salvar(editora);
        }

        public void Excluir (Editora editora)
        {
            repositorio.Excluir(editora);
        }

        public IEnumerable<Editora> ListarTodos()
        {
            return repositorio.ListarTodos();
        }

        public Editora ListaPorId(string id)
        {
            return repositorio.ListaPorId(id);
        }

    }
}

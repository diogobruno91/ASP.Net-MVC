using Aula08.Dominio;
using Aula08.Dominio.contrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula09.RepositorioEF
{
    public class AlunoRepositorioEF : IRepositorio<Editora>
    {
        private readonly Contexto contexto;

        public AlunoRepositorioEF()
        {
            contexto = new Contexto();
        }

        public void Salvar(Editora entidade)
        {
            if (entidade.Id > 0)
            {
                var alunoAlterar = contexto.Editoras.First(x => x.Id == entidade.Id);
                alunoAlterar.Nome = entidade.Nome;
            }
            else
            {
                contexto.Editoras.Add(entidade);
            }
            contexto.SaveChange();
        }
        public void Excluir(Editora entidade)
        {
            var alunoExcluir = contexto.Editoras.First(x => x.Id == entidade.Id);
            contexto.Set<Editora>().Remove(alunoExcluir);
            contexto.SaveChange();
        }
        public IEnumerable<Editora> ListarTodos()
        {
            return contexto.Editoras;
        }

        public Editora ListaPorId(string id)
        {
            int idInt;
            Int32.TryParse(id, out idInt);
            return contexto.Editoras.First(x => x.Id == idInt);
        }

    }
}

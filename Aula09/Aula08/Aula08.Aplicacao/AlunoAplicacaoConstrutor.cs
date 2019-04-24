using Aula08.RepositorioADO;
using Aula08.Repositorio;
using Aula09.RepositorioEF;

namespace Aula08.Aplicacao
{
    public class AlunoAplicacaoConstrutor
    {
        public static AlunoAplicacao AlunoAplicacaoADO()
        {
            return new AlunoAplicacao(new EditoraRepositorioADO());
        }

        public static AlunoAplicacao AlunoAplicacaoEF()
        {
            return new AlunoAplicacao(new AlunoRepositorioEF());
        }
    }
}
 
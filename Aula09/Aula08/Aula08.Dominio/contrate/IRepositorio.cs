using System.Collections.Generic;

namespace Aula08.Dominio.contrate
{
    public interface IRepositorio<T> where T : class
    {
        void Salvar(T entidade);

        void Excluir(T entidade);

        IEnumerable<T> ListarTodos();

        T ListaPorId(string id);
    }
}

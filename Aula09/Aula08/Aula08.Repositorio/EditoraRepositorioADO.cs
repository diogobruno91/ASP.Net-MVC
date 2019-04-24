using Aula08.Repositorio;
using Aula08.Dominio;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Aula08.Dominio.contrate;
using System;

namespace Aula08.RepositorioADO
{
    public class EditoraRepositorioADO:IRepositorio<Editora>
    {
        private Contexto contexto;

        private void Inserir(Editora editora)
        {
            var strQuery = "";
            strQuery += "INSERT INTO tbl_Editoras (Nome_Editora)";
            strQuery += string.Format("VALUES('{0}') ", editora.Nome);
            using (contexto = new Contexto())
            {
                contexto.ExecutaComando(strQuery);
            }
        }

        private void Alterar(Editora editora)
        {
            var strQuery = "";
            strQuery += " UPDATE tbl_Editoras SET ";
            strQuery += string.Format("Nome_Editora = '{0}', ", editora.Nome);
            strQuery += string.Format("WHERE Id_Editora = '{0}' ", editora.Id);
            using (contexto = new Contexto())
            {
                contexto.ExecutaComando(strQuery);
            }
        }

        public void Salvar(Editora editora)
        {
            if(editora.Id > 0)
            {
                Alterar(editora);
            } else
            {
                Inserir(editora);
            }
        }

        public void Excluir (Editora editora)
        {
            using (contexto = new Contexto())
            {
                var strQuery = string.Format(" DELETE FROM tbl_Editoras WHERE Id_Editora = {0}", editora.Id);
                contexto.ExecutaComando(strQuery);
            }
        }

        public IEnumerable<Editora> ListarTodos()
        {
            using (contexto = new Contexto())
            {
               var strQuery = "SELECT * FROM tbl_Editoras";
               var retornoDataReader = contexto.ExecutaComandoComRetorno(strQuery);
               return TransformaReaderEmListaDeObjeto(retornoDataReader);
            }
        }

        public Editora ListaPorId(string id)
        {
            using (contexto = new Contexto())
            {
                var strQuery = string.Format( "SELECT * FROM tbl_Editoras WHERE Id_Editora = {0} ", id);
                var retornoDataReader = contexto.ExecutaComandoComRetorno(strQuery);
                return TransformaReaderEmListaDeObjeto(retornoDataReader).FirstOrDefault();
            }
        }

        private List<Editora> TransformaReaderEmListaDeObjeto(SqlDataReader reader)
        {
            var editora = new List<Editora>();
            while (reader.Read())
            {
                var temObjeto = new Editora()
                {
                    Id = int.Parse(reader["Id_Editora"].ToString()),
                    Nome = reader["Nome_Editora"].ToString()
                };
                editora.Add(temObjeto);
            }
            reader.Close();
            return editora;
        }
    }
}

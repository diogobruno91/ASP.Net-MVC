using System;
using Aula08.Aplicacao;
using Aula08.Dominio;

namespace UI.Dos
{
    class Program
    {
        static void Main(string[] args)
        {
            var appAluno = new AlunoAplicacao();

            Console.Write("Digite um nome: ");
            string nome = Console.ReadLine();

            var editora1 = new Editora
            {
                Nome = nome
            };

            appAluno.Salvar(editora1);

            var dados = appAluno.ListarTodos();

            foreach(var editora in dados)
            {
                Console.WriteLine("Id_Editora:{0}, Nome_Editora:{1}", editora.Id, editora.Nome);
            }
        }
    }
}

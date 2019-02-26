using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace Aula04.Models
{
    public class Noticia
    {
        public int NoticiaId { get; set; }
        public string Titulo { get; set; }
        public string Conteudo { get; set; }
        public string Categoria { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Data { get; set; } 

        public IEnumerable<Noticia> TodasAsNoticias()
        {
            var retorno = new Collection<Noticia>
            {
                new Noticia
                {
                    NoticiaId = 1,
                    Categoria = "Esporte",
                    Titulo = "Felipe Massa F1",
                    Conteudo = "Numa tarde de chuva Felipe ganhou",
                    Data = new DateTime(2017,7,3)
                },
                new Noticia
                {
                    NoticiaId = 2,
                    Categoria = "Politica",
                    Titulo = "Presidente assina convênio",
                    Conteudo = "Presidente ganhou",
                    Data = new DateTime(2017,7,3)
                },
                new Noticia
                {
                    NoticiaId = 3,
                    Categoria = "Politica",
                    Titulo = "Vereador é eleito pela 4º vez",
                    Conteudo = "Numa tarde de chuva Felipe ganhou",
                    Data = new DateTime(2012,7,20)
                },
                new Noticia
                {
                    NoticiaId = 4,
                    Categoria = "Esportes",
                    Titulo = "O tão sonhado titulo chegou",
                    Conteudo = "Em um jogo que levou os torcedores ao delitio..",
                    Data = new DateTime(2012,7,18)
                },
                new Noticia
                {
                    NoticiaId = 5,
                    Categoria = "Humor",
                    Titulo = "O comediante Anderson Renato fará show hoje",
                    Conteudo = "O comediante mais engraçado dos comentários do Youtube fará show..",
                    Data = new DateTime(2012,7,14)
                },
                new Noticia
                {
                    NoticiaId = 6,
                    Categoria = "Policial",
                    Titulo = "Tenente coronel Lucas Farias Santos assume o controle",
                    Conteudo = "Durante a retomada do morro o tenente coronel disse..",
                    Data = new DateTime(2012,7,19)
                },
                new Noticia
                {
                    NoticiaId = 7,
                    Categoria = "Esporte",
                    Titulo = "Atacante do Barcelona faz 4 gols",
                    Conteudo = "O atacante Lucas Farias, fez 4 gols e decidiu o titulo..",
                    Data = new DateTime(2012,7,20)
                },
            };
            return retorno;
        }
    }
}
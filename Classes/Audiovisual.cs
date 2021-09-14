using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DIO.Series;

namespace DIO.Series
{
    abstract class Audiovisual
    {
        protected int ID { get; set; }
        protected Genero Genero { get; set; }
        protected string Titulo { get; set; }
        protected string Descricao { get; set; }
        protected int Ano { get; set; }
        protected bool Excluido { get; set; }

        public Audiovisual(int id, Genero genero, string titulo, string descricao, int ano)
        {
            ID = id;
            Genero = genero;
            Titulo = titulo;
            Descricao = descricao;
            Ano = ano;
        }

        public string retornaTitulo()
        {
            return this.Titulo;
        }

        public int retornaID()
        {
            return this.ID;
        }

        public void Excluir()
        {
            this.Excluido = true;
        }

        public bool retornaExcluido()
        {
            return this.Excluido;
        }
    }
}

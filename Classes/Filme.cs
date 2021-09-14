using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIO.Series
{
    class Filme : Audiovisual
    {
        protected int Duracao { get; private set; }
        protected double Nota { get; private set; }

        public Filme(int id, Genero genero, string titulo, string descricao, int duracao, int ano) : base(id, genero, titulo, descricao, ano)
        {
            Duracao = duracao;
        }

        public int retornaDuracao()
        {
            return this.Duracao;
        }

        public void setarDuracao(int minutos)
        {
            this.Duracao = minutos;
        }

        public double retornaNota()
        {
            return this.Nota;
        }

        public void setarNota(double nota)
        {
            this.Nota = nota;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Titulo: " + this.Titulo + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Ano de Início: " + this.Ano + Environment.NewLine;
            retorno += "Exclusão: " + this.Excluido + Environment.NewLine;
            return retorno;
        }

    }
}

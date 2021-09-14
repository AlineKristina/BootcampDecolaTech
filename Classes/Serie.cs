using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIO.Series
{
    class Serie : Audiovisual
    {

        public List<Temporada> Temporadas = new List<Temporada>();

        public Serie(int id, Genero genero, string titulo, string descricao, int ano) : base(id, genero, titulo, descricao, ano)
        {

        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Titulo: " + this.Titulo + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Ano de Início: " + this.Ano + Environment.NewLine;
            retorno += "Exclusão: " + this.Excluido + Environment.NewLine;
            if (Temporadas != null)
            {
                for (int i = 0; i < Temporadas.Count; i++)
                {
                    retorno += Environment.NewLine + "Temporada #" + (i + 1) + ":" + Environment.NewLine;
                    retorno += "Episódios: " + Temporadas[i].Episodios + Environment.NewLine;
                    retorno += "Duração média: " + Temporadas[i].DuracaoMedia + Environment.NewLine;
                }
            }
            return retorno;
        }

        public void adicionarTemporada(Temporada temp)
        {
            this.Temporadas.Add(temp);
        }
    }
    public class Temporada
    {
        public int Episodios { get; set; }
        public int DuracaoMedia { get; set; }

        public Temporada(int episodios, int duracaoMedia)
        {
            this.Episodios = episodios;
            this.DuracaoMedia = duracaoMedia;
        }

        public void setarEpisodios(int quantidade)
        {
            this.Episodios = quantidade;
        }

        public int obterEpisodios()
        {
            return this.Episodios;
        }

        public void setarDuracaoMedia(int duracao)
        {
            this.DuracaoMedia = duracao;
        }

        public int obterDuracaoMedia()
        {
            return DuracaoMedia;
        }
    }
}

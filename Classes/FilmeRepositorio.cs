using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DIO.Series.Interfaces;

namespace DIO.Series
{
    class FilmeRepositorio : IRepositorio<Filme>
    {

        private List<Filme> listaFilme = new List<Filme>();

        public void Atualiza(int id, Filme entidade)
        {
            listaFilme[id] = entidade;
        }

        public void Exclui(int id)
        {
            listaFilme[id].Excluir();
        }

        public void Insere(Filme entidade)
        {
            listaFilme.Add(entidade);
        }

        public List<Filme> Lista()
        {
            return listaFilme;
        }

        public int ProximoID()
        {
            return listaFilme.Count();
        }

        public Filme RetornaPorID(int id)
        {
            return listaFilme[id];
        }
    }
}

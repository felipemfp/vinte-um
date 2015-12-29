using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Postero.VinteUm.Modelo
{
    public class Carta
    {
        private string descricao;

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }
        private int valor;

        public int Valor
        {
            get { return valor; }
            set { valor = value; }
        }
        private string naipe;

        public string Naipe
        {
            get { return naipe; }
            set { naipe = value; }
        }

        public Carta(string descricao, int valor, string naipe)
        {
            this.descricao = descricao;
            this.valor = valor;
            this.naipe = naipe;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Postero.VinteUm.Negocio
{
    public class Jogador
    {
        int n;
        List<Modelo.Carta> mao;

        public List<Modelo.Carta> Mao
        {
            get { return mao; }
            set { mao = value; }
        }

        public Jogador(int n)
        {
            this.n = n;
            this.mao = new List<Modelo.Carta>();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Postero.VinteUm.Negocio
{
    public class Caixa
    {
        private int dinheiro;

        private int aposta;

        public Caixa()
        {
            dinheiro = 50;
        }

        public int GetDinheiro()
        {
            return dinheiro;
        }

        public int GetAposta()
        {
            return aposta;
        }

        public void Apostar(int aposta)
        {
            this.aposta += aposta;
            dinheiro -= aposta;
        }

        public void GanhoAposta()
        {
            dinheiro += (aposta * 2);
            aposta = 0;
        }

        public void PerdaAposta()
        {
            aposta = 0;
        }
    }
}

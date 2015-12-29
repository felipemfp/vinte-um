using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Postero.VinteUm.Negocio
{
    public class Mesa
    {
        Modelo.Baralho baralho;
        //List<Jogador> jogadores;
        Jogador jogador;

        public Jogador Jogador
        {
            get { return jogador; }
            set { jogador = value; }
        }
        List<Modelo.Carta> mesa;

        public List<Modelo.Carta> GetMesa
        {
            get { return mesa; }
        }
        public Mesa(int qteJogadores = 1)
        {
            baralho = new Modelo.Baralho();
            mesa = new List<Modelo.Carta>();
            jogador = new Jogador(1);
            //jogadores = new List<Jogador>();
            //for (int i = 1; i < qteJogadores+1; i++)
            //{
            //    jogadores.Add(new Jogador(i));
            //}
        }

        public List<Modelo.Carta> Parar()
        {
            return mesa;
        }

        public Modelo.Carta Tirar()
        {
            Modelo.Carta car = baralho.TirarCarta();
            jogador.Mao.Add(car);
            return car;
        }

        public Modelo.Carta TirarMesa()
        {
            Modelo.Carta car = baralho.TirarCarta();
            mesa.Add(car);
            return car;
        }

        public int Pontos(List<Modelo.Carta> cartas)
        {
            int pontos = cartas.Sum(c => c.Valor);
            bool contemKQJ = false;
            bool contemA = false;
            int qteA = 0;
            foreach (Modelo.Carta car in cartas)
            {
                if (car.Descricao.Contains("K") || car.Descricao.Contains("Q") || car.Descricao.Contains("J"))
                {
                    contemKQJ = true;
                } 
                if (car.Descricao.Contains("A"))
                {
                    contemA = true;
                    qteA++;
                }
            }
            return contemKQJ && contemA && pontos + (qteA*10) <= 21 ? pontos + (qteA * 10) : pontos;
        }
    }
}

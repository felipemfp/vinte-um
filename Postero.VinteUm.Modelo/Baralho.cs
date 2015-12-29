using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Postero.VinteUm.Modelo
{
    public class Baralho
    {
        private List<Carta> cartas;

        private List<Carta> lixo;

        public Baralho()
        {
            cartas = new List<Carta>();
            lixo = new List<Carta>();
            string[] naipes = new string[4];
            naipes.SetValue("♦", 0);
            naipes.SetValue("♣", 1);
            naipes.SetValue("♥", 2);
            naipes.SetValue("♠", 3);
            for (int i = 0; i < 4; i++)
            {
                cartas.Add(new Carta(naipes[i]+" A", 1, naipes[i].ToString()));
            }
            for (int i = 0; i < 4; i++)
            {
                cartas.Add(new Carta(naipes[i] + " 2", 2, naipes[i].ToString()));
            }
            for (int i = 0; i < 4; i++)
            {
                cartas.Add(new Carta(naipes[i] + " 3", 3, naipes[i].ToString()));
            }
            for (int i = 0; i < 4; i++)
            {
                cartas.Add(new Carta(naipes[i] + " 4", 4, naipes[i].ToString()));
            }
            for (int i = 0; i < 4; i++)
            {
                cartas.Add(new Carta(naipes[i] + " 5", 5, naipes[i].ToString()));
            }
            for (int i = 0; i < 4; i++)
            {
                cartas.Add(new Carta(naipes[i] + " 6", 6, naipes[i].ToString()));
            }
            for (int i = 0; i < 4; i++)
            {
                cartas.Add(new Carta(naipes[i] + " 7", 7, naipes[i].ToString()));
            }
            for (int i = 0; i < 4; i++)
            {
                cartas.Add(new Carta(naipes[i] + " 8", 8, naipes[i].ToString()));
            }
            for (int i = 0; i < 4; i++)
            {
                cartas.Add(new Carta(naipes[i] + " 9", 9, naipes[i].ToString()));
            }
            for (int i = 0; i < 4; i++)
            {
                cartas.Add(new Carta(naipes[i] + " 10", 10, naipes[i].ToString()));
            }
            for (int i = 0; i < 4; i++)
            {
                cartas.Add(new Carta(naipes[i] + " J", 10, naipes[i].ToString()));
            }
            for (int i = 0; i < 4; i++)
            {
                cartas.Add(new Carta(naipes[i] + " Q", 10, naipes[i].ToString()));
            }
            for (int i = 0; i < 4; i++)
            {
                cartas.Add(new Carta(naipes[i] + " K", 10, naipes[i].ToString()));
            }
        }

        public Carta TirarCarta() {
            Random rnd = new Random(new Random(DateTime.Now.Millisecond + cartas.Count).Next(DateTime.Now.Millisecond * cartas.Count) * DateTime.Now.TimeOfDay.Hours);
            int i = rnd.Next(0, (cartas.Count-1));
            Carta car = cartas[i];
            lixo.Add(cartas[i]);
            cartas.Remove(cartas[i]);
            return car;
        }
    }
}

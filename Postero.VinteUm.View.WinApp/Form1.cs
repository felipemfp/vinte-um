using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Postero.VinteUm.View.WinApp
{
    public partial class Form1 : Form
    {
        private Negocio.Mesa mesa;
        private Negocio.Caixa caixa;

        public Form1()
        {
            InitializeComponent();
            caixa = new Negocio.Caixa();
        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            Parar();
        }

        private void btnTirar_Click(object sender, EventArgs e)
        {
            Tirar();
        }
        
        private void btnNovo_Click(object sender, EventArgs e)
        {
            lblPontosDaMesa.ForeColor = Color.Black;
            lblPontosDaMesa.Text = String.Empty;

            lblPontosDoJogador.ForeColor = Color.Black;
            lblPontosDoJogador.Text = String.Empty;

            mesa = new Negocio.Mesa();

            lbxMaoJogador.Items.Clear();

            lbxMaoMesa.Items.Clear();
            lbxMaoMesa.ForeColor = Color.White;

            lblMesaCartaVirada.Text = String.Empty;

            AtualizarLabelsCaixa();

            Tirar();
            TirarMesa();
            Tirar();
            TirarMesa();

            btnTirar.Enabled = true;

            btnParar.Enabled = true;
        }

        private void btnApostar10_Click(object sender, EventArgs e)
        {
            if (caixa.GetDinheiro() - 10 >= 0)
            {
                caixa.Apostar(10);
            }
            AtualizarLabelsCaixa();
        }

        private void btnApostar50_Click(object sender, EventArgs e)
        {
            if (caixa.GetDinheiro() - 50 >= 0)
            {
                caixa.Apostar(50);
            }
            AtualizarLabelsCaixa();
        }

        private void btnApostar100_Click(object sender, EventArgs e)
        {
            if (caixa.GetDinheiro() - 100 >= 0)
            {
                caixa.Apostar(100);
            }
            AtualizarLabelsCaixa();
        }

        private void AtualizarLabelsCaixa() 
        {
            lblCaixa.Text = "R$ " + caixa.GetDinheiro() + ",00";
            lblAposta.Text = "R$ " + caixa.GetAposta() + ",00";
        }

        private void Tirar()
        {
            lbxMaoJogador.Items.Add(mesa.Tirar().Descricao);            
            int p = mesa.Pontos(mesa.Jogador.Mao);
            lblPontosDoJogador.Text = p + "";
            if (p >= 21)
            {
                Parar();
            }
        }

        private void TirarMesa()
        {
            string cartaMesa = mesa.TirarMesa().Descricao;
            lblMesaCartaVirada.Text = cartaMesa;
            lbxMaoMesa.Items.Add(cartaMesa);
        }

        private void Parar()
        {
            CompletarMesa();
            int pontosDaMesa = mesa.Pontos(mesa.Parar());
            int pontosDoJogador = mesa.Pontos(mesa.Jogador.Mao);
            lblPontosDaMesa.Text = pontosDaMesa.ToString();
            lblPontosDaMesa.ForeColor = pontosDaMesa > 21 ? Color.Red : pontosDaMesa == 21 ? Color.Green : Color.Black;
            lblPontosDoJogador.ForeColor = pontosDoJogador > 21 ? Color.Red : pontosDoJogador == 21 ? Color.Green : Color.Black;
            lblPontosDoJogador.Text = pontosDoJogador.ToString();
            lbxMaoMesa.ForeColor = Color.Black;
            if (pontosDoJogador <= 21)
            {
                if (pontosDaMesa <= 21)
                {
                    if (21 - pontosDoJogador < 21 - pontosDaMesa)
                    {
                        lblPontosDoJogador.ForeColor = Color.Green;
                        caixa.GanhoAposta();
                        AtualizarLabelsCaixa();
                        MessageBox.Show("O jogador ganhou!");
                    }
                    else
                    {
                        caixa.PerdaAposta();
                        AtualizarLabelsCaixa();
                        MessageBox.Show("A mesa ganhou!");
                    }
                }
                else
                {
                    lblPontosDoJogador.ForeColor = Color.Green;
                    caixa.GanhoAposta();
                    AtualizarLabelsCaixa();
                    MessageBox.Show("O jogador ganhou!");
                }
            }
            else
            {
                caixa.PerdaAposta();
                AtualizarLabelsCaixa();
                MessageBox.Show("A mesa ganhou!");
            }
            btnNovo.Enabled = true;
            btnTirar.Enabled = false;
            btnParar.Enabled = false;
        }

        private void CompletarMesa()
        {
            int pMesa = mesa.Pontos(mesa.GetMesa);
            int pJogador = mesa.Pontos(mesa.Jogador.Mao);
            while (pMesa <= 17 && 21-pMesa > 21-pJogador)
            {
                TirarMesa();
                pMesa = mesa.Pontos(mesa.GetMesa);
            }
        }
    }
}

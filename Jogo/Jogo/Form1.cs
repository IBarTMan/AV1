using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Jogo
{
    public partial class Form1 : Form
    {
        
        int player;
        int vitoria;
        int empate;
        int derrota;
        string resultado;


        public Form1()
        {
            InitializeComponent();


        }

        private void imgPapel_Click(object sender, EventArgs e)
        {
            Random rng = new Random();
            int randomNumber = rng.Next(1, 3);

            if (randomNumber == 1)
            {
                string myString = "Vitoria \nPapel vs Pedra";
                resultado = myString;
                vitoria += 1;
                imgAI.Load("pedra.png");
                txtVitoria.Text = "Vitorias:"+vitoria;
            }
            else if (randomNumber == 2)
            {
                string myString = "Empate \nPapel vs Papel";
                resultado = myString;
                empate += 1;
                imgAI.Load("papel.png");
                txtEmpate.Text = "Empates:" + empate;
            }
            else
            {

                string myString = "Derrota \nPapel vs Tesoura";
                resultado = myString;
                derrota += 1;
                imgAI.Load("tesoura.png");
                txtDerrota.Text = "Derrotas:" + derrota;
            }
            MessageBox.Show(resultado, "Resultado");
        }

        private void imgPedra_Click(object sender, EventArgs e)
        {
            Random rng = new Random();
            int randomNumber = rng.Next(1, 3);

            if (randomNumber == 3)
            {
                string myString = "Vitoria \nPedra vs Tesoura";
                resultado = myString;
                vitoria += 1;
                imgAI.Load("tesoura.png");
                txtVitoria.Text = "Vitorias:" + vitoria;
            }
            else if (randomNumber == 1)
            {
                string myString = "Empate \nPedra vs Pedra";
                resultado = myString;
                empate += 1;
                imgAI.Load("pedra.png");
                txtEmpate.Text = "Empates:" + empate;
            }
            else
            {

                string myString = "Derrota \nPedra vs Papel";
                resultado = myString;
                derrota += 1;
                imgAI.Load("papel.png");
                txtDerrota.Text = "Derrotas:" + derrota;
            }
            MessageBox.Show(resultado, "Resultado");
        }

        private void imgTesoura_Click(object sender, EventArgs e)
        {
            Random rng = new Random();
            int randomNumber = rng.Next(1, 3);

            if (randomNumber == 2)
            {
                string myString = "Vitoria \nTesoura vs Papel";
                resultado = myString;
                vitoria += 1;
                imgAI.Load("papel.png");
                txtVitoria.Text = "Vitorias:" + vitoria;
            }
            else if (randomNumber == 2)
            {
                string myString = "Empate \nTesoura vs Tesoura";
                resultado = myString;
                empate += 1;
                imgAI.Load("tesoura.png");
                txtEmpate.Text = "Empates:" + empate;
            }
            else
            {

                string myString = "Derrota \nTesoura vs Pedra";
                resultado = myString;
                derrota += 1;
                imgAI.Load("pedra.png");
                txtDerrota.Text = "Derrotas:" + derrota;
            }
            MessageBox.Show(resultado,"Resultado");
        }

        private void imgAI_Click(object sender, EventArgs e)
        {

        }

        private void txtReset_Click(object sender, EventArgs e)
        {
            derrota = 0;
            vitoria = 0;
            empate = 0;
            txtDerrota.Text = "Derrotas:0";
            txtEmpate.Text = "Empates:0";
            txtVitoria.Text = "Vitoria:0";
        }
    }
}

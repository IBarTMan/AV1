using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace UrnaEletronica
{
    public partial class Form1 : Form
    {
        string candidato;
        string[] votoCandidato = new string[7] { "Yoda", "Fallen", "Jukes", "Brtt", "Jovirone", "Nesk", "Zirigueira" };
        int[] numCandidato = new int[7];
        int[] cand_count = new int[7];
        int nulos;
        double percent1;
        int votoTotal;
        double[] percentCand = new double[7];
        bool sair;

        public Form1()
        {
            InitializeComponent();
        }

        private void Num_Click(object sender, EventArgs e)
        {
            Button num = (Button)sender;

            if (lblNum1.Text == "")
            {
                lblNum1.Text = num.Text;
            }
            else if (lblNum2.Text == "")
            {
                lblNum2.Text = num.Text;

                candidato = lblNum1.Text + lblNum2.Text;

                switch (candidato)//cand_count
                {
                    case "13":
                        lblNome.Text = "Yoda";
                        lblPart.Text = "YODISMO";
                        imgCand.Load("yoda.jpg");
                        numCandidato[0] = 13;
                        break;
                    case "15":
                        lblNome.Text = "Fallen";
                        lblPart.Text = "MORREU";
                        imgCand.Load("fallen.jpg");
                        numCandidato[1] = 15;
                        break;
                    case "19":
                        lblNome.Text = "Jukes";
                        lblPart.Text = "MEC";
                        imgCand.Load("jukes.jpg");
                        numCandidato[2] = 19;
                        break;
                    case "51":
                        lblNome.Text = "Brtt";
                        lblPart.Text = "RX";
                        imgCand.Load("brtt.jpg");
                        numCandidato[3] = 51;
                        break;
                    case "12":
                        lblNome.Text = "jovirone";
                        lblPart.Text = "DALE DELE";
                        imgCand.Load("jovirone.jpg");
                        numCandidato[4] = 12;
                        break;
                    case "27":
                        lblNome.Text = "Nesk";
                        lblPart.Text = "R6";
                        imgCand.Load("nesk.jpg");
                        numCandidato[5] = 27;
                        break;
                    case "45":
                        lblNome.Text = "Zigueira";
                        lblPart.Text = "CAVALA";
                        imgCand.Load("zigueira.jpg");
                        numCandidato[6] = 45;
                        break;
                    default:
                        MessageBox.Show("Invalido", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        lblNum1.Text = "";
                        lblNum2.Text = "";
                        break;
                }
            }
        }

        private void btnConf_Click(object sender, EventArgs e)
        {
            if (lblNum2.Text == "")
            {
                MessageBox.Show("Candidato Inválido", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                for (int n = 0; n < 7; n++)
                {
                    if (numCandidato[n] == Convert.ToInt32(candidato))
                    {
                        cand_count[n] += 1;
                        MessageBox.Show("VOTOU!","VOTO",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                        imgCand.Load("branco.jpg");
                        break;
                    }
                }
            }

            lblNum1.Text = "";
            lblNum2.Text = "";
            lblNome.Text = "--";
            lblPart.Text = "--";
        }

        private void btnCor_Click(object sender, EventArgs e)
        {
            imgCand.Load("branco.jpg");
            lblNome.Text = "--";
            lblPart.Text = "--";
            lblNum1.Text = ""; lblNum2.Text = "";
        }

        private void btnBranco_Click(object sender, EventArgs e)
        {

            if (lblNum1.Text != "")
            {
                MessageBox.Show("Corriga seu voto", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("VOTO ANULADO", "VOTO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nulos += 1; //Para cada voto nulo, será adicinado +1 à posição 13 do Array


            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCont_Click(object sender, EventArgs e)
        {

            //contador de  votos per percent
            for(int c = 0; c <= 6; c++)
            {
                votoTotal += cand_count[c];
            }

            votoTotal += nulos;
            percent1 = votoTotal * 0.01;

            for (int c = 0; c <= 6; c++)
            {
                percentCand[c] = cand_count[c] / percent1;
                percentCand[c] = Math.Round(percentCand[c], 2);
            }

            double nulospercent = nulos / percent1;
            nulospercent = Math.Round(nulospercent, 2);
            MessageBox.Show(
    "Yoda: " + percentCand[0] + "%" + "             Votos:" + cand_count[0] +
    "\n\nFallen: " + percentCand[1] + "%" + "              Votos:" + cand_count[1] +
    "\n\nJukes: " + percentCand[2] + "%" + "               Votos:" + cand_count[2] +
    "\n\nBrtt: " + percentCand[3] + "%" + "          Votos:" + cand_count[3] +
    "\n\nJovirone: " + percentCand[4] + "%" + "           Votos:" + cand_count[4] +
    "\n\nNesk: " + percentCand[5] + "%" + "             Votos:" + cand_count[5] +
    "\n\nZigueira: " + percentCand[6] + "%" + "          Votos:" + cand_count[6] +
    "\n\nBrancos-Nulos: " + nulospercent + "%" + "                Votos:" + nulos
    , "Contagem de votos");
        }

        private void btnFim_Click(object sender, EventArgs e)
        {
            for(int c = 0; c < 7; c++)
            {
                if(percentCand[c] > 50)
                {
                    MessageBox.Show(
                        "Novo Presidente:" +
                        votoCandidato[c]+
                        "\n"+
                        percentCand[c]+
                        "%", "RESULTADO");
                }
            }
            System.Windows.Forms.Application.Exit();
        }

        private void lblStatus_Click(object sender, EventArgs e)
        {

        }
    }
}
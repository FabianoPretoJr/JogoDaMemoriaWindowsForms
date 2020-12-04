using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace JogoDaMemoria
{
    public partial class Form1 : Form
    {
        int movimentos, clicks, cartasEncontradas, tagIndex;
        Image[] img = new Image[9];
        int[] tags = new int[2];
        List<string> lista = new List<string>();
        string nome;

        public Form1()
        {
            InitializeComponent();
            Inicio();
            playMusica();
        }

        private void Inicio()
        {
            foreach(PictureBox item in Controls.OfType<PictureBox>())
            {
                tagIndex = int.Parse(string.Format("{0}", item.Tag));
                img[tagIndex] = item.Image;
                item.Image = Properties.Resources.original;
                item.Enabled = true;
            }
            Posicoes();
        }

        private void Posicoes()
        {
            foreach(PictureBox item in Controls.OfType<PictureBox>())
            {
                Random rdn = new Random();

                int[] xP = { 43, 197, 351, 505, 659, 813 };
                int[] yP = { 161, 306, 451 };

                Repete:
                var x = xP[rdn.Next(0, xP.Length)];
                var y = yP[rdn.Next(0, yP.Length)];

                string verificacao = x.ToString() + y.ToString();

                if(lista.Contains(verificacao))
                {
                    goto Repete;
                }
                else
                {
                    item.Location = new Point(x, y);
                    lista.Add(verificacao);
                }
            }
        }

        private void ImagensClick_Click(object sender, EventArgs e)
        {
            bool parEncontrado = false;

            PictureBox pic = (PictureBox)sender;
            
            clicks++;
            tagIndex = int.Parse(string.Format("{0}", pic.Tag));
            pic.Image = img[tagIndex];
            pic.Refresh();

            if(clicks == 1)
            {
                tags[0] = int.Parse(String.Format("{0}", pic.Tag));
            }
            else if(clicks == 2)
            {
                movimentos++;
                lblMovimento.Text = "Movimentos: " + movimentos.ToString();
                tags[1] = int.Parse(String.Format("{0}", pic.Tag));

                parEncontrado = ChecagemPares();
                Desvirar(parEncontrado);
            }
        }

        private bool ChecagemPares()
        {
            clicks = 0;

            if(tags[0] == tags[1])
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Form2 screenStart = new Form2();
            this.Hide();
            StopMusica();
            screenStart.ShowDialog();
        }

        private void Desvirar(bool check)
        {
            Thread.Sleep(500);

            foreach(PictureBox item in Controls.OfType<PictureBox>())
            {
                if(int.Parse(String.Format("{0}", item.Tag)) == tags[0] || int.Parse(String.Format("{0}", item.Tag)) == tags[1])
                {
                    if(check == true)
                    {
                        item.Enabled = false;
                        cartasEncontradas++;
                    }
                    else
                    {
                        item.Image = Properties.Resources.original;
                        item.Refresh();
                    }
                }
            }
            FinalJogo();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            nome = txtNome.Text;
        }

        private void FinalJogo()
        {
            if(cartasEncontradas == img.Length*2)
            {
                Placar p = new Placar();
                PlacarDAL pDAL = new PlacarDAL();

                p.Nome = txtNome.Text;
                p.Score = movimentos;

                pDAL.Cadastrar(p);

                StopMusica();
                MessageBox.Show("parabéns, você terminou o jogo com " + movimentos.ToString() + " movimentos");
                DialogResult msg = MessageBox.Show("Deseja continuar o jogo?", "Caixa de perguntas", MessageBoxButtons.YesNo);

                if(msg == DialogResult.Yes)
                {
                    lblMovimento.Text = "Movimentos: ";
                    clicks = 0;
                    movimentos = 0;
                    cartasEncontradas = 0;
                    lista.Clear();
                    Inicio();
                    playMusica();
                }
                else
                {
                    MessageBox.Show("Obrigado por jogar!");
                    Application.Exit();
                }
            }
        }

        private void playMusica()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\Fabiano\Desktop\Aulas EAD Fatec\Fatec São Paulo\2º Semestre\Eletiva I - Linguagem de Programação VIII\Projetos\JogoDaMemoria\JogoDaMemoria\audios\musica.wav");
            simpleSound.Play();
        }

        private void StopMusica()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\Fabiano\Desktop\Aulas EAD Fatec\Fatec São Paulo\2º Semestre\Eletiva I - Linguagem de Programação VIII\Projetos\JogoDaMemoria\JogoDaMemoria\audios\musica.wav");
            simpleSound.Stop();
        }
    }
}

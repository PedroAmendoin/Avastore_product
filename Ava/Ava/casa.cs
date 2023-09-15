using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Speech.Recognition;
using System.Speech.Synthesis;
using System.Globalization;
using System.Diagnostics;
using System.Net.WebSockets;

namespace Ava
{

    public partial class casa : Form
    {
        static CultureInfo co = new CultureInfo("pt-BR");//definindo o idioma
        static SpeechRecognitionEngine reconhecedor2;
        SpeechSynthesizer resposta2 = new SpeechSynthesizer();

        public string[] listaPalavras2 = { "olá", "boa noite eiva", "tudo bem?", "estou bem", "eiva?","ascender luz do quarto","apagar luz do quarto", "ascender luz da cozinha","apagar luz da cozinha", "ascender luz da sala","apagar luz da sala", "ascender luz do banheiro","apagar luz do banheiro", "pesquisa", "obrigado" };

        public casa()
        {
            InitializeComponent();
            init();
        }

        public void Gramatica2()
        {
            try
            {
                reconhecedor2 = new SpeechRecognitionEngine(co);//criando o motor de reconhecimento e inserindo o idioma
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            var gramatica = new Choices();
            gramatica.Add(listaPalavras2);

            var gb = new GrammarBuilder();
            gb.Append(gramatica);

            try
            {
                var g = new Grammar(gb);

                try
                {
                    reconhecedor2.RequestRecognizerUpdate();
                    reconhecedor2.LoadGrammarAsync(g);
                    reconhecedor2.SpeechRecognized += Sre_Reconhecimento;
                    reconhecedor2.SetInputToDefaultAudioDevice();
                    resposta2.SetOutputToDefaultAudioDevice();
                    reconhecedor2.RecognizeAsync(RecognizeMode.Multiple);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("erro ao criar reconhecedor: " + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("erro ao criar a gramática" + ex.Message);
            }

        }

        public void init()
        {
            resposta2.Volume = 100;
            resposta2.Rate = 2;

            Gramatica2();
        }

        void Sre_Reconhecimento(object sender, SpeechRecognizedEventArgs e)
        {

            string frase = e.Result.Text;

            if (frase.Equals("olá"))
            {
                resposta2.SpeakAsync("olá usuário, como posso ajudar?");
            }

            else if (frase.Equals("boa noite eiva"))
            {
                resposta2.SpeakAsync("boa noite");
            }

            else if (frase.Equals("tudo bem?"))
            {
                resposta2.SpeakAsync("Tudo perfeito, e contigo?");
            }

            else if (frase.Equals("estou bem"))
            {
                resposta2.SpeakAsync("bom saber!");
            }



            else if (frase.Equals("eiva?"))
            {
                mic.Focus();
                resposta2.SpeakAsync("sim?");

                mic.BackColor = Color.Purple;
                mic.ForeColor = Color.White;

            }


            else if (mic.Focus() == true && !frase.Equals("pesquisa"))
            {



                if (frase.Equals("ascender luz do quarto"))
                {
                    quarto.BackColor = Color.Yellow;
                }
                else if(frase.Equals("apagar luz do quarto"))
                {
                    quarto.BackColor = Color.Gray;
                }

                else if (frase.Equals("ascender luz da cozinha"))
                {
                    cozinha.BackColor = Color.Yellow;
                }
                else if (frase.Equals("apagar luz da cozinha"))
                {
                    cozinha.BackColor = Color.Gray;
                }

                else if (frase.Equals("ascender luz da sala"))
                {
                    sala.BackColor = Color.Yellow;
                }
                else if (frase.Equals("apagar luz da sala"))
                {
                    sala.BackColor = Color.Gray;
                }

                else if (frase.Equals("ascender luz do banheiro"))
                {
                    banheiro.BackColor = Color.Yellow;
                }
                else if (frase.Equals("apagar luz do banheiro"))
                {
                    banheiro.BackColor = Color.Gray;
                }

                mic.BackColor = Color.White;
                mic.ForeColor = Color.Black;


            }

            else if (frase.Equals("pesquisa"))
            {
                Form1 goform1 = new Form1();
                goform1.ShowDialog();
                this.Close();
               
            }

            else if (frase.Equals("obrigado") && mic.Focus()!=true)
            {
                resposta2.SpeakAsync("disponha");
            }


        }

        private void cômodo_Load_1(object sender, EventArgs e)
        {

        }

        private void mic_Click(object sender, EventArgs e)
        {

        }

        private void quarto_Click(object sender, EventArgs e)
        {

        }

        private void cozinha_Click(object sender, EventArgs e)
        {

        }

        private void sala_Click(object sender, EventArgs e)
        {

        }

        private void banheiro_Click(object sender, EventArgs e)
        {

        }

        private void cômodo_Load(object sender, EventArgs e)
        {

        }
    }
}

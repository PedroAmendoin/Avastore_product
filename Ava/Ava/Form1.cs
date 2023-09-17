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

    public partial class Form1 : Form
    {
        static CultureInfo ci = new CultureInfo("pt-BR");//definindo o idioma
        static SpeechRecognitionEngine reconhecedor;
        SpeechSynthesizer resposta = new SpeechSynthesizer();
       
        public string[] listaPalavras = { "olá", "qual é o seu nome", "boa noite eiva", "tudo bem?", "estou bem", "eiva?", "calendário", "previsão do tempo", "jogos", "cachorro", "gugou", "iutube","minha casa", "obrigado" };
       
        public Form1()
        {
            InitializeComponent();
            init();
        }

        public void Gramatica()
        {
            try
            {
                reconhecedor = new SpeechRecognitionEngine(ci);//criando o motor de reconhecimento e inserindo o idioma
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            var gramatica = new Choices();
            gramatica.Add(listaPalavras);

            var gb = new GrammarBuilder();
            gb.Append(gramatica);

            try
            {
                var g = new Grammar(gb);

                try
                {
                    reconhecedor.RequestRecognizerUpdate();
                    reconhecedor.LoadGrammarAsync(g);
                    reconhecedor.SpeechRecognized += Sre_Reconhecimento;
                    reconhecedor.SetInputToDefaultAudioDevice();
                    resposta.SetOutputToDefaultAudioDevice();
                    reconhecedor.RecognizeAsync(RecognizeMode.Multiple);
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
            resposta.Volume = 100;
            resposta.Rate = 2;

            Gramatica();
        }

        void Sre_Reconhecimento(object sender, SpeechRecognizedEventArgs e)
        {

            string frase = e.Result.Text;

            if (frase.Equals("olá"))
            {
                resposta.SpeakAsync("olá usuário, como posso ajudar?");
            }

            else if (frase.Equals("obrigado"))
            {
                resposta.SpeakAsync("disponha");
            }

            else if (frase.Equals("qual é o seu nome"))
            {
                resposta.SpeakAsync("meu nome é eiva");
            }


            else if (frase.Equals("boa noite eiva"))
            {
                resposta.SpeakAsync("boa noite");
            }

            else if (frase.Equals("tudo bem?"))
            {
                resposta.SpeakAsync("Tudo perfeito, e contigo?");
            }

            else if (frase.Equals("estou bem"))
            {
                resposta.SpeakAsync("bom saber!");
            }

            else if (frase.Equals("gugou"))
            {

                string target = "https://www.google.com.br/";
                System.Diagnostics.Process.Start(target);

            }

            else if (frase.Equals("iutube"))
            {
                string target = "http://www.youtube.com";
                System.Diagnostics.Process.Start(target);
            }



            else if (frase.Equals("eiva?"))
            {
                mic.Focus();
                resposta.SpeakAsync("sim?");
                mic.BackColor = Color.Purple;
                mic.ForeColor = Color.White;
            }


            else if (mic.Focus() == true && !frase.Equals("minha casa"))
            {



                if (frase.Equals("calendário"))
                {
                    frase = "calendário do ano";
                }
                else if (frase.Equals("previsão do tempo"))
                {

                }
                else if (frase.Equals("jogos"))
                {
                    frase = "jogos da steam";
                }
                else if (frase.Equals("cachorro"))
                {

                }


                mic.BackColor = Color.White;
                mic.ForeColor = Color.Black;

                resposta.SpeakAsync("pesquisando");
                string target = "https://www.google.com/search?q=" + e.Result.Text;
                System.Diagnostics.Process.Start(target);



            }

            else if (frase.Equals("minha casa"))
            {
               
                    casa gocomodo = new casa();
                    gocomodo.ShowDialog();
                this.Hide();
                    
                

            }


           


        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
         
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void mic_Click(object sender, EventArgs e)
        {

        }
    }
}

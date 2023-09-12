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
using System.IO;
using System.Security.Policy;
using System.Speech.Synthesis.TtsEngine;

namespace Ava
{

    public partial class Form1 : Form
    {
        static CultureInfo ci = new CultureInfo("pt-BR");//definindo o idioma
        static SpeechRecognitionEngine reconhecedor;
        SpeechSynthesizer resposta = new SpeechSynthesizer();

        public string[] listaPalavras = { "olá", "qual é o seu nome", "boa noite eiva", "tudo bem?", "estou bem", "eiva?", "em qual mês estamos?", "gugou", "que tal, livros", "edgar alan pou", "iutube", "que tal uma música", "sódus", "obrigado" };
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


            else if (frase.Equals("eiva?"))
            {
                resposta.SpeakAsync("Sim?");
            }


            else if (frase.Equals("em qual mês estamos?"))
            {
                resposta.SpeakAsync("estamos no mês de setembro");
            }


            else if (frase.Equals("gugou"))
            {
                string target = "http://www.google.com";
                System.Diagnostics.Process.Start(target);

            }

            else if (frase.Equals("que tal, livros"))
            {
                resposta.SpeakAsync("qual autor?");
                
            }

            else if (frase.Equals("edgar alan pou"))
            {
                string target = "https://elivros.love/autor/Edgar-Allan-Poe";
                System.Diagnostics.Process.Start(target);
            }

            
            else if (frase.Equals("iutube"))
            {
                string target2 = "https://www.youtube.com/";
                System.Diagnostics.Process.Start(target2);
            }

            else if (frase.Equals("que tal uma música"))
            {
                resposta.SpeakAsync("diga o nome");
            }


            else if (frase.Equals("sódus"))
            {
                
                string target3 = "https://youtu.be/gR3Osz_5r14?si=J4EfjUU0TS7cuv63";
                System.Diagnostics.Process.Start(target3);

            }
     

            else if (frase.Equals("obrigado"))
            {
                resposta.SpeakAsync("disponha");
            }
            
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }


    }
}

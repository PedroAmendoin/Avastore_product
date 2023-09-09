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

namespace Ava
{
    public partial class Form1 : Form
    {
        static CultureInfo ci = new CultureInfo("pt-BR");//definindo o idioma
        static SpeechRecognitionEngine reconhecedor;
        SpeechSynthesizer resposta = new SpeechSynthesizer();

        public string[] listaPalavras = { "olá", "qual é o seu nome", "em qual mês estamos?" };
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
            resposta.Rate = 3;

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
            else if (frase.Equals("em qual mês estamos?"))
            {
                resposta.SpeakAsync("estamos no mês de setembro");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Speech.Recognition;
using System.Speech.Synthesis;


namespace Ava
{
    public partial class Cam_1 : Form
    {

        static CultureInfo ce = new CultureInfo("pt-BR");//definindo o idioma
        static SpeechRecognitionEngine reconhecedor3;
        SpeechSynthesizer resposta3 = new SpeechSynthesizer();

        public string[] listaPalavras3 = { "voltar" };

        public Cam_1()
        {
            InitializeComponent();
            init();
        }



        public void Gramatica3()
        {
            try
            {
                reconhecedor3 = new SpeechRecognitionEngine(ce);//criando o motor de reconhecimento e inserindo o idioma
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            var gramatica = new Choices();
            gramatica.Add(listaPalavras3);

            var gb = new GrammarBuilder();
            gb.Append(gramatica);

            try
            {
                var g = new Grammar(gb);

                try
                {
                    reconhecedor3.RequestRecognizerUpdate();
                    reconhecedor3.LoadGrammarAsync(g);
                    reconhecedor3.SpeechRecognized += Sre_Reconhecimento;
                    reconhecedor3.SetInputToDefaultAudioDevice();
                    resposta3.SetOutputToDefaultAudioDevice();
                    reconhecedor3.RecognizeAsync(RecognizeMode.Multiple);
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
            resposta3.Volume = 100;
            resposta3.Rate = 2;

            Gramatica3();
        }

        void Sre_Reconhecimento(object sender, SpeechRecognizedEventArgs e)
        {

            string frase = e.Result.Text;


                if (frase.Equals("eiva?"))
            {

                resposta3.SpeakAsync("sim?");

            }



            else if (frase.Equals("voltar"))
            {

                this.Close();

            }



            else if (frase.Equals("obrigado"))
            {
                resposta3.SpeakAsync("disponha");
            }


        }
    


        private void Cam_1_Load(object sender, EventArgs e)
        {
            clock_Click(this, new EventArgs());
        }



        private void clock_Click(object sender, EventArgs e)
        {
            DateTime localDate = DateTime.Now;
            String[] cultureNames = { "pt-BR" };

            foreach (var cultureName in cultureNames)
            {
                var culture = new CultureInfo(cultureName);
                Console.WriteLine("{0}: {1}", cultureName,
                localDate.ToString(culture));
                
            }

            clock.Text = localDate.ToString();
        }

        private void cam_img_Click(object sender, EventArgs e)
        {
            
        }

     
    }
}

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
using Org.BouncyCastle.Tls.Crypto;

namespace Ava
{

    public partial class casa : Form
    {
        string tempQ = "22°C";
        string tempC = "22°C";
        string tempS = "22°C";
        string tempB = "22°C";

        

        static CultureInfo co = new CultureInfo("pt-BR");//definindo o idioma
        static SpeechRecognitionEngine reconhecedor2;
        SpeechSynthesizer resposta2 = new SpeechSynthesizer();

        public string[] listaPalavras2 = { "eiva?","acender luz do quarto","apagar luz do quarto","temperatura do quarto","fechar temperatura do quarto", "acender luz da cozinha","apagar luz da cozinha","temperatura da cozinha","fechar temperatura da cozinha", "acender luz da sala","apagar luz da sala","temperatura da sala","fechar temperatura da sala", "acender luz do banheiro","apagar luz do banheiro","temperatura do banheiro","fechar temperatura do banheiro", "mídias","câmera", "obrigado" };

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

            if (frase.Length.Equals(null) == false)
            {
                MyAsyncMethod();

            }


            async Task MyAsyncMethod()
            {
                mic.BackColor = Color.Purple;
                mic.ForeColor = Color.White;

                await Task.Delay(5000);

                mic.BackColor = Color.White;
                mic.ForeColor = Color.Black;
            }


            while (this.Visible == true)//se estiver invisivel não receberá comandos
            {



                if (frase.Equals("eiva?"))
                {
                    mic.Focus();
                    resposta2.SpeakAsync("sim?");

                    mic.BackColor = Color.Purple;
                    mic.ForeColor = Color.White;

                }


                //quarto;
                if (frase.Equals("acender luz do quarto"))
                {
                    quarto.BackColor = Color.Yellow;
                }
                else if (frase.Equals("apagar luz do quarto"))
                {
                    quarto.BackColor = Color.Gainsboro;
                }


                else if (frase.Equals("temperatura do quarto"))
                {
                    temp_quarto.Text = tempQ;
                    temp_quarto.Show();
                }
                else if (frase.Equals("fechar temperatura do quarto"))
                {
                    temp_quarto.Hide();
                }


                //cozinha;

                else if (frase.Equals("acender luz da cozinha"))
                {
                    cozinha.BackColor = Color.Yellow;
                }
                else if (frase.Equals("apagar luz da cozinha"))
                {
                    cozinha.BackColor = Color.Gainsboro;
                }


                else if (frase.Equals("temperatura da cozinha"))
                {
                    temp_cozinha.Text = tempC;
                    temp_cozinha.Show();
                }
                else if (frase.Equals("fechar temperatura da cozinha"))
                {
                    temp_cozinha.Hide();
                }


                //sala;


                else if (frase.Equals("acender luz da sala"))
                {
                    sala.BackColor = Color.Yellow;

                }
                else if (frase.Equals("apagar luz da sala"))
                {
                    sala.BackColor = Color.Gainsboro;

                }


                else if (frase.Equals("temperatura da sala"))
                {
                    temp_sala.Text = tempS;
                    temp_sala.Show();
                }
                else if (frase.Equals("fechar temperatura da sala"))
                {
                    temp_sala.Hide();
                }


                //banheiro;

                else if (frase.Equals("acender luz do banheiro"))
                {
                    banheiro.BackColor = Color.Yellow;
                }
                else if (frase.Equals("apagar luz do banheiro"))
                {
                    banheiro.BackColor = Color.Gainsboro;
                }


                else if (frase.Equals("temperatura do banheiro"))
                {
                    temp_banheiro.Text = tempB;
                    temp_banheiro.Show();
                }
                else if (frase.Equals("fechar temperatura do banheiro"))
                {
                    temp_banheiro.Hide();
                }



                else if (frase.Equals("mídias"))
                {
        
                    this.Visible = false;

                }


                else if (frase.Equals("câmera"))
                {

                    if (Application.OpenForms.OfType<Cam_1>().Count() > 0)//se a quantidade desse forms for maior que zero
                    {
                        this.Visible = false;
                        Application.OpenForms["Cam_1"].BringToFront();
                        this.Visible = true;
                    }
                    else //senao
                    {
                        this.Visible = false;
                        Cam_1 gocam = new Cam_1();
                        gocam.ShowDialog();
                        this.Visible = true;
                    }




                }

                else if (frase.Equals("obrigado"))
                {
                    resposta2.SpeakAsync("disponha");
                }

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


        //temperatura dos cômodos:

        private void temp_quarto_Click(object sender, EventArgs e)
        {
            
        }

        private void temp_cozinha_Click(object sender, EventArgs e)
        {
            
        }

        private void temp_sala_Click(object sender, EventArgs e)
        {

        }

        private void temp_banheiro_Click(object sender, EventArgs e)
        {

        }

        private void cam_se_Click(object sender, EventArgs e)
        {

        }

        private void ajuda_Click(object sender, EventArgs e)
        {
            descricao.Visible = true;
            comandos.Visible = true;
            fechar_itns.Visible = true;
        }

        private void descricao_Click(object sender, EventArgs e)
        {

        }

        private void comandos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void menu_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void fechar_itns_Click(object sender, EventArgs e)
        {
            descricao.Visible = false;
            comandos.Visible = false;
            fechar_itns.Visible = false;
        }
    }
}

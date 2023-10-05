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
using System.Threading;
using Controller;
using Modelo;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto;
using System.IO.Ports; // necessário para ter acesso as portas 

namespace Ava
{

   
    public partial class menu : Form
    {
        

        private void atualizaListaCOMs()
        {
            int i;
            bool quantDiferente;    //flag para sinalizar que a quantidade de portas mudou

            i = 0;
            quantDiferente = false;

            //se a quantidade de portas mudou
            if (comboBox1.Items.Count == SerialPort.GetPortNames().Length)
            {
                foreach (string s in SerialPort.GetPortNames())
                {
                    if (comboBox1.Items[i++].Equals(s) == false)
                    {
                        quantDiferente = true;
                    }
                }
            }
            else
            {
                quantDiferente = true;
            }

            //Se não foi detectado diferença
            if (quantDiferente == false)
            {
                return;                     //retorna
            }

            //limpa comboBox
            comboBox1.Items.Clear();

            //adiciona todas as COM diponíveis na lista
            foreach (string s in SerialPort.GetPortNames())
            {
                comboBox1.Items.Add(s);
            }
            //seleciona a primeira posição da lista
            comboBox1.SelectedIndex = 0;
        }
        private void timerCOM_Tick(object sender, EventArgs e)
        {
            atualizaListaCOMs();
        }

        private void btConectar_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen == false)
            {
                try
                {
                    serialPort.PortName = comboBox1.Items[comboBox1.SelectedIndex].ToString();
                    serialPort.Open();

                }
                catch
                {
                    return;

                }
                if (serialPort.IsOpen)
                {
                    btConectar.Text = "Desconectar";
                    comboBox1.Enabled = false;

                }
            }
            else
            {

                try
                {
                    serialPort.Close();
                    comboBox1.Enabled = true;
                    btConectar.Text = "Conectar";
                }
                catch
                {
                    return;
                }
            }
        }

        private void menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (serialPort.IsOpen == true)  // se porta aberta
                serialPort.Close();            //fecha a porta
        }//fim da parte do arduino;


        //início do reconhecimento de voz;
        static CultureInfo ci = new CultureInfo("pt-BR");//definindo o idioma
        static SpeechRecognitionEngine reconhecedor;
        SpeechSynthesizer resposta = new SpeechSynthesizer();
       
        public string[] listaPalavras = { "olá", "qual é o seu nome", "boa noite eiva", "tudo bem?", "estou bem", "eiva?", "gugou", "iutube","minha casa","loguin", "obrigado" };
       LoginModelo logmodelo = new LoginModelo();
        public menu(LoginModelo usuario)
        {
            logmodelo = usuario;
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

            if (frase.Length.Equals(null)== false)
            {
                MyAsyncMethod();
               
            }
           

             async Task MyAsyncMethod()
                {
                     mic.BackColor = Color.Purple;
                mic.ForeColor = Color.White;
                mic.Text = "ouvindo";

                await Task.Delay(5000);

                mic.BackColor = Color.White;
                mic.ForeColor = Color.Black;
                mic.Text = "mic";
                }
              
            if (frase.Equals("olá"))
            {
                 
                 resposta.SpeakAsync("olá "+logmodelo.apelido +", como posso ajudar");
                string c = "b";
                if (serialPort.IsOpen == true)//porta está aberta
                    serialPort.Write(c);//envia variável

            }

            else if (frase.Equals("obrigado"))
            {
                resposta.SpeakAsync("disponha");
            }

            else if (frase.Equals("qual é o seu nome"))
            {
                resposta.SpeakAsync("meu nome é eiva");
            }


            else if (frase.Equals("boa noite"))
            {
                resposta.SpeakAsync("boa noite");
            }

            else if (frase.Equals("tudo bem?"))
            {
                resposta.SpeakAsync("funcionando");
            }

            else if (frase.Equals("estou bem"))
            {
                resposta.SpeakAsync("bom saber!");
            }

            else if (frase.Equals("gugou"))
            {

                resposta.SpeakAsync("abrindo gugou");
                string target = "https://www.google.com.br/";
                System.Diagnostics.Process.Start(target);

            }

            else if (frase.Equals("iutube"))
            {
                resposta.SpeakAsync("abrindo iutube");
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

            else if (frase.Equals("minha casa"))
            {
                resposta.SpeakAsync("abrindo sistema");
                this.Visible = false;
                casa gocomodo = new casa();
                gocomodo.ShowDialog();
                this.Visible = true;
                

            }

            else if (frase.Equals("loguin"))
            {
                this.Close();

            }


        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
           

                apelido.Text = logmodelo.apelido;//esvaziando textbox do usuario
                timerCOM.Enabled = true;


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

        private void apelido_Click(object sender, EventArgs e)
        {

        }

        private void perfil_Click(object sender, EventArgs e)
        {
            apelido.Visible = true;
        }

        private void perfil_MouseLeave(object sender, EventArgs e)
        {
            apelido.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void textBoxEnviar_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxReceber_TextChanged(object sender, EventArgs e)
        {

        }


    }
}

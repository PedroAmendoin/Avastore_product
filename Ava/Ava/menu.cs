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
using System.Diagnostics.Eventing.Reader;
using Google.Protobuf.WellKnownTypes;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace Ava
{


    public partial class menu : Form
    {

        int pergN = 0;//conta o número de vezes que pergunto o nome da Eiva

       //inicia parte do arduino
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

        public string[] listaPalavras = { "olá", "qual é o seu nome?", "boa noite eiva", "tudo bem?", "expandir", "mais", "menu", "minimizar", "eiva?", "data", "tuít", "feicebuk", "wótizapi", "ispótifai", "crânti", "yutube", "netflix", "instagram", "gugol", "minha casa", "loguin", "obrigado" };
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

            if (frase.Length.Equals(null) == false)
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


            if (this.Visible == true)
            {

                if (frase.Equals("olá"))
                {
                    if (logmodelo.apelido != null)
                    {
                        resposta.SpeakAsync("olá " + logmodelo.apelido + ", como posso ajudar");
                        string c = "b";
                        if (serialPort.IsOpen == true)//porta está aberta
                            serialPort.Write(c);//envia variável
                    }
                }

                else if (frase.Equals("obrigado"))
                {
                    resposta.SpeakAsync("disponha");
                    string c = "b";
                    if (serialPort.IsOpen == true)//porta está aberta
                        serialPort.Write(c);//envia variável
                }

                else if (frase.Equals("qual é o seu nome?"))
                {
                    pergN = pergN + 1;

                    if (pergN == 1)
                    {
                        resposta.SpeakAsync("meu nome é eiva");
                    }
                    else if (pergN == 2)
                    {
                        resposta.SpeakAsync("última vez que eu digo, meu nome é eiva");
                    }
                    else if (pergN > 2)
                    {
                        resposta.SpeakAsync("você já sabe");
                    }

                    string c = "b";
                    if (serialPort.IsOpen == true)//porta está aberta
                        serialPort.Write(c);//envia variável
                }


                else if (frase.Equals("boa noite eiva"))
                {
                    resposta.SpeakAsync("boa noite");
                    string c = "b";
                    if (serialPort.IsOpen == true)//porta está aberta
                        serialPort.Write(c);//envia variável

                }

                else if (frase.Equals("tudo bem?"))
                {
                    resposta.SpeakAsync("tudo bem");
                    string c = "b";
                    if (serialPort.IsOpen == true)//porta está aberta
                        serialPort.Write(c);//envia variável
                }


                else if (frase.Equals("expandir") || frase.Equals("mais") || frase.Equals("menu"))
                {
                    mostrar();
                }

                else if (frase.Equals("minimizar"))
                {
                    fechar();
                }

                else if (frase.Equals("data"))
                {
                    DateTime localDate = DateTime.Now;
                    String[] cultureNames = { "pt-BR" };


                    new DateTime(2017, 12, 1).ToString(@"d \de MMM \de yyyy", new CultureInfo("PT-pt"));
                    string tm = DateTime.Now.ToString(@"d \de MMM \de yyyy");
                    resposta.SpeakAsync("a data de hoje é");
                    resposta.SpeakAsync(tm);



                }





                else if (frase.Equals("tuít"))
                {

                    resposta.SpeakAsync("abrindo tuít");
                    string c = "b";
                    if (serialPort.IsOpen == true)//porta está aberta
                        serialPort.Write(c);//envia variável
                    string target = "https://www.twitch.tv/";
                    System.Diagnostics.Process.Start(target);

                }

                else if (frase.Equals("feicebuk"))
                {

                    resposta.SpeakAsync("abrindo feicebuk");
                    string c = "b";
                    if (serialPort.IsOpen == true)//porta está aberta
                        serialPort.Write(c);//envia variável
                    string target = "https://www.facebook.com/?locale=pt_BR";
                    System.Diagnostics.Process.Start(target);

                }



                else if (frase.Equals("wótizapi"))
                {

                    resposta.SpeakAsync("abrindo uótizapi");
                    string c = "b";
                    if (serialPort.IsOpen == true)//porta está aberta
                        serialPort.Write(c);//envia variável
                    string target = "https://web.whatsapp.com/";
                    System.Diagnostics.Process.Start(target);

                }

                else if (frase.Equals("crânti"))
                {

                    resposta.SpeakAsync("abrindo crânti");
                    string c = "b";
                    if (serialPort.IsOpen == true)//porta está aberta
                        serialPort.Write(c);//envia variável
                    string target = "https://www.crunchyroll.com/pt-br/";
                    System.Diagnostics.Process.Start(target);
                }

                else if (frase.Equals("ispótifai"))
                {

                    resposta.SpeakAsync("abrindo ispótifai");
                    string c = "b";
                    if (serialPort.IsOpen == true)//porta está aberta
                        serialPort.Write(c);//envia variável
                    string target = "https://open.spotify.com/intl-pt";
                    System.Diagnostics.Process.Start(target);

                }



                else if (frase.Equals("yutube"))
                {

                    resposta.SpeakAsync("abrindo yutube");
                    string c = "b";
                    if (serialPort.IsOpen == true)//porta está aberta
                        serialPort.Write(c);//envia variável
                    string target = "https://www.youtube.com/";
                    System.Diagnostics.Process.Start(target);

                }


                else if (frase.Equals("netflix"))
                {

                    resposta.SpeakAsync("abrindo netflix");
                    string c = "b";
                    if (serialPort.IsOpen == true)//porta está aberta
                        serialPort.Write(c);//envia variável
                    string target = "https://www.netflix.com/br/";
                    System.Diagnostics.Process.Start(target);

                }
                else if (frase.Equals("gugol"))
                {

                    resposta.SpeakAsync("abrindo gugol");
                    string c = "b";
                    if (serialPort.IsOpen == true)//porta está aberta
                        serialPort.Write(c);//envia variável
                    string target = "https://www.google.com.br/";
                    System.Diagnostics.Process.Start(target);

                }

                else if (frase.Equals("instagram"))
                {
                    resposta.SpeakAsync("abrindo instagram");

                    string c = "b";
                    if (serialPort.IsOpen == true)//porta está aberta
                        serialPort.Write(c);//envia variável
                    string target = "https://www.instagram.com/";
                    System.Diagnostics.Process.Start(target);
                }



                else if (frase.Equals("eiva?"))
                {
                    mic.Focus();
                    resposta.SpeakAsync("sim?");
                    string c = "b";
                    if (serialPort.IsOpen == true)//porta está aberta
                        serialPort.Write(c);//envia variável
                }

                else if (frase.Equals("minha casa"))
                {
                    if (Application.OpenForms.OfType<casa>().Count() > 0)//se a quantidade desse forms for maior que zero
                    {
                        this.Visible = false;
                        Application.OpenForms["casa"].BringToFront();
                        this.Visible = true;
                    }
                    else //senao
                    {

                        resposta.SpeakAsync("abrindo sistema");
                        string c = "b";
                        if (serialPort.IsOpen == true)//porta está aberta
                            serialPort.Write(c);//envia variável


                        this.Visible = false;
                        casa gocomodo = new casa();
                        gocomodo.ShowDialog();
                        this.Visible = true;
                        frase = null;
                        fechar();

                    }



                }

                else if (frase.Equals("loguin"))
                {
                    string c = "b";
                    if (serialPort.IsOpen == true)
                        serialPort.Write(c);
                    logmodelo.apelido = "";
                    this.Close();

                }
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

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void btConectar_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btConectar, "escolha a entrada do arduino");
        }

        private void twitch_Click(object sender, EventArgs e)
        {
            string target = "https://www.twitch.tv/";
            System.Diagnostics.Process.Start(target);
        }

        private void facebook_Click(object sender, EventArgs e)
        {
            string target = "https://www.facebook.com/?locale=pt_BR";
            System.Diagnostics.Process.Start(target);
        }

        private void whatsapp_Click(object sender, EventArgs e)
        {
            string target = "https://web.whatsapp.com/";
            System.Diagnostics.Process.Start(target);
        }

        private void spotfy_Click(object sender, EventArgs e)
        {
            string target = "https://open.spotify.com/intl-pt";
            System.Diagnostics.Process.Start(target);
        }

        private void crunchyroll_Click(object sender, EventArgs e)
        {
            string target = "https://www.crunchyroll.com/pt-br/";
            System.Diagnostics.Process.Start(target);
        }

        private void youtube_Click(object sender, EventArgs e)
        {
            string target = "https://www.youtube.com/";
            System.Diagnostics.Process.Start(target);
        }

        private void netflix_Click(object sender, EventArgs e)
        {
            string target = "https://www.netflix.com/br/";
            System.Diagnostics.Process.Start(target);
        }

        private void instagram_Click(object sender, EventArgs e)
        {
            string target = "https://www.instagram.com/";
            System.Diagnostics.Process.Start(target);
        }

        private void google_Click(object sender, EventArgs e)
        {
            string target = "https://www.google.com.br/?hl=pt-BR";
            System.Diagnostics.Process.Start(target);
        }

        public void mostrar()
        {
            AVA_interactsd.Visible = true;
            AVA_interact.Visible = false;
            twitch.Visible = true;
            facebook.Visible = true;
            whatsapp.Visible = true;
            spotfy.Visible = true;
            crunchyroll.Visible = true;
            youtube.Visible = true;
            netflix.Visible = true;
            instagram.Visible = true;
            fechar_itns.Visible = true;



            if (google.Visible == true)
            {
                google.Visible = false;
            }
        }


        private void pesquisar_Click(object sender, EventArgs e)
        {
            mostrar();
        }

           


        private void pesquisar_MouseHover(object sender, EventArgs e)
        {
            google.Visible = true;

        }


        private void google_MouseHover(object sender, EventArgs e)
        {
            google.Visible = true;

        }

        private void google_MouseLeave(object sender, EventArgs e)
        {
            google.Visible = false;
        }

        private void AVA_Click(object sender, EventArgs e)
        {
            
        }

        private void AVA_interact_Click_1(object sender, EventArgs e)
        {

        }

        private void AVA_interact_Click(object sender, EventArgs e)
        {

        }

        private void AVA_interactsd_Click(object sender, EventArgs e)
        {

        }

        private void fechar_itns_Click(object sender, EventArgs e)
        {
            fechar();
        }

    
        public void fechar() { 
        

            AVA_interactsd.Visible = false;
            AVA_interact.Visible = true;
            twitch.Visible = false;
            facebook.Visible = false;
            whatsapp.Visible = false;
            spotfy.Visible = false;
            crunchyroll.Visible = false;
            youtube.Visible = false;
            netflix.Visible = false;
            instagram.Visible = false;
            fechar_itns.Visible = false;
        }
   

        private void button1_Click(object sender, EventArgs e)
        {

        }


        private void guia_olhar_Click(object sender, EventArgs e)
        {

        }

        

        private void AVA_interact_MouseHover(object sender, EventArgs e)
        {
            toolTip2.SetToolTip(AVA_interact, "clique no '+' para acessar opções \n ou \n diga uma das palavras a seguir 'expandir/mais/menu'");
        }

        private void toolTip2_Popup(object sender, PopupEventArgs e)
        {

        }
        
        private void toolTip3_Popup(object sender, PopupEventArgs e)
        {

        }

        private void acessar_casa_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            casa gocomodo = new casa();
            gocomodo.ShowDialog();
            this.Visible = true;
        }

        private void acessar_casa_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(acessar_casa, "clique para acessar casa \n ou \n diga 'minha casa'");
        }

        private void login_Click(object sender, EventArgs e)
        {

            logmodelo.apelido = null;
            this.Close();
        }

        private void login_MouseHover(object sender, EventArgs e)
        {
            toolTip3.SetToolTip(login, "clique para voltar ao login \n ou \n diga 'login'");
        }

        private void foco_olhar_Click(object sender, EventArgs e)
        {

        }

        private void foco_olhar_MouseHover(object sender, EventArgs e)
        {
            AVA_interactsd.Visible = true;
            AVA_interact.Visible = false;
        }

        private void foco_olhar_MouseLeave(object sender, EventArgs e)
        {
            if (twitch.Visible == false)
            {
            AVA_interactsd.Visible = false;
            AVA_interact.Visible = true;
            }
            
        }

        private void fechar_itns_MouseHover(object sender, EventArgs e)
        {
            toolTip4.SetToolTip(fechar_itns, "clique para fechar leque \n ou \n diga 'minimizar'");
        }

        private void toolTip4_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}

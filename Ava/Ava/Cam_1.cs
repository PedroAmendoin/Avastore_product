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

namespace Ava
{
    public partial class Cam_1 : Form
    {
        public Cam_1()
        {
            InitializeComponent();


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

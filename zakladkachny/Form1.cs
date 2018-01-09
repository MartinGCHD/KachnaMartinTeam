using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zakladkachny
{
    public partial class Form1 : Form
    {

        Button prvni;
        Random nahoda = new Random();
        List<Button> kachny = new List<Button>();
        List<Button> kLikvidaci = new List<Button>();

        int zivoty = 101;

        int skore = 0;

        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < 10; i++)
            {
                vytvorKachnu();
            }
            
          
            //prvni = new Button();
            //prvni.Text = "Kachna";
            //prvni.Left = 100;
            //prvni.Top = 0;
            //prvni.Click += this.Clicked;
            //this.Controls.Add(prvni);
            //kachny.Add(prvni);
        }

        public void vytvorKachnu()
        {
            Button novaKachna = new Button();
            kachny.Add(novaKachna);
            novaKachna.Left = nahoda.Next(Size.Width);
            novaKachna.Top = 0;
            novaKachna.Click += Clicked;
            novaKachna.BackgroundImage = imageList1.Images[0];
            novaKachna.BackgroundImageLayout = ImageLayout.Stretch;
            novaKachna.Size = new Size(79, 49);
            Controls.Add(novaKachna);
                
        }

        public void Clicked(object sender, EventArgs args)
        {
            skore++;
            Info.Text= "" + skore;
            kachny.Remove((Button)sender);
            Controls.Remove((Button)sender);
            vytvorKachnu();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            
            foreach (Button b in kachny)
            {
                b.Top = b.Top + 5;                
                
                if (b.Bottom > Size.Height)
                {
                    skore--;
                    Info.Text = "" + skore;
                    kLikvidaci.Add(b);
                }
            }
            foreach (Button a in kLikvidaci)
            {
                kachny.Remove(a);
                Controls.Remove(a);               
                vytvorKachnu();
            }
            kLikvidaci.Clear();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        struct padajciVec
        {
            public Button tlacitko;
            public Timer casovac;
        }

        private void GameControl_Tick(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Drawing;

namespace MoviendoHilos
{
    public partial class Form1 : Form
    {
        //delegate void delegado();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //CheckForIllegalCrossThreadCalls = false;
        }

        private void Volar()
        {
            for (int i = 0; i < this.Width; i++)
            {
                pictureBox1.Left += i;
                pictureBox2.Left -= i;
                //pictureBox2.Right = i;
                Thread.Sleep(30);
                if (pictureBox1.Left >= pictureBox2.Left)
                {
                    pictureBox2.Visible = false;
                }
            }
        }
        //private void VolarDelegado()
        //{
        //    delegado DelVol = new delegado(Volar);
        //    DelVol.Invoke();
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            Volar();
            //Thread avion = new Thread(Volar);      //2ª opción
            //avion.Start();
            //VolarDelegado();                       //3ª Opción
            //Thread avion = new Thread(VolarDelegado);   //4ª Opción
            //avion.Start();
        }
    }
}
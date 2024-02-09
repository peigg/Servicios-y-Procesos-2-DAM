using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarreraMotos
{
    public partial class Form1 : Form
    {
        delegate void delegado();
        public Form1()
        {
            InitializeComponent();
        }

        
        PictureBox moto1, moto2, moto3, moto4;
        private AutoResetEvent resetEvent = new AutoResetEvent(false);

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            moto1 = pbMoto1;
            moto2 = pbMoto2;
            moto3 = pbMoto3;
            moto4 = pbMoto4;
        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            Thread moto = new Thread(metodoDelegado);
            resetEvent.Set(); // Indica que se puede continuar después del reinicio
            moto.Start();
        }

        private void metodoDelegado()
        {
            delegado movimientoDelegado = new delegado(movimiento);
            movimientoDelegado.Invoke();
        }

        private volatile bool continuarMovimiento = true;
        private void movimiento()
        {
            Random aleatorio = new Random();
            continuarMovimiento = true;

            int meta = lblMeta.Left;

            for (int i = 0; i < this.Width - moto1.Width - 50; i++)
            {
                this.BeginInvoke((MethodInvoker)delegate
                { 
                    moto2.Left += aleatorio.Next(40);
                    moto3.Left += aleatorio.Next(40);
                    moto4.Left += aleatorio.Next(40);
                });

                Thread.Sleep(500);

                if (moto1.Left >= meta)
                {
                 
                    MessageBox.Show("Ha ganado la moto 1");
                    ReiniciarCarrera();
                    break;
                }
                else if (moto2.Left >= meta)
                {
                    MessageBox.Show("Ha ganado la moto 2");
                    ReiniciarCarrera();
                    break;
                }
                else if (moto3.Left >= meta)
                {
                    MessageBox.Show("Ha ganado la moto 3");
                    ReiniciarCarrera();
                    break;
                }
                else if (moto4.Left >= meta)
                {
                    MessageBox.Show("Ha ganado la moto 4");
                    ReiniciarCarrera();
                    break;
                }
            }
        }
        private void btnControl_Click(object sender, EventArgs e)
        {
            ControlarMotoManualmente(moto1); // Cambia moto1 por la moto que deseas controlar
        }

        private void ControlarMotoManualmente(PictureBox moto)
        {
            
            // Movemos la moto 10 píxeles a la derecha en cada clic
            moto.Left += 10;
        }

        private void ReiniciarCarrera()
        {
            moto1.Left = 0;
            moto2.Left = 0;
            moto3.Left = 0;
            moto4.Left = 0;
            continuarMovimiento = false;  // Pausar el movimiento
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            
            moto1.Left = 0;
            moto2.Left = 0;
            moto3.Left = 0;
            moto4.Left = 0;
   
        }

        
    }
}

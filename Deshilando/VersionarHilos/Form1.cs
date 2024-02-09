namespace VersionarHilos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread tareaMensaje = new Thread(LanzarProceso);
            tareaMensaje.Start();
        }

        private void LanzarProceso()
        {
            //Hacer que se tarde 10000 milisegundos (10 segundos) 
            Thread.Sleep(10000);
            MessageBox.Show("Proceso finalizado");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Estoy hilando sin liarme");
        }
    }
}
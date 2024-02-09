using System.Diagnostics;

namespace SelArchivo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            // Directorio de trabajo
            // - Se comienza la exploraci�n en C:\
            openFileDialog.InitialDirectory = "c:\\";
            // - Al final, se vuelve al directorio donde nos encontr�semos
            openFileDialog.RestoreDirectory = true;
            // Filtros
            openFileDialog.Filter = "Ficheros de texto (*.txt)|*.txt"
            + "|Todos los ficheros (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Process aperturaArchivo = new Process();
                aperturaArchivo.StartInfo.UseShellExecute = true;
                aperturaArchivo.StartInfo.FileName = openFileDialog.FileName;
                aperturaArchivo.Start();               
            }
        }
    }
}
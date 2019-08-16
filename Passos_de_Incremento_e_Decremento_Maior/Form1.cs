using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Windows.Input;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        private double VariavelValor;
        private Stopwatch Cronometro;
        private bool OIncrementoMaiorOcorreu;

        public Form1()
        {
            InitializeComponent();
            Cronometro = new Stopwatch();
            Mostrar.TextAlign = HorizontalAlignment.Center;
            OIncrementoMaiorOcorreu = false; 
        }

        private void Incrementar_Click(object sender, EventArgs e)
        {
            if (OIncrementoMaiorOcorreu == false)
            {
                VariavelValor++;
                Mostrar.Text = VariavelValor.ToString();
            }
            OIncrementoMaiorOcorreu = false;
        }

        private void Decrementar_Click(object sender, EventArgs e)
        {
            if(OIncrementoMaiorOcorreu == false)
            {
                VariavelValor--;
                Mostrar.Text = VariavelValor.ToString();
            }
            OIncrementoMaiorOcorreu = false;
        }

        private void Decrementar_MouseDown(object sender, MouseEventArgs e)
        {
            if (!Cronometro.IsRunning)
            {
                Cronometro.Start();
                Task taskA = new Task(() => IncrementoMaior(-5));
                taskA.Start();
            }
        }

        private void PararIncrementoMaior_MouseUp(object sender, MouseEventArgs e)
        {
            Cronometro.Stop();
        }

        private void IncrementoMaior(int valor_De_Decremento)
        {
            int TempoDeEsperaEmMilisigundos = 1100;

            while (Cronometro.IsRunning)
            {
                if(Cronometro.ElapsedMilliseconds >= TempoDeEsperaEmMilisigundos)
                {
                    VariavelValor += valor_De_Decremento;
                    WriteTextSafe(VariavelValor.ToString());
                    Cronometro.Restart();

                    TempoDeEsperaEmMilisigundos = 200;
                    OIncrementoMaiorOcorreu = true;
                }
            }
        }

        private void WriteTextSafe(string text)
        {
            if (Mostrar.InvokeRequired)
            {
                var d = new Action<String>(WriteTextSafe);
                Invoke(d, new object[] { text });
            }
            else
            {
                Mostrar.Text = text;
            }
        }

        private void Incrementar_MouseDown(object sender, MouseEventArgs e)
        {
            if (!Cronometro.IsRunning)
            {
                Cronometro.Start();
                Task taskA = new Task(() => IncrementoMaior(5));
                taskA.Start();
            }
        }
    }
}

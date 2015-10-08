using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using System.Threading;
using System.Net;

namespace Sonar
{
    public partial class PlayerLayout : UserControl
    {

        private static MediaPlayer mp;
        private static Thread t;
        private static Cancion cancion;

        public PlayerLayout()
        {
            mp = new MediaPlayer();
            t = new Thread(actualizaProgreso);
            t.IsBackground = true;

            mp.MediaOpened += cancionCargada;
            mp.MediaEnded += cancionCompleta;

            InitializeComponent();
        }

        public static void cambiaCancion(Cancion c)
        {
            cancion = c;
            Uri uri = new Uri(c.url);
            mp.Open(uri);

        }

        private void cancionCompleta(object sender, EventArgs e)
        {
            button1.mouseClicked = false;
            customTrackBar1.Valor = 0;
            mp.Stop();
        }


        private void cancionCargada(object sender, EventArgs e)
        {
            button1.Enabled=true;
            button1.mouseClicked = false;
            button1.doClick();
            Console.WriteLine(mp.Source);

            customTrackBar1.Maximum = (int)mp.NaturalDuration.TimeSpan.TotalMilliseconds;

            if (!t.IsAlive)
            {
                t.Start();

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (button1.isClicked())
            {
                mp.Pause();
            }
            else
            {
                mp.Play();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            mp.Pause();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mp.Stop();
        }


        public void actualizaProgreso()
        {
            while (true)
            {
                Thread.Sleep(250);
                if (customTrackBar1.Valor < customTrackBar1.Maximum)
                {
                    customTrackBar1.Invoke(new Action(() => customTrackBar1.Valor = (int)mp.Position.TotalMilliseconds));

                }
            }

        }


        //private void trackBar1_Scroll(object sender, EventArgs e)
        //{
        //    TimeSpan t = new TimeSpan(trackBar1.Value*TimeSpan.TicksPerMillisecond);
            
        //    Console.WriteLine(trackBar1.Value + "/"+mp.Position+"/"+t);

        //    mp.Position = t;

        //}

        private void button5_Click(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            String path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+"\\"+cancion.titulo+".mp3";
            webClient.DownloadFileAsync(new Uri(cancion.url), path);
            webClient.DownloadProgressChanged += downloadListener;
            webClient.DownloadFileCompleted += descargadoListener;
        }

        private void descargadoListener(object sender, AsyncCompletedEventArgs e)
        {
            progressBar1.Value = 0;
            String path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + cancion.titulo + ".mp3";
            MessageBox.Show("Se ha descargado "+cancion.titulo+"correctamente en:\n"+path, "Cancion descargada", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        void downloadListener(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
           

        }

        private void customTrackBar1_ValorCambiado(object sender, customTrackBarEvent e)
        {
            TimeSpan t = new TimeSpan(customTrackBar1.Valor * TimeSpan.TicksPerMillisecond);

            //Console.WriteLine(customTrackBar1.Valor + "/" + mp.Position + "/" + t);

            mp.Position = t;
        }
    }
}

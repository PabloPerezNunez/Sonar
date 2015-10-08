using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Forms;
using CsQuery;
using System.Threading;
using System.Net;
using Sonar;

namespace WindowsFormsApplication1
{
    public partial class vPrincipal : Form
    {


        public vPrincipal()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        public void busca(string text)
        {
            tableLayoutPanel1.Invoke(new Action(() => tableLayoutPanel1.Controls.Clear()));

            try
            {
                text = text.Trim();
                text = text.Replace(" ", "-");
                text = text.ToLower();
                
                var dom = CQ.CreateFromUrl("http://mp3freex.org/"+text+"-download");
          

                var selectionHtml = dom.Select(".actl");

                foreach (var item in selectionHtml)
                {
                    var cancion = CQ.Create(item);
                    var title = cancion.Select(".res_title").Text();
                    var link = "http://mp3freex.org/download-mp3/" + cancion.Select("#dowload").Select(".mp3download").Attr("data-online");

                    tableLayoutPanel1.Invoke(new Action(() => tableLayoutPanel1.Controls.Add(new itemLista(new Cancion(title, link)))));

                }

            }
            catch(Exception e){

            }





        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text.CompareTo("") != 0)
            {
                Thread thread = new Thread(() => busca(txtBuscar.Text));
                thread.IsBackground = true;
                thread.Start();

            }
        }

        public static void cambiaCancion(String newurl)
        {
           Player.getInstancia().URL = newurl;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void playerLayout2_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

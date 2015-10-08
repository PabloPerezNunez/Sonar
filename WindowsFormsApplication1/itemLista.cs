using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1;
using System.Threading;
using System.Windows.Threading;

namespace Sonar
{
    public partial class itemLista : UserControl
    {
        public Cancion cancion;

        public itemLista(Cancion c)
        {
            InitializeComponent();
            Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            cancion = c;
            label1.Text = c.titulo;


        }



        private void itemLista_DoubleClick(object sender, EventArgs e)
        {
            cancion.generaLinkDescarga();
            PlayerLayout.cambiaCancion(cancion);

    
        }


        private void itemLista_MouseEnter(object sender, EventArgs e)
        {
            BackColor=Color.DarkGray;
        }

        private void itemLista_MouseLeave(object sender, EventArgs e)
        {
            BackColor = System.Drawing.Color.Transparent;
        }
    }

    

}

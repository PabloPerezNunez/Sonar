using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Player: AxWMPLib.AxWindowsMediaPlayer
    {
        private static Player reproductor = new Player();

        private Player()
        {
            InitializeComponent();
           

        }

        private void InitializeComponent()
        {
            Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            Enabled = true;
            Location = new System.Drawing.Point(7, 608);
            Name = "axWindowsMediaPlayer1";
            Size = new System.Drawing.Size(543, 45);
            TabIndex = 10;
        }

        public static Player getInstancia()
        {
            return reproductor;
        }





    }
}

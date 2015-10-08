using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sonar { 

class ImageButton : Button
{

        private Image icono,iconoHover, iconoClicked, iconoClickedHover;
        public Boolean mouseInside,mouseClicked;
        public ImageButton()
        {
            //icono = Image.FromFile("");
            //iconoHover = Image.FromFile("");
            //iconoClicked = Image.FromFile("");
            //iconoClickedHover = Image.FromFile("");

            mouseClicked = false;
            mouseInside = false;
        }


        [Category("PPN"),Description("The base icon for the button.")]
        public Image NormalIcon
        {
            get
            {
                return icono;
            }
            set
            {
                icono = value;
                Invalidate();
            }
        }

        [Category("PPN"), Description("The hover icon for the button.")]
        public Image HoverIcon
        {
            get
            {
                return iconoHover;
            }
            set
            {
                iconoHover = value;
                Invalidate();
            }
        }

        [Category("PPN"), Description("The clicked icon for the button.")]
        public Image ClickedIcon
        {
            get
            {
                return iconoClicked;
            }
            set
            {
                iconoClicked = value;
                Invalidate();
            }
        }

        [Category("PPN"), Description("The hover icon for the clicked button.")]
        public Image HoverClickedIcon
        {
            get
            {
                return iconoClickedHover;
            }
            set
            {
                iconoClickedHover = value;
                Invalidate();
            }
        }


        protected override void OnPaint(PaintEventArgs pevent)
        {
            Graphics g = pevent.Graphics;
            // Fill the background
            using (SolidBrush backgroundBrush = new SolidBrush(Color.FromArgb(255,40,40,40)))
            {

                g.FillRectangle(backgroundBrush, this.ClientRectangle);
                int size = Math.Max(this.Height, this.Width);
                this.Width = size;
                this.Height = size;
                RectangleF sourceRect = new RectangleF(0, 0, size,size);

                if (!mouseInside && !mouseClicked)
                {
                    g.DrawImage(icono, sourceRect);

                }
                if (mouseInside && mouseClicked)
                {
                    g.DrawImage(iconoClickedHover, sourceRect);

                }
                if (mouseInside && !mouseClicked)
                {
                    g.DrawImage(iconoHover, sourceRect);

                }
                if (!mouseInside && mouseClicked)
                {
                    g.DrawImage(iconoClicked, sourceRect);

                }

            }

        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            mouseInside = true;

        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            mouseInside = false;

        }
        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            
            if (mouseClicked){mouseClicked = false;}
            else { mouseClicked = true; }

        }

        public Boolean isClicked()
        {
            return mouseClicked;
        }

        public void doClick()
        {
            PerformClick();
            mouseClicked = true;
        }

    }
}

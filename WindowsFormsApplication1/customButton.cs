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

class customButton : Button
{

        private Image icono,iconoHover,iconoPressed;
        private Color colorNormal, colorHover,colorPressed;
        private Boolean mouseInside;
        public customButton()
        {
            icono = Image.FromFile("C:\\Users\\PPN\\Desktop\\ic_play_circle_filled_white.png");
            iconoHover = Image.FromFile("C:\\Users\\PPN\\Desktop\\ic_play_circle_filled_gray.png");
            iconoPressed = Image.FromFile("C:\\Users\\PPN\\Desktop\\ic_play_circle_filled_white.png");
            colorNormal = Color.White;
            colorHover = Color.Gray;
            colorPressed = Color.DarkGray;


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

        [Category("PPN"), Description("The hover icon for the button.")]
        public Image PressedIcon
        {
            get
            {
                return iconoPressed;
            }
            set
            {
                iconoPressed = value;
                Invalidate();
            }
        }

        [Category("PPN"), Description("The hover color for the text.")]
        public Color HoverColor
        {
            get
            {
                return colorHover;
            }
            set
            {
                colorHover = value;
                Invalidate();
            }
        }

        [Category("PPN"), Description("The pressed color for the text.")]
        public Color PressedColor
        {
            get
            {
                return colorPressed;
            }
            set
            {
                colorPressed = value;
                Invalidate();
            }
        }

        [Category("PPN"), Description("The color for the text.")]
        public Color NormalColor
        {
            get
            {
                return colorNormal;
            }
            set
            {
                colorNormal = value;
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
                RectangleF sourceRect = new RectangleF(0, 0, this.Height, this.Height);

                if (!mouseInside)
                {
                    g.DrawImage(icono, sourceRect);
                    g.DrawString(Text, Font, new SolidBrush(colorNormal), new PointF(this.Height + 2, this.Height/2-(Font.Height/2)));


                }else
                {
                    g.DrawImage(iconoHover, sourceRect);
                    g.DrawString(Text, Font, new SolidBrush(colorHover), new PointF(this.Height + 2, this.Height / 2 - (Font.Height / 2)));


                }





            }
            // Paint the outer rounded rectangle

            // Paint the text
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

    }
}

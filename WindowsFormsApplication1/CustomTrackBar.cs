using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sonar
{

    public delegate void customTrackBarHandle(object sender, customTrackBarEvent e);


    class CustomTrackBar :TrackBar
    {

        Boolean click;
        private int oldValue;
        private int valor;
        private int margenProgreso,margenSlider,margenBarra;
        private Color progressColor,barraColor,sliderColor;

        public event customTrackBarHandle ValorCambiado;

        public CustomTrackBar()
        {
            AutoSize = false;
            TickStyle = TickStyle.None;
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);



            click = false;

        }

        protected virtual void OnValorCambiado(customTrackBarEvent e){

            if (ValorCambiado != null)
            {
                //Invokes the delegates.
                ValorCambiado(this, e);
            }

        }
   

        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (click && (oldValue!=Value))
            {
                Refresh();
                oldValue = Value;
                OnValorCambiado(new customTrackBarEvent());
            }
            Valor = Value;

        }

        
        protected override void OnMouseDown(MouseEventArgs e)
        {
            click = true;
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            click = false;
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            drawBarra(g);
            drawProgress(g);
            drawSlider(g);

           
        }

        private void drawProgress(Graphics g)
        {
            using (SolidBrush backgroundBrush = new SolidBrush(progressColor))
            {
                int margin = margenProgreso;
                int barHeight = Height - 2 * margin;
                int radio = barHeight / 2;
                int progress = 0;

                if (Value != 0)
                {
                    progress =(int)((Value * 1.0f / Maximum) * (Width - (2 * margin) - barHeight));

                }

                RectangleF sourceRect = new RectangleF(margin + radio, margin, progress, barHeight);
                RectangleF ini = new RectangleF(margin, margin, barHeight, barHeight);
                RectangleF end = new RectangleF(margin + progress, margin, barHeight, barHeight);


                g.FillEllipse(backgroundBrush, ini);
                g.FillEllipse(backgroundBrush, end);
                g.FillRectangle(backgroundBrush, sourceRect);

            }
        }

        private void drawSlider(Graphics g)
        {
            using (SolidBrush backgroundBrush = new SolidBrush(sliderColor))
            {
                int margin = margenSlider;
                int barHeight = Height - 2 * margin;
                int radio = barHeight / 2;
                int barWidth = Width - (2 * margin);
                int progress = 0;

                if (Value != 0)
                {
                    progress = (int)((Value * 1.0f / Maximum) * (Width - (2 * margin) - barHeight));

                }


                RectangleF sourceRect = new RectangleF(margin+progress, margin, barHeight, barHeight);

                g.FillEllipse(backgroundBrush, sourceRect);

            }
        }

        public void drawBarra(Graphics g)
        {
            using (SolidBrush backgroundBrush = new SolidBrush(barraColor))
            {
                int margin = margenBarra;
                int barHeight = Height - 2 * margin;
                int radio = barHeight / 2;

                RectangleF sourceRect = new RectangleF(margin + radio, margin, Width - barHeight - 2 * margin, barHeight);
                RectangleF ini = new RectangleF(margin, margin, barHeight, barHeight);
                RectangleF end = new RectangleF(Width - barHeight - margin, margin, barHeight, barHeight);


                g.FillEllipse(backgroundBrush, ini);
                g.FillEllipse(backgroundBrush, end);
                g.FillRectangle(backgroundBrush, sourceRect);



            }
        }

        [Category("PPN"), Description("The base icon for the button.")]
        public int Valor
        {
            get
            {
                return valor;
            }
            set
            {
                valor = value;
                Value = valor;
                Refresh();
            }
        }


        [Category("PPN"), Description("The color of the progress bar.")]
        public Color ProgressColor
        {
            get
            {
                return progressColor;
            }
            set
            {
                progressColor = value;

                Refresh();
            }
        }


        [Category("PPN"), Description("The margin of the progress bar.")]
        public int MargenProgreso
        {
            get
            {
                return margenProgreso;
            }
            set
            {
                margenProgreso = value;
                Refresh();
            }
        }

        [Category("PPN"), Description("The color of the bar.")]
        public Color BarraColor
        {
            get
            {
                return barraColor;
            }
            set
            {
                barraColor = value;

                Refresh();
            }
        }

        [Category("PPN"), Description("The margin of the bar.")]
        public int MargenBarra
        {
            get
            {
                return margenBarra;
            }
            set
            {
                margenBarra = value;
                Refresh();
            }
        }

        [Category("PPN"), Description("The slider color.")]
        public Color SliderColor
        {
            get
            {
                return sliderColor;
            }
            set
            {
                sliderColor = value;

                Refresh();
            }
        }

        [Category("PPN"), Description("The slider margin.")]
        public int MargenSlider
        {
            get
            {
                return margenSlider;
            }
            set
            {
                margenSlider = value;
                Refresh();
            }
        }

    }

    public class customTrackBarEvent : EventArgs
    {
       
      
    }
}

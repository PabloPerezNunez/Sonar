using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sonar
{
    public partial class Progress : UserControl
    {


        public int Value
        {
            get { return Value; }
            set
            {
                Value = value;
                UpdateLabel();
            }
        }
        public int Maximum
        {
            get { return Maximum; }
            set { Maximum = value; }
        }

        public int Step
        {
            get { return Step; }
            set { Step = value; }
        }
        public void PerformStep()
        {
            PerformStep();
            UpdateLabel();
        }
        private void UpdateLabel()
        {
            label1.Text = (Math.Round((decimal)(Value * 100) /
            Maximum)).ToString();
            label1.Text += "% Done";
        }

        public Progress()
        {
            InitializeComponent();
        }


    }
}

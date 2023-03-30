using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Views
{
    public partial class BuyCard : Form
    {
        public BuyCard()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime t = DateTime.Now;
            this.time.Text = t.ToString("HH:mm:ss");
            this.date.Text = t.ToString("MMM/dd/yyyy");
        }

        private void BuyCard_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}

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
    public partial class RechargeCard : Form
    {
        public RechargeCard()
        {
            InitializeComponent();
        }

        private void RechargeCard_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime t = DateTime.Now;
            this.dateTimePicker1.Text = t.ToString("MMM/dd/yyyy");
            this.time.Text = t.ToString("HH:mm:ss");
        }

        private void label4_Click(object sender, EventArgs e)
        {
            CardInformation ci = new CardInformation();
            ci.Show();
        }
    }
}

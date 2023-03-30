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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            BuyCard buyCard= new BuyCard();
            buyCard.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime t = DateTime.Now;
            this.time.Text = t.ToString("HH:mm:ss");
        }

        private void btnRecharge_Click(object sender, EventArgs e)
        {
            RechargeCard rc = new RechargeCard();
            rc.Show();
        }
    }
}

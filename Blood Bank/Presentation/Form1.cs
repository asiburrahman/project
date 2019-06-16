using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Blood_Bank.Presentation;

namespace Blood_Bank
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonDoner_Click(object sender, EventArgs e)
        {
            formDoner formDoner = new formDoner();
            formDoner.Show();
            this.Hide();
        }

        private void buttonReceiver_Click(object sender, EventArgs e)
        {
            formReceiver formReceiver = new formReceiver();
            formReceiver.Show();
            this.Hide();
        }
    }
}

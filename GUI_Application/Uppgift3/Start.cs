using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift3
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void avsluta_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void strt_Click(object sender, EventArgs e)
        {
            var prsn = new Form1();
            prsn.Show();
            this.Hide();
        }
    }
}

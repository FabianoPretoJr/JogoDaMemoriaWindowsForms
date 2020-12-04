using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDaMemoria
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Form1 screenGame = new Form1();
            this.Hide();
            screenGame.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 screenScore = new Form3();
            this.Hide();
            screenScore.ShowDialog();
        }
    }
}

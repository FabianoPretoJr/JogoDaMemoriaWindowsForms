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
    public partial class Form3 : Form
    {
        Placar p = new Placar();
        PlacarDAL pDAL = new PlacarDAL();

        public Form3()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Form2 screenStart = new Form2();
            this.Hide();
            screenStart.ShowDialog();
        }
    }
}

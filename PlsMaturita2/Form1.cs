using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlsMaturita2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void btnCtenari_Click(object sender, EventArgs e)
        {
            Čtenáři ctenari = new Čtenáři();
            ctenari.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KnihyForm knihy = new KnihyForm();
            knihy.ShowDialog();
        }
    }
}

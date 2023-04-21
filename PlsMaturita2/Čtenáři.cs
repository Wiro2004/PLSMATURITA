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
    public partial class Čtenáři : Form
    {
        SqlRepository sqlRepository;
        public Čtenáři()
        {
            InitializeComponent();
            sqlRepository = new SqlRepository(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=PlsMaturita;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        public void LoadData()
        {
            lvCtenari.Items.Clear();
            var ctenari = sqlRepository.NactiCtenare();
            foreach (var ctenar in ctenari)
            {
                lvCtenari.Items.Add(new ListViewItem(new String[] { ctenar.IdCtenar.ToString(), ctenar.Jmeno, ctenar.Prijmeni, ctenar.PujcenychKnih.ToString() }));
            }
        }

        private void Čtenáři_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbJmeno.Text))
            {
                MessageBox.Show("L");
            }
            else if (string.IsNullOrEmpty(tbPrijmeni.Text))
            {
                MessageBox.Show("L");
            }
            else if (string.IsNullOrEmpty(tbPujcenychKnih.Text))
            {
                MessageBox.Show("L");
            }
            else
            {
                sqlRepository.VytvorCtenare(tbJmeno.Text, tbPrijmeni.Text, Convert.ToInt32(tbPujcenychKnih.Text));
            }
           
                LoadData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (lvCtenari.SelectedItems.Count > 0)
            {
                sqlRepository.OdstranCtenare(Convert.ToInt32(lvCtenari.SelectedItems[0].SubItems[0].Text));
                LoadData();
            }
            else
            {
                MessageBox.Show("Nic nebylo vybráno. Smutné");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            var id = Convert.ToInt32(lvCtenari.SelectedItems[0].SubItems[0].Text);


            ČtenářiUpravit ctenariUpravit = new ČtenářiUpravit(this,id);
            ctenariUpravit.ShowDialog();
        }
    }
}

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
    public partial class ČtenářiUpravit : Form
    {

        private new Čtenáři ParentForm { get; set; }

        private int IdCtenar { get; set; }

        SqlRepository sqlRepository;
        public ČtenářiUpravit(Čtenáři parentform, int id)
        {
            InitializeComponent();
            sqlRepository = new SqlRepository(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=PlsMaturita;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            ParentForm = parentform;
            IdCtenar = id;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
        

            if (string.IsNullOrEmpty(tbNoveJmeno.Text))
            {
                MessageBox.Show("L");
            }
            else if (string.IsNullOrEmpty(tbNovePrijmeni.Text))
            {
                MessageBox.Show("L");
            }
            else if (string.IsNullOrEmpty(tbNovePujcenychKnih.Text))
            {
                MessageBox.Show("L");
            }
            else
            {
                sqlRepository.EditCtenare(IdCtenar, tbNoveJmeno.Text, tbNovePrijmeni.Text, Convert.ToInt32(tbNovePujcenychKnih.Text));

                MessageBox.Show("Uživatel byl upraven. Skvělá práce! ;)");
                Close();
            }

            ParentForm.LoadData();

        }
    }
}

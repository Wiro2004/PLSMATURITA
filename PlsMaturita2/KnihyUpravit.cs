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
    public partial class KnihyUpravit : Form
    {
        private new KnihyForm ParentForm { get; set; }

        private int IdKniha { get; set; }

        SqlRepository sqlRepository;
        public KnihyUpravit(KnihyForm parentform, int id)
        {
            InitializeComponent();
            sqlRepository = new SqlRepository(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=PlsMaturita;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            ParentForm = parentform;
            IdKniha = id;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(tbNazevEdit.Text))
            {
                MessageBox.Show("L");
            }
            else if (string.IsNullOrEmpty(tbAutorEdit.Text))
            {
                MessageBox.Show("L");
            }
            else if (string.IsNullOrEmpty(dtDatumEdit.Text))
            {
                MessageBox.Show("L");
            }
            else
            {
              //  sqlRepository.EditCtenare(IdKniha, tbNazevEdit.Text, tbAutorEdit.Text, Convert.ToDateTime(dtDatumEdit.Text));

                MessageBox.Show("Uživatel byl upraven. Skvělá práce! ;)");
                Close();
            }

            ParentForm.LoadDataKnihy();

        }
    }
    
}

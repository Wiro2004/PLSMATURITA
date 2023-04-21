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
    public partial class KnihyForm : Form
    {
        SqlRepository sqlRepository;
        //List<Knihy> knihy;   
        public KnihyForm()
        {
            InitializeComponent();
           // knihy = sqlRepository.NactiKnihu();
            sqlRepository = new SqlRepository(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=PlsMaturita;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            //NajdiKnihu();
        }

        public void LoadDataKnihy()
        {
            lvKnihy.Items.Clear();
            var knihy = sqlRepository.NactiKnihu();
            foreach (var kniha in knihy)
            {
                lvKnihy.Items.Add(new ListViewItem(new String[] { kniha.IdKnihy.ToString(), kniha.Nazev, kniha.Autor, kniha.Datum.ToString("d") }));
            }
        }

        private void KnihyForm_Load(object sender, EventArgs e)
        {
            LoadDataKnihy();
        }
        //private void NajdiKnihu() // VOJTOVO KOD, TOHLE NWM JAK KURVA FUNGUJE. Asi má nahoře někde založený pole, který odkazuje na načtení v reposu. Ale jak to kurva funguje nemám tucha
        //{
        //    lvKnihy.Items.Clear();

        //    foreach (var kniha in knihy)
        //    {
        //        if (kniha.Nazev.Contains(tbSearch.Text) || kniha.Autor.Contains(tbSearch.Text))
        //        {
        //            lvKnihy.Items.Add(new ListViewItem(new String[] { kniha.IdKnihy.ToString(), kniha.Nazev, kniha.Autor, kniha.Datum.ToString("d") }));
        //        }

        //    }

        //}



        private void btnAddKnihy_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbNazev.Text))
            {
                MessageBox.Show("L");
            }
            else if (string.IsNullOrEmpty(tbAutor.Text))
            {
                MessageBox.Show("L");
            }
            else if (string.IsNullOrEmpty(dtKnihy.Text))
            {
                MessageBox.Show("L");
            }
            else
            {
                sqlRepository.VytvorKnihu(tbNazev.Text, tbAutor.Text, Convert.ToDateTime(dtKnihy.Text));
            }

            LoadDataKnihy();
        }

        private void btnDelKnihy_Click(object sender, EventArgs e)
        {
            if (lvKnihy.SelectedItems.Count > 0)
            {
                sqlRepository.OdstranKnihu(Convert.ToInt32(lvKnihy.SelectedItems[0].SubItems[0].Text));
                LoadDataKnihy();
            }
            else
            {
                MessageBox.Show("Nic nebylo vybráno. Smutné");
            }
        }

        private void btnEditKnihy_Click(object sender, EventArgs e)
        {
            var idkn = Convert.ToInt32(lvKnihy.SelectedItems[0].SubItems[0].Text);


            KnihyUpravit knihyUpravit = new KnihyUpravit(this, idkn);
            knihyUpravit.ShowDialog();
        }

      
    }
}

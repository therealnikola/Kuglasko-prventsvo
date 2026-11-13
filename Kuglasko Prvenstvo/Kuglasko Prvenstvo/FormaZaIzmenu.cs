using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KuglaskoPrvenstvo
{
    public partial class FormaZaIzmenu : Form
    {
        private int idZaIzmenu;
        public FormaZaIzmenu(int idZaIzmenu, string imeZaIzmenu, string prezimeZaIzmenu, string datumRodjenjaZaIzmenu, int idKuglaskiTimZaIzmenu)
        {
            InitializeComponent();

            this.idZaIzmenu = idZaIzmenu;
            ImeTxt.Text = imeZaIzmenu;
            PrezimeTxt.Text = prezimeZaIzmenu;
            datumRodjenjaDateTimePicker.Value = DateTime.Parse(datumRodjenjaZaIzmenu);

            KuglaskiTimCls kuglaskitimObj = new KuglaskiTimCls();
            DataSet kuglasketimove = kuglaskitimObj.DajSveKuglaskeTimove();
            KuglaskiTimComboBox.DataSource = kuglasketimove.Tables[0];
            KuglaskiTimComboBox.ValueMember = "KuglaskiTimID";
            KuglaskiTimComboBox.DisplayMember = "ImeKuglaskogTima";
            KuglaskiTimComboBox.SelectedValue = idKuglaskiTimZaIzmenu;
        }

        private void izmenaBtn_Click(object sender, EventArgs e)
        {
            Igrac igracObj = new Igrac();
            //igracObj.IgracID = idZaIzmenu;
            igracObj.Ime = ImeTxt.Text.ToString();
            igracObj.Prezime = PrezimeTxt.Text.ToString();
            igracObj.DatumRodjenja = datumRodjenjaDateTimePicker.Value.Date;
            igracObj.KuglaskiTimID = Int32.Parse(KuglaskiTimComboBox.SelectedValue.ToString());

            if (igracObj.IzmeniIgraca(this.idZaIzmenu))
            {
                MessageBox.Show("Izmena podatka o postojecem igracu uspesna!");
            }
            else
            {
                MessageBox.Show("Doslo je do greske!");
            }
        }

        private void FormaZaIzmenu_Load(object sender, EventArgs e)
        {

        }
    }
}

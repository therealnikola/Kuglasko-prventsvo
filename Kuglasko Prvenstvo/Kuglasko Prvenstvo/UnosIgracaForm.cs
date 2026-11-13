using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KuglaskoPrvenstvo
{
    public partial class UnosIgracaForm : Form
    {
        public UnosIgracaForm()
        {
            InitializeComponent();

            KuglaskiTimCls kuglaskitimObj = new KuglaskiTimCls();
            DataSet kuglasketimove = kuglaskitimObj.DajSveKuglaskeTimove();
            KuglaskiTimComboBox.DataSource = kuglasketimove.Tables[0];
            KuglaskiTimComboBox.ValueMember = "KuglaskiTimID";
            KuglaskiTimComboBox.DisplayMember = "ImeKuglaskogtima";
        }

        private void DatumRodjenjalbl_Click(object sender, EventArgs e)
        {

        }

        private void PotvrdaButton_Click(object sender, EventArgs e)
        {
            Igrac igracObj = new Igrac();
            igracObj.Ime = ImeIgracaTxt.Text.ToString();
            igracObj.Prezime = PrezimeIgracaTxt.Text.ToString();
            igracObj.DatumRodjenja = DatumRodjenjaDateTimePicker.Value.Date;
            igracObj.KuglaskiTimID = Int32.Parse(KuglaskiTimComboBox.SelectedValue.ToString());
            igracObj.UnesiNovogIgraca();
            //MessageBox.Show(igracObj.KuglaskiTimID.ToString());


        }

        private void KuglaskiTimComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UnosIgracaForm_Load(object sender, EventArgs e)
        {

        }
    }
}

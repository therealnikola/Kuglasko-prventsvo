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
    public partial class TabelarniPrikazIgracaForm : Form
    {
        public TabelarniPrikazIgracaForm()
        {
            InitializeComponent();
            Igrac igracObj = new Igrac();
            DataSet igraciDataSet = igracObj.DajSveIgraceSaJedinicom();
            igraciDataGridView.DataSource = igraciDataSet.Tables[0];
            igraciDataGridView.Columns["IgracID"].Visible = false;
            igraciDataGridView.Columns["KuglaskiTimID"].Visible = false;
            igraciDataGridView.Columns["KuglaskiTimID1"].Visible = false;
            igraciDataGridView.Columns["KapitenID"].Visible = false;
        }

        private void prikaziSveBtn_Click(object sender, EventArgs e)
        {
            Igrac igracObj = new Igrac();
            DataSet igraciDataSet = igracObj.DajSveIgraceSaJedinicom();
            igraciDataGridView.DataSource = igraciDataSet.Tables[0];
            igraciDataGridView.Columns["IgracID"].Visible = false;
            igraciDataGridView.Columns["KuglaskiTimID"].Visible = false;
            igraciDataGridView.Columns["KuglaskiTimID1"].Visible = false;
            igraciDataGridView.Columns["KapitenID"].Visible = false;
        }

        private void potvrdaBtn_Click(object sender, EventArgs e)
        {
            Igrac igracObj = new Igrac();
            string prezimeFilter = filterTxt.Text.ToString();
            if ((prezimeFilter != null) && (prezimeFilter!=""))
            {
                DataSet igraciDataSetFilter = igracObj.DajSveIgracePoPrezimenu(prezimeFilter);
                igraciDataGridView.DataSource = igraciDataSetFilter.Tables[0];
                igraciDataGridView.Columns["IgracID"].Visible = false;
                igraciDataGridView.Columns["KuglaskiTimID"].Visible = false;
                igraciDataGridView.Columns["KuglaskiTimID1"].Visible = false;
                igraciDataGridView.Columns["KapitenID"].Visible = false;
            }
            else
            {
                MessageBox.Show("Niste uneli prezime za filter!");
            }

        }
    }
}

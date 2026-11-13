using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace KuglaskoPrvenstvo
{
    public partial class Pocetna : Form
    {

        private PrintDocument izvestajZaStampu = new PrintDocument();
        private int trenutniRed;
        private int trenutnaKolona;
        private const int kolonaMargine = 185;
        private const int redMargine = 85;
        private const int poljePadding = 40;
        private string naslovDokumenta = "Izvestaj";

        public Pocetna()
        {
            InitializeComponent();
            Igrac igracObj = new Igrac();
            DataSet igraciDataSet = igracObj.DajSveIgraceSaJedinicom();
            KuglaskiIgraciDGV.DataSource = igraciDataSet.Tables[0];
            KuglaskiIgraciDGV.Columns["IgracID"].Visible = false;
            KuglaskiIgraciDGV.Columns["KuglaskiTimID"].Visible = false;
            KuglaskiIgraciDGV.Columns["KuglaskiTimID1"].Visible = false;
            KuglaskiIgraciDGV.Columns["KapitenID"].Visible = false;

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void unosNovogIgracaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnosIgracaForm unosIgracaFormObj = new UnosIgracaForm();
            unosIgracaFormObj.Show();
        }

        private void prikazIgracaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabelarniPrikazIgracaForm tabelarniPrikazIgracaFormObj = new TabelarniPrikazIgracaForm();
            tabelarniPrikazIgracaFormObj.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void izmenaBtn_Click(object sender, EventArgs e)
        {
            if(KuglaskiIgraciDGV.SelectedRows.Count > 0)
            {
                DataGridViewRow selektovaniRed = KuglaskiIgraciDGV.Rows[KuglaskiIgraciDGV.CurrentCell.RowIndex];
                int idIzmena = Int32.Parse(selektovaniRed.Cells[0].Value.ToString());
                string imeIzmena = selektovaniRed.Cells[1].Value.ToString();
                string prezimeIzmena = selektovaniRed.Cells[2].Value.ToString();
                string datumRodjenja = selektovaniRed.Cells[3].Value.ToString();
                int idKuglaskiTim = Int32.Parse(selektovaniRed.Cells[4].Value.ToString());
                FormaZaIzmenu formaZaIzmenuObj = new FormaZaIzmenu(idIzmena, imeIzmena, prezimeIzmena, datumRodjenja, idKuglaskiTim);
                formaZaIzmenuObj.ShowDialog();
            }
            else
            {
                MessageBox.Show("Niste odabrali red za izmenu/brisanje!");
            }
        }

        private void PrikazSvihBtn_Click(object sender, EventArgs e)
        {
            Igrac igracObj = new Igrac();
            DataSet igraciDataSet = igracObj.DajSveIgraceSaJedinicom();
            KuglaskiIgraciDGV.DataSource = igraciDataSet.Tables[0];
            KuglaskiIgraciDGV.Columns["IgracID"].Visible = false;
            KuglaskiIgraciDGV.Columns["KuglaskiTimID"].Visible = false;
            KuglaskiIgraciDGV.Columns["KuglaskiTimID1"].Visible = false;
            KuglaskiIgraciDGV.Columns["KapitenID"].Visible = false;
        }

        private void FilterBtn_Click(object sender, EventArgs e)
        {
            Igrac igracObj = new Igrac();
            string prezimeFilter = filterTxt.Text.ToString();
            if ((prezimeFilter != null) && (prezimeFilter != ""))
            {
                DataSet igraciDataSetFilter = igracObj.DajSveIgracePoPrezimenu(prezimeFilter);
                KuglaskiIgraciDGV.DataSource = igraciDataSetFilter.Tables[0];
                KuglaskiIgraciDGV.Columns["IgracID"].Visible = false;
                KuglaskiIgraciDGV.Columns["KuglaskiTimID"].Visible = false;
                KuglaskiIgraciDGV.Columns["KuglaskiTimID1"].Visible = false;
                KuglaskiIgraciDGV.Columns["KapitenID"].Visible = false;
            }
            else
            {
                MessageBox.Show("Niste uneli prezime za filter!");
            }
        }

        private void BrisanjeBtn_Click(object sender, EventArgs e)
        {
            Igrac igracObj = new Igrac();
            DataGridViewRow selektovaniRed = KuglaskiIgraciDGV.Rows[KuglaskiIgraciDGV.CurrentCell.RowIndex];
            int idZaBrisanje = Int32.Parse(selektovaniRed.Cells[0].Value.ToString());

            switch (igracObj.ObrisiIgraca(idZaBrisanje))
            {
                default:
                    MessageBox.Show("Doslo je do nedefinisane greske");
                    break;
                case 1:
                    MessageBox.Show("Podatak uspesno obrisan!");
                    break;
                case -1:
                    MessageBox.Show("Greska prilikom brisanja podatka!");
                    break;
            }

            DataSet igraciDataSet = igracObj.DajSveIgraceSaJedinicom();
            KuglaskiIgraciDGV.DataSource = igraciDataSet.Tables[0];

        }

        private void StampaBtn_Click(object sender, EventArgs e)
        {
            izvestajZaStampu.PrintPage += new PrintPageEventHandler(StampajStranicu);
            trenutnaKolona = 0;
            trenutniRed = 0;
            izvestajZaStampu.Print();
            
        }

        private void StampajStranicu(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Font font = new Font("Arial", 10);
            Font naslovFont = new Font("Arial", 14, FontStyle.Bold);

            Brush cetkica = Brushes.Black;
            int yPos = 0;
            int xPos;
            g.DrawString(naslovDokumenta, naslovFont, cetkica, e.MarginBounds.Left, yPos);
            int[] kolonaSirina = new int[KuglaskiIgraciDGV.Columns.Count];
            int ukupnaSirina = 0;

            for(int i = 0; i < KuglaskiIgraciDGV.Columns.Count; i++)
            {
                kolonaSirina[i] = KuglaskiIgraciDGV.Columns[i].Width;
                ukupnaSirina += kolonaSirina[i];
            }


            xPos = kolonaMargine;

            foreach(DataGridViewColumn kolona in KuglaskiIgraciDGV.Columns)
            {
                if (kolona.Index != 0 && kolona.Index != 4 && kolona.Index != 5 && kolona.Index != 8)
                {
                    g.DrawString(kolona.HeaderText, font, cetkica, xPos, yPos);
                    xPos = kolonaSirina[kolona.Index];
                }
            }

            yPos += font.Height + redMargine;

            while (trenutniRed < KuglaskiIgraciDGV.Rows.Count)
            {
                xPos = kolonaMargine;
                foreach(DataGridViewColumn kolona in KuglaskiIgraciDGV.Columns)
                {
                    if (kolona.Index != 0 && kolona.Index != 4 && kolona.Index != 5 && kolona.Index != 8)
                    {
                        if (KuglaskiIgraciDGV.Rows[trenutniRed].Cells[kolona.Index].Value != null)
                        {
                            g.DrawString(KuglaskiIgraciDGV.Rows[trenutniRed].Cells[kolona.Index].Value.ToString(), font, cetkica, xPos, yPos);
                        }

                        xPos += kolonaSirina[kolona.Index];
                    }
                }

                yPos += font.Height + redMargine;
                trenutniRed++;

                if(yPos + font.Height > e.MarginBounds.Height)
                {
                    e.HasMorePages = true;
                    return;
                }

            }

            e.HasMorePages = false;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}

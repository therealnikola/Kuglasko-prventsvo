using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KuglaskoPrvenstvo
{
    internal class KapitenCls
    {
        private int kapitenId;
        private string ime;
        private string prezimel;
        private string datumRodjenja;
        private int kuglaskitimId;

        //1. Get i Set property na drugi nacin
        public int KapitenID { get => kapitenId; set => kapitenId = value; }
        public string Ime { get => ime; set => ime = value; }
        public string Prezimel { get => prezimel; set => prezimel = value; }
        public string DatumRodjenja { get => datumRodjenja; set => datumRodjenja = value; }
        public int KuglaskiTimID { get => kuglaskitimId; set => kuglaskitimId = value; }

        //2. Konkretne funkcije
        public DataSet DajSveKapitene()
        {
            DataSet KapitenDataSet = new DataSet();

            try
            {
                string upit = "SELECT * FROM Kapiten";

                SqlConnection konekcija = new SqlConnection(Program.konekcioniString);
                SqlCommand komanda = new SqlCommand(upit, konekcija);
                SqlDataAdapter adapter = new SqlDataAdapter(komanda);

                konekcija.Open();
                komanda.ExecuteNonQuery();
                adapter.Fill(KapitenDataSet);
                konekcija.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return KapitenDataSet;

        }




    }
}

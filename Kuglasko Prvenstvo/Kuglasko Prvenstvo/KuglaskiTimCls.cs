using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KuglaskoPrvenstvo
{
    internal class KuglaskiTimCls
    {
        private int kuglaskitimId;
        private string imeKuglaskogTima;
        private string opis;
        private int kapitenId;
        
        //1. Get i Set metode-------------------
        public void SetKuglaskiTimID(int kuglaskitimId)
        {
            this.kuglaskitimId = kuglaskitimId;
        }

        public int GetKuglaskiTimID() 
        { 
            return this.kuglaskitimId; 
        }

        public void SetImeKuglaskogTima(string imeKuglaskogTima)
        {   
            this.imeKuglaskogTima= imeKuglaskogTima; 
        }

        public string GetImeKuglaskogTima() 
        { 
            return this.imeKuglaskogTima;
        }

        public void SetOpis(string opis)
        {
            this.opis = opis;
        }

        public string GetOpis()
        {
            return this.opis;
        }

        public void SetKapitenID(int kapitenId)
        {
            this.kapitenId= kapitenId;
        }

        public int GetKapitenID()
        {
            return this.kapitenId;
        }

        //-------------------------------------------------

        //2. Konkretne funkcije----------------------------

        public DataSet DajSveKuglaskeTimove()
        {
            DataSet KuglaskeTimoveDataSet = new DataSet();

            try
            {
                string upit = "SELECT * FROM KuglaskiTim";

                SqlConnection konekcija = new SqlConnection(Program.konekcioniString);
                SqlCommand komanda = new SqlCommand(upit, konekcija);
                SqlDataAdapter adapter = new SqlDataAdapter(komanda);

                konekcija.Open();
                komanda.ExecuteNonQuery();
                adapter.Fill(KuglaskeTimoveDataSet);
                konekcija.Close();
            }
            catch(Exception ex)
            {

            }
            

            return KuglaskeTimoveDataSet;

        } 

    }
}

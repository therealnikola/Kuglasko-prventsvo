using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace KuglaskoPrvenstvo
{
    public class Igrac
    {
        private int igracId;
        private string ime;
        private string prezime;
        private DateTime datumRodjenja;
        private int kuglaskitimId;

        public string konekcioniString = "Server=EVGA\\SQLEXPRESS; Database=KuglaskoPrvenstvo; Integrated Security=True;";

        public int IgracID { get => igracId; set => igracId = value; }
        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public DateTime DatumRodjenja { get => datumRodjenja; set => datumRodjenja = value; }
        public int KuglaskiTimID { get => kuglaskitimId; set => kuglaskitimId = value; }


        //2. Konkretne funkcije
        public DataSet DajSveIgrace()
        {
            DataSet IgracDataSet = new DataSet();

            try
            {
                string upit = "SELECT * FROM Igrac";

                SqlConnection konekcija = new SqlConnection(konekcioniString);
                SqlCommand komanda = new SqlCommand(upit, konekcija);
                SqlDataAdapter adapter = new SqlDataAdapter(komanda);

                konekcija.Open();
                komanda.ExecuteNonQuery();
                adapter.Fill(IgracDataSet);
                konekcija.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return IgracDataSet;

        }

        public DataSet DajSveIgraceSaJedinicom()
        {
            DataSet IgracDataSet = new DataSet();

            try
            {
                string upit = "SELECT * FROM Igrac INNER JOIN KuglaskiTim ON Igrac.KuglaskiTimID = KuglaskiTim.KuglaskiTimID";

                SqlConnection konekcija = new SqlConnection(konekcioniString);
                SqlCommand komanda = new SqlCommand(upit, konekcija);
                SqlDataAdapter adapter = new SqlDataAdapter(komanda);

                konekcija.Open();
                komanda.ExecuteNonQuery();
                adapter.Fill(IgracDataSet);
                konekcija.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return IgracDataSet;

        }

        public DataSet DajSveIgracePoPrezimenu(string Prezime)
        {
            DataSet IgracDataSet = new DataSet();

            try
            {
                string upit = "SELECT * FROM Igrac INNER JOIN KuglaskiTim ON Igrac.KuglaskiTimID = KuglaskiTim.KuglaskiTimID WHERE Prezime ='" + Prezime+"';";

                SqlConnection konekcija = new SqlConnection(konekcioniString);
                SqlCommand komanda = new SqlCommand(upit, konekcija);
                SqlDataAdapter adapter = new SqlDataAdapter(komanda);

                konekcija.Open();
                komanda.ExecuteNonQuery();
                adapter.Fill(IgracDataSet);
                konekcija.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return IgracDataSet;

        }

        public int UnesiNovogIgraca()
        {
            int rezultat = 0;
            try
            {
                string upit = "INSERT INTO Igrac " +
                    "(Ime, Prezime, DatumRodjenja, KuglaskiTimID)" +
                    " VALUES " +
                    "(@ImePrametar, @PrezimeParametar, @DatumRodjenjaParametar, @KuglaskiTimIDParametar)";
                SqlConnection konekcija = new SqlConnection(konekcioniString);


                
                SqlCommand komanda = new SqlCommand(upit, konekcija);
                komanda.Parameters.AddWithValue("@ImePrametar", this.ime);
                komanda.Parameters.AddWithValue("@PrezimeParametar", this.prezime);
                komanda.Parameters.AddWithValue("@DatumRodjenjaParametar", this.datumRodjenja.ToString("yyyy-MM-dd"));
                komanda.Parameters.AddWithValue("@KuglaskiTimIDParametar", this.kuglaskitimId);
                

                konekcija.Open();
                if (komanda.ExecuteNonQuery() > 0)
                {
                    rezultat = 1;
                }
                konekcija.Close();

                MessageBox.Show("Unos podatka o novom igracu uspesan!");
                rezultat = 1;
            }
            catch(Exception ex)
            {
                //MessageBox.Show(ex.ToString());
                rezultat = -1;
            }

            return rezultat;

        }

        public bool IzmeniIgraca(int igracIdZaIzmenu)
        {
            bool uspeh = false;
            try
            {
                string upit =
                    "UPDATE Igrac SET " +
                    "Ime = @ImeParametar, " +
                    "Prezime = @PrezimeParametar, " +
                    "DatumRodjenja = @DatumRodjenjaParametar," +
                    " KuglaskiTimID = @KuglaskiTimIDParametar WHERE IgracID = @igracIdZaIzmenuParametar";

                SqlConnection konekcija = new SqlConnection(konekcioniString);

                SqlCommand komanda = new SqlCommand(upit, konekcija);
                komanda.Parameters.AddWithValue("@ImeParametar", this.ime);
                komanda.Parameters.AddWithValue("@PrezimeParametar", this.prezime);
                komanda.Parameters.AddWithValue("@DatumRodjenjaParametar", this.datumRodjenja);
                komanda.Parameters.AddWithValue("@KuglaskiTimIDParametar", this.kuglaskitimId);
                komanda.Parameters.AddWithValue("@igracIdZaIzmenuParametar", igracIdZaIzmenu);

                konekcija.Open();
                
                if (komanda.ExecuteNonQuery() > 0)
                {
                    uspeh = true;
                }

                konekcija.Close();

                // MessageBox.Show("Izmena podatka o postojecem igracu uspesna!");
                
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }

            return uspeh;

        }

        public int ObrisiIgraca(int igracId)
        {
            int uspeh = 0;

            try
            {

                string upit = "DELETE FROM Igrac WHERE IgracID = " + igracId +";";

                SqlConnection konekcija = new SqlConnection(konekcioniString);
                SqlCommand komanda = new SqlCommand(upit, konekcija);

                konekcija.Open();
                if (komanda.ExecuteNonQuery() > 0)
                {
                    uspeh = 1;
                }
                konekcija.Close();

            }
            catch(Exception ex)
            {
                //MessageBox.Show(ex.ToString());
                uspeh = -1;
            }

            return uspeh;
        }


    }




}

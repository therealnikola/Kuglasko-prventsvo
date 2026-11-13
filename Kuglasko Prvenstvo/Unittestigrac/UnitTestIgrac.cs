using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Text.RegularExpressions;
using System.Xml;

namespace UnitTestIgrac
{
    [TestClass]
    public class UnitTestIgrac
    {
        string putanjaDoXML = "Igraci.xml";
        string patternIme = @"^[A-ZČĆŽŠĐ][a-zčćžšđ]{1,15}( [A-ZČĆŽŠĐ][a-zčćžšđ]{1,15})?$";
        string patternPrezime = @"^[A-ZČĆŽŠĐ][a-zčćžšđ]{1,15}( [A-ZČĆŽŠĐ][a-zčćžšđ]{1,15})?$";
        XmlDocument dokument = new XmlDocument();

        [TestMethod]
        public void TestImeIPrezime()
        {
            try
            {
                dokument.Load(putanjaDoXML);
                XmlNodeList osobe = dokument.GetElementsByTagName("Osoba");

                foreach (XmlNode osoba in osobe)
                {
                    string ime = osoba["Ime"].InnerText;
                    string prezime = osoba["Prezime"].InnerText;

                    bool imeValidno = Regex.IsMatch(ime, patternIme);
                    bool prezimeValidno = Regex.IsMatch(prezime, patternPrezime);

                    if (imeValidno && prezimeValidno)
                    {
                        Console.WriteLine($"Validno: {ime} {prezime}");
                    }
                    else
                    {
                        string errorMessage = $"Nevalidno: {ime} {prezime} (Ime validno: {imeValidno}, Prezime validno: {prezimeValidno})";
                        Console.WriteLine(errorMessage);
                        Assert.Fail(errorMessage);
                    }
                }
            }
            catch (Exception ex)
            {
                Assert.Fail("Greška prilikom učitavanja XML-a ili obrade podataka: " + ex.Message);
                Console.WriteLine(ex.ToString());
            }
        }

        [TestMethod]
        public void ProveriIdKuglaskihTimova()
        {
            int idKuglaskeTimove = 1;
            if(idKuglaskeTimove < 1 && idKuglaskeTimove > 4)
            {
                Assert.Fail("Neispravan Id kuglaskog tima, validno od 1 - 4.");            
            }
        }
    }
}

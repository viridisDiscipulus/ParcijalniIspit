using System;

namespace Ispit.Model
{
    public class Ucenik
    {
        #region Fields
        private string ime;
        private string prezime;
        private DateTime datumRodenja;
        private double prosjek;
        #endregion

        #region Properties
        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }

        public string Prezime
        {
            get { return prezime; }
            set { prezime = value; }
        }

        public DateTime DatumRodenja
        {
            get { return datumRodenja; }
            set { datumRodenja = value; }
        }

        public double Prosjek
        {
            get { return prosjek; }
            set { prosjek = value; }
        }
        #endregion

        #region Methods
        public int? Starost(DateTime datumRodenja)
        {
            if (datumRodenja > DateTime.Now)
            {
                return null;
            }

            DateTime tekuciDatum = DateTime.Now;
            int starost = tekuciDatum.Year - datumRodenja.Year;

            return starost;
        }
        public string IspisProsjeka(double prosjek)
        {
            if (prosjek >= 1 && prosjek <= 1.49)
                return "Nedovoljan";
            else if (prosjek >= 1.50 && prosjek <= 2.49)
                return "Dovoljan";
            else if (prosjek >= 2.50 && prosjek <= 3.49)
                return "Dobar";
            else if (prosjek >= 3.50 && prosjek <= 4.49)
                return "Vrlo dobar";
            else if (prosjek >= 4.50 && prosjek <= 5)
                return "Odličan";

            return "Nevažeći prosjek";
        }
        #endregion
    }
}

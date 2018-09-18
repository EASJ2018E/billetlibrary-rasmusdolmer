using System;

namespace BilletLibrary
{
    /// <summary>
    /// Bil klasse med 2 properties, en default constructor og 2 metoder
    /// </summary>
    public class Bil
    {
        public string Nummerplade { get; set; }
        public DateTime Dato { get; set; }

        public Bil()
        {
            
        }

        /// <summary>
        /// Denne metode returnerer bilens pris
        /// </summary>
        /// <returns>Returnerer en type double som er 240</returns>
        public double Pris()
        {
            return 240;
        }

        /// <summary>
        /// Denne metode returnerer hvilket køretøj
        /// </summary>
        /// <returns>Returnerer en type string som er bil</returns>
        public string Køretøj()
        {
            return "Bil";
        }
    }
}

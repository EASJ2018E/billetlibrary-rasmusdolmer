using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLibrary
{
    /// <summary>
    /// MC klasse med 2 properties, en default constructor og 2 metoder
    /// </summary>
    public class MC
    {
        /// <summary>
        /// String property til nummerplade med get set
        /// </summary>
        public string Nummerplade { get; set; }
        /// <summary>
        /// DateTime property til dato med get set
        /// </summary>
        public DateTime Dato { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        public MC()
        {

        }

        /// <summary>
        /// Denne metode returnerer MC'ens pris
        /// </summary>
        /// <returns>Returnerer en variabel af typen double som er 125</returns>
        public double Pris()
        {
            return 125;
        }

        /// <summary>
        /// Denne metode returnerer hvilket køretøj
        /// </summary>
        /// <returns>Returnerer en variabel af typen string som er MC</returns>
        public string Køretøj()
        {
            return "MC";
        }
    }
}

﻿using System;

namespace BilletLibrary
{
    /// <summary>
    /// Bil klasse med 2 properties, en default constructor og 2 metoder
    /// </summary>
    public class Bil
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
        public Bil()
        {
            
        }

        /// <summary>
        /// Denne metode returnerer bilens pris
        /// </summary>
        /// <returns>Returnerer en variabel af typen double som er 240</returns>
        public double Pris()
        {
            return 240;
        }

        /// <summary>
        /// Denne metode returnerer hvilket køretøj
        /// </summary>
        /// <returns>Returnerer en variabel af typen string som er Bil</returns>
        public string Køretøj()
        {
            return "Bil";
        }
    }
}

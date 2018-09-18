using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLibrary
{
    /// <summary>
    /// Dette er base klassen køretøj. Klasser som bil og MC arver fra denne klasse
    /// </summary>
    public abstract class Køretøj
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
        /// Bool property til brobizz med get set
        /// </summary>
        public bool Brobizz { get; set; }

        /// <summary>
        /// Constructor med 2 parametre
        /// </summary>
        protected Køretøj(string nummerplade, DateTime dato, bool brobizz)
        {
            if (nummerplade.Length > 7)
            {
                throw new Exception("Du har indtastet en nummerplade på mere end 7 tegn. Prøv igen..");
            }
            Nummerplade = nummerplade;
            Dato = dato;
            Brobizz = brobizz;
        }

        /// <summary>
        /// Denne metode returnerer MC'ens pris
        /// </summary>
        /// <returns>Returnerer en variabel af typen double som er 125</returns>
        public abstract double Pris();


        /// <summary>
        /// Denne metode returnerer hvilket køretøj
        /// </summary>
        /// <returns>Returnerer en variabel af typen string som er MC</returns>
        public abstract string Køretøjet();
    }
}

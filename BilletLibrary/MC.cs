using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLibrary
{
    /// <summary>
    /// MC klasse med 2 properties, en default constructor og 2 metoder
    /// </summary>
    public class MC : Køretøj
    {

        /// <summary>
        /// Constructor med parametre fra base klassen køretøj
        /// </summary>
        public MC(string nummerplade, DateTime dato, bool brobizz) : base(nummerplade, dato, brobizz)
        {
            this.Nummerplade = nummerplade;
            this.Dato = dato;
            this.Brobizz = brobizz;
        }

        /// <summary>
        /// Denne metode returnerer bilens pris. Metoden ligger i klassen køretøj og bliver heri overridet
        /// </summary>
        /// <returns>Returnerer en variabel af typen double som er 240</returns>
        public override double Pris()
        {
            if (Brobizz)
            {
                return 125*0.95;
            }
            return 125;
        }

        /// <summary>
        /// Denne metode returnerer hvilket køretøj. Metoden ligger i klassen køretøj og bliver heri overridet
        /// </summary>
        /// <returns>Returnerer en variabel af typen string som er Bil</returns>
        public override string Køretøjet()
        {
            return "MC";
        }
    }
}

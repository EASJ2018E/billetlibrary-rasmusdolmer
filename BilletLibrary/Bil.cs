using System;

namespace BilletLibrary
{
    /// <summary>
    /// Bil klasse med 2 properties, en default constructor og 2 metoder
    /// </summary>
    public class Bil : Køretøj
    {

        /// <summary>
        /// Constructor med parametre fra base klassen køretøj
        /// </summary>
        public Bil(string nummerplade, DateTime dato, bool brobizz) : base(nummerplade, dato, brobizz)
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
                return 240 * 0.95;
            }
            return 240;
        }

        /// <summary>
        /// Denne metode returnerer hvilket køretøj. Metoden ligger i klassen køretøj og bliver heri overridet
        /// </summary>
        /// <returns>Returnerer en variabel af typen string som er Bil</returns>
        public override string Køretøjet()
        {
            return "Bil";
        }
    }
}

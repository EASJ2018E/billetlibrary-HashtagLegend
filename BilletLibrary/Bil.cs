using System;

namespace BilletLibrary
{
    public class Bil : Køretøj
    {
        public Bil(string nummerplade, DateTime dato) : base(nummerplade, dato)
        {

        }

        /// <summary>
        /// Returnere prisen på en overkørsel
        /// </summary>
        /// <returns></returns>
        public override decimal Pris()
        {
            return 240;
        }

        /// <summary>
        /// Retunerer køretøjstypen
        /// </summary>
        /// <returns></returns>
        public override string Køretøjstype()
        {
            return "Bil";
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLibrary
{
    public class MC : Køretøj
    {
        public MC(string nummerplade, DateTime dato) : base(nummerplade, dato)
        {
        }

        /// <summary>
        /// Returnere prisen på en overkørsel
        /// </summary>
        /// <returns></returns>
        public override decimal Pris()
        {
            return 125;
        }

        /// <summary>
        /// Retunerer køretøjstypen
        /// </summary>
        /// <returns></returns>
        public override string Køretøjstype()
        {
            return "MC";
        }
    }
}

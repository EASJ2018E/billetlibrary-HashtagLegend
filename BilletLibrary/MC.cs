using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLibrary
{
    public class MC
    {
        public string Nummerplade { get; set; }
        public DateTime Dato { get; set; }

        public MC()
        {
            
        }

        /// <summary>
        /// Returnere prisen på en overkørsel
        /// </summary>
        /// <returns></returns>
        public decimal Pris()
        {
            return 125;
        }
        /// <summary>
        /// Retunerer køretøjstypen
        /// </summary>
        /// <returns></returns>
        public string Køretøj()
        {
            return "MC";
        }
    }
}

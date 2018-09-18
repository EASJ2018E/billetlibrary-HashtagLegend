using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLibrary
{
    public abstract class Køretøj
    {
        public string Nummerplade { get; set; }

        public DateTime Dato { get; set; }

        public Køretøj(string nummerplade, DateTime dato)
        {
            Nummerplade = nummerplade;
            Dato = dato;
        }

        /// <summary>
        /// Returnere prisen på en overkørsel
        /// </summary>
        /// <returns></returns>
        public abstract decimal Pris();

        /// <summary>
        /// Retunerer en default køretøjstype, skal overrides i en specialiseret klasse
        /// </summary>
        /// <returns></returns>
        public virtual string Køretøjstype()
        {
            return "Køretøj";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Hundlista.models
{
    class Hund
    {
        public Hund(string inNamn, string inHundras, int inÅlder)
        {
            namn = inNamn;
            hundras = inHundras;
            ålder = inÅlder;
        }

        private string namn;
        public string Namn
        {
            get { return namn; }
        }

        private string hundras;
        public string Hundras
        {
            get { return hundras; }
        }

        private int ålder;
        public int Ålder
        {
            get { return ålder; }
        }

    }
}

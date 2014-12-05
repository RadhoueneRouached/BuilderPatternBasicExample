using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace $safeprojectname$
{
    public class $safeprojectname$
    {
        private double debit;
        private string support;
        private int maxPorte;


        public void setDebit(double debit) { this.debit = debit; }
        public void setSupport(string support) { this.support = support; }
        public void setMaxPorte(int maxPorte) { this.maxPorte = maxPorte; }


        public void Informations()
        {
            Console.WriteLine("Resaux --> " +"Debit :"+ debit+"Mbs" + ", " +
                "Support:" + support + ", " + "Porté Maximale :" + maxPorte + "m");
        }
    }
}

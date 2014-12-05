using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace $safeprojectname$
{
    class MonteurFilaire : MonteurReseau
    {
        public override void monteurDebit()
        {
            reseau.setDebit(42.27);
           
        }

        public override void monteurSupport()
        {
            reseau.setSupport("router");
           
        }

        public override void monteurMaxPorte()
        {
            reseau.setMaxPorte(100);
            
        }
    }
}

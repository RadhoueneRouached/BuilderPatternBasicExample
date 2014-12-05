using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace $safeprojectname$
{
    class MonteurSansFil : MonteurReseau

    {


        public override void monteurDebit()
        {
            reseau.setDebit(2.01);
         
        }

        public override void monteurSupport()
        {
            reseau.setSupport("Ondes hertziennes");
            
        }

        public override void monteurMaxPorte()
        {
            reseau.setMaxPorte(10);
            
        }
    }
}

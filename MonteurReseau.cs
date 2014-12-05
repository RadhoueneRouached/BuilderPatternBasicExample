using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace $safeprojectname$
{
    public abstract class MonteurReseau
    {

        public $safeprojectname$ reseau;

        public $safeprojectname$ getReseau() { return reseau; }
        public void creerNouvelleReseau() { reseau = new $safeprojectname$(); }

        public abstract void monteurDebit();
        public abstract void monteurSupport();
        public abstract void monteurMaxPorte();

        
    }
}

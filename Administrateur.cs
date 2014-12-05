using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace $safeprojectname$
{
    class Administrateur
    {
        private MonteurReseau monteurReseau;

        public void setMonteurReseau(MonteurReseau m) { monteurReseau = m; }
        public $safeprojectname$ getReseau() { return monteurReseau.getReseau();}

        public void construireReseau()
        {
            monteurReseau.creerNouvelleReseau();
            monteurReseau.monteurDebit();
            monteurReseau.monteurSupport();
            monteurReseau.monteurMaxPorte();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace $safeprojectname$
{
    class Programme
    {
        static void Main(string[] args)
        {
            Administrateur admin = new Administrateur();
            MonteurReseau monteurSansFil = new MonteurSansFil();
            MonteurReseau monteurFilaire = new MonteurFilaire();


            admin.setMonteurReseau(monteurSansFil);
          
            admin.construireReseau();

            $safeprojectname$ reseau = admin.getReseau();
            


            reseau.Informations();
            Console.ReadKey();
        }
    }
}

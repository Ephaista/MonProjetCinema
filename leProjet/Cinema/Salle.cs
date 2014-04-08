using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cinema
{
    class Salle
    {

        // Attributs
        private int nbPlace;
        private int nbPlaceTarifNormal;
        private int nbPlaceTarifReduit;
        private double pourcentageReduction;
        private double prix;

        public double chiffreDAffaire()
        {
            double chiffre=0;
            double placeTarifNormal = nbPlaceTarifNormal * prix;
            double placeTarifReduit = nbPlaceTarifReduit * (prix-(prix * (pourcentageReduction/100)));
            chiffre = placeTarifNormal + nbPlaceTarifReduit;
            return chiffre;
        }

        public double tauxDeRemplissage()
        {
            double taux = 0;

            return taux;
        }

    }
}

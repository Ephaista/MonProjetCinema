using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cinema
{
    class Salle : Film
    {

        // Attributs
        private int nbPlace;
        private int nbPlaceTarifNormal;
        private int nbPlaceTarifReduit;
        private double pourcentageReduction;
        private double prix;

        // Constructeur

        public Salle(int unNbPlace, int unNbPlaceTarifNormal, int unNbPlaceTarifReduit, double unPourcentageReduction, double unPrix, string uneAffiche, string unNom) :base(uneAffiche, unNom)
        {
            this.nbPlace = unNbPlace;
            this.nbPlaceTarifNormal = unNbPlaceTarifNormal;
            this.nbPlaceTarifReduit = unNbPlaceTarifReduit;
            this.pourcentageReduction = unPourcentageReduction;
            this.prix = unPrix;
        }

        // Méthodes

        public void remiseAZero()
        {


        }

        public double chiffreDAffaire()
        {
            double chiffre = 0;
            double placeTarifNormal = nbPlaceTarifNormal * prix;
            double placeTarifReduit = nbPlaceTarifReduit * (prix - (prix * (pourcentageReduction / 100)));
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

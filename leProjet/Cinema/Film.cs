using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cinema
{
    class Film
    {
        private string affiche;
        private string nom;
        public Film(string uneAffiche, string unNom)
        {
            this.affiche = uneAffiche;
            this.nom = unNom;
        }
        public string getAffiche()
        {
            return this.affiche;
        }
        public string getNom()
        {
            return this.nom;
        }
        public void setAffiche(string uneAffiche)
        {
            this.affiche = uneAffiche;
        }
        public void SetNom(string unNom)
        {
            this.nom = unNom;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cinema
{
    class Film
    {
        private string titre;
        private string resume;
        public Film(string unTitre, string unResume)
        {
            this.titre = unTitre;
            this.resume = unResume;
        }
        public string getTitre()
        {
            return this.titre;
        }
        public string getResume()
        {
            return this.resume;
        }
        public void setTitre(string unTitre)
        {
            this.titre = unTitre;
        }
        public void setResume(string unResume)
        {
            this.resume = unResume;
        }
    }
}

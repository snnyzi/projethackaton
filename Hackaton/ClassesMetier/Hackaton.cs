using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackaton
{
    public class Hackaton
    {
        private int id;
        private string theme;
        private string nomLieu;
        private string ville;
        private DateTime dateHeureDebut;
        private DateTime dateHeureFin;
        private int nbPlacesMax;
        private DateTime dateLimiteAjoutDefi;
        private DateTime LimiteInscription;

        public Hackaton(int id, string theme, string nomLieu, string ville, DateTime dateHeureDebut, DateTime dateHeureFin, int nbPlacesMax, DateTime dateLimiteAjoutDefi, DateTime limiteInscription)
        {
            this.id = id;
            this.theme = theme;
            this.nomLieu = nomLieu;
            this.ville = ville;
            this.dateHeureDebut = dateHeureDebut;
            this.dateHeureFin = dateHeureFin;
            this.nbPlacesMax = nbPlacesMax;
            this.dateLimiteAjoutDefi = dateLimiteAjoutDefi;
            LimiteInscription = limiteInscription;
        }

        public override string ToString()
        {
            return(this.id.ToString() + " " + this.theme + " " + nomLieu + " " + ville + " " + dateHeureDebut + " " + 
                dateHeureFin + " " + nbPlacesMax + " " + dateLimiteAjoutDefi + " " + LimiteInscription);
        }
    }
}

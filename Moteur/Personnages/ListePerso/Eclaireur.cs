using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moteur.Plateau;
using Moteur.Personnages.Objectif;
using Moteur.Observateur;

namespace Moteur.Personnages.ListePerso
{
    [Serializable]
    public class Eclaireur : Personnage
    {
        public Eclaireur(ZoneAbstraite position, string nom,Organisation organisation,eObjectif objectif )
            : base(position, nom,organisation,objectif)
        {
            Random vie = new Random();
            this.Sante = vie.Next(50);
            this.Attaque = vie.Next(10, 30);
            this.Defense = vie.Next(40, 60);
        }


        #region Methode

        #endregion
    }
}

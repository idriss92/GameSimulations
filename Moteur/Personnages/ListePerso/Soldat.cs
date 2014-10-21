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
    public class Soldat : Personnage
    {
        PlateauDeJeu plateau = new PlateauDeJeu();
        public Soldat(ZoneAbstraite position, string nom, Organisation organisation, eObjectif objectf) 
            : base(position,nom, organisation,objectf)
        {
            Random rand = new Random();
            this.Sante = rand.Next(70);
            this.Attaque = rand.Next(40, 60);
            this.Defense = rand.Next(40, 60);
        }

        

        #region Methode

        #endregion
    }
}

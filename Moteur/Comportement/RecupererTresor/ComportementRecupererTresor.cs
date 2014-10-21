using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moteur.Objet;
using Moteur.Personnages;

namespace Moteur.Comportement.RecupererTresor
{
    public  class ComportementRecupererTresor
    {
        public void Ramasser(Personnage perso,params ObjetTresorNonOffensif [] tresor)
        {
            foreach (var i in tresor)
            {
                perso.mesTresors.Add(i);
            }
        }


        public void VolerAdversaire(Personnage voleur, Personnage proprio)
        {
            foreach (var i in proprio.mesTresors)
            {
                voleur.mesTresors.Add(i);
            }
        }

    }
}

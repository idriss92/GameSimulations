using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moteur.Personnages;
using Moteur.Objet;

namespace Moteur.Comportement.Combat
{
    public abstract class ComportementCombat
    {
        public virtual string Combattre()
        {
            return "Action de combat";
        }

        public abstract void Attaquer(Personnage cible, Personnage source);
        
        public abstract void RecevoirDegat(Personnage source, Personnage cible);

        public abstract void AttaquerObjet(ObjetAbstrait cible, Personnage source);

        public abstract void RecevoirDegatObjet(Personnage cible, ObjetAbstrait source);

    }
}

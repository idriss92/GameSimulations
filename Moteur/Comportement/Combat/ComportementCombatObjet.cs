using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moteur.Personnages;
using Moteur.Objet;

namespace Moteur.Comportement.Combat
{
    public abstract class ComportementCombatObjet
    {
        public abstract void Attaquer(Personnage cible, ObjetAbstrait source );

        public abstract void RecevoirDegat(ObjetAbstrait cible, Personnage source);
    }
}

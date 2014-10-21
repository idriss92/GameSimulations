using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moteur.Personnages.Type;
using Moteur.Observateur;
using Moteur.Plateau;
using Moteur.Personnages.Objectif;

namespace Moteur.Personnages
{
    public abstract class FactoryPersonnage
    {
        public virtual Personnage CreatePersonnage(ePersonnage personnage, Organisation organisation, string nom, Zone position, eObjectif objectif)
        {
            return null;
        }
    }
}

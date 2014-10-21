using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moteur.Objet.type;
using Moteur.Objet;
using Moteur.Observateur;
using Moteur.Plateau;

namespace Moteur.Objet
{
    public abstract class FactoryObjet
    {
        public virtual ObjetMere CreateObjet(eObjet objet, Organisation organisation, string nom, Zone position)
        {
            return null;
        }
    }
}

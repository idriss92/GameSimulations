using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moteur.Personnages.Type;
using Moteur.Personnages;
using Moteur.Observateur;
using Moteur.Personnages.ListePerso;
using Moteur.Plateau;
using Moteur.Personnages.Objectif;


namespace Moteur.Personnages
{
    public class FactoryPersonnageBattleField : FactoryPersonnage
    {
        public override Personnage CreatePersonnage(ePersonnage personnage,Organisation organisation, string nom,Zone position,eObjectif objectif )
        {
            switch (personnage)
            {
                case ePersonnage.eclaireur :
                    return new Eclaireur(position, nom,organisation,objectif);
                case ePersonnage.soldat :
                    return new Soldat(position, nom,organisation,objectif);
                default :
                    return null;
            }
        }
    }
}

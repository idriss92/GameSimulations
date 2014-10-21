using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moteur.Observateur;
using Moteur.Objet.type;
using Moteur.Plateau;
using Moteur.Objet.ListeObjet;


namespace Moteur.Objet
{
    public class FactoryObjetBattleField : FactoryObjet
    {
        public override ObjetMere CreateObjet(eObjet objet, Organisation organisation, string nom, Zone position)
        {
            switch (objet)
            {
                case eObjet.argent :
                    return new Argent(position,nom);
                case eObjet.bombe:
                    return new Bombe(position, nom);
                case eObjet.chardassaud :
                    return new CharDassaut(position, nom, organisation);
                case eObjet.helico :
                    return new Helico(position, nom, organisation);
                case eObjet.labase :
                    return new Base(organisation, position, nom);
                case eObjet.or :
                    return new Or(position, nom);
                case eObjet.tour :
                    return new Tour(position, nom, organisation);
                case eObjet.troumortel :
                    return new TrouMortel(position, nom);
                case eObjet.trouretention :
                    return new TrouRetention(position, nom);
                default :
                    return null;
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moteur.Personnages.Type;
using Moteur.Personnages.ListePerso;
using Moteur.Plateau;
using Moteur.Personnages;
using Moteur.Personnages.Objectif;

namespace Moteur.Comportement.Deplacement
{
    public  class ComportementDeplacementHumain
    {
        public void Deplacer(ZoneAbstraite position, Personnage personnage, PlateauDeJeuAbstrait plateau)
        {

            if (plateau.ZoneList.Contains(position) && personnage.Position != position)
            {
                foreach (var p in plateau.AccesList)
                {
                    if (p.listZoneAcces.Contains(position) && p.listZoneAcces.Contains(personnage.Position))
                    {
                        personnage.Position = position;
                        break;
                    }                    
                }
            }
        }

        public void DeplacerAvecObjectif(ZoneAbstraite position, Personnage personnage, eObjectif objectif)
        {
            switch (objectif)
            {

            }
        }
    }
}

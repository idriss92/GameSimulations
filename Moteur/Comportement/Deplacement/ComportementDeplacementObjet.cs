using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moteur.Personnages;
using Moteur.Plateau;
using Moteur.Objet;

namespace Moteur.Comportement.Deplacement
{
    public class ComportementDeplacementObjet
    {
        public void Deplacer(ZoneAbstraite position, ObjetAbstrait objet)
        {
            objet.Position = position;
        }
    }
}

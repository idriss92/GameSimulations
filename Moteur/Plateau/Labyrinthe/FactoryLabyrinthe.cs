using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moteur.Plateau.Labyrinthe
{
    public class FactoryLabyrinthe : FactoryEnvironnementDeJeu
    {
        public override EnvironnementDeJeu CreateEnvironnementDeJeu()
        {
            return new Labyrinthe();
        }
    }
}

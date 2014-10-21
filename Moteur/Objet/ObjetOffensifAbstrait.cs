using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moteur.Plateau;
using Moteur.Comportement.Combat;
using Moteur.Observateur;

namespace Moteur.Objet
{
    public abstract class ObjetOffensifAbstrait : ObjetMere
    {
        #region Propriétés
        public Organisation Organisation { get; set; }
        public ComportementCombatObjet ComportementCombatObjet { get; set; }
        public int PointDeVie { get; set; }
        public int Attaque { get; set; }
        public int Defense { get; set; }

        #endregion
    }
}

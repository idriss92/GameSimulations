using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moteur.Plateau;
using Moteur.Personnages;
using Moteur.Comportement.Combat;

namespace Moteur.Objet
{
    public abstract class ObjetAbstrait
    {
        #region Propriétés
        public ZoneAbstraite Position { get;  set; }
        public ComportementCombatObjet ComportementCombatObjet { get; set; }
        public string Nom { get; private set; }
        public int PointDeVie { get; set; }

        public int Attaque { get; set; }
        public int Defense { get; set; }
        #endregion
       

        #region Constructeur
        public ObjetAbstrait(ZoneAbstraite position, string nom)
        {
            Random vie = new Random();
            this.PointDeVie = vie.Next(100);
            this.Position = position;
            this.Nom = nom;

        }
        #endregion

    }
}

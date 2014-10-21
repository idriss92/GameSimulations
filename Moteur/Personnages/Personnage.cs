using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moteur.Comportement.Combat;
using Moteur.Personnages.Objectif;
using Moteur.Plateau;
using Moteur.Objet.type;
using Moteur.Personnages.ListePerso;
using  System.Xml.Serialization;
using Moteur.Observateur;
using Moteur.Objet;
using Moteur.Comportement.RecupererTresor;
using Moteur.Comportement.Deplacement;

namespace Moteur.Personnages
{
    [Serializable , XmlInclude(typeof(Eclaireur)), XmlInclude(typeof(Soldat))]
    public abstract class Personnage
    {
        #region Propriétés
        public List<ObjetTresorNonOffensif> mesTresors;
        public Organisation Organisation { get; set; }
        public ZoneAbstraite Position { get; set; }

        public eObjectif MainObjectif { get; set; }
        
        public eObjet Objet { get; set; }
        
        public string Nom { get; set; }
        

        public int Sante { get; set; }
        

        public int Attaque { get; set; }

        public int Defense { get; set; }
        public ComportementCombat comportementCombat { get; set; }
        public ComportementRecupererTresor comportementRecupererTresor { get; set; }
        public ComportementDeplacementHumain comportementDeplacemement { get; set; }

        #endregion
        public Personnage(ZoneAbstraite position, string nom, Organisation organisation, eObjectif objectif)
        {
            this.mesTresors = new List<ObjetTresorNonOffensif>();
            this.Organisation = organisation;
            this.Nom = nom;
            this.Position = position;
            this.MainObjectif = objectif;
        }


        #region Methode

        #endregion
    }
}

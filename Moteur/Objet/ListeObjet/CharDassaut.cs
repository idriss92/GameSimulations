using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moteur.Plateau;
using Moteur.Observateur;

namespace Moteur.Objet.ListeObjet
{
    public class CharDassaut : ObjetOffensifAbstrait
    {
        public CharDassaut(ZoneAbstraite position, string nom,Organisation organisation)
        {
            Random rand = new Random();
            this.PointDeVie = rand.Next(40, 100);
            this.Attaque = rand.Next(40, 100);
            this.Defense = rand.Next(40, 100);
            this.Position = position;
            this.Nom = nom;
            this.Organisation = organisation;
        }
    }
}

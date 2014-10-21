using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moteur.Observateur;
using Moteur.Plateau;
namespace Moteur.Objet.ListeObjet
{
    public class Tour : ObjetOffensifAbstrait
    {
        public Tour(ZoneAbstraite position, string nom,Organisation organisation)
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

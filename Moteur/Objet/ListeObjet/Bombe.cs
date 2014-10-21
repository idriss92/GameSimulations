using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moteur.Plateau;
using Moteur.Observateur;


namespace Moteur.Objet.ListeObjet
{
    public class Bombe : ObjetOffensifAbstrait
    {
        public Bombe(ZoneAbstraite position, string nom)
        {
            Random rand = new Random();
            this.PointDeVie = rand.Next(40, 100);
            this.Attaque = rand.Next(40, 100);
            this.Defense = rand.Next(40, 100);
            this.Position = position;
            this.Nom = nom;
        }
    }
}

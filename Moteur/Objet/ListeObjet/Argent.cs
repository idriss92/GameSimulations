using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moteur.Plateau;

namespace Moteur.Objet.ListeObjet
{
    public class Argent : ObjetTresorNonOffensif
    {
        public int Quantité { get; set; }
        public Argent(ZoneAbstraite position, string nom)
        {
            Random rand = new Random();
            this.Position = position;
            this.Nom = nom;
            this.Quantité = rand.Next(-1, 100);
            this.PointDeVie = 100;

        }
    }
}

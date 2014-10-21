using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moteur.Plateau;


namespace Moteur.Objet.ListeObjet
{
    public class TrouRetention : ObjetTresorNonOffensif
    {
        public int NombreTr { get; set; }

        public TrouRetention(ZoneAbstraite position, string nom)
        {
            Random rand = new Random();
            this.NombreTr = rand.Next(1, 9);
            this.Defense = rand.Next(40, 100);
            this.Position = position;
            this.Nom = nom;
        }
    }
}

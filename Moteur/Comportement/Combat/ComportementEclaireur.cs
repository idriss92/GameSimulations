using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moteur.Personnages;
using Moteur.Objet;

namespace Moteur.Comportement.Combat
{
    public class ComportementEclaireur : ComportementCombat
    {

        public override void Attaquer(Personnage cible, Personnage source)
        {
            cible.comportementCombat.RecevoirDegat(source, cible);

            Console.WriteLine("{0} a attaqué {1}",source.Nom,cible.Nom);
        }

        public override void RecevoirDegat(Personnage source, Personnage cible)
        {
            if (source.Attaque > cible.Defense)
            {
                Console.WriteLine("{0} a perdu {1} de points de vie", cible.Nom, source.Attaque / cible.Defense);
                cible.Sante = cible.Sante - (source.Attaque / cible.Defense);
            }
        }

        public override void AttaquerObjet(ObjetAbstrait cible, Personnage source)
        {
            cible.ComportementCombatObjet.RecevoirDegat(cible, source);
            Console.WriteLine("{0} a attaqué {1}", source.Nom, cible.Nom);
        }

        public override void RecevoirDegatObjet(Personnage cible, ObjetAbstrait source)
        {
            if (source.Attaque > cible.Defense)
            {
                Console.WriteLine("{0} a perdu {1} de points de vie", cible.Nom, source.Attaque / cible.Defense);
                cible.Sante = cible.Sante - (source.Attaque / cible.Defense);
            }
        }

    }
}

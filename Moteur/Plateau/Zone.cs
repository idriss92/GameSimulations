using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moteur.Personnages;
using Moteur.Objet;
namespace Moteur.Plateau
{
    public class Zone : ZoneAbstraite
    {
        List<Personnage> listPerso;
        //List<AccesAbstrait> listAcces;
        List<ObjetAbstrait> listObjet;

        public Zone()
        {
            listObjet = new List<ObjetAbstrait>();
            listPerso = new List<Personnage>();
        }
    }
}

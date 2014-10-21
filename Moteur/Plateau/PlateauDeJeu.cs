using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moteur.Plateau
{
    public class PlateauDeJeu : PlateauDeJeuAbstrait
    {

        public override void AjouterAcces(params AccesAbstrait [] acces)
        {
            foreach (var p in acces)
            {
                this.AccesList.Add(p);
            }
        }

        public override void AjouterZone(params ZoneAbstraite [] zone)
        {
            foreach (var p in zone)
            {
                this.ZoneList.Add(p);
            }
        }
    }
}

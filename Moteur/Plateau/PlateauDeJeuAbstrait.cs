using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moteur.Plateau
{
    public abstract class PlateauDeJeuAbstrait
    {
        public List<AccesAbstrait> AccesList;
        public List<ZoneAbstraite> ZoneList;

        public PlateauDeJeuAbstrait ()
    	{
            AccesList = new List<AccesAbstrait>();
            ZoneList = new List<ZoneAbstraite>();
	    }

        public  abstract void AjouterAcces(params AccesAbstrait [] acces);
        public  abstract void AjouterZone(params ZoneAbstraite [] zone);
    }
}

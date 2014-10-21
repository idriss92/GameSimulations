using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moteur.Plateau
{
    public abstract class AccesAbstrait
    {
        public List<ZoneAbstraite> listZoneAcces;

        public AccesAbstrait()
        {
            listZoneAcces = new List<ZoneAbstraite>();
        }
    }
}

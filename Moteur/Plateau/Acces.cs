using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moteur.Plateau
{
    public class Acces : AccesAbstrait
    {


        public void AccesAuZone(params ZoneAbstraite[] zones)
        {
            for (int i = 0; i < zones.Length; i++)
            {
                listZoneAcces.Add(zones[i]);
            }
        }
    }
}

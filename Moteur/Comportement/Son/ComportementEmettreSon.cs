using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moteur.Comportement.Son
{
    public abstract class ComportementEmettreSon
    {
        public virtual string EmettreSon()
        {
            return "Emission de son";
        }
    }
}

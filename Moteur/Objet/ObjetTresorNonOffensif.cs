using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moteur.Objet
{
    public abstract class ObjetTresorNonOffensif : ObjetMere
    {
        #region Propriétés
        public int PointDeVie { get; set; }
        public int Defense { get; set; }

        #endregion

    }
}

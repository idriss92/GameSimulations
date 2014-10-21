using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moteur.Plateau;

namespace Moteur.Objet
{
    public abstract class ObjetMere
    {
        #region Propriétés
        public ZoneAbstraite Position { get; protected set; }
        public string Nom { get; protected set; }

        #endregion
    }
}

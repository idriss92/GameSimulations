using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moteur.Observateur
{
    public class Organisation
    {
        private string nomOrganisation;
        private ModeFonctionnement modeFonction;
        public string NomOrganisation { get; set; }
        public ModeFonctionnement ModeFonction { get; set; }

        public Organisation()
        {
            this.modeFonction = ModeFonctionnement.innactif;
        }

        public Organisation(string nom, ModeFonctionnement fonctionnement)
        {
            this.nomOrganisation = nom;
            this.modeFonction = fonctionnement;
        }

        public ModeFonctionnement getMode()
        {
            return modeFonction;
        }
    }
}

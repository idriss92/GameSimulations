using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moteur.Observateur
{
    public class SujetObservateurAbstrait
    {
        private List<ObservateurAbstrait> listeObservateur;

        public SujetObservateurAbstrait()
        {
            listeObservateur = new List<ObservateurAbstrait>();
        }

        void Attach(ObservateurAbstrait unObservateur)
        {
            listeObservateur.Add(unObservateur);
        }
        void Dettach(ObservateurAbstrait unObservateur)
        {
            listeObservateur.Remove(unObservateur);
        }

        void Update()
        {
            listeObservateur.ForEach(c => c.Update());
        }
    }
}

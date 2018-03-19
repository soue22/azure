using BoVoyage.BOL;
using BoVoyage.UIL.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BoVoyage.UIL.Controllers
{
    public class VoyageController : ApiController
    {
        private Repository Context = new Repository();
        public IEnumerable<Continent> GetAllContinents()
        {
            ArrayList liste = Context.GetAllContinents();
            List<Continent> listeContinents = new List<Continent>();
            for(int i=0;i<listeContinents.Count; i += 2)
            {
                listeContinents.Add(new Continent { id = int.Parse(liste[i].ToString()), nom = liste[i + 1].ToString() });
            }
            return listeContinents;
        }
    }//On aura a définir d'autres modèles
}

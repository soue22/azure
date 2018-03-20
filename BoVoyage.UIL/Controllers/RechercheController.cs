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
    public class RechercheController : ApiController
    {
        private Repository Context = new Repository();
        public IEnumerable<Continent> GetAllContinents()
        {
            ArrayList liste = Context.GetAllContinents();
            List<Continent> listeContinents = new List<Continent>();
            for (int i = 0; i < liste.Count; i += 2)
            {
                listeContinents.Add(new Continent { id = int.Parse(liste[i].ToString()), nom = liste[i + 1].ToString() });
            }
            return listeContinents;
        }
        public IEnumerable<Pays> POSTallPays(int id)
        {

            ArrayList liste = Context.POSTallPays(id);
            List<Pays> listePays = new List<Pays>();
            for (int i = 0; i < liste.Count; i += 2)
            {
                listePays.Add(new Pays { id = int.Parse(liste[i].ToString()), nom = liste[i + 1].ToString() });
            }
            return listePays;
        }
        public IEnumerable<Regions> PutallRegions(int id)
        {

            ArrayList liste = Context.PutallRegions(id);
            List<Regions> listeRegions = new List<Regions>();
            for (int i = 0; i < liste.Count; i += 2)
            {
                listeRegions.Add(new Regions { id = int.Parse(liste[i].ToString()), nom = liste[i + 1].ToString() });
            }
            return listeRegions;
        }

    }//On aura a définir d'autres modèles
}

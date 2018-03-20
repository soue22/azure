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
            for(int i=0;i<liste.Count; i += 2)
            {
                listeContinents.Add(new Continent { id = int.Parse(liste[i].ToString()), nom = liste[i + 1].ToString() });
            }
            return listeContinents;
        }
        public IEnumerable<Pays> GetAllPays(int id)
        {

            ArrayList liste = Context.GetAllPays(id);
            List<Pays> listePays = new List<Pays>();
            for (int i = 0; i < liste.Count; i += 2)
            {
                listePays.Add(new Pays { id = int.Parse(liste[i].ToString()), nom = liste[i + 1].ToString() });
            }
            return listePays;
        }

        //public IEnumerable<Pays> GetAllRegions(int id)
        //{

        //    ArrayList liste = Context.GetAllRegions(id);
        //    List<Pays> listePays = new List<Pays>();
        //    for (int i = 0; i < liste.Count; i += 2)
        //    {
        //        listePays.Add(new Pays { id = int.Parse(liste[i].ToString()), nom = liste[i + 1].ToString() });
        //    }
        //    return listePays;
        //}




    }//On aura a définir d'autres modèles
}

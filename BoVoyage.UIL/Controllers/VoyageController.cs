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
            for(int i=0;i<liste.Count; i += 2)
            {
                listeContinents.Add(new Continent { id = int.Parse(liste[i].ToString()), nom = liste[i + 1].ToString() });
            }
            return listeContinents;
        }
        public IEnumerable<Pays> GetAllPays([FromBody] string nomcontinent)
        {
            ArrayList liste = Context.GetAllPays();
            List<Pays> listePays = new List<Pays>();
            for (int i = 0; i < liste.Count; i += 2)
            {
                listePays.Add(new Pays { id = int.Parse(liste[i].ToString()), nom = liste[i + 1].ToString() });
            }
            return listePays;
        }
       


        //public IEnumerable<Pays> GetAllPays()
        //{
        //    ArrayList liste = Context.GetAllPays();
        //    List<Pays> listPays = new List<Pays>();
        //    for(int i=0;i<listPays.Count;i += 2)
        //    {
        //        listPays.Add(new Pays { id = int.Parse(liste[i].ToString()), nom = liste[i + 1].ToString() });
        //    }
        //    return listPays;
        //}
    }//On aura a définir d'autres modèles
}

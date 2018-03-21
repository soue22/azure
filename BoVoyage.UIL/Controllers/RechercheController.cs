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
        public IEnumerable<Regions> PutallRegions(int idPays)
        {

            ArrayList liste = Context.PutallRegions(idPays);
            List<Regions> listeRegions = new List<Regions>();
            if (liste != null)
            {
                for (int i = 0; i < liste.Count; i += 2)
                {
                    listeRegions.Add(new Regions { id = int.Parse(liste[i].ToString()), nom = liste[i + 1].ToString() });
                }
                return listeRegions;
            }
            else
            {
                return null;
            }
        }
        public IEnumerable<Voyage> GetAllVoyages(int id)
        {
            ArrayList liste = Context.GetAllVoyages(id);
            List<Voyage> listeVoyage = new List<Voyage>();
            if (liste != null)
            {
                for (int i = 0; i < liste.Count; i += 5)
                {
                   listeVoyage.Add(new Voyage { id = int.Parse(liste[i].ToString()), titre = liste[i + 1].ToString(),
                       nomImage = liste[i + 2].ToString(), description = liste[i + 3].ToString(), prix = int.Parse(liste[i + 4].ToString()) });
            
                    }
                return listeVoyage;
            }
            else return null;
        }
        public IEnumerable<Voyage> PostAllVoyagesByContinent([FromUri]int idPays)
        {
            ArrayList liste = Context.PostAllVoyagesByContinent(idPays);
            List<Voyage> listeVoyage = new List<Voyage>();
            if (liste != null)
            {
                for (int i = 0; i < liste.Count; i += 5)
                {
                    listeVoyage.Add(new Voyage
                    {
                        id = int.Parse(liste[i].ToString()),
                        titre = liste[i + 1].ToString(),
                        nomImage = liste[i + 2].ToString(),
                        description = liste[i + 3].ToString(),
                        prix = int.Parse(liste[i + 4].ToString())
                    });

                }
                return listeVoyage;
            }
            else return null;
        }
        public IEnumerable<Voyage> GETAllVoyagesByPays(int idRegions)
        {
            ArrayList liste = Context.GETAllVoyagesByPays(idRegions);
            List<Voyage> listeVoyage = new List<Voyage>();
            if (liste != null)
            {
                for (int i = 0; i < liste.Count; i += 5)
                {
                    listeVoyage.Add(new Voyage
                    {
                        id = int.Parse(liste[i].ToString()),
                        titre = liste[i + 1].ToString(),
                        nomImage = liste[i + 2].ToString(),
                        description = liste[i + 3].ToString(),
                        prix = int.Parse(liste[i + 4].ToString())
                    });

                }
                return listeVoyage;
            }
            else return null;
        }

    }//On aura a définir d'autres modèles
}

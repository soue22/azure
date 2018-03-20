using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BoVoyage.UIL.Models
{
    public class Continent
    {
        public int id; 
        public string nom;

        List<Pays> listPays;
        List<Voyages> listVoyages;
    }
    public class Voyages
    {
        public int id;
    }
}
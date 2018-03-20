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
        public IEnumerable<Voyage> GetAllVoyages(int idVoyage)
        {
            ArrayList liste = Context.GetAllVoyages(idVoyage);
            return null;
        }
    }
}

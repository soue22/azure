using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoVoyage.BOL
{
    public class Repository
    {
        public ArrayList GetAllContinents()
        {
            return new ArrayList {
                1, "Afrique",
                2, "Amérique",
                3, "Asie",
                4, "Europe",
                5, "Océanie"
            };
        }
        
        public ArrayList GetAllPays()
        {
            return new ArrayList
              {
                    11, "Côte D'Ivoire",
                    12, "Égypte",
                    21, "Afrique2",
                    22, "Afrique3",
                   
                    //Bon après ici, j'sais pas trop quoi faire, comment on peut lier les continents aux pays? Erf erf
            };
        }
    }
}


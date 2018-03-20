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

        public ArrayList GetAllPays(int id)
        {
            switch (id)

            {
                case 1:

                    return new ArrayList
              {
                    11,"Côte D'Ivoire",
                    12, "Égypte" };

                case 2:

                    return new ArrayList
                    {
                        21, "gfgfgfgf",
                        22, "gfgfgfggf",
                    };
                default: return null;
            }
            
        }







            public ArrayList GetAllVoyages()

        {
            return new ArrayList
            {
                 1311, "Liste de tous les voyages dispo",
                 2354, "Séjour pas cher en Floride \t 400 euros\t 5 places",
                 2355, "Séjour pas cher en Texas \t 400 euros\t 5 places",
                        
            };
        }
    }
}


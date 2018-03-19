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

        //    public ArrayList GetAllPays()
        //    {
        //        return new ArrayList
        //        {
        //            1, "Côte D'Ivoire",
        //            2, "Égypte",
        //            3, "Afrique",
        //            4, "Afrique",
        //            5, "Afrique",
        //            6, "Afrique",
        //            7, "Afrique"
        //        }
        //    }
        //}
    }
}

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
                4, "Afrique",
                2, "Asie",
                1, "Amérique",
                3, "Europe",
                5, "Océanie"
            };
        }

        public ArrayList GetAllVoyages(int idVoyage)
        {
            switch (idVoyage)
            {
                case 0:
                    return new ArrayList{

                        2354, "Séjour pas cher en Floride" ,
                        2355, "Séjour pas cher en Texas",
                        2221, " Quebec en dernière minute",
                        2222, " Montreal en 3 jours",
                        5001, "Plongée sous marine à Cancun",
                        5012, "Séjour Mexico derniéres places",
                        5002, " Séjour pas cher à Santa Cruz",
                        5022, "  Séjour de reve à Buenos Aires",
                        5003, "Phuket et ses iles paradisiaques",
                        5004, " Profitez des Cascades à  Bangkok",
                        50024, "Sable blanc des iles de Kuala Lampur",
                        50025, "Derniéres minutes pour un séjour à Ipoh",
                        5005, " Escale à Tokyo",
                        5015, " Voyage à Okazaki",
                        5006, "Séjour dernière  minute à Delhi",
                        5016, "Séjour dernière  minute à Mumbai",
                        50017, "Spa et Thalasso en Bretagne",
                        50027, "Weekend dans le Var",
                        5008, "Douceur de  Florence",
                        5018, "Visitez Pompei à partir de Naples",
                        5009, "Départ Immediat à Barcelone",
                        5039, "Carnaval à seville",
                        50014, " Sejour pas cher a Bruxelles",
                        50034, " Sejour pas cher a Bruges",
                        50010, "venez profiter du soleil de Marrakech",
                        50045, "Belles plage de Hurgada ",
                        50011, " Séjour pas cher à Dakar",
                        50041, " Séjour pas cher à Dahra",
                        50012, " Djerba plages et sable fin",
                        50312, " Tunis Pas cher",
                        50013, "Safari unique Johannesburg",
                        50435, "Safari unique Le Cap",
                        50236,"Decouverte de Bora Bora",
                        523654,"Traverser des payasages extraordinaires en nouvelle zelande",
                    };

                case 001:
                    return new ArrayList {
                       2354, "Séjour pas cher en Floride" ,
                        2355, "Séjour pas cher en Texas",
                        2221, " Quebec en dernière minute",
                        2222, " Montreal en 3 jours",
                        5001, "Plongée sous marine à Cancun",

                    };

                case 002:
                    return new ArrayList
                {
                    5001, "Plongée sous marine à Cancun",
                        5012, "Séjour Mexico derniéres places",
                        5002, " Séjour pas cher à Santa Cruz",
                        5022, "  Séjour de reve à Buenos Aires",
                        5003, "Phuket et ses iles paradisiaques",
                        5004, " Profitez des Cascades à  Bangkok",
                        50024, "Sable blanc des iles de Kuala Lampur",
                        50025, "Derniéres minutes pour un séjour à Ipoh",
                        5005, " Escale à Tokyo",
                        5015, " Voyage à Okazaki",
                        5006, "Séjour dernière  minute à Delhi",
                        5016, "Séjour dernière  minute à Mumbai",

                    };

                case 003:
                    return new ArrayList
                {  50017, "Spa et Thalasso en Bretagne",
                        50027, "Weekend dans le Var",
                        5008, "Douceur de  Florence",
                        5018, "Visitez Pompei à partir de Naples",
                        5009, "Départ Immediat à Barcelone",
                        5039, "Carnaval à seville",
                        50014, " Sejour pas cher a Bruxelles",
                        50034, " Sejour pas cher a Bruges",

                    };

                case 004:
                    return new ArrayList
                {
                    50010, "venez profiter du soleil de Marrakech",
                        50045, "Belles plage de Hurgada ",
                        50011, " Séjour pas cher à Dakar",
                        50041, " Séjour pas cher à Dahra",
                        50012, " Djerba plages et sable fin",
                        50312, " Tunis Pas cher",
                        50013, "Safari unique Johannesburg",
                        50435, "Safari unique Le Cap",

                    };



                case 011:
                    return new ArrayList {
                        2354, "Séjour pas cher en Floride" ,
                        2355, "Séjour pas cher en Texas",
                    };

                case 12:
                    return new ArrayList {
                        2221, " Quebec en dernière minute",
                        2222, " Montreal en 3 jours",
                    };

                case 13:
                    return new ArrayList{
                         5001, "Plongée sous marine à Cancun",
                        5012, "Séjour Mexico derniéres places",
                    };

                case 14:
                    return new ArrayList {
                         5002, " Séjour pas cher à Santa Cruz",
                        5022, "  Séjour de reve à Buenos Aires",
                    };

                case 21:
                    return new ArrayList {
                 5003, "Phuket et ses iles paradisiaques",
                        5004, " Profitez des Cascades à  Bangkok",
                    };

                case 22:
                    return new ArrayList {
               50024, "Sable blanc des iles de Kuala Lampur",
                        50025, "Derniéres minutes pour un séjour à Ipoh",
                    };

                case 23:
                    return new ArrayList {
                         5005, " Escale à Tokyo",
                        5015, " Voyage à Okazaki",
                    };

                case 24:
                    return new ArrayList {
                 5006, "Séjour dernière  minute à Delhi",
                        5016, "Séjour dernière  minute à Mumbai",
                    };

                case 31:
                    return new ArrayList {
                50017, "Spa et Thalasso en Bretagne",
                        50027, "Weekend dans le Var",
                    };

                case 32:
                    return new ArrayList {
               5008, "Douceur de  Florence",
                        5018, "Visitez Pompei à partir de Naples",
                    };

                case 33:
                    return new ArrayList {
               5009, "Départ Immediat à Barcelone",
                        5039, "Carnaval à seville",
                    };

                case 34:
                    return new ArrayList {
                50010, "venez profiter du soleil de Marrakech",
                        50045, "Belles plage de Hurgada ",
                    };

                case 41:
                    return new ArrayList {
                50011, " Séjour pas cher à Dakar",
                        50041, " Séjour pas cher à Dahra",
                    };

                case 42:
                    return new ArrayList {
                50012, " Djerba plages et sable fin",
                        50312, " Tunis Pas cher",
                    };

                case 43:
                    return new ArrayList {
               50013, "Safari unique Johannesburg",
                        50435, "Safari unique Le Cap",
                    };

                case 55:
                    return new ArrayList
                {
                        50236,"Decouverte de Bora Bora",
                        523654,"Traverser des payasages extraordinaires en nouvelle zelande",
                    };



                default: return null;
            }
        }


        public ArrayList POSTallPays(int id)
        {
            switch (id)
            {
                case 4:
                    return new ArrayList
              {
                    11,"Côte D'Ivoire",
                    12,"Égypte",
                    13,"cap vert",
                    14,"Afrique du sud",
                    15,"Maroc" };
                case 2:
                    return new ArrayList
                    {

                    31,"Chine",
                    32,"Thailande",
                    33,"Inde",
                    34,"Les Maldives" };

                case 1:
                    return new ArrayList
                    {  21,"Canada",
                    22,"Mexique",
                    23,"Bresil",
                    24,"Chili"
                    };

                case 3:
                    return new ArrayList
                    {41,"France",
                    42,"Espagnol",
                    43,"Italie",
                    44,"Finlande"

                    };
                case 5:
                    return new ArrayList
                    {
                    51,"Tahiti",
                    52,"Nouvelle Calidonie",
                    53,"Nouvelle Zelande"
                    };
                default: return null;
            }
        }
        public ArrayList PutallRegions(int idPays)
        {
            switch (idPays)
            {
                case 11:
                    return new ArrayList
                    { 111, "Texas",
                      112, "Floride"
                };


                case 12:

                    return new ArrayList
                { 121, "Montreal",
                  122, "Quebec"};

                case 13:
                    return new ArrayList
                { 131, "Cancun",
                  132, "Mexico"};

                case 14:
                    return new ArrayList
                { 141, "SAnta Cruz" ,
                  142, "Buenos Aires"};

                case 21:
                    return new ArrayList
                { 211, "Bankok",
                 212, "Phuket"
                };

                case 22:
                    return new ArrayList
                { 221, "Kuala Lampur",
                  222, "Ipoh"
                };

                case 23:
                    return new ArrayList
                { 231, "Tokyo",
                  232, "Okazaki"
                };

                case 24:
                    return new ArrayList
                { 241, "Delhi",
                  242, "Mumbai"
                };

                case 31:
                    return new ArrayList
                {311, "Bretagne",
                 312, "Var"
                };

                case 32:
                    return new ArrayList
                {321, "Florence",
                322, "Naples"

                    };

                case 33:
                    return new ArrayList
                { 331, "Barcelone",
                  332, "Seville"

                    };
                case 34:
                    return new ArrayList
                { 341, "Bruges",
                  342, "Bruxelles"

                    };

                case 41:
                    return new ArrayList
                { 411, "Marrakech",
                  412, "Hurgada"

                    };

                case 42:
                    return new ArrayList
                { 421, "Dakar",
                  422, "Dahra"
                    };

                case 43:
                    return new ArrayList
                { 431, "Tunis",
                  432, "Djerba"

                    };

                case 44:
                    return new ArrayList
                { 441, "Johannesbourg",
                  442, "Le Cap"};

                case 51:
                    return new ArrayList
                    {
                        511,"Mahina",
                        512,"Papara"
                    };

                case 53:
                    return new ArrayList
                    {
              531,"taranaki",
              532,"northland"

                    };
                default: return null;


            }

        }
    }



}



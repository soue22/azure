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

        public ArrayList GetAllVoyages(int id)
        {
            switch (id)
            {
                case 0:
                    return new ArrayList(5){

                        2354, "Séjour pas cher en Floride","Content/Images/afrique.jpg","hqzioepaunioveuazioup auuz,op ueiop azuioena etaznyzehazioeuaznopdusdioq fufuiopef ^zeufiçàu y", 1200,
                        2355, "Séjour pas cher en Texas","Content/Images/afrique.jpg","hqzioepaunioveuazioup auuz,op ueiop azuioena etaznyzehazioeuaznopdusdioq fufuiopef ^zeufiçàu y", 1200,
                        2221, " Quebec en dernière minute","Content/Images/afrique.jpg","hqzioepaunioveuazioup auuz,op ueiop azuioena etaznyzehazioeuaznopdusdioq fufuiopef ^zeufiçàu y", 1200,
                        2222, " Montreal en 3 jours","Content/Images/afrique.jpg","hqzioepaunioveuazioup auuz,op ueiop azuioena etaznyzehazioeuaznopdusdioq fufuiopef ^zeufiçàu y", 1200,
                        5001, "Plongée sous marine à Cancun","Content/Images/afrique.jpg","hqzioepaunioveuazioup auuz,op ueiop azuioena etaznyzehazioeuaznopdusdioq fufuiopef ^zeufiçàu y", 1200,
                        5012, "Séjour Mexico derniéres places","Content/Images/afrique.jpg","hqzioepaunioveuazioup auuz,op ueiop azuioena etaznyzehazioeuaznopdusdioq fufuiopef ^zeufiçàu y", 1200,
                        5002, " Séjour pas cher à Santa Cruz","Content/Images/afrique.jpg","hqzioepaunioveuazioup auuz,op ueiop azuioena etaznyzehazioeuaznopdusdioq fufuiopef ^zeufiçàu y", 1200,
                        5022, "  Séjour de reve à Buenos Aires","Content/Images/afrique.jpg","hqzioepaunioveuazioup auuz,op ueiop azuioena etaznyzehazioeuaznopdusdioq fufuiopef ^zeufiçàu y", 1200,
                        5003, "Phuket et ses iles paradisiaques","Content/Images/afrique.jpg","hqzioepaunioveuazioup auuz,op ueiop azuioena etaznyzehazioeuaznopdusdioq fufuiopef ^zeufiçàu y", 1200,
                        5004, " Profitez des Cascades à  Bangkok","Content/Images/afrique.jpg","hqzioepaunioveuazioup auuz,op ueiop azuioena etaznyzehazioeuaznopdusdioq fufuiopef ^zeufiçàu y", 1200,
                        50024, "Sable blanc des iles de Kuala Lampur","Content/Images/afrique.jpg","hqzioepaunioveuazioup auuz,op ueiop azuioena etaznyzehazioeuaznopdusdioq fufuiopef ^zeufiçàu y", 1200,
                        50025, "Derniéres minutes pour un séjour à Ipoh","Content/Images/afrique.jpg","hqzioepaunioveuazioup auuz,op ueiop azuioena etaznyzehazioeuaznopdusdioq fufuiopef ^zeufiçàu y", 1200,
                        5005, " Escale à Tokyo","Content/Images/afrique.jpg","hqzioepaunioveuazioup auuz,op ueiop azuioena etaznyzehazioeuaznopdusdioq fufuiopef ^zeufiçàu y", 1200,
                        5015, " Voyage à Okazaki","Content/Images/afrique.jpg","hqzioepaunioveuazioup auuz,op ueiop azuioena etaznyzehazioeuaznopdusdioq fufuiopef ^zeufiçàu y", 1200,
                        5006, "Séjour dernière  minute à Delhi","Content/Images/afrique.jpg","hqzioepaunioveuazioup auuz,op ueiop azuioena etaznyzehazioeuaznopdusdioq fufuiopef ^zeufiçàu y", 1200,
                        5016, "Séjour dernière  minute à Mumbai","Content/Images/afrique.jpg","hqzioepaunioveuazioup auuz,op ueiop azuioena etaznyzehazioeuaznopdusdioq fufuiopef ^zeufiçàu y", 1200,
                        50017, "Spa et Thalasso en Bretagne","Content/Images/afrique.jpg","hqzioepaunioveuazioup auuz,op ueiop azuioena etaznyzehazioeuaznopdusdioq fufuiopef ^zeufiçàu y", 1200,
                        50027, "Weekend dans le Var","Content/Images/afrique.jpg","hqzioepaunioveuazioup auuz,op ueiop azuioena etaznyzehazioeuaznopdusdioq fufuiopef ^zeufiçàu y", 1200,
                        5008, "Douceur de  Florence","Content/Images/afrique.jpg","hqzioepaunioveuazioup auuz,op ueiop azuioena etaznyzehazioeuaznopdusdioq fufuiopef ^zeufiçàu y", 1200,
                        5018, "Visitez Pompei à partir de Naples","Content/Images/afrique.jpg","hqzioepaunioveuazioup auuz,op ueiop azuioena etaznyzehazioeuaznopdusdioq fufuiopef ^zeufiçàu y", 1200,
                        5009, "Départ Immediat à Barcelone","Content/Images/afrique.jpg","hqzioepaunioveuazioup auuz,op ueiop azuioena etaznyzehazioeuaznopdusdioq fufuiopef ^zeufiçàu y", 1200,
                        5039, "Carnaval à seville","Content/Images/afrique.jpg","hqzioepaunioveuazioup auuz,op ueiop azuioena etaznyzehazioeuaznopdusdioq fufuiopef ^zeufiçàu y", 1200,
                        50014, " Sejour pas cher a Bruxelles","Content/Images/afrique.jpg","hqzioepaunioveuazioup auuz,op ueiop azuioena etaznyzehazioeuaznopdusdioq fufuiopef ^zeufiçàu y", 1200,
                        50034, " Sejour pas cher a Bruges","Content/Images/afrique.jpg","hqzioepaunioveuazioup auuz,op ueiop azuioena etaznyzehazioeuaznopdusdioq fufuiopef ^zeufiçàu y", 1200,
                        50010, "venez profiter du soleil de Marrakech","Content/Images/afrique.jpg","hqzioepaunioveuazioup auuz,op ueiop azuioena etaznyzehazioeuaznopdusdioq fufuiopef ^zeufiçàu y", 1200,
                        50045, "Belles plage de Hurgada ","Content/Images/afrique.jpg","hqzioepaunioveuazioup auuz,op ueiop azuioena etaznyzehazioeuaznopdusdioq fufuiopef ^zeufiçàu y", 1200,
                        50011, " Séjour pas cher à Dakar","Content/Images/afrique.jpg","hqzioepaunioveuazioup auuz,op ueiop azuioena etaznyzehazioeuaznopdusdioq fufuiopef ^zeufiçàu y", 1200,
                        50041, " Séjour pas cher à Dahra","Content/Images/afrique.jpg","hqzioepaunioveuazioup auuz,op ueiop azuioena etaznyzehazioeuaznopdusdioq fufuiopef ^zeufiçàu y", 1200,
                        50012, " Djerba plages et sable fin","Content/Images/afrique.jpg","hqzioepaunioveuazioup auuz,op ueiop azuioena etaznyzehazioeuaznopdusdioq fufuiopef ^zeufiçàu y", 1200,
                        50312, " Tunis Pas cher","Content/Images/afrique.jpg","hqzioepaunioveuazioup auuz,op ueiop azuioena etaznyzehazioeuaznopdusdioq fufuiopef ^zeufiçàu y", 1200,
                        50013, "Safari unique Johannesburg","Content/Images/afrique.jpg","hqzioepaunioveuazioup auuz,op ueiop azuioena etaznyzehazioeuaznopdusdioq fufuiopef ^zeufiçàu y", 1200,
                        50435, "Safari unique Le Cap","Content/Images/afrique.jpg","hqzioepaunioveuazioup auuz,op ueiop azuioena etaznyzehazioeuaznopdusdioq fufuiopef ^zeufiçàu y", 1200,
                        50236,"Decouverte de Bora Bora","Content/Images/afrique.jpg","hqzioepaunioveuazioup auuz,op ueiop azuioena etaznyzehazioeuaznopdusdioq fufuiopef ^zeufiçàu y", 1200,
                        523654,"Traverser des payasages extraordinaires en nouvelle zelande","Content/Images/afrique.jpg","hqzioepaunioveuazioup auuz,op ueiop azuioena etaznyzehazioeuaznopdusdioq fufuiopef ^zeufiçàu y", 1200,
                    };

                case 001:
                    return new ArrayList(5){
                       2354, "Séjour pas cher en Floride" ,"Content/Images/afrique.jpg","hqzioepaunioveuazioup auuz,op ueiop azuioena etaznyzehazioeuaznopdusdioq fufuiopef ^zeufiçàu y", 1200,
                        2355, "Séjour pas cher en Texas","Content/Images/afrique.jpg","hqzioepaunioveuazioup auuz,op ueiop azuioena etaznyzehazioeuaznopdusdioq fufuiopef ^zeufiçàu y", 1200,
                        2221, " Quebec en dernière minute","Content/Images/afrique.jpg","hqzioepaunioveuazioup auuz,op ueiop azuioena etaznyzehazioeuaznopdusdioq fufuiopef ^zeufiçàu y", 1200,
                        2222, " Montreal en 3 jours","Content/Images/afrique.jpg","hqzioepaunioveuazioup auuz,op ueiop azuioena etaznyzehazioeuaznopdusdioq fufuiopef ^zeufiçàu y", 1200,
                        5001, "Plongée sous marine à Cancun","Content/Images/afrique.jpg","hqzioepaunioveuazioup auuz,op ueiop azuioena etaznyzehazioeuaznopdusdioq fufuiopef ^zeufiçàu y", 1200,

                    };

                case 002:
                    return new ArrayList(5)
                {
                    5001, "Plongée sous marine à Cancun","Content/Images/afrique.jpg","hqzioepaunioveuazioup auuz,op ueiop azuioena etaznyzehazioeuaznopdusdioq fufuiopef ^zeufiçàu y", 1200,
                        5012, "Séjour Mexico derniéres places","Content/Images/afrique.jpg","hqzioepaunioveuazioup auuz,op ueiop azuioena etaznyzehazioeuaznopdusdioq fufuiopef ^zeufiçàu y", 1200,
                        5002, " Séjour pas cher à Santa Cruz","Content/Images/afrique.jpg","hqzioepaunioveuazioup auuz,op ueiop azuioena etaznyzehazioeuaznopdusdioq fufuiopef ^zeufiçàu y", 1200,
                        5022, "  Séjour de reve à Buenos Aires","Content/Images/afrique.jpg","hqzioepaunioveuazioup auuz,op ueiop azuioena etaznyzehazioeuaznopdusdioq fufuiopef ^zeufiçàu y", 1200,
                        5003, "Phuket et ses iles paradisiaques","Content/Images/afrique.jpg","hqzioepaunioveuazioup auuz,op ueiop azuioena etaznyzehazioeuaznopdusdioq fufuiopef ^zeufiçàu y", 1200,
                        5004, " Profitez des Cascades à  Bangkok","Content/Images/afrique.jpg","hqzioepaunioveuazioup auuz,op ueiop azuioena etaznyzehazioeuaznopdusdioq fufuiopef ^zeufiçàu y", 1200,
                        50024, "Sable blanc des iles de Kuala Lampur","Content/Images/afrique.jpg","hqzioepaunioveuazioup auuz,op ueiop azuioena etaznyzehazioeuaznopdusdioq fufuiopef ^zeufiçàu y", 1200,
                        50025, "Derniéres minutes pour un séjour à Ipoh","Content/Images/afrique.jpg","hqzioepaunioveuazioup auuz,op ueiop azuioena etaznyzehazioeuaznopdusdioq fufuiopef ^zeufiçàu y", 1200,
                        5005, " Escale à Tokyo","Content/Images/afrique.jpg","hqzioepaunioveuazioup auuz,op ueiop azuioena etaznyzehazioeuaznopdusdioq fufuiopef ^zeufiçàu y", 1200,
                        5015, " Voyage à Okazaki","Content/Images/afrique.jpg","hqzioepaunioveuazioup auuz,op ueiop azuioena etaznyzehazioeuaznopdusdioq fufuiopef ^zeufiçàu y", 1200,
                        5006, "Séjour dernière  minute à Delhi","Content/Images/afrique.jpg","hqzioepaunioveuazioup auuz,op ueiop azuioena etaznyzehazioeuaznopdusdioq fufuiopef ^zeufiçàu y", 1200,
                        5016, "Séjour dernière  minute à Mumbai","Content/Images/afrique.jpg","hqzioepaunioveuazioup auuz,op ueiop azuioena etaznyzehazioeuaznopdusdioq fufuiopef ^zeufiçàu y", 1200,

                    };

                case 003:
                    return new ArrayList(5)
                {  50017, "Spa et Thalasso en Bretagne","Content/Images/afrique.jpg","hqzioepaunioveuazioup auuz,op ueiop azuioena etaznyzehazioeuaznopdusdioq fufuiopef ^zeufiçàu y", 1200,
                        50027, "Weekend dans le Var","Content/Images/afrique.jpg","hqzioepaunioveuazioup auuz,op ueiop azuioena etaznyzehazioeuaznopdusdioq fufuiopef ^zeufiçàu y", 1200,
                        5008, "Douceur de  Florence","Content/Images/afrique.jpg","hqzioepaunioveuazioup auuz,op ueiop azuioena etaznyzehazioeuaznopdusdioq fufuiopef ^zeufiçàu y", 1200,
                        5018, "Visitez Pompei à partir de Naples","Content/Images/afrique.jpg","hqzioepaunioveuazioup auuz,op ueiop azuioena etaznyzehazioeuaznopdusdioq fufuiopef ^zeufiçàu y", 1200,
                        5009, "Départ Immediat à Barcelone","Content/Images/afrique.jpg","hqzioepaunioveuazioup auuz,op ueiop azuioena etaznyzehazioeuaznopdusdioq fufuiopef ^zeufiçàu y", 1200,
                        5039, "Carnaval à seville","Content/Images/afrique.jpg","hqzioepaunioveuazioup auuz,op ueiop azuioena etaznyzehazioeuaznopdusdioq fufuiopef ^zeufiçàu y", 1200,
                        50014, " Sejour pas cher a Bruxelles","Content/Images/afrique.jpg","hqzioepaunioveuazioup auuz,op ueiop azuioena etaznyzehazioeuaznopdusdioq fufuiopef ^zeufiçàu y", 1200,
                        50034, " Sejour pas cher a Bruges","Content/Images/afrique.jpg","hqzioepaunioveuazioup auuz,op ueiop azuioena etaznyzehazioeuaznopdusdioq fufuiopef ^zeufiçàu y", 1200,

                    };

                case 004:
                    return new ArrayList(5)
                {
                        50010, "venez profiter du soleil de Marrakech","Content/Images/afrique.jpg","hqzioepaunioveuazioup auuz,op ueiop azuioena etaznyzehazioeuaznopdusdioq fufuiopef ^zeufiçàu y", 1200,
                        50045, "Belles plage de Hurgada ","Content/Images/afrique.jpg","hqzioepaunioveuazioup auuz,op ueiop azuioena etaznyzehazioeuaznopdusdioq fufuiopef ^zeufiçàu y", 1200,
                        50011, " Séjour pas cher à Dakar","Content/Images/afrique.jpg","hqzioepaunioveuazioup auuz,op ueiop azuioena etaznyzehazioeuaznopdusdioq fufuiopef ^zeufiçàu y", 1200,
                        50041, " Séjour pas cher à Dahra","Content/Images/afrique.jpg","hqzioepaunioveuazioup auuz,op ueiop azuioena etaznyzehazioeuaznopdusdioq fufuiopef ^zeufiçàu y", 1200,
                        50012, " Djerba plages et sable fin","Content/Images/afrique.jpg","hqzioepaunioveuazioup auuz,op ueiop azuioena etaznyzehazioeuaznopdusdioq fufuiopef ^zeufiçàu y", 1200,
                        50312, " Tunis Pas cher","Content/Images/afrique.jpg","hqzioepaunioveuazioup auuz,op ueiop azuioena etaznyzehazioeuaznopdusdioq fufuiopef ^zeufiçàu y", 1200,
                        50013, "Safari unique Johannesburg","Content/Images/afrique.jpg","hqzioepaunioveuazioup auuz,op ueiop azuioena etaznyzehazioeuaznopdusdioq fufuiopef ^zeufiçàu y", 1200,
                        50435, "Safari unique Le Cap","Content/Images/afrique.jpg","hqzioepaunioveuazioup auuz,op ueiop azuioena etaznyzehazioeuaznopdusdioq fufuiopef ^zeufiçàu y", 1200,

                    };



                case 011:
                    return new ArrayList(5){
                        2354, "Séjour pas cher en Floride" ,"Content/Images/afrique.jpg","hqzioepaunioveuazioup auuz,op ueiop azuioena etaznyzehazioeuaznopdusdioq fufuiopef ^zeufiçàu y", 1200,
                        2355, "Séjour pas cher en Texas","Content/Images/afrique.jpg","hqzioepaunioveuazioup auuz,op ueiop azuioena etaznyzehazioeuaznopdusdioq fufuiopef ^zeufiçàu y", 1200,
                    };

                case 12:
                    return new ArrayList(5){
                        2221, " Quebec en dernière minute","Content/Images/afrique.jpg","hqzioepaunioveuazioup auuz,op ueiop azuioena etaznyzehazioeuaznopdusdioq fufuiopef ^zeufiçàu y", 1200,
                        2222, " Montreal en 3 jours","Content/Images/afrique.jpg","hqzioepaunioveuazioup auuz,op ueiop azuioena etaznyzehazioeuaznopdusdioq fufuiopef ^zeufiçàu y", 1200,
                    };

                case 13:
                    return new ArrayList(5){
                         5001, "Plongée sous marine à Cancun","Content/Images/afrique.jpg","hqzioepaunioveuazioup auuz,op ueiop azuioena etaznyzehazioeuaznopdusdioq fufuiopef ^zeufiçàu y", 1200,
                        5012, "Séjour Mexico derniéres places","Content/Images/afrique.jpg","hqzioepaunioveuazioup auuz,op ueiop azuioena etaznyzehazioeuaznopdusdioq fufuiopef ^zeufiçàu y", 1200,
                    };

                case 14:
                    return new ArrayList(5){
                         5002, " Séjour pas cher à Santa Cruz","Content/Images/afrique.jpg","hqzioepaunioveuazioup auuz,op ueiop azuioena etaznyzehazioeuaznopdusdioq fufuiopef ^zeufiçàu y", 1200,
                        5022, "  Séjour de reve à Buenos Aires","Content/Images/afrique.jpg","hqzioepaunioveuazioup auuz,op ueiop azuioena etaznyzehazioeuaznopdusdioq fufuiopef ^zeufiçàu y", 1200,
                    };

                case 21:
                    return new ArrayList(5){
                 5003, "Phuket et ses iles paradisiaques","Content/Images/afrique.jpg","hqzioepaunioveuazioup auuz,op ueiop azuioena etaznyzehazioeuaznopdusdioq fufuiopef ^zeufiçàu y", 1200,
                        5004, " Profitez des Cascades à  Bangkok","Content/Images/afrique.jpg","hqzioepaunioveuazioup auuz,op ueiop azuioena etaznyzehazioeuaznopdusdioq fufuiopef ^zeufiçàu y", 1200,
                    };

                case 22:
                    return new ArrayList(5){
               50024, "Sable blanc des iles de Kuala Lampur","Content/Images/afrique.jpg","hqzioepaunioveuazioup auuz,op ueiop azuioena etaznyzehazioeuaznopdusdioq fufuiopef ^zeufiçàu y", 1200,
                        50025, "Derniéres minutes pour un séjour à Ipoh","Content/Images/afrique.jpg","hqzioepaunioveuazioup auuz,op ueiop azuioena etaznyzehazioeuaznopdusdioq fufuiopef ^zeufiçàu y", 1200,
                    };

                case 23:
                    return new ArrayList(5){
                         5005, " Escale à Tokyo","Content/Images/afrique.jpg","hqzioepaunioveuazioup auuz,op ueiop azuioena etaznyzehazioeuaznopdusdioq fufuiopef ^zeufiçàu y", 1200,
                        5015, " Voyage à Okazaki","Content/Images/afrique.jpg","hqzioepaunioveuazioup auuz,op ueiop azuioena etaznyzehazioeuaznopdusdioq fufuiopef ^zeufiçàu y", 1200,
                    };

                case 24:
                    return new ArrayList(5) {
                 5006, "Séjour dernière  minute à Delhi","Content/Images/afrique.jpg","hqzioepaunioveuazioup auuz,op ueiop azuioena etaznyzehazioeuaznopdusdioq fufuiopef ^zeufiçàu y", 1200,
                        5016, "Séjour dernière  minute à Mumbai","Content/Images/afrique.jpg","hqzioepaunioveuazioup auuz,op ueiop azuioena etaznyzehazioeuaznopdusdioq fufuiopef ^zeufiçàu y", 1200,
                    };

                case 31:
                    return new ArrayList(5) {
                50017, "Spa et Thalasso en Bretagne","Content/Images/afrique.jpg","hqzioepaunioveuazioup auuz,op ueiop azuioena etaznyzehazioeuaznopdusdioq fufuiopef ^zeufiçàu y", 1200,
                        50027, "Weekend dans le Var","Content/Images/afrique.jpg","hqzioepaunioveuazioup auuz,op ueiop azuioena etaznyzehazioeuaznopdusdioq fufuiopef ^zeufiçàu y", 1200,
                    };

                case 32:
                    return new ArrayList(5) {
               5008, "Douceur de  Florence","Content/Images/afrique.jpg","hqzioepaunioveuazioup auuz,op ueiop azuioena etaznyzehazioeuaznopdusdioq fufuiopef ^zeufiçàu y", 1200,
                        5018, "Visitez Pompei à partir de Naples","Content/Images/afrique.jpg","hqzioepaunioveuazioup auuz,op ueiop azuioena etaznyzehazioeuaznopdusdioq fufuiopef ^zeufiçàu y", 1200,
                    };

                case 33:
                    return new ArrayList(5){
               5009, "Départ Immediat à Barcelone","Content/Images/afrique.jpg","hqzioepaunioveuazioup auuz,op ueiop azuioena etaznyzehazioeuaznopdusdioq fufuiopef ^zeufiçàu y", 1200,
                        5039, "Carnaval à seville","Content/Images/afrique.jpg","hqzioepaunioveuazioup auuz,op ueiop azuioena etaznyzehazioeuaznopdusdioq fufuiopef ^zeufiçàu y", 1200,
                    };

                case 34:
                    return new ArrayList(5){
                50010, "venez profiter du soleil de Marrakech","Content/Images/afrique.jpg","hqzioepaunioveuazioup auuz,op ueiop azuioena etaznyzehazioeuaznopdusdioq fufuiopef ^zeufiçàu y", 1200,
                        50045, "Belles plage de Hurgada ","Content/Images/afrique.jpg","hqzioepaunioveuazioup auuz,op ueiop azuioena etaznyzehazioeuaznopdusdioq fufuiopef ^zeufiçàu y", 1200,
                    };

                case 41:
                    return new ArrayList(5){
                50011, " Séjour pas cher à Dakar","Content/Images/afrique.jpg","hqzioepaunioveuazioup auuz,op ueiop azuioena etaznyzehazioeuaznopdusdioq fufuiopef ^zeufiçàu y", 1200,
                        50041, " Séjour pas cher à Dahra","Content/Images/afrique.jpg","hqzioepaunioveuazioup auuz,op ueiop azuioena etaznyzehazioeuaznopdusdioq fufuiopef ^zeufiçàu y", 1200,
                    };

                case 42:
                    return new ArrayList(5){
                50012, " Djerba plages et sable fin","Content/Images/afrique.jpg","hqzioepaunioveuazioup auuz,op ueiop azuioena etaznyzehazioeuaznopdusdioq fufuiopef ^zeufiçàu y", 1200,
                        50312, " Tunis Pas cher","Content/Images/afrique.jpg","hqzioepaunioveuazioup auuz,op ueiop azuioena etaznyzehazioeuaznopdusdioq fufuiopef ^zeufiçàu y", 1200,
                    };

                case 43:
                    return new ArrayList(5){
               50013, "Safari unique Johannesburg","Content/Images/afrique.jpg","hqzioepaunioveuazioup auuz,op ueiop azuioena etaznyzehazioeuaznopdusdioq fufuiopef ^zeufiçàu y", 1200,
                        50435, "Safari unique Le Cap","Content/Images/afrique.jpg","hqzioepaunioveuazioup auuz,op ueiop azuioena etaznyzehazioeuaznopdusdioq fufuiopef ^zeufiçàu y", 1200,
                    };

                case 55:
                    return new ArrayList(5)
                {
                        50236,"Decouverte de Bora Bora","Content/Images/afrique.jpg","hqzioepaunioveuazioup auuz,op ueiop azuioena etaznyzehazioeuaznopdusdioq fufuiopef ^zeufiçàu y", 1200,
                        523654,"Traverser des payasages extraordinaires en nouvelle zelande","Content/Images/afrique.jpg","hqzioepaunioveuazioup auuz,op ueiop azuioena etaznyzehazioeuaznopdusdioq fufuiopef ^zeufiçàu y", 1200,
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



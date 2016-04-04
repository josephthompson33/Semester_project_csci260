using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WOB.Model
{
    public class BeerModel
    {
        public string name;
        public string brewery;
        public string type;
        public float IBU;
        public float abv;
        public BeerModel(string Name, string Brewery, string Type, float ibu, float Abv)
        {
            name = Name;
            brewery = Brewery;
            type = Type;
            IBU = ibu;
            abv = Abv;
        }
        public BeerModel()
        {
            name = "";
            brewery = "";
            type = "";
            IBU = 0;
            abv = 0;

        }
        void setName(string Name)
        {
            name = Name;
        }
        string getName()
        {
            return name;
        }
        string getBrewery()
        {
            return brewery;
        }
        void setBrewery(string Brewery)
        {
            brewery = Brewery;
        }
        string getType()
        {
            return type;
        }
        void setType(string Type)
        {
            type = Type;
        }
        float getIBU()
        {
            return IBU;
        }
        void setIBU(float ibu)
        {
            IBU = ibu;
        }
        float getAbv()
        {
            return abv;
        }
        void setAbv(float Abv)
        {
            abv = Abv;
        }
    }
}
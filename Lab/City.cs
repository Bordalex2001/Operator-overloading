using System;

namespace Lab
{
    internal class City
    {
        private string name; //название города
        private string country; //страна
        private int inhabitants; //кол-во жителей
        private int tel_code; //телефонный код города
        private string[] districts; //названия районов города

        public City()
        {
            name = null;
            country = null;
            inhabitants = 0;
            tel_code = 0;
            districts = null;
        }

        public City(string n, string c, int i, int tc, string[] d)
        {
            name = n;
            country = c;
            inhabitants = i;
            tel_code = tc;
            districts = d;
        }

        public override string ToString()
        {
            string darray = string.Empty; //darray – массив районов
            foreach (string item in districts) 
            {
                darray += item + ", ";
            }
            return $"Name: {name}\nCountry: {country}\nNumber of inhabitants: {inhabitants}\nTelephone code: {tel_code}\nDistricts: {darray}";
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Country
        {
            get
            {
                return country;
            }
            set
            {
                country = value;
            }
        }
        public int Inhabitants
        {
            get
            {
                return inhabitants;
            }
            set
            {
                inhabitants = value;
            }
        }
        public int TelCode
        {
            get
            {
                return tel_code;
            }
            set
            {
                tel_code = value;
            }
        }
        public string[] Districts
        {
            get
            {
                return districts;
            }
            set
            {
                districts = value;
            }
        }
        public static City operator+(City city, int add) 
        { 
            city.inhabitants += add;
            return city;
        }
        public static City operator-(City city, int reduce) 
        { 
            city.inhabitants -= reduce;
            return city;
        }
        public static bool operator==(City city1, City city2) 
        { 
            if (city1.inhabitants == city2.inhabitants)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator!=(City city1, City city2) 
        { 
            if (city1.inhabitants != city2.inhabitants)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator>(City city1, City city2) 
        { 
            if (city1.inhabitants > city2.inhabitants)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator<(City city1, City city2)
        {
            if (city1.inhabitants < city2.inhabitants)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override bool Equals(object city)
        {
            City city1 = (City)city;
            if (city1.inhabitants == inhabitants)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
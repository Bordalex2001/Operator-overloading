using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    internal class Store
    {
        private string name; //название магазина
        private string address; //адрес
        private string profile; //профиль
        private string telephone; //телефон
        private string email; //эл. адрес
        private int area; //площадь
        public Store()
        {
            name = null;
            address = null;
            profile = null;
            telephone = null;
            email = null;
            area = 0;
        }
        public Store(string name, string address, string profile, string telephone, string email, int area)
        {
            this.name = name;
            this.address = address;
            this.profile = profile;
            this.telephone = telephone;
            this.email = email;
            this.area = area;
        }
        public string Name
        {
            get { return name; } set { name = value; }
        }
        public string Address
        {
            get { return address; } set { address = value; }
        }
        public string Profile
        {
            get { return profile; } set { profile = value; }
        }
        public string Telephone
        {
            get { return telephone; } set { telephone = value; }
        }
        public string Email
        {
            get { return email; } set { email = value; }
        }
        public int Area
        {
            get { return area; } set { area = value; }
        }
        public override string ToString()
        {
            return $"Name: {name}\nAddress: {address}\nProfile: {profile}\nTelephone: {telephone}\nEmail: {email}\nArea: {area}";
        }
        public static Store operator+(Store s, int add)
        {
            s.area += add;
            return s;
        }
        public static Store operator-(Store s, int reduce)
        {
            s.area -= reduce;
            return s;
        }
        public static bool operator<(Store s1, Store s2)
        {
            if (s1.area < s2.area)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator>(Store s1, Store s2)
        {
            if (s1.area > s2.area)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator==(Store s1, Store s2)
        {
            if (s1.area == s2.area)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator!=(Store s1, Store s2)
        {
            if (s1.area != s2.area)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override bool Equals(object s)
        {
            Store s1 = (Store)s;
            if (s1.area == area)
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

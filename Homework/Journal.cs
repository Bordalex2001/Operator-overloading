using System;

namespace Homework
{
    internal class Journal
    {
        private string name; //название журнала
        private int year; //год основания
        private string description; //описание
        private string telephone; //телефон
        private string email; //эл. адрес
        private int employees; //кол-во сотрудников
        public Journal()
        {
            name = null;
            year = 0;
            description = null;
            telephone = null;
            email = null;
            employees = 0;
        }
        public Journal(string name, int year, string description, string telephone, string email, int employees)
        {
            this.name = name;
            this.year = year;
            this.description = description;
            this.telephone = telephone;
            this.email = email;
            this.employees = employees;
        }
        public string Name 
        { 
            get { return name; } set { name = value; }
        }
        public int Year
        { 
            get { return year; } set { year = value; } 
        }
        public string Description
        {
            get { return description; } set { description = value; }
        }
        public string Telephone
        {
            get { return telephone; } set { telephone = value; }
        }
        public string Email
        {
            get { return email; } set { email = value; }
        }
        public int Employees
        {
            get { return employees; } set { employees = value; }
        }
        public override string ToString()
        {
            return $"Name: {name}\nYear: {year}\nDescription: {description}\nTelephone: {telephone}\nEmail: {email}\nEmployees: {employees}";
        }
        public static Journal operator+(Journal jour, int add)
        {
            jour.employees += add;
            return jour;
        }
        public static Journal operator-(Journal jour, int reduce)
        {
            jour.employees -= reduce;
            return jour;
        }
        public static bool operator==(Journal jour1, Journal jour2)
        {
            if (jour1.employees == jour2.employees)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator!=(Journal jour1, Journal jour2)
        {
            if (jour1.employees != jour2.employees)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator<(Journal jour1, Journal jour2)
        {
            if (jour1.employees < jour2.employees)
            {
                return true;
            }
            else 
            { 
                return false; 
            }
        }
        public static bool operator>(Journal jour1, Journal jour2)
        {
            if (jour1.employees > jour2.employees)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override bool Equals(object jour)
        {
            Journal jour1 = (Journal)jour;
            if (jour1.employees == employees)
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

using System;

namespace Lab
{
    internal class CreditCard
    {
        public string CardNumber
        {
            get
            {
                return card_number;
            }
            set
            {
                try
                {
                    if (value.Length != 16)
                    {
                        throw new Exception("Card number length cannot be less or greater than 16");
                    }
                    else
                    {
                        card_number = value;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex.Message}");
                }
            }
        }
        public string Name
        { 
            get
            {
                return name;
            }
            set
            {
                try
                {
                    string data = value.ToString();
                    if(int.TryParse(data, out int not_letters)) //Ввод числа вместо имени
                    {
                        throw new Exception("Name cannot be an Integer or a number");
                    }
                    else
                    {
                        name = value;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex.Message}");
                }
            }
        
        }
        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                try
                {
                    string data = value.ToString();
                    if (int.TryParse(data, out int not_letters)) //Ввод числа вместо фамилии
                    {
                        throw new Exception("Surname cannot be an Integer or a number");
                    }
                    else
                    {
                        surname = value;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex.Message}");
                }
            }

        }
        public int CVVCode 
        { 
            get
            {
                return cvv_code;
            }
            set
            {
                try
                {
                    if (value < 100 || value >= 1000)
                    {
                        throw new Exception("Value of a CVV code cannot be less than 100 or greater than 999");
                    }
                    else
                    {
                        cvv_code = value;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex.Message}");
                }
            }
        }
        public int Month
        { 
            get
            {
                return month;
            }
            set
            {
                try
                {
                    if (value < 1 || value > 12)
                    {
                        throw new Exception("Value of a month cannot be less than 1 or bigger than 12");
                    }
                    else
                    {
                        month = value;
                    }
                }
                catch (Exception ex)
                { 
                    Console.WriteLine($"{ex.Message}");
                }
            }
        
        }
        public int Year
        {
            get
            {
                return year;
            }
            set
            {
                try
                {
                    if (value < 0 || value > 99)
                    {
                        throw new Exception("Last two digits of the year cannot be negative or greater than 99");
                    }
                    else
                    {
                        year = value;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex.Message}");
                }
            }

        }
        public double PersonalFunds 
        { 
            get
            {
                return personal_funds;
            }
            set
            {
                try
                {
                    if (value < 0)
                    {
                        throw new Exception("Value of personal funds cannot be negative");
                    }
                    else
                    {
                        personal_funds = value;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex.Message}");
                }
            }
        }
        public double CreditLimit
        {
            get
            {
                return credit_limit;
            }
            set
            {
                try
                {
                    if (value < 0)
                    {
                        throw new Exception("Value of credit limit cannot be negative");
                    }
                    else
                    { 
                        credit_limit = value;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex.Message}");
                }
            }
        }
        private string card_number; //номер карты
        private string name; //имя владельца
        private string surname; //фамилия владельца
        private int cvv_code; //CVV-код или CVC
        private int month; //месяц завершения работы
        private int year; //год завершения работы
        private double personal_funds; //собственные средства
        private double credit_limit; //кредитный лимит (кредит)
        public CreditCard(string card_number = null, string name = null, string surname = null, int cvv_code = 0,
            int month = 0, int year = 0, double personal_funds = 0.0, double credit_limit = 0.0)
        {
            CardNumber = card_number;
            Name = name;
            Surname = surname;
            CVVCode = cvv_code;
            Month = month;
            Year = year;
            PersonalFunds = personal_funds;
            CreditLimit = credit_limit;
        }
        public void Print()
        {
            Console.WriteLine($"Card number: {card_number}\nHolder: {name}  {surname}\nCVV code: {cvv_code}\nValidity: {month}/{year}\nPersonal funds: {personal_funds}\nCredit limit: {credit_limit}");
        }
        public static CreditCard operator+(CreditCard card, double add)
        {
            card.personal_funds += add;
            return card;
        }
        public static CreditCard operator-(CreditCard card, double reduce)
        {
            card.personal_funds -= reduce;
            return card;
        }
        public static bool operator==(CreditCard card1, CreditCard card2)
        {
            if (card1.cvv_code == card2.cvv_code)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator!=(CreditCard card1, CreditCard card2)
        {
            if (card1.cvv_code != card2.cvv_code)
            {
                return true;
            }
            else
            { 
                return false; 
            }
        }
        public static bool operator<(CreditCard card1, CreditCard card2)
        {
            if (card1.personal_funds < card2.personal_funds)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator>(CreditCard card1, CreditCard card2)
        {
            if (card1.personal_funds > card2.personal_funds)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override bool Equals(object card)
        {
            CreditCard card1 = (CreditCard)card;
            if (card1.cvv_code == cvv_code)
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
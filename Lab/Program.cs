using System;

namespace Lab
{
    internal class Program
    {
        static void Task1() //Задание 1
        {
            Console.WriteLine("Class Employee");
            Employee john = new Employee("Smith", "John", 12, 04, 1954, "johnsmith54@gmail.com", "Software developer", "Creating software programs", 25257);
            Console.WriteLine(john);
            Employee john1 = new Employee("Smith", "John", 12, 04, 1954, "johnsmith54@gmail.com", "Software developer", "Creating software programs", 25257);
            Console.WriteLine("\n");
            Employee harry = new Employee("Fletcher", "Harry", 24, 07, 1976, "harryfletcher54@gmail.com", "Quality assurance (QA) tester", "Checking how the program works", 18475);
            Console.WriteLine(harry);
            Employee harry1 = new Employee("Fletcher", "Harry", 24, 07, 1976, "harryfletcher54@gmail.com", "Quality assurance (QA) tester", "Checking how the program works", 18475);
            Console.WriteLine("\n");
            john += 1363;
            Console.WriteLine($"{john.Name}'s salary has increased to {john.Salary}");
            harry += 2382;
            Console.WriteLine($"{harry.Name}'s salary has increased to {harry.Salary}\n");
            john -= 1694;
            Console.WriteLine($"{john.Name}'s salary has reduced to {john.Salary}");
            harry -= 3257;
            Console.WriteLine($"{harry.Name}'s salary has reduced to {harry.Salary}\n");
            if (john == harry) Console.WriteLine("Salaries of both employees are equal\n");
            if (john != harry) Console.WriteLine("Salaries of both employees are not equal\n");
            if (john < harry) Console.WriteLine($"{john.Name}'s salary is less than {harry.Name}'s one");
            if (john > harry) Console.WriteLine($"{john.Name}'s salary is greater than {harry.Name}'s one");
            if (harry < john) Console.WriteLine($"{harry.Name}'s salary is less than {john.Name}'s one\n");
            if (harry > john) Console.WriteLine($"{harry.Name}'s salary is greater than {john.Name}'s one\n");
            Console.WriteLine(john.Equals(john1) ? "Salaries of both employees are equal" : "Salaries of both employees are not equal");
            Console.WriteLine(harry.Equals(harry1) ? "Salaries of both employees are equal" : "Salaries of both employees are not equal");
        }
        static void Task2() //Задание 2
        {
            Console.WriteLine("Class Matrix\n");
            Matrix A = new Matrix(new int[,] { { 10, 17, 24 }, { 24, 36, 13 }, { 50, 29, 42 } });
            Matrix A1 = new Matrix(new int[,] { { 10, 17, 24 }, { 24, 36, 13 }, { 50, 29, 42 } });
            Console.WriteLine(A);
            Console.Write($"Minimum element: {A.GetMinimum()}\nMaximum element: {A.GetMaximum()}");
            Console.WriteLine("\n");
            Matrix B = new Matrix(new int[,] { { 25, 36, 18 }, { 47, 42, 68 }, { 53, 27, 39 } });
            Matrix B1 = new Matrix(new int[,] { { 25, 36, 18 }, { 47, 42, 68 }, { 53, 27, 39 } });
            Console.WriteLine(B);
            Console.Write($"Minimum element: {B.GetMinimum()}\nMaximum element: {B.GetMaximum()}");
            Console.WriteLine("\n");
            Console.WriteLine($"Element by index A[1, 2]: {A[1, 2]}");
            Console.WriteLine($"Element by index B[2, 1]: {B[2, 1]}");
            Console.WriteLine("\n");
            Console.WriteLine("Sum of matrices (A + B):");
            Matrix sum = A + B;
            Console.WriteLine(sum.ToString());
            Console.WriteLine("Difference of matrices (B - A):");
            Matrix difference = B - A;
            Console.WriteLine(difference.ToString());
            Console.WriteLine("Matrix multiplication by number (A * 2):");
            Matrix multByNumberA = A * 2;
            Console.WriteLine(multByNumberA.ToString());
            Console.WriteLine("Matrix multiplication by number (B * 3):");
            Matrix multByNumberB = B * 3;
            Console.WriteLine(multByNumberB.ToString());
            Console.WriteLine("Product of matrices (A * B):");
            Matrix productAB = A * B;
            Console.WriteLine(productAB.ToString());
            Console.WriteLine("Product of matrices (B * A):");
            Matrix productBA = B * A;
            Console.WriteLine(productBA.ToString());
            if (A == B) Console.WriteLine("Matrix A is equal to matrix B");
            if (A != B) Console.WriteLine("Matrix A is not equal to matrix B\n");
            Console.WriteLine(A.Equals(A1) ? "Matrix A is equal to matrix A1" : "Matrix A is not equal to matrix A1");
            Console.WriteLine(B.Equals(B1) ? "Matrix B is equal to matrix B1" : "Matrix B is not equal to matrix B1");
        }
        static void Task3() //Задание 3
        {
            Console.WriteLine("Class City");
            City odesa = new City("Odesa", "Ukraine", 1025893, 048, new string[] { "Kyivskyj", "Prymorskyj", "Malynovskyj", "Suvorovskyj" });
            Console.WriteLine(odesa);
            City odesa1 = new City("Odesa", "Ukraine", 1025893, 048, new string[] { "Kyivskyj", "Prymorskyj", "Malynovskyj", "Suvorovskyj" });
            Console.WriteLine("\n");
            City lviv = new City("Lviv", "Ukraine", 714578, 032, new string[] { "Zalizhnychnyj", "Halytskyj", "Shevchenkivskyj", "Lychakivskyj", "Frankivskyj", "Sykhivskyj" });
            Console.WriteLine(lviv);
            City lviv1 = new City("Lviv", "Ukraine", 714578, 032, new string[] { "Zalizhnychnyj", "Halytskyj", "Shevchenkivskyj", "Lychakivskyj", "Frankivskyj", "Sykhivskyj" });
            Console.WriteLine("\n");
            odesa += 1267;
            Console.WriteLine($"Population of {odesa.Name} has increased to {odesa.Inhabitants}");
            lviv += 2648;
            Console.WriteLine($"Population of {lviv.Name} has increased to {lviv.Inhabitants}\n");
            odesa -= 739;
            Console.WriteLine($"Population of {odesa.Name} has reduced to {odesa.Inhabitants}");
            lviv -= 1683;
            Console.WriteLine($"Population of {lviv.Name} has reduced to {lviv.Inhabitants}\n");
            if (odesa == lviv) Console.WriteLine("Population of both cities are equal\n");
            if (odesa != lviv) Console.WriteLine("Population of both cities are not equal\n");
            if (odesa < lviv) Console.WriteLine($"Population of {odesa.Name} is less than population of {lviv.Name}");
            if (odesa > lviv) Console.WriteLine($"Population of {odesa.Name} is greater than population of {lviv.Name}");
            if (lviv < odesa) Console.WriteLine($"Population of {lviv.Name} is less than population of {odesa.Name}\n");
            if (lviv > odesa) Console.WriteLine($"Population of {lviv.Name} is greater than population of {odesa.Name}\n");
            Console.WriteLine(odesa.Equals(odesa1) ? "Population of both cities are equal" : "Population of both cities are not equal");
            Console.WriteLine(lviv.Equals(lviv1) ? "Population of both cities are equal" : "Population of both cities are not equal");
        }
        static void Task4() //Задание 4
        {
            Console.WriteLine("Class Credit card");
            CreditCard card1 = new CreditCard("1234567890123456", "Benjamin", "Thompson", 445, 04, 27, 18363.56, 50000.00);
            CreditCard card1a = new CreditCard("1234567890123456", "Benjamin", "Thompson", 445, 04, 27, 18363.56, 50000.00);
            card1.Print();
            Console.WriteLine();
            CreditCard card2 = new CreditCard("2468013579864219", "Mark", "Walker", 372, 10, 26, 43819.47, 75000.00);
            CreditCard card2a = new CreditCard("2468013579864219", "Mark", "Walker", 372, 10, 26, 43819.47, 75000.00);
            Console.WriteLine();
            card2.Print();
            Console.WriteLine();
            card1 += 1738.37;
            Console.WriteLine($"Personal funds of {card1.Name} {card1.Surname} have increased to {card1.PersonalFunds}");
            card2 += 3595.82;
            Console.WriteLine($"Personal funds of {card2.Name} {card2.Surname} have increased to {card2.PersonalFunds}\n");
            card1 -= 2486.47;
            Console.WriteLine($"Persoanl funds of {card1.Name} {card1.Surname} have increased to {card1.PersonalFunds}");
            card2 -= 1693.14;
            Console.WriteLine($"Personal funds of {card2.Name} {card2.Surname} have increased to {card2.PersonalFunds}\n");
            if (card1 == card2) Console.WriteLine("CVV codes of both cards are equal\n");
            if (card1 != card2) Console.WriteLine("CVV codes of both cards are not equal\n");
            if (card1 > card2) Console.WriteLine($"Personal funds of {card1.Name} {card1.Surname} are greater than " +
                $"personal funds of {card2.Name} {card2.Surname}");
            if (card1 < card2) Console.WriteLine($"Personal funds of {card1.Name} {card1.Surname} are less than " +
                $"personal funds of {card2.Name} {card2.Surname}");
            if (card2 > card1) Console.WriteLine($"Personal funds of {card2.Name} {card2.Surname} are greater than " +
                $"personal funds of {card1.Name} {card1.Surname}\n");
            if (card2 < card1) Console.WriteLine($"Personal funds of {card2.Name} {card2.Surname} are less than " +
                $"personal funds of {card1.Name} {card1.Surname}\n");
            Console.WriteLine(card1.Equals(card1a) ? "CVV codes of both cards are equal" : "CVV codes of both cards are not equal");
            Console.WriteLine(card2.Equals(card2a) ? "CVV codes of both cards are equal" : "CVV codes of both cards are not equal");
        }
        static void Main()
        {
            //Task1();
            //Task2();
            //Task3();
            //Task4();
        }
    }
}
using System;

namespace Homework
{
    internal class Program
    {
        static void Task1() //Задание 1
        {
            Console.WriteLine("Class Journal");
            Journal journal1 = new Journal("Local History", 2020, "Historical journal about the past and the future of Ukraine", "096-126-87-26", "lochist.mag@gmail.com", 26);
            Journal journal1a = new Journal("Local History", 2020, "Histircal journal about the past and the future of Ukraine", "096-126-87-26", "lochist.mag@gmail.com", 26);
            Console.WriteLine(journal1);
            Console.WriteLine("\n");
            Journal journal2 = new Journal("Reporters.", 2021, "Literary journal that settles in people's stories", "063-035-10-44", "spilnota@theukrainians.org", 13);
            Journal journal2a = new Journal("Reporters.", 2021, "Literary journal that settles in people's stories", "063-035-10-44", "spilnota@theukrainians.org", 13);
            Console.WriteLine(journal2);
            Console.WriteLine("\n");
            journal1 += 16;
            journal2 += 24;
            Console.WriteLine($"Number of employees of journal \"{journal1.Name}\" has raised to {journal1.Employees}");
            Console.WriteLine($"Number of employees of journal \"{journal2.Name}\" has raised to {journal2.Employees}\n");
            journal1 -= 29;
            journal2 -= 14;
            Console.WriteLine($"Number of employees of journal \"{journal1.Name}\" has reduced to {journal1.Employees}");
            Console.WriteLine($"Number of employees of journal \"{journal2.Name}\" has reduced to {journal2.Employees}\n");
            if (journal1 == journal2) Console.WriteLine("Number of employees of both journals is equal\n");
            if (journal1 != journal2) Console.WriteLine("Number of employees of both journals is not equal\n");
            if (journal1 < journal2) Console.WriteLine($"Number of employees of journal \"{journal1.Name}\" is less than " +
                $"number of employees of journal \"{journal2.Name}\"");
            if (journal1 > journal2) Console.WriteLine($"Number of employees of journal \"{journal1.Name}\" is greater than " +
                $"number of employees of journal \"{journal2.Name}\"");
            if (journal2 < journal1) Console.WriteLine($"Number of employees of journal \"{journal2.Name}\" is less than " +
                $"number of employees of journal \"{journal1.Name}\"\n");
            if (journal2 > journal1) Console.WriteLine($"Number of employees of journal \"{journal2.Name}\" is greater than " +
                $"number of employees of journal \"{journal1.Name}\"\n");
            Console.WriteLine(journal1.Equals(journal1a) ? "Number of employees of both journals is equal" : "Number of employees " +
                "of both journals is not equal");
            Console.WriteLine(journal2.Equals(journal2a) ? "Number of employees of both journals is equal" : "Number of employees " +
                "of both journals is not equal");
        }
        static void Task2() //Задание 2
        {
            Console.WriteLine("Class Store");
            Store store1 = new Store("Silpo", "Liustdorfska doroha, 54", "Food store", "0-800-301-707", "program@silpo.ua", 1821);
            Store store1a = new Store("Silpo", "Liustdorfska doroha, 54", "Food store", "0-800-301-707", "program@silpo.ua", 1821);
            Console.WriteLine(store1);
            Console.WriteLine("\n");
            Store store2 = new Store("ATB", "Fontanska doroha, 18", "Food store", "0-800-500-415", "program@atbmarket.com", 1515);
            Store store2a = new Store("ATB", "Fontanska doroha, 18", "Food store", "0-800-500-415", "program@atbmarket.com", 1515);
            Console.WriteLine(store2);
            Console.WriteLine("\n");
            store1 += 359;
            store2 += 182;
            Console.WriteLine($"The area of {store1.Name} store has increased to {store1.Area}");
            Console.WriteLine($"The area of {store2.Name} store has increased to {store2.Area}\n");
            store1 -= 233;
            store2 -= 317;
            Console.WriteLine($"The area of {store1.Name} store has reduced to {store1.Area}");
            Console.WriteLine($"The area of {store2.Name} store has reduced to {store2.Area}\n");
            if (store1 == store2) Console.WriteLine("The area of both stores is equal to each other\n");
            if (store1 != store2) Console.WriteLine("The area of both stores is not equal to each other\n");
            if (store1 < store2) Console.WriteLine($"The area of {store1.Name} is less than the area of {store2.Name}");
            if (store1 > store2) Console.WriteLine($"The area of {store1.Name} is greater than the area of {store2.Name}");
            if (store2 < store1) Console.WriteLine($"The area of {store2.Name} is less than the area of {store1.Name}\n");
            if (store2 > store1) Console.WriteLine($"The area of {store2.Name} is greater than the area of {store1.Name}\n");
            Console.WriteLine(store1.Equals(store1a) ? "The area of both stores is equal to each other" : "The area of both stores is not equal to each other");
            Console.WriteLine(store2.Equals(store2a) ? "The area of both stores is equal to each other" : "The area of both stores is not equal to each other");
        }
        static void Main()
        {
            //Task1();
            //Task2();
        }
    }
}

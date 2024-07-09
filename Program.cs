using System;

class Ali
{
    public static void Main()
    {
        Costumer C1 = new Costumer();
        C1.ID = 101;
        C1.Name = "John Lorusso";
        C1.Salary = 5000;

        Costumer C2 = new Costumer();
        C2.ID = 102;
        C2.Name = "Ibrahim Arabaki";
        C2.Salary = 6000;

        Costumer C3 = new Costumer();
        C3.ID = 103;
        C3.Name = "UFO";
        C3.Salary = 7000;

        Dictionary<int, Costumer> DC = new Dictionary<int, Costumer>();
        DC.Add(C1.ID, C1);
        DC.Add(C2.ID, C2);
        DC.Add(C3.ID, C3);

        Console.WriteLine("TryGetValue Function");  // Checks if the Key Exists or Not

        Costumer Cust;
        for(int i = 100; i < 105; i++)
        {
            if (DC.TryGetValue(i, out Cust))
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", Cust.ID, Cust.Name, Cust.Salary);
            }
            else
            {
                Console.WriteLine("Key: {0} not Found.", i);
            }

            Console.WriteLine("---------------------------------------------------------------------------------------------");
        }

        Console.WriteLine("Count Function");    // Checks Total Number of Items in the Dictionary
        Console.WriteLine("Total Items in Dictionary: {0}", DC.Count);

        Console.WriteLine("---------------------------------------------------------------------------------------------");
        Console.WriteLine("Overloaded Count Function");
        Console.WriteLine("Number of Employess having Salary greater than 5000: {0}", DC.Count(kvp => kvp.Value.Salary > 5000));

        Console.WriteLine("---------------------------------------------------------------------------------------------");

        Console.WriteLine("Remove Function");
        DC.Remove(101);

        Console.WriteLine("Item 101 in Dictionary Removed.");

        for(int i = 100; i < 105; i++)
        {
            Console.WriteLine("---------------------------------------------------------------------------------------------");
            if (DC.TryGetValue(i, out Cust))
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", Cust.ID, Cust.Name, Cust.Salary);
            }
            else
            {
                Console.WriteLine("Key: {0} not Found.", i);
            }
        }

        Console.WriteLine("---------------------------------------------------------------------------------------------");

        Console.WriteLine("Clear Function");
        DC.Clear();
        
        Console.WriteLine("All Items in Dictionary Removed.");

        for(int i = 100; i < 105; i++)
        {
            Console.WriteLine("---------------------------------------------------------------------------------------------");
            if (DC.TryGetValue(i, out Cust))
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", Cust.ID, Cust.Name, Cust.Salary);
            }
            else
            {
                Console.WriteLine("Key: {0} not Found.", i);
            }
        }
    }
}

public class Costumer
{
    public int ID {get; set; }
    public string Name {get; set; }
    public int Salary {get; set; }
}
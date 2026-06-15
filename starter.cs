using System;
using System.Collections.Generic;

public class Customer
{
    // Properties voor Klantgegevens
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }

    public Customer(int id, string name, string email)
    {
        Id = id;
        Name = name;
        Email = email;
    }

    public override string ToString()
    {
        return $"ID: {Id}, Naam: {Name}, E-mail: {Email}";
    }
}

public class CustomerManager
{
    private List<Customer> customers = new List<Customer>();
    private int nextId = 1;

    // Methode om een klant toe te voegen
    public void AddCustomer(string name, string email)
    {
        // Implementeer hier de logica om een nieuwe klant toe te voegen
    }

    // Methode om alle klanten weer te geven
    public void DisplayAllCustomers()
    {
        // Implementeer hier de logica om alle klanten weer te geven
    }

    // Methode om een klant te zoeken op ID
    public Customer FindCustomerById(int id)
    {
        // Implementeer hier de logica om een klant te zoeken
        return null; // Placeholder
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        CustomerManager manager = new CustomerManager();

        // Voorbeeldgebruik (dit deel kan uitgebreid worden met een menu)
        manager.AddCustomer("Jan Jansen", "jan.jansen@example.com");
        manager.AddCustomer("Piet Pietersen", "piet.pietersen@example.com");

        manager.DisplayAllCustomers();

        Customer foundCustomer = manager.FindCustomerById(1);
        if (foundCustomer != null)
        {
            Console.WriteLine($"Gevonden klant: {foundCustomer.Name}");
        }
        else
        {
            Console.WriteLine("Klant niet gevonden.");
        }
    }
}
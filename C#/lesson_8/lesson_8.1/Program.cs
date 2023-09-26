using System;

public class Address
{
    private string index;
    private string country;
    private string city;
    private string street;
    private string house;
    private string apartment;

    public string Index
    {
        get { return index; }
        set { index = value; }
    }


    public string Country
    {
        get { return country; }
        set { country = value; }
    }

    public string City
    {
        get { return city; }
        set { city = value; }
    }
    public string Street
    {
        get { return street; }
        set { street = value; }
    }
    public string House
    {
        get { return house; }
        set { house = value; }
    }

    public string Apartment
    {
        get { return apartment; }
        set { apartment = value; }
    }

    public Address(string index, string country, string city, string street, string house, string apartment)
    {
        Index = index;
        Country = country;
        City = city;
        Street = street;
        House = house;
        Apartment = apartment;
    }

    public void DisplayAddress()
    {
        Console.WriteLine($"Index: {Index}");
        Console.WriteLine($"Country: {Country}");
        Console.WriteLine($"City: {City}");
        Console.WriteLine($"Street: {Street}");
        Console.WriteLine($"House: {House}");
        Console.WriteLine($"Apartment: {Apartment}");
        Console.ReadKey();  
    }
}

class Program
{
    static void Main()
    {
        Address myAddress = new Address("12345", "USA", "New York", "Main Street", "123", "Apt 4B");
        myAddress.DisplayAddress();
    }
}

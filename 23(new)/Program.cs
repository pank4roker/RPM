using System;
using System.Collections.Generic;
using System.IO;

class Country
{
    public string Name { get; set; }
    public string Capital { get; set; }
    public string OfficialLanguage { get; set; }
    public long Population { get; set; }
    public double Area { get; set; }
    public string Currency { get; set; }
    public string GovernmentType { get; set; }
    public string HeadOfState { get; set; }

    public Country(string name, string capital, string language, long population, double area, string currency, string governmentType, string headOfState)
    {
        Name = name;
        Capital = capital;
        OfficialLanguage = language;
        Population = population;
        Area = area;
        Currency = currency;
        GovernmentType = governmentType;
        HeadOfState = headOfState;
    }

    public Country() { }

    public void DisplayData()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Capital: {Capital}");
        Console.WriteLine($"Official Language: {OfficialLanguage}");
        Console.WriteLine($"Population: {Population} people");
        Console.WriteLine($"Area: {Area} km²");
        Console.WriteLine($"Currency: {Currency}");
        Console.WriteLine($"Government Type: {GovernmentType}");
        Console.WriteLine($"Head of State: {HeadOfState}");
    }

    public static void WriteToFile(List<Country> countries, string path)
    {
        using (StreamWriter writer = new StreamWriter(path, false))
        {
            foreach (var country in countries)
            {
                writer.WriteLine($"{country.Name}|{country.Capital}|{country.OfficialLanguage}|{country.Population}|{country.Area}|{country.Currency}|{country.GovernmentType}|{country.HeadOfState}");
            }
        }
    }

    public static List<Country> ReadFromFile(string path)
    {
        List<Country> countries = new List<Country>();
        using (StreamReader reader = new StreamReader(path))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                var data = line.Split('|');
                if (data.Length == 8)
                {
                    Country country = new Country(data[0], data[1], data[2], long.Parse(data[3]), double.Parse(data[4]), data[5], data[6], data[7]);
                    countries.Add(country);
                }
            }
        }
        return countries;
    }
}

class Program
{
    static void Main()
    {
        string filePath = @"C:\Users\Kirill\Desktop\23(new)\Base.txt";
        List<Country> countries = Country.ReadFromFile(filePath);

        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Display all countries");
            Console.WriteLine("2. Display countries with a population over 20 million");
            Console.WriteLine("3. Add new country");
            Console.WriteLine("4. Write to file");
            Console.WriteLine("5. Exit");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    foreach (var country in countries)
                    {
                        country.DisplayData();
                        Console.WriteLine();
                    }
                    break;
                case "2":
                    foreach (var country in countries)
                    {
                        if (country.Population > 20000000)
                        {
                            country.DisplayData();
                            Console.WriteLine();
                        }
                    }
                    break;
                case "3":
                    AddNewCountry(countries);
                    break;
                case "4":
                    Country.WriteToFile(countries, filePath);
                    Console.WriteLine("Data has been written to the file.");
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }
        }
    }

    static void AddNewCountry(List<Country> countries)
    {
        Console.WriteLine("Enter the name of the country:");
        string name = Console.ReadLine();
        Console.WriteLine("Enter the capital of the country:");
        string capital = Console.ReadLine();
        Console.WriteLine("Enter the official language:");
        string language = Console.ReadLine();
        Console.WriteLine("Enter the population:");
        long population = long.Parse(Console.ReadLine());
        Console.WriteLine("Enter the area in square kilometers:");
        double area = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the currency:");
        string currency = Console.ReadLine();
        Console.WriteLine("Enter the government type:");
        string governmentType = Console.ReadLine();
        Console.WriteLine("Enter the head of state:");
        string headOfState = Console.ReadLine();

        countries.Add(new Country(name, capital, language, population, area, currency, governmentType, headOfState));
    }
}
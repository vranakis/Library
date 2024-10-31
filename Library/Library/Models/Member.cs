using Library.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models;

public class Member(string firstName, string lastName)
{
    public string FirstName { get; set; } = firstName;
    public string LastName { get; set; } = lastName;
    public List<IRentable> RentedObjects { get; set; } = new List<IRentable>();

    public bool IsActive { get; set; } = true;
    public void ToggleActive()
    {
        IsActive = !IsActive;
    }
    public void GetRentedPubs()
    {
        Console.WriteLine($"All the publications rented by the member:\n");
        foreach (IRentable item in RentedObjects)
        {
            Console.WriteLine($"{item.GetType().Name}:");
            if (item is Publication publication)
            {
                Console.WriteLine($"{publication.Title}");
            }
        }
    }
}

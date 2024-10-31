using Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models;

public abstract class Publication(string author, string title, string publisher) : IRentable
{
    public string Author { get; set; } = author;
    public string Title { get; set; } = title;
    public string Publisher { get; set; } = publisher;
    public List<Publication> Publications { get; set; } = [];

    //IRentable properties
    public DateTime LastUpdate { get; set; }
    public bool Available { get; set; }
    public void Rent(Member member)
    {
        Available = false;
        LastUpdate = DateTime.Now;
        member.RentedObjects.Add(this);
        Console.WriteLine($"{GetType().Name} '{Title}' rented by {member.FirstName} {member.LastName}");
    }
    public void Return(Member member)
    {
        Available = true;
        LastUpdate = DateTime.Now;
        Console.WriteLine($"{GetType().Name}: '{Title}' returned by {member.FirstName} {member.LastName}");
    }
    public bool IsAvailable()
    {  
        return Available; 
    }

    //Methods
    public List<Publication> GetAvailables() 
    {
        return Publications.FindAll(pub => pub.Available);
    }
    public int DaysSinceLastUpdate() 
    {
        return (DateTime.Now - LastUpdate).Days;
    }
}

using Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models;

internal class Equipment(string name, string type) : IRentable
{
    public string Name { get; set; } = name;
    public string Type { get; set; } = type;

    //IRentable properties
    public DateTime LastUpdate { get; set; }
    public bool Available { get; set; }
    public void Rent(Member member) { 
        this.Available = false;
        LastUpdate = DateTime.Now;
        Console.WriteLine($"Equipment '{Name}' rented by {member.FirstName} {member.LastName}");
    }
    public void Return(Member member) 
    {
        Available = true;
        LastUpdate = DateTime.Now;
        Console.WriteLine($"Equipment '{Name}' returned by {member.FirstName} {member.LastName}");
    }
    public Boolean IsAvailable() 
    { 
        return Available; 
    }
}

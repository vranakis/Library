using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloggerApp.Models;

    public class Product
    {
    //public int id; pedio
    public int Id { get; set; } = 1; 
    public string? Name { get; set; } = "";
    public DateTime RegistrationDate { get; set; }
    }


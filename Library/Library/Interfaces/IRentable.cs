using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Models;

namespace Library.Interfaces;

public interface IRentable
{
    DateTime LastUpdate { get; set; }
    bool Available { get; set; }
    void Rent(Member member);
    void Return(Member member);
    Boolean IsAvailable();
}

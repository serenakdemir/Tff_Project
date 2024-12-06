using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tff_Project.Models.Enums;

namespace Tff_Project.Models;

public sealed class Player : Entity<Guid>
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Number { get; set; }
    public Branch Branch { get; set; }
    public int Age { get; set; }
    public double MarketValue { get; set; }

    public Gender Gender { get; set; }

    public int TeamId { get; set; }


    public override string ToString()
    {
        return $"{Id},{Name}, {Surname}, {Number}, {Branch},{Age},{MarketValue},{TeamId}, {Gender}";
    }
}

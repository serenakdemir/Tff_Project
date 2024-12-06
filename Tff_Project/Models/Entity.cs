using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tff_Project.Models;

public abstract class Entity<TId>
{
    public TId Id { get; set; }
}

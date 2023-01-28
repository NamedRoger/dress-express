using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.SeedWork;

public interface IBusinessRule
{
    string Message { get; }
    bool IsBroke();
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.SeedWork;

public class BusinessRuleException : Exception
{
    public IBusinessRule Rule { get; set; }

    public BusinessRuleException(IBusinessRule rule)
        : base(rule.Message)
    {
        Rule = rule;
    }
}

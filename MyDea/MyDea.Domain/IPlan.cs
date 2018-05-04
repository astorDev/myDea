using System;
using System.Collections.Generic;
using System.Text;

namespace MyDea.Domain
{
    public interface IPlan
    {
        string Name { get; }
        DateTime Date { get; }
    }
}

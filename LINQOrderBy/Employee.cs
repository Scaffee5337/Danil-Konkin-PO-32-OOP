using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace LINQOrderBy
{
    public record Employee(
        int Id,
        string FullName,
        string Department,
        string Position,
        decimal Salary,
        DateTime HireDate
    );
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LINQOrderBy
{
        public enum EmployeeSortMode
        {
            FullNameAscending,
            SalaryDescending,
            DepartmentSalary,
            PositionHireDate
        }

        public class EmployeeProcessor
        {
            public List<Employee> Process(
                List<Employee> employees,
                string selectedDept,
                decimal minSalary,
                decimal maxSalary,
                string searchText,
                EmployeeSortMode sortMode)
            {
                var result = employees.Where(e =>
                    (selectedDept == "Все отделы" ||
                     e.Department == selectedDept) &&
                    e.Salary >= minSalary &&
                    e.Salary <= maxSalary &&
                    (string.IsNullOrWhiteSpace(searchText) ||
                     e.FullName.Contains(
                         searchText.Trim(),
                         StringComparison.OrdinalIgnoreCase))
                );
                switch (sortMode)
                {
                    case EmployeeSortMode.FullNameAscending: result = result.OrderBy(e => e.FullName);
                        break;
                    case EmployeeSortMode.SalaryDescending:result = result.OrderByDescending(e => e.Salary);
                        break;
                    case EmployeeSortMode.DepartmentSalary:
                        result = result.OrderBy(e => e.Department).ThenByDescending(e => e.Salary);
                        break;
                    case EmployeeSortMode.PositionHireDate:
                        result = result.OrderBy(e => e.Position).ThenBy(e => e.HireDate);
                        break;
                }
                return result.ToList();
            }
        }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace Excercise_1;

internal class Program
{
    private static List<Employee> employees = new();

    static void Main(string[] args)
    {
        Console.WriteLine("The small restaurant");
        Console.WriteLine("====================");
        Console.WriteLine("Please enter your employees as <first name>[tab]<last name>[tab]<salary>");
        Console.WriteLine("or <first name>[tab]<salary>, end with an empty line.");

        while (true)    
        {
            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                break;
            }
            var parts = input.Split('\t');

            Employee? employee;
            if (parts.Length == 2)
            {
                employee = new Employee(parts[0], float.Parse(parts[1]));
            }
            else if (parts.Length > 2)
            {
                employee = new Employee(parts[0], parts[1], float.Parse(parts[2]));
            } 
            else
            {
                Console.WriteLine("Invalid input");
                continue;
            }
            if (employee is not null)
            {
                employees.Add(employee);
            }
        }

        Console.WriteLine();    
        Console.WriteLine($"Employees ({employees.Count()}):");
        foreach (var employee in employees)
        {
            employee.Print();
        }
    }
}

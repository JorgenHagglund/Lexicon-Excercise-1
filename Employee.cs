using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1;

public class Employee
{
    string firstName { get; set; }  
    string lastName { get; set; }       
    float salary { get; set; }

    public Employee(string firstName, string lastName, float salary)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.salary = salary;
    }   

    public Employee(string firstName, float salary)
    {
        this.firstName = firstName;
        this.lastName = string.Empty;
        this.salary = salary;
    }  

    public void Print()
    {
        Console.WriteLine($"{firstName}\t{lastName}\t{salary:F2}");  
    }
}

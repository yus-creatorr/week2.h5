using Domain.Models;

namespace Infrastructure.Services;

public class EmployeeService
{
    public void PrintEmployee(Employee employee)
    {
        Console.WriteLine($"Name: {employee.Firstname} {employee.Lastname}");
        Console.WriteLine($"Birth date: {employee.BirthDate.ToShortDateString()}");
        Console.WriteLine($"Salary: {employee.Salary}");
        Console.WriteLine($"Department: {employee.Department.Name}");
    }
}

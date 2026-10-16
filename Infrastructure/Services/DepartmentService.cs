using Domain.Models;

namespace Infrastructure.Services;

public class DepartmentService
{
    public void PrintDepartment(Department department)
    {
        Console.WriteLine($"Department: {department.Name}");
        Console.WriteLine($"Description: {department.Description}");
        Console.WriteLine($"Manager: {department.Manager.Firstname} {department.Manager.Lastname}");
    }
}

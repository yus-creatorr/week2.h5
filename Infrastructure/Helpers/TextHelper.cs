using Domain.Models;

namespace Infrastructure.Helpers;

public class TextHelper
{
    public string GetFullName(Employee employee)
    {
        return employee.Firstname + " " + employee.Lastname;
    }
}

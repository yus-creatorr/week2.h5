using Domain.Models;
using Infrastructure.Helpers;
using Infrastructure.Services;

Department department = new Department();
department.Name = "IT";
department.Description = "Information Technology";

department.Manager = new Employee();
department.Manager.Firstname = "Ali";
department.Manager.Lastname = "Karimov";

department.Manager.BirthDate = new DateTime(1985, 5, 12);
department.Manager.Salary = 5000m;
department.Manager.Department = department;

Employee employee = new Employee();
employee.Firstname = "Said";
employee.Lastname = "Rahimov";
employee.BirthDate = new DateTime(2000, 3, 15);
employee.Salary = 2500m;
employee.Department = department;

EmployeeService employeeService = new EmployeeService();
DepartmentService departmentService = new DepartmentService();
TextHelper textHelper = new TextHelper();

Console.WriteLine("=== Employee ===");
employeeService.PrintEmployee(employee);
Console.WriteLine("Full name from helper: " + textHelper.GetFullName(employee));

Console.WriteLine();
Console.WriteLine("=== Department ===");
departmentService.PrintDepartment(department);

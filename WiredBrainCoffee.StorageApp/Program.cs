using System;
using WiredBrainCoffee.StorageApp.Entities;
using WiredBrainCoffee.StorageApp.Repositories;

namespace WiredBrainCoffee.StorageApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var employeeRepository = new GenericRepository<Employee>();
            AddEmployees(employeeRepository);
            GetEmployeeById(employeeRepository);

            var organizationRepository = new GenericRepository<Organization>();
            AddOrganizations(organizationRepository);
        }

        private static void GetEmployeeById(GenericRepository<Employee> employeeRepository)
        {
            Employee employee = employeeRepository.GetById(2);
            Console.WriteLine($"Employee with Id = 2 : {employee.FirstName}");
        }

        private static void AddEmployees(GenericRepository<Employee> employeeRepository)
        {
            employeeRepository.Add(new Employee { FirstName = "John" });
            employeeRepository.Add(new Employee { FirstName = "Carter" });
            employeeRepository.Add(new Employee { FirstName = "Basoom" });
            employeeRepository.Save();
        }

        private static void AddOrganizations(GenericRepository<Organization> organizationRepository)
        {
            organizationRepository.Add(new Organization { Name = "Apple Inc." });
            organizationRepository.Add(new Organization { Name = "Tesla Inc." });
            organizationRepository.Add(new Organization { Name = "Boring Company" });
            organizationRepository.Save();
        }
    }
}
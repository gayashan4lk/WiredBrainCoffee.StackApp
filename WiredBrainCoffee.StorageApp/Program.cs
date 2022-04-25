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
            employeeRepository.Add(new Employee { FirstName = "John" });
            employeeRepository.Add(new Employee { FirstName = "Carter" });
            employeeRepository.Add(new Employee { FirstName = "Basoom" });
            employeeRepository.Save();

            var organizationRepository = new GenericRepositoryWithRemove<Organization>();
            organizationRepository.Add(new Organization { Name = "Apple Inc." });
            organizationRepository.Add(new Organization { Name = "Tesla Inc." });
            organizationRepository.Add(new Organization { Name = "Boring Company" });
            organizationRepository.Save();
            organizationRepository.Remove(new Organization { Name = "Boring Company" });
            organizationRepository.Save();
        }
    }
}
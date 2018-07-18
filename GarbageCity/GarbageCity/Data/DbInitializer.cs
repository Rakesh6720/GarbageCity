using GarbageCity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GarbageCity.Data
{
    public class DbInitializer
    {
        public static void Initialize(CompanyContext context)
        {
            //context.Database.EnsureCreated();
            if (!context.Customer.Any())
            {
                var customers = new Customer[]
            {
                new Customer{LastName="Alexander", FirstMidName="Carson", Address="44 Bilbo Road", ZipCode=11111, PickupDay="Monday"},
                new Customer{FirstMidName="Meredith", LastName="Alonso", Address="55 Pineapple Way", ZipCode=22222, PickupDay="Tuesday"},
                new Customer{FirstMidName="Arturo", LastName="Anand", Address="66 Lucy Lane", ZipCode=33333, PickupDay="Wednesday"}
            };
                foreach (Customer c in customers)
                {
                    context.Customer.Add(c);
                }
                context.SaveChanges();
            }

            if (!context.Employee.Any())
            {
                var employees = new Employee[]
                {
                new Employee{FirstMidName="Gavin", LastName="Rossdale", EmployeeID=11111 },
                new Employee{FirstMidName="Gwen", LastName="Stefani", EmployeeID=22222},
                new Employee{FirstMidName="Avery", LastName="Carmichael", EmployeeID=33333}
                };
                foreach (Employee e in employees)
                {
                    context.Employee.Add(e);
                }
                context.SaveChanges();
                return;
            }
        }
    }
}

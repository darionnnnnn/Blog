using System;
using System.Linq;
using System.Threading.Tasks;
using DBFirst.Models;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace DBFirst
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var connectionString = @"Persist Security Info=False;User ID=[loginId];Password=[Password];Initial Catalog=Northwind;Server=[DB_IP]";

            await using (var services = new ServiceCollection()
                .AddDbContext<Northwind>(options => options.UseSqlServer(connectionString))
                .BuildServiceProvider())
            {
                var dbNorthwind = services.GetRequiredService<Northwind>();

                var employees = await dbNorthwind.Employees.ToListAsync();

                Console.WriteLine("Employee Info");

                foreach (var employee in employees)
                {
                    Console.WriteLine($"Id: {employee.EmployeeId}, Name: {employee.FirstName} {employee.LastName}");
                }
            }

            Console.ReadLine();
        }
    }
}

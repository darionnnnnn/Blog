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

            // 透過 .AddDbContext 將 Northwind 註冊到 DI 容器
            await using (var services = new ServiceCollection()
                .AddDbContext<Northwind>(options => options.UseSqlServer(connectionString))
                .BuildServiceProvider())
            {
                // 透過 DI 容器取得物件
                var dbNorthwind = services.GetRequiredService<Northwind>();

                // 取得全部 employee 資料
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

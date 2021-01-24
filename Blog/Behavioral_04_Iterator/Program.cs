using System;

namespace Behavioral_04_Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Default

            // Default.ConcreteAggregate aggregate = new Default.ConcreteAggregate
            // {
            //     [0] = "Item A", [1] = "Item B", [2] = "Item C", [3] = "Item D"
            // };
            //
            // Default.IIterator iterator = aggregate.CreateIterator();
            //
            // Console.WriteLine("遍歷 ConcreteAggregate:");
            //
            // var item = iterator.First();
            // while (item != null)
            // {
            //     Console.WriteLine(item);
            //     item = iterator.Next();
            // }

            #endregion

            #region Situation

            Situation.Employees employees = new Situation.Employees
            {
                [0] = new Situation.Employee { Id = 1, Name = "Wayne", EmployeeType = Situation.EmployeeType.General},
                [1] = new Situation.Employee { Id = 2, Name = "Dog", EmployeeType = Situation.EmployeeType.Honours },
                [2] = new Situation.Employee { Id = 3, Name = "Andy", EmployeeType = Situation.EmployeeType.General },
                [3] = new Situation.Employee { Id = 4, Name = "Cat", EmployeeType = Situation.EmployeeType.Honours },
            };
            
            Situation.IIterator iterator = employees.CreateIterator();
            
            Console.WriteLine("Iterating over collection:");
            
            var item = iterator.First();
            while (item != null)
            {
                Console.WriteLine($"Id: {item.Id}, Name: {item.Name}");
                item = iterator.Next();
            }

            #endregion

            Console.ReadLine();
        }
    }
}

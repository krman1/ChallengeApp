using ChallengeApp;
using System;

List<Employee> employees = new List<Employee>();

Employee employee1 = new Employee("Adam", "Nowak", 34);
Employee employee2 = new Employee("Ewa", "Kowalska", 31);
Employee employee3 = new Employee("Jan", "Grabowski", 25);
employee1.AddScore(5);
employee1.AddScore(7);
employee1.AddScore(3);
employee1.AddScore(8);
employee1.AddScore(1);
employee2.AddScore(2);
employee2.AddScore(5);
employee2.AddScore(9);
employee2.AddScore(8);
employee2.AddScore(9);
employee3.AddScore(3);
employee3.AddScore(5);
employee3.AddScore(7);
employee3.AddScore(3);
employee3.AddScore(9);

employees.Add(employee1);
employees.Add(employee2);
employees.Add(employee3);

int maxResult = 0;
Employee employeeWithMaxresult = null;
foreach (var employee in employees)
{
    if(employee.Result >  maxResult)
    { 
       maxResult = employee.Result; 
       employeeWithMaxresult = employee;
    }
}
Console.WriteLine("Najwiecej punktów otrzymał pracownik:");
Console.WriteLine(employeeWithMaxresult.Name +" " + employeeWithMaxresult.Surname + ", wiek: "+ employeeWithMaxresult.Age + "lat, uzyskany wynik: " + employeeWithMaxresult.Result);


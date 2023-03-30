using ChallengeApp;
using System;

List<Employee> employers = new List<Employee>();

Employee employee1 = new Employee("Adam", "Nowak", 34);
Employee employee2 = new Employee("Ewa", "Kowalska", 31);
Employee employee3 = new Employee("Jan", "Grabowski", 25);
employee1.AddScore(50);
employee1.AddScore(1);
employee1.AddScore(1);
employee1.AddScore(1);
employee1.AddScore(1);
employee2.AddScore(2);
employee2.AddScore(2);
employee2.AddScore(2);
employee2.AddScore(2);
employee2.AddScore(2);
employee3.AddScore(3);
employee3.AddScore(3);
employee3.AddScore(3);
employee3.AddScore(3);
employee3.AddScore(3);

employers.Add(employee1);
employers.Add(employee2);
employers.Add(employee3);

int maxResult = 0;
Employee employeeWithMaxresult = null;
foreach (var employee in employers)
{
    if(employee.Result >  maxResult)
    { 
       maxResult = employee.Result; 
       employeeWithMaxresult = employee;
    }
}
Console.WriteLine(employeeWithMaxresult.Name +" " + employeeWithMaxresult.Surname + " "+ employeeWithMaxresult.Age + " " + employeeWithMaxresult.Result);


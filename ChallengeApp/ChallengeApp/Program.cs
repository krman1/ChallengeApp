using ChallengeApp;
using System;

var employee = new Employee("Adam", "Nowak");

employee.AddScore(2); 
employee.AddScore(2);
employee.AddScore(6);

var statistics = employee.GetStatistics();
Console.WriteLine($"Averange: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");



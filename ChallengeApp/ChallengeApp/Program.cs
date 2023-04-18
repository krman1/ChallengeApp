using ChallengeApp;



Console.WriteLine("Witamy w programie XYZ do oceny Pracowników");
Console.WriteLine("=============================================");
Console.WriteLine();

var employee = new EmployeeInMemory("Adam", "Nowak");
employee.GradeAdded += employee.EmployeeGradeAdded;

employee.AddScore(10f);

var employeeInFile = new EmployeeInFile("Ewa", "Kowalska");
employeeInFile.GradeAdded += employeeInFile.EmployeeGradeAdded;

employeeInFile.AddScore(15f);


/*Console.WriteLine($"Average: {statisticsFile.Average}");
Console.WriteLine($"Min: {statisticsFile.Min}");
Console.WriteLine($"Max: {statisticsFile.Max}");
Console.WriteLine($"AverageLetter: {statisticsFile.AverageLetter}");*/
//employeeFile.ClearFile();   



/*while (true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika");
    var input = Console.ReadLine();
    if (input == "q")
    { 
        break;
    }
    try
    {
        employee.AddScore(input);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exeption catched: {e.Message}");
    }
}

var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"AverageLetter: {statistics.AverageLetter}");*/







using ChallengeApp;

var employeeFile = new EmployeeInFile("Adam", "Nowak");

Console.WriteLine("Witamy w programie XYZ do oceny Pracowników");
Console.WriteLine("=============================================");
Console.WriteLine();

employeeFile.AddScore(5f);
employeeFile.AddScore("15");
employeeFile.AddScore('d');

var statisticsFile = employeeFile.GetStatistics();

Console.WriteLine($"Average: {statisticsFile.Average}");
Console.WriteLine($"Min: {statisticsFile.Min}");
Console.WriteLine($"Max: {statisticsFile.Max}");
Console.WriteLine($"AverageLetter: {statisticsFile.AverageLetter}");
employeeFile.ClearFile();   



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







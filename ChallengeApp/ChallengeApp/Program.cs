using ChallengeApp;



Console.WriteLine("Witamy w programie XYZ do oceny Pracowników");
Console.WriteLine("=============================================");
Console.WriteLine();

//var employeeInMemory = new EmployeeInMemory("Marcin", "Nowak");
var employeeInFile = new EmployeeInFile("Ewa", "Kowalska");


while (true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    try
    {
        //employeeInMemory.AddScore(input);
        employeeInFile.AddScore(input);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exeption catched: {e.Message}");
    }
}

//var statistics = employeeInMemory.GetStatistics();
var statistics = employeeInFile.GetStatistics();
Console.WriteLine($"Average: {statistics.Average}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"AverageLetter: {statistics.AverageLetter}");







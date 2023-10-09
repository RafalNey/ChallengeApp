using ChallengeApp;
using System.ComponentModel.DataAnnotations;

Console.WriteLine("====================================");
Console.WriteLine("Witamy w programie oceny supervisora");
Console.WriteLine("====================================");
Console.WriteLine("Skala ocen: 1-6, mozna stosowac z '+' lub '-'. Np: 3+");
Console.WriteLine("Wybierajac 'Q' (quit), konczysz dodawanie ocen.");
Console.WriteLine();

var supervisor = new Supervisor("Adam", "Kamizelich");

while (true)
{
    Console.WriteLine("Podaj kolejna ocene supervisora: ");
    var input = Console.ReadLine();
    if (input != null)
    {
        if (input == "q" || input == "Q")
        {
            break;
        }
        try
        {
            supervisor.AddGrade(input);
        }
        catch (Exception e)
        {
            Console.WriteLine($"Exeption catched: {e.Message}");
        }
    }
    else
    {
        input = "0";
    }
}
// wylistowanie superwisiora i jego statystyk:
var statistics = supervisor.GetStatistics();

Console.WriteLine($"{supervisor.Name} {supervisor.Surname} - max: {statistics.Max:N0}, min: {statistics.Min:N0}, srednia: {statistics.Average:N2} srednia cyferkowa: {statistics.AverageDigit}");


/*
Console.WriteLine("====================================");
Console.WriteLine("Witamy w programie oceny pracownikow");
Console.WriteLine("====================================");
Console.WriteLine("Skala numeryczna ocen: 0-100, skala literowa: A-E.");
Console.WriteLine("Wybierajac 'Q' (quit), konczysz dodawanie ocen.");
Console.WriteLine();

var employee = new Employee("Adam", "Kamizelich");
//var employee = new Employee();

while (true)
{
    Console.WriteLine("Podaj kolejna ocene pracownika: ");
    var input = Console.ReadLine();
    if (input != null)
    {
        if (input == "q" || input == "Q")
        {
            break;
        }
        try
        {
            employee.AddGrade(input);
        }
        catch (Exception e)
        {
            Console.WriteLine($"Exeption catched: {e.Message}");
        }
    }
    else
    {
        input = "0";
    }
}
// wylistowanie pracownika i jego statystyk:
var statistics = employee.GetStatistics();

Console.WriteLine($"{employee.Name} {employee.Surname}- max: {statistics.Max:N0}, min: {statistics.Min:N0}, srednia: {statistics.Average:N2} srednia literowa: {statistics.AverageLetter}");
*/
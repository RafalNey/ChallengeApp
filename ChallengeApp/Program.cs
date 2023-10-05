﻿using ChallengeApp;
using System.ComponentModel.DataAnnotations;

Console.WriteLine("====================================");
Console.WriteLine("Witamy w programie oceny pracownikow");
Console.WriteLine("====================================");
Console.WriteLine("Skala numeryczna ocen: 0-100, skala literowa A-E.");
Console.WriteLine("W kazdej chwili mozesz wybrac 'Q' (quit), aby zakonczyc dodawanie ocen.");
Console.WriteLine();

var employee = new Employee("Adam", "Kamizelich");

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
        employee.AddGrade(input);
    }
    else
    {
        input = "0";
    }
}
// wylistowanie pracownika i jego statystyk:
var statistics = employee.GetStatistics();

Console.WriteLine($"{employee.Name} {employee.Surname} - max: {statistics.Max:N0}, min: {statistics.Min:N0}, srednia: {statistics.Average:N2} srednia literowa: {statistics.AverageLetter}");
using ChallengeApp;

var employee = new Employee("Adam", "Kamizelich");

employee.AddGrade("Kalafior");
employee.AddGrade("4000");
employee.AddGrade("3");
employee.AddGrade(4);
employee.AddGrade(5);

// wylistowanie pracownika i jego statystyk na pierdyliard sposobow:
Console.WriteLine($"{employee.Name} {employee.Surname}");

var statistics = employee.GetStatistics();

Console.WriteLine($"GetStatistics:            max: {statistics.Max}, min: {statistics.Min}, srednia: {statistics.Average:N2}");
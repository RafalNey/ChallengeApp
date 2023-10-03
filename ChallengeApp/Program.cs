using ChallengeApp;

var employee = new Employee("Adam", "Kamizelich");

employee.AddGrade("Kalafior");
employee.AddGrade("4000");
employee.AddGrade("3");
employee.AddGrade(4);
employee.AddGrade(5);

// wylistowanie pracownika i jego statystyk na pierdyliard sposobow:
Console.WriteLine($"{employee.Name} {employee.Surname}");

var statistics1 = employee.GetStatistics();
var statistics2 = employee.GetStatisticsWithForEach();
var statistics3 = employee.GetStatisticsWithFor();
var statistics4 = employee.GetStatisticsWithDoWhile();
var statistics5 = employee.GetStatisticsWithWhile();

Console.WriteLine($"GetStatistics:            max: {statistics1.Max}, min: {statistics1.Min}, srednia: {statistics1.Average:N2}");
Console.WriteLine($"GetStatisticsWithForEach: max: {statistics2.Max}, min: {statistics2.Min}, srednia: {statistics2.Average:N2}");
Console.WriteLine($"GetStatisticsWithFor:     max: {statistics3.Max}, min: {statistics3.Min}, srednia: {statistics3.Average:N2}");
Console.WriteLine($"GetStatisticsWithDoWhile: max: {statistics4.Max}, min: {statistics4.Min}, srednia: {statistics4.Average:N2}");
Console.WriteLine($"GetStatisticsWitzWhile:   max: {statistics5.Max}, min: {statistics5.Min}, srednia: {statistics5.Average:N2}");

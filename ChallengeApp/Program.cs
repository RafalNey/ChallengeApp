using ChallengeApp;

//dodawanie pracownikow
var employee1 = new Employee("Adam", "Kamizelich");
var employee2 = new Employee("Rafal", "Ney");
var employee3 = new Employee("Monika", "Ratownika");
var employee4 = new Employee("Zuzia", "Nieduza");

// przyznawanie losowych punktow pracownikowi (zeby bylo uczciwiej)
List<Employee> employees = new List<Employee>()
{ employee1, employee2, employee3, employee4 };

foreach (var employee in employees)
{
    for (int i = 0; i < 5; i++)
    {
        Random random = new Random();
        float randomNumber = random.Next(0, 101);
        employee.AddGrade(randomNumber); ;
    }
}

employee1.AddGrade("Kalafior");
employee1.AddGrade("4000");
employee1.AddGrade("4");
employee1.AddGrade(40.00000);
employee1.AddGrade(400000000000000000.00000);

// wylistowanie pracownikow i ich statystyk:
foreach (var employee in employees)
{
    var statistics = employee.GetStatistics();
    Console.WriteLine($"{employee.Name} {employee.Surname},     max: {statistics.Max}, min: {statistics.Min}, srednia: {statistics.Average:N2}");
}

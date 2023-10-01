using NUnit.Framework.Constraints;

namespace ChallengeApp.Tests;

public class EmployeeTest
{
    [Test]
    public void AddOneEmployee()
    {
        // arrange
        var employee = new Employee("Adam", "Kamizelich");

        //act

        //asert
        Assert.That(employee.Name, Is.EqualTo("Adam"));
        Assert.That(employee.Surname, Is.EqualTo("Kamizelich"));
    }
    [Test]
    public void AddFewEmployees()
    {
        // arrange
        var employee1 = new Employee("Adam", "Kamizelich");
        var employee2 = new Employee("Rafal", "Ney");
        var employee3 = new Employee("Monika", "Ratownika");
        var employee4 = new Employee("Zuzia", "Nieduza");

        //act

        //asert
        Assert.That(employee1.Name, Is.EqualTo("Adam"));
        Assert.That(employee2.Name, Is.EqualTo("Rafal"));
        Assert.That(employee3.Name, Is.EqualTo("Monika"));
        Assert.That(employee4.Name, Is.EqualTo("Zuzia"));
    }
    [Test]
    public void AddGradesToOneEmployee()
    {
        // arrange
        var employee = new Employee("Adam", "Kamizelich");

        //act
        employee.AddGrade(2);
        employee.AddGrade(3);
        employee.AddGrade(4);

        var statistics = employee.GetStatistics();

        //asert
        Assert.That(statistics.Min, Is.EqualTo(2));
        Assert.That(statistics.Max, Is.EqualTo(4));
        Assert.That(statistics.Average, Is.EqualTo(3.00));
    }
    [Test]
    public void AddGradesToFewEmployee()
    {
        // arrange
        var employee1 = new Employee("Adam", "Kamizelich");
        var employee2 = new Employee("Rafal", "Ney");
        var employee3 = new Employee("Monika", "Ratownika");
        var employee4 = new Employee("Zuzia", "Nieduza");

        //act
        employee1.AddGrade(2);
        employee1.AddGrade(3);
        employee1.AddGrade(4);
        employee2.AddGrade(3);
        employee2.AddGrade(4);
        employee2.AddGrade(5);
        employee3.AddGrade(4);
        employee3.AddGrade(5);
        employee3.AddGrade(6);
        employee4.AddGrade(5);
        employee4.AddGrade(6);
        employee4.AddGrade(7);

        var statistics1 = employee1.GetStatistics();
        var statistics2 = employee2.GetStatistics();
        var statistics3 = employee3.GetStatistics();
        var statistics4 = employee4.GetStatistics();

        //asert
        Assert.That(statistics1.Min, Is.EqualTo(2));
        Assert.That(statistics1.Max, Is.EqualTo(4));
        Assert.That(statistics1.Average, Is.EqualTo(3.00));
        Assert.That(statistics2.Min, Is.EqualTo(3));
        Assert.That(statistics2.Max, Is.EqualTo(5));
        Assert.That(statistics2.Average, Is.EqualTo(4.00));
        Assert.That(statistics3.Min, Is.EqualTo(4));
        Assert.That(statistics3.Max, Is.EqualTo(6));
        Assert.That(statistics3.Average, Is.EqualTo(5.00));
        Assert.That(statistics4.Min, Is.EqualTo(5));
        Assert.That(statistics4.Max, Is.EqualTo(7));
        Assert.That(statistics4.Average, Is.EqualTo(6.00));
    }
    [Test]
    public void AddOnlyZeroesToOneEmployee()
    {
        // arrange
        var employee = new Employee("Adam", "Kamizelich");

        //act
        employee.AddGrade(0);
        employee.AddGrade(0);
        employee.AddGrade(0);
        employee.AddGrade(0);
        employee.AddGrade(0);
        employee.AddGrade(0);
        employee.AddGrade(0);

        var statistics = employee.GetStatistics();

        //asert
        Assert.That(statistics.Min, Is.EqualTo(0));
        Assert.That(statistics.Max, Is.EqualTo(0));
        Assert.That(statistics.Average, Is.EqualTo(0));
    }
    [Test]
    public void AddNegativesToOneEmployee()
    {
        // arrange
        var employee = new Employee("Adam", "Kamizelich");

        //act
        employee.AddGrade(-5);
        employee.AddGrade(0);
        employee.AddGrade(5);

        var statistics = employee.GetStatistics();

        //asert
        Assert.That(statistics.Min, Is.EqualTo(-5));
        Assert.That(statistics.Max, Is.EqualTo(5));
        Assert.That(statistics.Average, Is.EqualTo(0));
    }
    [Test]
    public void WhatIfGradesAreEmpty()
    {
        // arrange
        var employee = new Employee("Adam", "Kamizelich");

        //act
        var statistics = employee.GetStatistics();

        //asert
        Assert.That(statistics.Min, Is.EqualTo(float.MaxValue));
        Assert.That(statistics.Max, Is.EqualTo(float.MinValue));
        Assert.That(statistics.Average, Is.EqualTo(System.Double.NaN));
    }
}
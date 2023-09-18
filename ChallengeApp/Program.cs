using System.Data;

//liczby calkowite
int myAge1 = int.MaxValue;
var myAge2 = uint.MaxValue;
var myAge3 = long.MaxValue;
var myAge4 = ulong.MaxValue;
ulong myAge25 = (myAge2 - 1) * (myAge2 - 1);

//liczby zmiennoprzecinkowe
float myAge5 = float.MaxValue;
double myAge6 = double.MaxValue;
decimal myAge7 = decimal.MaxValue;

//zmienne tekstowe
string myName = "Rafal";
char mySymbol = 'N';
var naLiterki = myName.ToArray();

//zmienne logiczne
bool isActive = true;
bool isValid = 5 > 4;

//wyswietlanie na ekranie
Console.WriteLine(myAge1);
Console.WriteLine(myAge2);
Console.WriteLine(myAge3);
Console.WriteLine(myAge4);
Console.WriteLine(myAge2 + 1);
Console.WriteLine(myAge25 - 5);
Console.WriteLine();
Console.WriteLine(myAge5);
Console.WriteLine(myAge6);
Console.WriteLine(myAge7);
Console.WriteLine();
Console.WriteLine(myName + " " + mySymbol);
Console.WriteLine(naLiterki);
Console.WriteLine(isActive);
Console.WriteLine(!isValid);
Console.WriteLine();

var numberZiben = 37;
//var numberZibcis = 17;

if (numberZiben > 50)
{
    Console.WriteLine("Ziben jest 50 latkiem");
}
else if (numberZiben > 40)
{
    Console.WriteLine("Ziben jest 40 latkiem");
}
else if (numberZiben > 30)
{
    Console.WriteLine("Ziben jest 30 latkiem");
}
else
{
    Console.WriteLine("Ziben jest jeszcze za mlody");
}
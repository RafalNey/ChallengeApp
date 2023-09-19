ulong number = 1022033305066077709;
string numberInString = number.ToString();
char[] letters = numberInString.ToArray();
char[] cyfry = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
int[] liczbaCyfr = new int[10];

foreach (char letter in letters)
{
    for (int i = 0; i < 10; i++)
    {
        if (letter == cyfry[i]) { liczbaCyfr[i]++; }
    }
}
Console.WriteLine($"Wyniki dla liczby {number}:");
for (int i = 0; i < liczbaCyfr.Length; i++)
{
    Console.WriteLine($"{i} => {liczbaCyfr[i]}");
}


/*

liczby calkowite
int myAge1 = int.MaxValue;
var myAge2 = uint.MaxValue;
var myAge3 = long.MaxValue;
var myAge4 = ulong.MaxValue;
ulong myAge25 = (myAge2 - 1) * (myAge2 - 1);

liczby zmiennoprzecinkowe
float myAge5 = float.MaxValue;
double myAge6 = double.MaxValue;
decimal myAge7 = decimal.MaxValue;

zmienne tekstowe
string myName = "Rafal";
char mySymbol = 'N';
var naLiterki = myName.ToArray();

zmienne logiczne
bool isActive = true;
bool isValid = 5 > 4;

*/
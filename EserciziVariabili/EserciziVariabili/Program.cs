
#region 1. Dichiarare una variabile di tipo `int` e assegnarle un valore, quindi modificarlo.
Console.WriteLine("\n========== ESERCIZIO 1 ==========");

int number = 10;
Console.WriteLine(number);
number = 20;
Console.WriteLine(number);
#endregion

#region 2. Creare una variabile di tipo `string`, assegnarle un valore e concatenarla con un'altra stringa.
Console.WriteLine("\n========== ESERCIZIO 2 ==========");

string name = "Andrea";
string greeting = "Hello " + name;
Console.WriteLine(greeting);
#endregion

#region 3. Dichiarare una variabile di tipo `bool` e cambiarne il valore.
Console.WriteLine("\n========== ESERCIZIO 3 ==========");

bool isActive = true;
Console.WriteLine(isActive);
isActive = false;
Console.WriteLine(isActive);
#endregion

#region 4. Utilizzare una variabile di tipo `double` per rappresentare un numero con decimali.
Console.WriteLine("\n========== ESERCIZIO 4 ==========");

double price = 13.99;
Console.WriteLine(price);
#endregion

#region 5. Dichiarare una variabile `char` e assegnarle un carattere.
Console.WriteLine("\n========== ESERCIZIO 5 ==========");

char letter = 'A';
Console.WriteLine(letter);
#endregion

#region 6. Usare una variabile di tipo `decimal` per rappresentare una quantità monetaria.
Console.WriteLine("\n========== ESERCIZIO 6 ==========");

decimal amount = 1234.56m;
Console.WriteLine(amount);
#endregion

#region 7. Dichiarare una variabile `float` e assegnarle un valore, verificandone la precisione rispetto a `double`.
Console.WriteLine("\n========== ESERCIZIO 7 ==========");

float floatNumber = 1.23456789f;   //Mostrerà circa 7 cifre decimali
Console.WriteLine(floatNumber);
double doubleNumber = 1.23456789;   //Mostrerà circa 15-17 cifre decimali
Console.WriteLine(doubleNumber);
#endregion

#region 8. Dichiarare una variabile `long` per rappresentare un numero molto grande.
Console.WriteLine("\n========== ESERCIZIO 8 ==========");

long longNumber = 1234567891011213;   
Console.WriteLine(longNumber);
#endregion

#region 9. Creare una variabile `short` e verificare il suo range di valori.
Console.WriteLine("\n========== ESERCIZIO 9 ==========");

short shortNumber = 32767;
Console.WriteLine(shortNumber);
shortNumber = -32767;
Console.WriteLine(shortNumber);
#endregion

#region 10. Usare una variabile `byte` per rappresentare un numero tra 0 e 255.
Console.WriteLine("\n========== ESERCIZIO 10 ==========");

byte byteNumber = 25;
Console.WriteLine(byteNumber);
#endregion

#region 11. Dichiarare una variabile `const` e provare a modificarne il valore.
Console.WriteLine("\n========== ESERCIZIO 11 ==========");

const int C1 = 5;
Console.WriteLine(C1);
const int C2 = C1 + 5;
Console.WriteLine(C2);
#endregion

#region 12. Dichiarare più variabili in una sola riga e assegnare loro valori diversi.
Console.WriteLine("\n========== ESERCIZIO 12 ==========");

int x = 10, y = 20, z = 30;
Console.WriteLine($"{x} {y} {z}");
//Console.WriteLine(x+" "+y+" "+z);  Altro modo per scriverlo
#endregion

#region 13. Dichiarare una variabile di tipo `var` e verificare come il compilatore determina il tipo.
Console.WriteLine("\n========== ESERCIZIO 13 ==========");

var varNumber = 20;   // Il compilatore determina un int
Console.WriteLine(varNumber);
var varText = "Hello Andrea";   // Il compilatore determina una string
Console.WriteLine(varText);
var varPrice = 13.99;   // Il compilatore determina un double
Console.WriteLine(varPrice);
#endregion

#region 14. Dichiarare e usare variabili con valori predefiniti.
Console.WriteLine("\n========== ESERCIZIO 14 ==========");

int intNumber = default;
Console.WriteLine($"int: {intNumber}");
string stringText = default;
Console.WriteLine($"string: {stringText}");
bool boolIsActive = default;
Console.WriteLine($"bool: {boolIsActive}");
double doublePrice = default;
Console.WriteLine($"double: {doublePrice}");
#endregion

#region 15. Cambiare il tipo di una variabile usando il casting esplicito.
Console.WriteLine("\n========== ESERCIZIO 15 ==========");

double doubleprice = 13.99;
Console.WriteLine(doubleprice);
int intPrice = (int)doubleprice;
Console.WriteLine(intPrice);
#endregion

#region 16. Dichiarare una variabile costante di tipo `string`.
Console.WriteLine("\n========== ESERCIZIO 16 ==========");

const string NAME = "Andrea";
Console.WriteLine(NAME);
#endregion

#region 17. Utilizzare una variabile per rappresentare una data usando il tipo `DateTime`.
Console.WriteLine("\n========== ESERCIZIO 17 ==========");

DateTime currentDate = DateTime.Now;
Console.WriteLine(currentDate);
#endregion

#region 18. Dichiarare una variabile e utilizzarla in un'espressione matematica.
Console.WriteLine("\n========== ESERCIZIO 18 ==========");

int a = 10;
Console.WriteLine(a);
int b = 5;
Console.WriteLine(b);

int sum = a + b;
Console.WriteLine($"somma: {sum}");
int difference = a - b;
Console.WriteLine($"differenza: {difference}");
int product = a * b;
Console.WriteLine($"moltiplicazione: {product}");
int division = a / b;
Console.WriteLine($"divisione: {division}");
int result = (a + b) + (a - b) + (a * b) + (a / b);
//int result = (sum) + (difference) + (product) + (division);
Console.WriteLine($"somma totale: {result}");
#endregion
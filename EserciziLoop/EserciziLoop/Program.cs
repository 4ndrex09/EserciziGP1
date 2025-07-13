using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Runtime.ConstrainedExecution;
using System;

class Program
{
    #region 1. Scrivere un ciclo `for` che stampa numeri da 1 a 10.

    public static string PrintNumbers()
    {
        string result = "";
        for (int i = 1; i <= 10; i++)
        {
            result += i + " ";
        }
        return result.Trim();
    }
    #endregion

    #region 2. Creare un ciclo `while` che continua finché un valore è minore di 100.

    public static string CountToHundred(int startValue)
    {
        string result = "";
        int currentValue = startValue;

        while (currentValue < 100)
        {
            result += currentValue + " ";
            currentValue += 10;
        }
        return result.Trim();
    }
    #endregion

    #region 3. Utilizzare un ciclo `do-while` per chiedere all'utente di inserire un valore valido.

    public static int GetValidNumber()
    {
        int number;
        string input;
        do
        {
            Console.Write("Inserisci un numero tra 1 e 10: ");
            input = Console.ReadLine();
        } while (!int.TryParse(input, out number) || number < 1 || number > 10);

        return number;
    }

    public static string ValidateInput(int number)
    {
        return $"Hai inserito un numero valido: {number}";
    }
    #endregion

    #region 4. Scrivere un ciclo `for` che calcola la somma di un array.

    public static int CalculateSum(int[] numbers)
    {
        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        return sum;
    }

    public static string FormatResult(int[] numbers, int sum)
    {
        return $"Array: [{string.Join(", ", numbers)}], Somma: {sum}";
    }
    #endregion

    #region 5. Utilizzare un ciclo `foreach` per iterare attraverso una lista di stringhe.

    public static void PrintNames()
    {
        List<string> names = new List<string> { "Andrea", "Anna", "Marco", "Sofia" };

        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
    }
    #endregion

    #region 6. Creare un ciclo `for` che calcola il fattoriale di un numero.

    public static int CalculateFactorial(int number)
    {
        int factorial = 1;
        for (int i = 1; i <= number; i++)
        {
            factorial *= i;
        }
        return factorial;
    }
    #endregion

    #region 7. Scrivere un ciclo `while` che verifica se un numero è primo.

    public static bool IsPrime(int number)
    {
        if (number <= 1) return false;

        int divisor = 2;
        while (divisor <= Math.Sqrt(number))
        {
            if (number % divisor == 0)
            {
                return false;
            }
            divisor++;
        }
        return true;
    }
    #endregion

    #region 8. Utilizzare un ciclo `do-while` per stampare i numeri pari fino a un massimo.

    public static void PrintEvenNumbers(int max)
    {
        int number = 2;
        do
        {
            Console.Write(number + " ");
            number += 2;
        } while (number <= max);
    }
    #endregion

    #region 9. Scrivere un ciclo `for` che stampa i numeri in ordine inverso.

    public static void PrintReverse(int start)
    {
        for (int i = start; i >= 1; i--)
        {
            Console.Write(i + " ");
        }
    }
    #endregion

    #region 10. Creare un ciclo `while` che calcola il prodotto dei numeri fino a un valore specifico.

    public static void CalculateProduct(int max)
    {
        int product = 1;
        int number = 1;

        while (number <= max)
        {
            product *= number;
            number++;
        }

        Console.WriteLine($"Il prodotto dei numeri da 1 a {max} è: {product}");
    }
    #endregion

    #region 11. Utilizzare un ciclo `foreach` per modificare i valori in una lista.

    public static void ModifyList()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

        Console.Write("Lista originale: ");
        foreach (int num in numbers)
        {
            Console.Write(num + " ");
        }

        for (int i = 0; i < numbers.Count; i++)
        {
            numbers[i] *= 2;
        }

        Console.Write("\nLista modificata: ");
        foreach (int num in numbers)
        {
            Console.Write(num + " ");
        }
    }
    #endregion

    #region 12. Scrivere un ciclo `do-while` che calcola il totale di un array.

    public static void CalculateTotal()
    {
        int[] numbers = { 10, 20, 30, 40, 50 };
        int total = 0;
        int index = 0;

        do
        {
            total += numbers[index];
            index++;
        } while (index < numbers.Length);

        Console.WriteLine($"Il totale dell'array è: {total}");
    }
    #endregion

    #region 13. Creare un ciclo `for` che utilizza un'istruzione `break`.

    public static void FindNumber()
    {
        int target = 7;

        for (int i = 1; i <= 20; i++)
        {
            if (i == target)
            {
                Console.WriteLine($"Numero {target} trovato!");
                break;
            }
            Console.Write(i + " ");
        }
    }
    #endregion

    #region 14. Utilizzare un ciclo `while` che termina con un'istruzione `continue`.

    public static void SkipNumbers()
    {
        int count = 0;

        while (count < 10)
        {
            count++;
            if (count % 2 == 0)
            {
                continue;
            }
            Console.Write(count + " ");
        }
    }
    #endregion

    #region 15. Scrivere un ciclo `for` che utilizza una variabile dichiarata all'esterno del ciclo.

    public static void SumNumbers()
    {
        int total = 0;

        for (int i = 1; i <= 5; i++)
        {
            total += i;
            Console.WriteLine($"Dopo aver aggiunto {i}: totale = {total}");
        }
    }
    #endregion

    #region 16. Creare un ciclo `foreach` che stampa gli indici e i valori di un array.

    public static void PrintArrayWithIndex()
    {
        string[] fruits = { "Mela", "Pera", "Banana", "Arancia" };
        int index = 0;

        foreach (string fruit in fruits)
        {
            Console.WriteLine($"Indice {index}: {fruit}");
            index++;
        }
    }
    #endregion

    #region 17. Utilizzare un ciclo `do-while` che verifica un valore booleano prima di continuare.

    public static void CheckCondition()
    {
        bool isValid = false;
        int attempts = 0;

        do
        {
            attempts++;
            Console.WriteLine($"Tentativo {attempts}");

            if (attempts == 3)
            {
                isValid = true;
            }

        } while (!isValid);

        Console.WriteLine("Condizione verificata!");
    }
    #endregion

    #region 18. Scrivere un ciclo `for` che calcola la somma dei numeri dispari.

    public static void SumOddNumbers()
    {
        int sum = 0;

        for (int i = 1; i <= 10; i += 2)
        {
            sum += i;
            Console.WriteLine($"Aggiunto {i}: somma = {sum}");
        }

        Console.WriteLine($"La somma totale dei numeri dispari è: {sum}");
    }
    #endregion

    #region 19. Creare un ciclo `while` che termina quando un valore raggiunge una soglia.

    public static void ReachThreshold()
    {
        int value = 0;
        int threshold = 100;
        int increment = 20;

        while (value < threshold)
        {
            value += increment;
            Console.WriteLine($"Valore attuale: {value}");
        }

        Console.WriteLine($"Soglia {threshold} raggiunta!");
    }
    #endregion

    #region 20. Utilizzare un ciclo `foreach` per calcolare la lunghezza totale di tutte le stringhe in una lista.

    public static void CalculateStringLengths()
    {
        List<string> words = new List<string> { "ciao", "mondo", "programmazione", "C#" };
        int totalLength = 0;

        foreach (string word in words)
        {
            totalLength += word.Length;
            Console.WriteLine($"Parola: {word}, Lunghezza: {word.Length}");
        }

        Console.WriteLine($"Lunghezza totale: {totalLength} caratteri");
    }
    #endregion

    #region 21. Scrivere un ciclo `do-while` che stampa un menu fino a quando l'utente sceglie di uscire.

    public static void ShowMenu()
    {
        string choice;
        do
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Opzione 1");
            Console.WriteLine("2. Opzione 2");
            Console.WriteLine("3. Esci");
            Console.Write("Scelta: ");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Hai scelto l'opzione 1");
                    break;
                case "2":
                    Console.WriteLine("Hai scelto l'opzione 2");
                    break;
            }

        } while (choice != "3");
    }
    #endregion

    #region 22. Creare un ciclo `for` che utilizza una condizione complessa.

    public static void ComplexLoop()
    {
        int sum = 0;

        for (int i = 1; i <= 20 && sum < 100; i++)
        {
            if (i % 3 == 0 || i % 5 == 0)
            {
                sum += i;
                Console.WriteLine($"Numero: {i}, Somma: {sum}");
            }
        }
    }
    //Somma solo i numeri che sono multipli di 3 o di 5
    //Parte da 1 e controlla fino a 20
    //Si ferma se la somma supera 100
    //Per ogni numero valido mostra:
    //- Il numero trovato
    //- La somma progressiva
    #endregion

    #region 23. Utilizzare un ciclo `while` per cercare un valore specifico in un array.

    public static void SearchArray()
    {
        int[] numbers = { 4, 8, 15, 16, 23, 42 };
        int target = 15;
        int index = 0;

        while (index < numbers.Length)
        {
            if (numbers[index] == target)
            {
                Console.WriteLine($"Valore {target} trovato all'indice {index}");
                break;
            }
            index++;
        }
    }
    #endregion

    #region 24. Scrivere un ciclo `for` che calcola la media di un array.

    public static void CalculateAverage()
    {
        int[] grades = { 85, 92, 78, 95, 88 };
        int sum = 0;

        for (int i = 0; i < grades.Length; i++)
        {
            sum += grades[i];
            Console.WriteLine($"Voto {i + 1}: {grades[i]}");
        }

        double average = (double)sum / grades.Length;
        Console.WriteLine($"Media dei voti: {average:F1}");
    }
    //:F1 serve per mostrare il numero con una sola cifra decimale.
    //87.666666 Verrà mostrato come: 87.7
    //:F2 -> due decimali(87.67)
    //:F0 -> nessun decimale(88)
    //:N -> con separatore delle migliaia(1.234,56)
    #endregion

    #region 25. Creare un ciclo `foreach` che copia valori da un array a un altro.

    public static void CopyArrays()
    {
        int[] source = { 10, 20, 30, 40, 50 };
        int[] destination = new int[source.Length];
        int index = 0;

        foreach (int number in source)
        {
            destination[index] = number;
            Console.WriteLine($"Copiato {number} nella posizione {index}");
            index++;
        }

        Console.WriteLine("\nArray finale:");
        foreach (int number in destination)
        {
            Console.Write(number + " ");
        }
    }
    #endregion

    static void Main(string[] args)
    {
        Console.WriteLine("\n========== ESERCIZIO 1 ==========");
        Console.WriteLine($"Numeri da 1 a 10: {PrintNumbers()}");

        Console.WriteLine("\n========== ESERCIZIO 2 ==========");
        Console.WriteLine($"Conteggio partendo da 0: {CountToHundred(0)}");
        Console.WriteLine($"Conteggio partendo da 30: {CountToHundred(30)}");

        Console.WriteLine("\n========== ESERCIZIO 3 ==========");
        int validNumber = GetValidNumber();
        Console.WriteLine(ValidateInput(validNumber));

        Console.WriteLine("\n========== ESERCIZIO 4 ==========");
        int[] array1 = { 1, 2, 3, 4, 5 };
        int[] array2 = { 10, 20, 30 };
        Console.WriteLine(FormatResult(array1, CalculateSum(array1)));
        Console.WriteLine(FormatResult(array2, CalculateSum(array2)));

        Console.WriteLine("\n========== ESERCIZIO 5 ==========");
        PrintNames();

        Console.WriteLine("\n========== ESERCIZIO 6 ==========");
        Console.WriteLine($"Fattoriale di 5: {CalculateFactorial(5)}");
        Console.WriteLine($"Fattoriale di 3: {CalculateFactorial(3)}");

        Console.WriteLine("\n========== ESERCIZIO 7 ==========");
        Console.WriteLine($"7 è primo? {IsPrime(7)}");
        Console.WriteLine($"12 è primo? {IsPrime(12)}");
        Console.WriteLine($"17 è primo? {IsPrime(17)}");

        Console.WriteLine("\n========== ESERCIZIO 8 ==========");
        PrintEvenNumbers(10);
        Console.WriteLine();

        Console.WriteLine("\n========== ESERCIZIO 9 ==========");
        PrintReverse(10);
        Console.WriteLine();

        Console.WriteLine("\n========== ESERCIZIO 10 ==========");
        CalculateProduct(5);

        Console.WriteLine("\n========== ESERCIZIO 11 ==========");
        ModifyList();
        Console.WriteLine();

        Console.WriteLine("\n========== ESERCIZIO 12 ==========");
        CalculateTotal();

        Console.WriteLine("\n========== ESERCIZIO 13 ==========");
        FindNumber();

        Console.WriteLine("\n========== ESERCIZIO 14 ==========");
        SkipNumbers();
        Console.WriteLine();

        Console.WriteLine("\n========== ESERCIZIO 15 ==========");
        SumNumbers();

        Console.WriteLine("\n========== ESERCIZIO 16 ==========");
        PrintArrayWithIndex();

        Console.WriteLine("\n========== ESERCIZIO 17 ==========");
        CheckCondition();

        Console.WriteLine("\n========== ESERCIZIO 18 ==========");
        SumOddNumbers();

        Console.WriteLine("\n========== ESERCIZIO 19 ==========");
        ReachThreshold();

        Console.WriteLine("\n========== ESERCIZIO 20 ==========");
        CalculateStringLengths();

        Console.WriteLine("\n========== ESERCIZIO 21 ==========");
        ShowMenu();

        Console.WriteLine("\n========== ESERCIZIO 22 ==========");
        ComplexLoop();

        Console.WriteLine("\n========== ESERCIZIO 23 ==========");
        SearchArray();

        Console.WriteLine("\n========== ESERCIZIO 24 ==========");
        CalculateAverage();

        Console.WriteLine("\n========== ESERCIZIO 25 ==========");
        CopyArrays();
        Console.WriteLine();
    }
    
}
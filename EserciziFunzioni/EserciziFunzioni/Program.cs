class Program {

    #region 1. Dichiarare una funzione che restituisce un valore di tipo `int` e accetta due parametri.

    static int Somma(int a, int b)
    {
        return a + b;
    }
    #endregion

    #region 2. Creare una funzione `void` che stampa un messaggio a console.

    static void PrintMessage()
    {
        Console.WriteLine("Hello World!");
    }
    #endregion

    #region 3. Scrivere una funzione che accetta un parametro `string` e restituisce la lunghezza della stringa.
    static int GetStringLength(string text)
    {
        return text.Length;
    }
    #endregion

    #region 4. Dichiarare una funzione con un parametro opzionale.
    static string Greet(string name = "User")
    {
        return $"Hello {name}!";
    }
    #endregion

    #region 5. Scrivere una funzione che accetta un array come parametro.

    static double CalcolaMedia(int[] numeri)
    {
        int somma = 0;
        foreach (int numero in numeri)
        {
            somma += numero;
        }
        return (double)somma / numeri.Length;
    }
    #endregion

    #region 6. Scrivere una funzione che calcola il fattoriale di un numero.

    static long Fattoriale(int numero)
    {
        if (numero == 0 || numero == 1)
            return 1;

        long risultato = 1;
        for (int i = 2; i <= numero; i++)
        {
            risultato *= i;
        }
        return risultato;
    }
    #endregion

    #region 7. Dichiarare una funzione che restituisce un valore di tipo `bool` basato su una condizione.

    static bool IsPositive(int number)
    {
        return number > 0;
    }
    #endregion

    #region 8. Creare una funzione che utilizza un'eccezione per gestire input non validi. (try - catch)

    static int DivideNumbers(int numerator, int denominator)
    {
        try
        {
            return numerator / denominator;
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: Cannot divide by zero!");
            return 0;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unexpected error: {ex.Message}");
            return 0;
        }
    }
    #endregion

    #region 9. Dichiarare una funzione che restituisce una lista di numeri.

    static List<int> GenerateNumbersList(int start, int end)
    {
        List<int> numbers = new List<int>();
        for (int i = start; i <= end; i++)
        {
            numbers.Add(i);
        }
        return numbers;
    }
    #endregion

    #region 10. Scrivere una funzione che accetta e restituisce oggetti di una classe custom.

    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public static Student CreateStudent()
    {
        return new Student { Name = "Andrea", Age = 21 };
    }
    #endregion

    #region 11. Scrivere una funzione che modifica una lista passata come parametro.

    public static void AddNumbers(List<int> numbers)
    {
        numbers.Add(10);
        numbers.Add(20);
        numbers.Add(30);
    }
    #endregion

    #region 12. Creare una funzione che utilizza un'espressione condizionale per determinare il valore restituito. (if else)

    public static string GetAgeCategory(int age)
    {
        if (age < 18)
        {
            return "Minorenne";
        }
        else
        {
            return "Maggiorenne";
        }
    }
    #endregion

    static void Main(string[] args)
    {
        Console.WriteLine("\n========== ESERCIZIO 1 ==========");
        Console.WriteLine(Somma(5, 3));

        Console.WriteLine("\n========== ESERCIZIO 2 ==========");
        PrintMessage();

        Console.WriteLine("\n========== ESERCIZIO 3 ==========");
        //Metodo 1
        Console.WriteLine($"Lunghezza di 'Test': {GetStringLength("Test")}");
        //Metodo 2
        //string frase = "Ciao mondo";
        //int lunghezza = GetStringLength(frase);
        //Console.WriteLine($"La lunghezza della stringa '{frase}' è: {lunghezza}");

        Console.WriteLine("\n========== ESERCIZIO 4 ==========");
        Console.WriteLine(Greet("Andrea"));

        Console.WriteLine("\n========== ESERCIZIO 5 ==========");
        int[] valori = { 10, 20, 30, 40, 50 };
        double media = CalcolaMedia(valori);
        Console.WriteLine($"La media dei numeri è: {media}");

        Console.WriteLine("\n========== ESERCIZIO 6 ==========");
        int numero = 5;
        long risultato = Fattoriale(numero);
        Console.WriteLine($"Il fattoriale di {numero} è: {risultato}");
        Console.WriteLine($"Fattoriale di 0: {Fattoriale(0)}");
        Console.WriteLine($"Fattoriale di 3: {Fattoriale(3)}");
        Console.WriteLine($"Fattoriale di 7: {Fattoriale(7)}");

        Console.WriteLine("\n========== ESERCIZIO 7 ==========");
        Console.WriteLine($"Is 5 positive? {IsPositive(5)}");    
        Console.WriteLine($"Is -3 positive? {IsPositive(-3)}");  
        Console.WriteLine($"Is 0 positive? {IsPositive(0)}");

        Console.WriteLine("\n========== ESERCIZIO 8 ==========");
        Console.WriteLine($"10 / 2 = {DivideNumbers(10, 2)}");  
        Console.WriteLine($"10 / 0 = {DivideNumbers(10, 0)}");

        Console.WriteLine("\n========== ESERCIZIO 9 ==========");
        List<int> numbersList = GenerateNumbersList(1, 9);
        Console.WriteLine("Numbers from 1 to 9: " + string.Join(", ", numbersList));

        Console.WriteLine("\n========== ESERCIZIO 10 ==========");
        Student student = CreateStudent();
        Console.WriteLine($"Student: {student.Name}, Age: {student.Age}");

        Console.WriteLine("\n========== ESERCIZIO 11 ==========");
        List<int> myList = new List<int>();
        Console.WriteLine($"Lista originale: {string.Join(", ", myList)}");
        AddNumbers(myList);
        Console.WriteLine($"Lista modificata: {string.Join(", ", myList)}");

        Console.WriteLine("\n========== ESERCIZIO 12 ==========");
        Console.WriteLine($"Età 15: {GetAgeCategory(15)}");
        Console.WriteLine($"Età 20: {GetAgeCategory(20)}");
    }
}
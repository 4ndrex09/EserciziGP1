class Program
{
    #region 1. Utilizzare un `if-else` per verificare se un numero è pari o dispari.

    public static string CheckEvenOdd(int number)
    {
        if (number % 2 == 0)
        {
            return "Pari";
        }
        else
        {
            return "Dispari";
        }
    }
    #endregion

    #region 2. Scrivere un programma che utilizza una serie di `if-else` per categorizzare un'età.

    public static string GetAgeCategory(int age)
    {
        if (age < 13)
        {
            return "Bambino";
        }
        else if (age < 18)
        {
            return "Adolescente";
        }
        else if (age < 65)
        {
            return "Adulto";
        }
        else
        {
            return "Anziano";
        }
    }
    #endregion

    #region 3. Creare un'espressione logica che combina più condizioni con `&&`.

    public static bool CanPlayRanked(bool hasAccount, int level, bool hasPlus)
    {
        return hasAccount && level >= 10 && hasPlus;
    }
    #endregion

    #region 4. Utilizzare un'espressione logica con `||` per verificare se un numero è compreso in un intervallo.

    public static bool IsInRange(int number)
    {
        return number <= 0 || number >= 100;
    }
    #endregion

    #region 5. Scrivere un `if-else` che utilizza l'operatore `!` per invertire una condizione.

    public static string CheckAccess(bool isBlocked)
    {
        if (!isBlocked)
        {
            return "Accesso consentito";
        }
        else
        {
            return "Accesso negato";
        }
    }
    #endregion

    #region 6. Dichiarare una variabile booleana e usarla in un'istruzione `if`.

    public static string CheckGameStatus(bool isGameOver)
    {
        if (isGameOver)
        {
            return "Game Over!";
        }
        else
        {
            return "Game is still running";
        }
    }
    #endregion

    #region 7. Creare un programma che utilizza `if-else` nidificati.

    public static string CheckLevel(int score)
    {
        if (score >= 100)
        {
            if (score >= 200)
            {
                return "Livello Pro";
            }
            else
            {
                return "Livello Medio";
            }
        }
        else
        {
            return "Livello Base";
        }
    }
    #endregion

    #region 8. Utilizzare un'espressione `switch` per valutare un valore booleano.

    public static string CheckPayment(bool isPaid)
    {
        switch (isPaid)
        {
            case true:
                return "Pagamento completato";
            case false:
                return "Pagamento in attesa";
        }
    }
    #endregion

    #region 9. Creare un'istruzione `if-else` che utilizza un'espressione con operatori di confronto.

    public static string GetGameRating(int age)
    {
        if (age < 7)
        {
            return "PEGI 3";
        }
        else if (age < 12)
        {
            return "PEGI 7";
        }
        else if (age < 16)
        {
            return "PEGI 12";
        }
        else if (age < 18)
        {
            return "PEGI 16";
        }
        else
        {
            return "PEGI 18";
        }
    }
    #endregion

    #region 10. Utilizzare un operatore ternario per assegnare un valore a una variabile.

    public static string GetStatus(int score)
    {
        string result = score >= 60 ? "Promosso" : "Bocciato";
        return result;
    }
    #endregion

    #region 11. Scrivere una serie di `if-else` per verificare più condizioni.

    public static string GetPlayerRank(int wins)
    {
        if (wins >= 100)
        {
            return "Diamond";
        }
        else if (wins >= 50)
        {
            return "Platinum";
        }
        else if (wins >= 20)
        {
            return "Gold";
        }
        else if (wins >= 5)
        {
            return "Silver";
        }
        else
        {
            return "Bronze";
        }
    }
    #endregion

    #region 12. Creare un programma che utilizza un `if-else` per determinare il maggiore tra due numeri.

    public static string FindLarger(int a, int b)
    {
        if (a > b)
        {
            return $"Il numero maggiore è {a}";
        }
        else if (a < b)
        {
            return $"Il numero maggiore è {b}";
        }
        else
        {
            return "I numeri sono uguali";
        }
    }
    #endregion

    #region 13. Utilizzare un'istruzione `if` per verificare se una stringa è vuota o nulla.

    public static string CheckString(string text)
    {
        if (string.IsNullOrEmpty(text))
        {
            return "La stringa è vuota o nulla";
        }
        else
        {
            return $"La stringa contiene: {text}";
        }
    }
    #endregion

    #region 14. Creare un programma che utilizza `if-else` per verificare se un anno è bisestile.

    public static string CheckLeapYear(int year)
    {
        if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
        {
            return $"{year} è un anno bisestile";
        }
        else
        {
            return $"{year} non è un anno bisestile";
        }
    }
    #endregion

    #region 15. Scrivere un'espressione logica che verifica se una stringa contiene una sottostringa specifica.

    public static string CheckSubstring(string text)
    {
        if (text.Contains("hello"))
        {
            return "La stringa contiene 'hello'";
        }
        else
        {
            return "La stringa non contiene 'hello'";
        }
    }
    #endregion

    #region 16. Utilizzare un `if-else` per verificare se un array contiene un elemento specifico.

    public static string CheckNumber(int[] numbers, int target)
    {
        if (numbers.Contains(target))
        {
            return $"Il numero {target} è presente nell'array";
        }
        else
        {
            return $"Il numero {target} non è presente nell'array";
        }
    }
    #endregion

    #region 17. Creare una funzione che utilizza `if-else` per determinare se un numero è positivo, negativo o zero.

    public static string CheckNumber(int number)
    {
        if (number > 0)
        {
            return "Il numero è positivo";
        }
        else if (number < 0)
        {
            return "Il numero è negativo";
        }
        else
        {
            return "Il numero è zero";
        }
    }
    #endregion

    #region 18. Creare un programma che utilizza un `switch` per determinare il giorno della settimana.

    public static string GetDay(int day)
    {
        switch (day)
        {
            case 1:
                return "Lunedì";
            case 2:
                return "Martedì";
            case 3:
                return "Mercoledì";
            case 4:
                return "Giovedì";
            case 5:
                return "Venerdì";
            case 6:
                return "Sabato";
            case 7:
                return "Domenica";
            default:
                return "Giorno non valido";
        }
    }
    #endregion

    #region 19. Utilizzare un'istruzione `if` per verificare se un numero è divisibile per 3 e 5.

    public static string CheckDivisibility(int number)
    {
        if (number % 3 == 0 && number % 5 == 0)
        {
            return $"{number} è divisibile per 3 e 5";
        }
        else
        {
            return $"{number} non è divisibile per 3 e 5";
        }
    }
    #endregion

    #region 20. Scrivere un'istruzione `if` per verificare se un valore booleano è `true`.

    public static string CheckStatus(bool isActive)
    {
        if (isActive)
        {
            return "attivo";
        }
        else
        {
            return "inattivo";
        }
    }
    #endregion

    #region 21. Utilizzare un `switch` per valutare una variabile stringa.

    public static string GetColor(string color)
    {
        switch (color.ToLower())
        {
            case "rosso":
                return "Hai scelto il colore rosso";
            case "verde":
                return "Hai scelto il colore verde";
            case "blu":
                return "Hai scelto il colore blu";
            default:
                return "Colore non riconosciuto";
        }
    }
    #endregion

    #region 22. Creare un programma che utilizza un `if` per verificare se un array è vuoto.

    public static string CheckArray(int[] numbers)
    {
        if (numbers.Length == 0)
        {
            return "L'array è vuoto";
        }
        else
        {
            return $"L'array contiene {numbers.Length} elementi";
        }
    }
    #endregion

    #region 23. Utilizzare un `if` per verificare se un valore è un numero primo.

    public static string CheckPrime(int number)
    {
        if (number <= 1)
        {
            return $"{number} non è un numero primo";
        }

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                return $"{number} non è un numero primo";
            }
        }

        return $"{number} è un numero primo";
    }
    #endregion

    #region 24. Scrivere un programma che utilizza un'istruzione `if-else` per verificare se una parola è palindroma.

    public static string CheckPalindrome(string word)
    {
        string reversed = new string(word.ToLower().Reverse().ToArray());

        if (word.ToLower() == reversed)
        {
            return $"{word} è palindroma";
        }
        else
        {
            return $"{word} non è palindroma";
        }
    }
    #endregion

    static void Main(string[] args)
    {
        Console.WriteLine("\n========== ESERCIZIO 1 ==========");
        Console.WriteLine($"Numero 4: {CheckEvenOdd(4)}");
        Console.WriteLine($"Numero 7: {CheckEvenOdd(7)}");
        Console.WriteLine($"Numero 15: {CheckEvenOdd(15)}");

        Console.WriteLine("\n========== ESERCIZIO 2 ==========");
        Console.WriteLine($"Età 10: {GetAgeCategory(10)}");
        Console.WriteLine($"Età 15: {GetAgeCategory(15)}");
        Console.WriteLine($"Età 30: {GetAgeCategory(30)}");
        Console.WriteLine($"Età 70: {GetAgeCategory(70)}");

        Console.WriteLine("\n========== ESERCIZIO 3 ==========");
        Console.WriteLine($"Giocatore (true, 15, true): {CanPlayRanked(true, 15, true)}");   
        Console.WriteLine($"Giocatore (false, 35, true): {CanPlayRanked(false, 35, true)}");  
        Console.WriteLine($"Giocatore (true, 5, true): {CanPlayRanked(true, 5, true)}");      
        Console.WriteLine($"Giocatore (true, 20, false): {CanPlayRanked(true, 20, false)}");

        Console.WriteLine("\n========== ESERCIZIO 4 ==========");
        Console.WriteLine($"Numero -5: {IsInRange(-5)}");   
        Console.WriteLine($"Numero 50: {IsInRange(50)}");   
        Console.WriteLine($"Numero 150: {IsInRange(150)}");

        Console.WriteLine("\n========== ESERCIZIO 5 ==========");
        Console.WriteLine($"Utente non bloccato: {CheckAccess(false)}"); 
        Console.WriteLine($"Utente bloccato: {CheckAccess(true)}");

        Console.WriteLine("\n========== ESERCIZIO 6 ==========");
        bool gameFinished = true;
        Console.WriteLine($"Status: {CheckGameStatus(gameFinished)}");
        gameFinished = false;
        Console.WriteLine($"Status: {CheckGameStatus(gameFinished)}");

        Console.WriteLine("\n========== ESERCIZIO 7 ==========");
        Console.WriteLine($"Score 250: {CheckLevel(250)}"); 
        Console.WriteLine($"Score 150: {CheckLevel(150)}"); 
        Console.WriteLine($"Score 50: {CheckLevel(50)}");

        Console.WriteLine("\n========== ESERCIZIO 8 ==========");
        Console.WriteLine($"Ordine 1: {CheckPayment(true)}");
        Console.WriteLine($"Ordine 2: {CheckPayment(false)}");

        Console.WriteLine("\n========== ESERCIZIO 9 ==========");
        Console.WriteLine($"Età 6: {GetGameRating(6)}");
        Console.WriteLine($"Età 10: {GetGameRating(10)}");
        Console.WriteLine($"Età 14: {GetGameRating(14)}");
        Console.WriteLine($"Età 17: {GetGameRating(17)}");
        Console.WriteLine($"Età 20: {GetGameRating(20)}");

        Console.WriteLine("\n========== ESERCIZIO 10 ==========");
        Console.WriteLine($"Score 75: {GetStatus(75)}");
        Console.WriteLine($"Score 45: {GetStatus(45)}");

        Console.WriteLine("\n========== ESERCIZIO 11 ==========");
        Console.WriteLine($"Wins 150: {GetPlayerRank(150)}");
        Console.WriteLine($"Wins 75: {GetPlayerRank(75)}");
        Console.WriteLine($"Wins 30: {GetPlayerRank(30)}");
        Console.WriteLine($"Wins 10: {GetPlayerRank(10)}");
        Console.WriteLine($"Wins 3: {GetPlayerRank(3)}");

        Console.WriteLine("\n========== ESERCIZIO 12 ==========");
        Console.WriteLine($"Confronto (10, 5): {FindLarger(10, 5)}");
        Console.WriteLine($"Confronto (3, 7): {FindLarger(3, 7)}");
        Console.WriteLine($"Confronto (4, 4): {FindLarger(4, 4)}");

        Console.WriteLine("\n========== ESERCIZIO 13 ==========");
        Console.WriteLine(CheckString("Hello"));
        Console.WriteLine(CheckString(""));
        Console.WriteLine(CheckString(null));

        Console.WriteLine("\n========== ESERCIZIO 14 ==========");
        Console.WriteLine(CheckLeapYear(2024));
        Console.WriteLine(CheckLeapYear(2023));
        Console.WriteLine(CheckLeapYear(2000));
        Console.WriteLine(CheckLeapYear(1900));

        Console.WriteLine("\n========== ESERCIZIO 15 ==========");
        Console.WriteLine(CheckSubstring("hello world"));
        Console.WriteLine(CheckSubstring("hi there"));
        Console.WriteLine(CheckSubstring("say hello everyone"));

        Console.WriteLine("\n========== ESERCIZIO 16 ==========");
        int[] array = { 1, 3, 5, 7, 9 };
        Console.WriteLine(CheckNumber(array, 5));
        Console.WriteLine(CheckNumber(array, 4));

        Console.WriteLine("\n========== ESERCIZIO 17 ==========");
        Console.WriteLine(CheckNumber(5));
        Console.WriteLine(CheckNumber(-3));
        Console.WriteLine(CheckNumber(0));

        Console.WriteLine("\n========== ESERCIZIO 18 ==========");
        Console.WriteLine($"Giorno 1: {GetDay(1)}");
        Console.WriteLine($"Giorno 4: {GetDay(4)}");
        Console.WriteLine($"Giorno 7: {GetDay(7)}");
        Console.WriteLine($"Giorno 9: {GetDay(9)}");

        Console.WriteLine("\n========== ESERCIZIO 19 ==========");
        Console.WriteLine(CheckDivisibility(15));  
        Console.WriteLine(CheckDivisibility(9));  
        Console.WriteLine(CheckDivisibility(10));  
        Console.WriteLine(CheckDivisibility(7));

        Console.WriteLine("\n========== ESERCIZIO 20 ==========");
        Console.WriteLine(CheckStatus(true));
        Console.WriteLine(CheckStatus(false));

        Console.WriteLine("\n========== ESERCIZIO 21 ==========");
        Console.WriteLine(GetColor("rosso"));
        Console.WriteLine(GetColor("verde"));
        Console.WriteLine(GetColor("blu"));
        Console.WriteLine(GetColor("giallo"));

        Console.WriteLine("\n========== ESERCIZIO 22 ==========");
        int[] array1 = { 1, 2, 3 };
        int[] array2 = { };
        Console.WriteLine(CheckArray(array1));
        Console.WriteLine(CheckArray(array2));

        Console.WriteLine("\n========== ESERCIZIO 23 ==========");
        Console.WriteLine(CheckPrime(7));    
        Console.WriteLine(CheckPrime(12));   
        Console.WriteLine(CheckPrime(23));   
        Console.WriteLine(CheckPrime(1));

        Console.WriteLine("\n========== ESERCIZIO 24 ==========");
        Console.WriteLine(CheckPalindrome("radar"));
        Console.WriteLine(CheckPalindrome("hello"));
        Console.WriteLine(CheckPalindrome("Anna"));
    }
}
class Program
{
    #region 1. Creare un array di `int` con 5 elementi e stamparne i valori.

    public static void StampaArray()
    {
        int[] numeri = { 10, 20, 30, 40, 50 };

        foreach (int numero in numeri)
        {
            Console.WriteLine($"Valore: {numero}");
        }
    }
    #endregion

    #region 2. Dichiarare una lista di stringhe e aggiungere elementi dinamicamente.

    public static void UsaLista()
    {
        List<string> nomi = new List<string>();

        nomi.Add("Marco");
        nomi.Add("Anna");
        nomi.Add("Luigi");

        foreach (string nome in nomi)
        {
            Console.WriteLine($"Nome: {nome}");
        }
    }
    #endregion

    #region 3. Creare un array bidimensionale e popolarlo con valori.

    public static void ArrayBidimensionale()
    {
        int[,] matrice = {
        { 1, 2, 3 },
        { 4, 5, 6 }
        };

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"{matrice[i, j]} ");
            }
            Console.WriteLine();
        }
    }
    #endregion

    #region 4. Utilizzare un array per calcolare la media dei valori.

    public static void CalcolaMedia()
    {
        int[] voti = { 85, 92, 78, 95, 88 };
        int somma = 0;

        foreach (int voto in voti)
        {
            somma += voto;
        }

        double media = (double)somma / voti.Length;
        Console.WriteLine($"La media dei voti è: {media:F1}");
    }
    #endregion

    #region 5. Dichiarare una lista di oggetti personalizzati. (classi, enum, struct, ecc)

    public struct Studente
    {
        public string Nome;
        public int Eta;

        public Studente(string nome, int eta)
        {
            Nome = nome;
            Eta = eta;
        }
    }

    public static void ListaStudenti()
    {
        List<Studente> studenti = new List<Studente>();

        studenti.Add(new Studente("Marco", 20));
        studenti.Add(new Studente("Anna", 22));
        studenti.Add(new Studente("Luca", 19));

        foreach (Studente s in studenti)
        {
            Console.WriteLine($"{s.Nome}, {s.Eta} anni");
        }
    }

    #endregion

    #region 6. Creare un array di booleani per rappresentare lo stato di vari interruttori.

    public static void StatoInterruttori()
    {
        bool[] interruttori = { true, false, true, true, false };

        for (int i = 0; i < interruttori.Length; i++)
        {
            string stato = interruttori[i] ? "Acceso" : "Spento";
            Console.WriteLine($"Interruttore {i + 1}: {stato}");
        }
    }
    #endregion

    #region 7. Dichiarare una lista di numeri e ordinarla.

    public static void OrdinaNumeri()
    {
        List<int> numeri = new List<int> { 45, 12, 89, 23, 56, 34, 7 };

        Console.WriteLine("Lista originale:");
        foreach (int num in numeri)
        {
            Console.Write($"{num} ");
        }

        numeri.Sort();

        Console.WriteLine("\nLista ordinata:");
        foreach (int num in numeri)
        {
            Console.Write($"{num} ");
        }
        Console.WriteLine();
    }
    #endregion

    #region 8. Utilizzare un array per contare la frequenza di un valore.

    public static void ContaFrequenza()
    {
        int[] numeri = { 1, 3, 5, 3, 7, 1, 9, 3, 5, 3 };
        int valoreDaCercare = 3;
        int frequenza = 0;

        foreach (int numero in numeri)
        {
            if (numero == valoreDaCercare)
            {
                frequenza++;
            }
        }

        Console.WriteLine($"Array: {string.Join(", ", numeri)}");
        Console.WriteLine($"Il numero {valoreDaCercare} appare {frequenza} volte nell'array");
    }
    #endregion

    #region 9. Creare una lista di stringhe e rimuovere elementi specifici.

    public static void RimuoviElementi()
    {
        List<string> frutti = new List<string>
        {
        "Mela",
        "Banana",
        "Pera",
        "Arancia",
        "Mela",
        "Kiwi"
        };

        Console.WriteLine("Lista originale:");
        Console.WriteLine(string.Join(", ", frutti));

        frutti.Remove("Mela");         
        frutti.RemoveAll(x => x == "Mela"); 

        Console.WriteLine("\nLista dopo la rimozione:");
        Console.WriteLine(string.Join(", ", frutti));
    }
    #endregion

    #region 10. Dichiarare un array e inizializzarlo con valori predefiniti.

    public static void InizializzaArray()
    {
        int[] numeri1 = { 100, 200, 300, 400, 500 };

        int[] numeri2 = new int[] { 10, 20, 30, 40, 50 };

        int[] numeri3 = new int[3];
        numeri3[0] = 1;
        numeri3[1] = 2;
        numeri3[2] = 3;

        Console.WriteLine("Array 1: " + string.Join(", ", numeri1));
        Console.WriteLine("Array 2: " + string.Join(", ", numeri2));
        Console.WriteLine("Array 3: " + string.Join(", ", numeri3));
    }
    #endregion

    #region 11. Creare una lista che accetta solo valori univoci.

    public static void ListaValoriUnivoci()
    {
        HashSet<string> colori = new HashSet<string>();

        colori.Add("Rosso");
        colori.Add("Verde");
        colori.Add("Blu");
        colori.Add("Rosso");  
        colori.Add("Verde");  
        colori.Add("Giallo");

        Console.WriteLine("Colori univoci nella lista:");
        foreach (string colore in colori)
        {
            Console.WriteLine(colore);
        }

        Console.WriteLine($"\nNumero totale di colori univoci: {colori.Count}");
    }
    #endregion

    #region 12. Utilizzare un array per rappresentare una matrice di 3x3.

    public static void MatriceTrePerTre()
    {
        int[,] matrice = new int[3, 3]
        {
        { 1, 2, 3 },
        { 4, 5, 6 },
        { 7, 8, 9 }
        };

        Console.WriteLine("Matrice 3x3:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"{matrice[i, j]} ");
            }
            Console.WriteLine();
        }
    }
    #endregion

    #region 13. Dichiarare una lista e cercare un elemento al suo interno.

    public static void CercaElemento()
    {
        List<string> citta = new List<string>
        {
        "Torino",
        "Milano",
        "Napoli",
        "Firenze",
        "Roma"
        };

        string cittaDaCercare = "Torino";

        Console.WriteLine("Lista delle città:");
        Console.WriteLine(string.Join(", ", citta));

        bool esisteCitta = citta.Contains(cittaDaCercare);
        int posizione = citta.IndexOf(cittaDaCercare);

        Console.WriteLine($"\nRicerca di '{cittaDaCercare}':");
        Console.WriteLine($"La città è presente nella lista: {esisteCitta}");
        Console.WriteLine($"Posizione nella lista: {posizione}");
    }
    #endregion

    #region 14. Creare un array di oggetti e iterare sui valori.

    public static void IteraOggetti()
    {
        string[] frutta = new string[]
        {
        "Mela",
        "Pera",
        "Banana",
        "Arancia"
        };

        Console.WriteLine("Lista della frutta:");
        foreach (string f in frutta)
        {
            Console.WriteLine($"- {f}");
        }
    }
    #endregion

    #region 15. Utilizzare una lista per memorizzare i punteggi di un gioco.

    public static void PunteggiGioco()
    {
        List<int> punteggi = new List<int>
        {
        100,
        200,
        150
        };

        Console.WriteLine("Punteggi del gioco:");
        foreach (int punteggio in punteggi)
        {
            Console.WriteLine(punteggio);
        }

        int punteggioMigliore = punteggi.Max();
        Console.WriteLine($"Il punteggio più alto è: {punteggioMigliore}");
    }
    #endregion

    #region 16. Dichiarare un array di `char` per rappresentare una parola.

    public static void RappresentaParola()
    {
        char[] parola = { 'C', 'I', 'A', 'O' };

        Console.WriteLine("Caratteri della parola:");
        foreach (char lettera in parola)
        {
            Console.WriteLine(lettera);
        }

        string parolaCompleta = new string(parola);
        Console.WriteLine($"Parola completa: {parolaCompleta}");
    }
    #endregion

    #region 17. Creare una lista che accetta solo valori di tipo `float`.

    public static void ListaFloat()
    {
        List<float> numeriDecimali = new List<float>();

        // Valori float validi
        numeriDecimali.Add(3.14f);
        numeriDecimali.Add(2.5f);
        numeriDecimali.Add(1.0f);

        // Esempio di valore non float (commentato perché causerebbe errore)
        //numeriDecimali.Add(3.14);  Errore è un double!

        Console.WriteLine("Numeri nella lista float:");
        foreach (float numero in numeriDecimali)
        {
            Console.WriteLine(numero);
        }
    }
    #endregion

    #region 18. Utilizzare un array per memorizzare i giorni della settimana.

    public static void GiorniSettimana()
    {
        string[] giorni = 
        {
        "Lunedì",
        "Martedì",
        "Mercoledì",
        "Giovedì",
        "Venerdì",
        "Sabato",
        "Domenica"
        };

        Console.WriteLine("Giorni della settimana:");
        foreach (string giorno in giorni)
        {
            Console.WriteLine(giorno);
        }
    }
    #endregion

    #region 19. Dichiarare una lista e modificarne gli elementi in base alla loro posizione.

    public static void ModificaElementiLista()
    {
        List<string> colori = new List<string>
        {
        "Rosso",
        "Verde",
        "Blu"
        };

        Console.WriteLine("Lista originale:");
        foreach (string colore in colori)
        {
            Console.WriteLine(colore);
        }

        colori[0] = "Giallo";
        colori[2] = "Arancione";

        Console.WriteLine("\nLista dopo le modifiche:");
        foreach (string colore in colori)
        {
            Console.WriteLine(colore);
        }
    }
    #endregion

    #region 20. Creare un array di stringhe e concatenare tutti i valori in un'unica stringa.

    public static void ConcatenaStringhe()
    {
        string[] parole = { "Il", "gatto", "sul", "tetto" };

        Console.WriteLine("Array di parole:");
        foreach (string parola in parole)
        {
            Console.WriteLine(parola);
        }

        string frase = string.Join(" ", parole);
        Console.WriteLine("\nFrase concatenata:");
        Console.WriteLine(frase);
    }
    #endregion

    #region 21. Utilizzare una lista per memorizzare dati inseriti dall'utente.

    public static void InserisciDatiUtente()
    {
        List<string> inputUtente = new List<string>();

        Console.WriteLine("Inserisci 3 nomi (premi Enter dopo ogni nome):");

        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Nome {i + 1}: ");
            string input = Console.ReadLine();
            inputUtente.Add(input);
        }

        Console.WriteLine("\nNomi inseriti:");
        foreach (string nome in inputUtente)
        {
            Console.WriteLine(nome);
        }
    }
    #endregion

    #region 22. Dichiarare un array di numeri casuali.

    public static void NumeriCasuali()
    {
        Random random = new Random();
        int[] numeri = new int[5];

        for (int i = 0; i < numeri.Length; i++)
        {
            numeri[i] = random.Next(1, 101);
        }

        Console.WriteLine("Numeri casuali generati:");
        foreach (int numero in numeri)
        {
            Console.WriteLine(numero);
        }
    }
    #endregion

    #region 23. Creare una lista che accetta solo valori superiori a 10.

    public static void ListaValoriMaggioriDieci()
    {
        List<int> numeri = new List<int>();

        void AggiungiNumero(int n)
        {
            if (n > 10)
            {
                numeri.Add(n);
                Console.WriteLine($"Numero {n} aggiunto alla lista");
            }
            else
            {
                Console.WriteLine($"Numero {n} non aggiunto: deve essere maggiore di 10");
            }
        }

        AggiungiNumero(15);
        AggiungiNumero(8);
        AggiungiNumero(20);
        AggiungiNumero(5);

        Console.WriteLine("\nNumeri nella lista:");
        foreach (int numero in numeri)
        {
            Console.WriteLine(numero);
        }
    }
    #endregion

    #region 24. Utilizzare un array per rappresentare una tabella di moltiplicazione.

    public static void TabellaMoltiplicazione()
    {
        int[,] tabella = new int[5, 5];

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                tabella[i, j] = (i + 1) * (j + 1);
            }
        }

        Console.WriteLine("Tabella di moltiplicazione 5x5:");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write($"{tabella[i, j],4}");
            }
            Console.WriteLine();
        }
    }
    #endregion

    #region 25. Dichiarare una lista e convertirla in array.

    public static void ConvertListaInArray()
    {
        List<int> numeriLista = new List<int> { 10, 20, 30, 40, 50 };

        Console.WriteLine("Contenuto della lista:");
        foreach (int numero in numeriLista)
        {
            Console.WriteLine(numero);
        }

        int[] numeriArray = numeriLista.ToArray();

        Console.WriteLine("\nContenuto dell'array:");
        foreach (int numero in numeriArray)
        {
            Console.WriteLine(numero);
        }
    }
    #endregion

    static void Main(string[] args)
    {
        Console.WriteLine("\n========== ESERCIZIO 1 ==========");
        StampaArray();

        Console.WriteLine("\n========== ESERCIZIO 2 ==========");
        UsaLista();

        Console.WriteLine("\n========== ESERCIZIO 3 ==========");
        ArrayBidimensionale();

        Console.WriteLine("\n========== ESERCIZIO 4 ==========");
        CalcolaMedia();

        Console.WriteLine("\n========== ESERCIZIO 5 ==========");
        ListaStudenti();

        Console.WriteLine("\n========== ESERCIZIO 6 ==========");
        StatoInterruttori();

        Console.WriteLine("\n========== ESERCIZIO 7 ==========");
        OrdinaNumeri();

        Console.WriteLine("\n========== ESERCIZIO 8 ==========");
        ContaFrequenza();

        Console.WriteLine("\n========== ESERCIZIO 9 ==========");
        RimuoviElementi();

        Console.WriteLine("\n========== ESERCIZIO 10 ==========");
        InizializzaArray();

        Console.WriteLine("\n========== ESERCIZIO 11 ==========");
        ListaValoriUnivoci();

        Console.WriteLine("\n========== ESERCIZIO 12 ==========");
        MatriceTrePerTre();

        Console.WriteLine("\n========== ESERCIZIO 13 ==========");
        CercaElemento();

        Console.WriteLine("\n========== ESERCIZIO 14 ==========");
        IteraOggetti();

        Console.WriteLine("\n========== ESERCIZIO 15 ==========");
        PunteggiGioco();

        Console.WriteLine("\n========== ESERCIZIO 16 ==========");
        RappresentaParola();

        Console.WriteLine("\n========== ESERCIZIO 17 ==========");
        ListaFloat();

        Console.WriteLine("\n========== ESERCIZIO 18 ==========");
        GiorniSettimana();

        Console.WriteLine("\n========== ESERCIZIO 19 ==========");
        ModificaElementiLista();

        Console.WriteLine("\n========== ESERCIZIO 20 ==========");
        ConcatenaStringhe();

        Console.WriteLine("\n========== ESERCIZIO 21 ==========");
        InserisciDatiUtente();

        Console.WriteLine("\n========== ESERCIZIO 22 ==========");
        NumeriCasuali();

        Console.WriteLine("\n========== ESERCIZIO 23 ==========");
        ListaValoriMaggioriDieci();

        Console.WriteLine("\n========== ESERCIZIO 24 ==========");
        TabellaMoltiplicazione();

        Console.WriteLine("\n========== ESERCIZIO 25 ==========");
        ConvertListaInArray();

    }
}
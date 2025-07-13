class Program
{
    #region 1. Creare una classe `Persona` con proprietà per nome e età e una classe `Lavoro` con parametri il nome e la descrizione.

    public class Persona
    {
        public string Nome { get; set; }
        public int Eta { get; set; }
    }

    public class Lavoro
    {
        public string Nome { get; set; }
        public string Descrizione { get; set; }
    }

    public static void CreaPersonaELavoro()
    {
        Persona persona = new Persona
        {
            Nome = "Andrea",
            Eta = 22
        };

        Lavoro lavoro = new Lavoro
        {
            Nome = "Game Programmer",
            Descrizione = "Programmazione videogiochi"
        };

        Console.WriteLine($"Persona: {persona.Nome}, {persona.Eta} anni");
        Console.WriteLine($"Lavoro: {lavoro.Nome} - {lavoro.Descrizione}");
    }
    #endregion

    #region 2. Dichiarare una classe con un costruttore parametrizzato.

    public class Videogioco
    {
        public string Titolo { get; set; }
        public string Genere { get; set; }
        public int AnnoUscita { get; set; }

        public Videogioco(string titolo, string genere, int annoUscita)
        {
            Titolo = titolo;
            Genere = genere;
            AnnoUscita = annoUscita;
        }
    }

    public static void CreaVideogioco()
    {
        Videogioco gioco = new Videogioco("Elden Ring", "Action RPG", 2022);
        Console.WriteLine($"Videogioco: {gioco.Titolo}");
        Console.WriteLine($"Genere: {gioco.Genere}");
        Console.WriteLine($"Anno di uscita: {gioco.AnnoUscita}");
    }
    #endregion

    #region 3. Creare una classe che implementa un metodo per calcolare un valore.

    public class Calcolatrice
    {
        public int Somma(int a, int b)
        {
            return a + b;
        }
    }

    public static void UsaCalcolatrice()
    {
        Calcolatrice calc = new Calcolatrice();
        int risultato = calc.Somma(10, 5);

        Console.WriteLine($"La somma è: {risultato}");
    }
    #endregion

    #region 4. Creare una classe che eredita da un'altra.

    public class Veicolo
    {
        public string Marca { get; set; }
        public string Modello { get; set; }
    }

    public class Auto : Veicolo
    {
        public int NumeroPorte { get; set; }
    }

    public static void UsaEredita()
    {
        Auto auto = new Auto
        {
            Marca = "Ferrari",
            Modello = "F40",
            NumeroPorte = 2
        };

        Console.WriteLine($"Auto: {auto.Marca} {auto.Modello}");
        Console.WriteLine($"Numero porte: {auto.NumeroPorte}");
    }
    #endregion

    #region 5. Aggiungere diversi metodi public all'interno della classe 'Persona'

    public class Persona2
    {
        public string Nome { get; set; }
        public int Eta { get; set; }

        public void Saluta()
        {
            Console.WriteLine($"Ciao, sono {Nome}!");
        }

        public void Presentati()
        {
            Console.WriteLine($"Mi chiamo {Nome} e ho {Eta} anni");
        }

        public void Studia()
        {
            Console.WriteLine($"{Nome} sta studiando programmazione");
        }
    }

    public static void UsaMetodiPersona()
    {
        Persona2 persona = new Persona2
        {
            Nome = "Andrea",
            Eta = 22
        };

        persona.Saluta();
        persona.Presentati();
        persona.Studia();
    }
    #endregion

    #region 6. Creare una classe che contiene una lista come proprietà.

    public class CollezionePlatini
    {
        public string NomeGiocatore { get; set; }
        public List<string> GiochiPlatinati { get; set; }

        public CollezionePlatini()
        {
            GiochiPlatinati = new List<string>();
        }
    }

    public static void UsaCollezionePlatini()
    {
        CollezionePlatini collezione = new CollezionePlatini();
        collezione.NomeGiocatore = "TrophyHunter";
        collezione.GiochiPlatinati.Add("Elden Ring");
        collezione.GiochiPlatinati.Add("Dark Souls III");
        collezione.GiochiPlatinati.Add("Bloodborne");

        Console.WriteLine($"Trofei Platino di: {collezione.NomeGiocatore}");
        Console.WriteLine("Platini ottenuti:");
        foreach (string platino in collezione.GiochiPlatinati)
        {
            Console.WriteLine(platino);
        }
    }
    #endregion

    #region 7. Creare una classe con proprietà indicizzate.

    public class Inventario
    {
        private string[] oggetti = new string[3];

        public string this[int index]
        {
            get { return oggetti[index]; }
            set { oggetti[index] = value; }
        }
    }

    public static void UsaInventario()
    {
        Inventario zaino = new Inventario();

        zaino[0] = "Pozione di Cura";
        zaino[1] = "Spada Lunga";
        zaino[2] = "Anello Magico";

        Console.WriteLine("Contenuto dello zaino:");
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"Slot {i}: {zaino[i]}");
        }
    }
    #endregion

    #region 8. Dentro a persona dichiarare un parametro di tipo Lavoro.

    public class Persona3
    {
        public string Nome { get; set; }
        public int Eta { get; set; }
        public Lavoro Occupazione { get; set; }
    }

    public static void PersonaConLavoro()
    {
        Persona3 persona = new Persona3
        {
            Nome = "Andrea",
            Eta = 22,
            Occupazione = new Lavoro
            {
                Nome = "Game Programmer",
                Descrizione = "Programmazione videogiochi"
            }
        };

        Console.WriteLine($"Nome: {persona.Nome}");
        Console.WriteLine($"Età: {persona.Eta}");
        Console.WriteLine($"Lavoro: {persona.Occupazione.Nome}");
        Console.WriteLine($"Descrizione: {persona.Occupazione.Descrizione}");
    }
    #endregion

    #region 9. Fare un programma che data una lista di Persone e una lista di Lavori venga assegnato a ogni persona un Lavoro casuale

    public static void AssegnaLavoriCasuali()
    {
        List<Persona3> persone = new List<Persona3>
        {
        new Persona3 { Nome = "Marco" },
        new Persona3 { Nome = "Laura" },
        new Persona3 { Nome = "Paolo" }
        };

        List<Lavoro> lavori = new List<Lavoro>
        {
        new Lavoro { Nome = "Game Programmer", Descrizione = "Programmazione videogiochi" },
        new Lavoro { Nome = "Game Designer", Descrizione = "Design meccaniche di gioco" },
        new Lavoro { Nome = "3D Artist", Descrizione = "Modellazione 3D" }
        };

        Random random = new Random();

        foreach (var persona in persone)
        {
            int indice = random.Next(lavori.Count);
            persona.Occupazione = lavori[indice];
            Console.WriteLine($"{persona.Nome} è stato assegnato come {persona.Occupazione.Nome}");
        }
    }
    #endregion

    static void Main(string[] args)
    {
        Console.WriteLine("\n========== ESERCIZIO 1 ==========");
        CreaPersonaELavoro();

        Console.WriteLine("\n========== ESERCIZIO 2 ==========");
        CreaVideogioco();

        Console.WriteLine("\n========== ESERCIZIO 3 ==========");
        UsaCalcolatrice();

        Console.WriteLine("\n========== ESERCIZIO 4 ==========");
        UsaEredita();

        Console.WriteLine("\n========== ESERCIZIO 5 ==========");
        UsaMetodiPersona();

        Console.WriteLine("\n========== ESERCIZIO 6 ==========");
        UsaCollezionePlatini();

        Console.WriteLine("\n========== ESERCIZIO 7 ==========");
        UsaInventario();

        Console.WriteLine("\n========== ESERCIZIO 8 ==========");
        PersonaConLavoro();

        Console.WriteLine("\n========== ESERCIZIO 9 ==========");
        AssegnaLavoriCasuali();

    }
}

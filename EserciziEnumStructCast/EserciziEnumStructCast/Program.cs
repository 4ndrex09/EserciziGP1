class Program
{
    #region 1. Creare un `enum` per rappresentare i giorni della settimana e iterare sui valori.

    public enum GiorniSettimana
    {
        Lunedi,
        Martedi,
        Mercoledi,
        Giovedi,
        Venerdi,
        Sabato,
        Domenica
    }

    public static void StampaGiorni()
    {
        foreach (GiorniSettimana giorno in Enum.GetValues(typeof(GiorniSettimana)))
        {
            Console.WriteLine($"Giorno: {giorno}");
        }
    }
    #endregion

    #region 2. Dichiarare un `enum` per rappresentare i livelli di priorità di un task.

    public enum PrioritaTask
    {
        Bassa = 1,
        Media = 2,
        Alta = 3,
        Urgente = 4
    }

    public static void MostraPriorita()
    {
        foreach (PrioritaTask priorita in Enum.GetValues(typeof(PrioritaTask)))
        {
            Console.WriteLine($"Livello {(int)priorita}: {priorita}");
        }
    }
    #endregion

    #region 3. Usare un `enum` per selezionare un'opzione in uno switch-case.

    public enum Colore
    {
        Rosso,
        Verde,
        Blu,
        Giallo
    }

    public static void ScegliColore(Colore colore)
    {
        switch (colore)
        {
            case Colore.Rosso:
                Console.WriteLine("Hai scelto il rosso!");
                break;
            case Colore.Verde:
                Console.WriteLine("Hai scelto il verde!");
                break;
            case Colore.Blu:
                Console.WriteLine("Hai scelto il blu!");
                break;
            case Colore.Giallo:
                Console.WriteLine("Hai scelto il giallo!");
                break;
        }
    }
    #endregion

    #region 4. Dichiarare una `struct` per rappresentare un punto 2D e calcolare la distanza tra due punti.

    public struct Punto2D
    {
        public int X;
        public int Y;

        public Punto2D(int x, int y)
        {
            X = x;
            Y = y;
        }
    }

    public static void CalcolaDistanza()
    {
        Punto2D p1 = new Punto2D(0, 0);
        Punto2D p2 = new Punto2D(3, 4);

        double distanza = Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2));
        Console.WriteLine($"Punto 1: ({p1.X}, {p1.Y})");
        Console.WriteLine($"Punto 2: ({p2.X}, {p2.Y})");
        Console.WriteLine($"Distanza: {distanza:F2}");
    }
    #endregion

    #region 5. Creare una `struct` per rappresentare un rettangolo e calcolarne l'area.

    public struct Rettangolo
    {
        public double Base;
        public double Altezza;

        public Rettangolo(double baseRett, double altezza)
        {
            Base = baseRett;
            Altezza = altezza;
        }

        public double CalcolaArea()
        {
            return Base * Altezza;
        }
    }

    public static void MostraRettangolo()
    {
        Rettangolo rett = new Rettangolo(5.0, 3.0);
        Console.WriteLine($"Base: {rett.Base}");
        Console.WriteLine($"Altezza: {rett.Altezza}");
        Console.WriteLine($"Area: {rett.CalcolaArea()}");
    }
    #endregion

    #region 6. Utilizzare un `enum` per rappresentare i tipi di un veicolo in un programma.

    public enum TipoVeicolo
    {
        Auto,
        Moto,
        Bicicletta,
        Camion
    }

    public static void MostraVeicoli()
    {
        foreach (TipoVeicolo tipo in Enum.GetValues(typeof(TipoVeicolo)))
        {
            Console.WriteLine($"Veicolo: {tipo}");
        }
    }
    #endregion

    #region 7. Dichiarare una `struct` con un costruttore e un metodo.

    public struct Persona
    {
        public string Nome;
        public int Eta;

        public Persona(string nome, int eta)
        {
            Nome = nome;
            Eta = eta;
        }

        public void Presentati()
        {
            Console.WriteLine($"Mi chiamo {Nome} e ho {Eta} anni");
        }
    }

    public static void UsaPersona()
    {
        Persona p1 = new Persona("Andrea", 22);
        p1.Presentati();
    }
    #endregion

    #region 8. Scrivere un programma che converte un valore `int` in un `enum` usando il casting.

    public enum Mese
    {
        Gennaio = 1,
        Febbraio,
        Marzo,
        Aprile
    }

    public static void ConvertToEnum()
    {
        int numero = 2;
        Mese mese = (Mese)numero;
        Console.WriteLine($"Numero {numero} convertito in: {mese}");
    }
    #endregion

    #region 9. Dichiarare un `enum` con valori personalizzati e verificarne l'uso.

    public enum Livello
    {
        Base = 10,
        Intermedio = 20,
        Avanzato = 30,
        Expert = 40
    }

    public static void MostraLivelli()
    {
        foreach (Livello liv in Enum.GetValues(typeof(Livello)))
        {
            Console.WriteLine($"Livello {liv}: {(int)liv} punti");
        }
    }
    #endregion

    #region 10. Creare una `struct` per rappresentare un colore in formato RGB.

    public struct ColoreRGB
    {
        public int Rosso;
        public int Verde;
        public int Blu;

        public ColoreRGB(int r, int v, int b)
        {
            Rosso = r;
            Verde = v;
            Blu = b;
        }

        public void Mostra()
        {
            Console.WriteLine($"RGB({Rosso}, {Verde}, {Blu})");
        }
    }

    public static void UsaColore()
    {
        ColoreRGB rosso = new ColoreRGB(255, 0, 0);
        ColoreRGB verde = new ColoreRGB(0, 255, 0);

        rosso.Mostra();
        verde.Mostra();
    }
    #endregion

    #region 11. Utilizzare un `enum` in una funzione per selezionare un'opzione.

    public enum Stagione
    {
        Primavera,
        Estate,
        Autunno,
        Inverno
    }

    public static void MostraStagioni()
    {
        foreach (Stagione s in Enum.GetValues(typeof(Stagione)))
        {
            Console.WriteLine($"Stagione: {s}");
        }
    }
    #endregion

    #region 12. Dichiarare una `struct` con proprietà `readonly`.

    public struct Libro
    {
        public readonly string Titolo;
        public readonly string Autore;

        public Libro(string titolo, string autore)
        {
            Titolo = titolo;
            Autore = autore;
        }
    }

    public static void MostraLibro()
    {
        Libro libro = new Libro("Il Signore degli Anelli", "Tolkien");
        Console.WriteLine($"Libro: {libro.Titolo} di {libro.Autore}");
    }
    #endregion

    #region 13. Creare un `enum` per rappresentare i mesi dell'anno.

    public enum Mesi
    {
        Gennaio = 1,
        Febbraio,
        Marzo,
        Aprile,
        Maggio,
        Giugno,
        Luglio,
        Agosto,
        Settembre,
        Ottobre,
        Novembre,
        Dicembre
    }

    public static void MostraMesi()
    {
        foreach (Mesi mese in Enum.GetValues(typeof(Mesi)))
        {
            Console.WriteLine($"Mese {(int)mese}: {mese}");
        }
    }
    #endregion

    #region 14. Dichiarare una `struct` per rappresentare una persona con nome e età.

    public struct Utente
    {
        public string Nome;
        public int Eta;

        public Utente(string nome, int eta)
        {
            Nome = nome;
            Eta = eta;
        }
    }

    public static void MostraUtenti()
    {
        Utente u1 = new Utente("Andrea", 22);
        Utente u2 = new Utente("Mario", 30);

        Console.WriteLine($"{u1.Nome}, {u1.Eta} anni");
        Console.WriteLine($"{u2.Nome}, {u2.Eta} anni");
    }
    #endregion

    #region 15. Scrivere un programma che utilizza il casting esplicito tra tipi numerici.

    public static void MostraCasting()
    {
        double numero = 123.45;
        int numeroIntero = (int)numero;
        float numeroFloat = (float)numero;

        Console.WriteLine($"Double: {numero}");
        Console.WriteLine($"Int: {numeroIntero}");
        Console.WriteLine($"Float: {numeroFloat}");
    }
    #endregion

    #region 16. Dichiarare un `enum` per rappresentare i tipi di errore di un'app.

    public enum TipoErrore
    {
        Nessuno = 0,
        Rete = 100,
        Database = 200,
        Login = 300,
        Sistema = 400
    }

    public static void MostraErrori()
    {
        foreach (TipoErrore errore in Enum.GetValues(typeof(TipoErrore)))
        {
            Console.WriteLine($"Errore {(int)errore}: {errore}");
        }
    }
    #endregion

    #region 17. Creare una `struct` per rappresentare una posizione 3D e calcolarne la distanza.

    public struct Punto3D
    {
        public int X;
        public int Y;
        public int Z;

        public Punto3D(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }
    }

    public static void CalcolaDistanza3D()
    {
        Punto3D p1 = new Punto3D(0, 0, 0);
        Punto3D p2 = new Punto3D(3, 4, 5);

        Console.WriteLine($"Punto 1: ({p1.X}, {p1.Y}, {p1.Z})");
        Console.WriteLine($"Punto 2: ({p2.X}, {p2.Y}, {p2.Z})");

        double distanza = Math.Sqrt(
            Math.Pow(p2.X - p1.X, 2) +
            Math.Pow(p2.Y - p1.Y, 2) +
            Math.Pow(p2.Z - p1.Z, 2));

        Console.WriteLine($"Distanza 3D: {distanza:F2}");
    }
    #endregion

    #region 18. Utilizzare un `enum` per definire i tipi di permesso di un'app.

    public enum Permesso
    {
        Lettura = 1,
        Scrittura = 2,
        Modifica = 4,
        Admin = 8
    }

    public static void MostraPermessi()
    {
        foreach (Permesso p in Enum.GetValues(typeof(Permesso)))
        {
            Console.WriteLine($"Livello {(int)p}: {p}");
        }
    }
    #endregion

    #region 19. Dichiarare una `struct` per rappresentare una data personalizzata.

    public struct Data
    {
        public int Giorno;
        public int Mese;
        public int Anno;

        public Data(int giorno, int mese, int anno)
        {
            Giorno = giorno;
            Mese = mese;
            Anno = anno;
        }

        public void Mostra()
        {
            Console.WriteLine($"{Giorno}/{Mese}/{Anno}");
        }
    }

    public static void UsaData()
    {
        Data data1 = new Data(9, 12, 2024);
        Data data2 = new Data(3, 1, 2025);

        data1.Mostra();
        data2.Mostra();
    }
    #endregion

    #region 20. Creare una `struct` per rappresentare una carta da gioco (valore e seme).

    public struct Carta
    {
        public string Valore;
        public string Seme;

        public Carta(string valore, string seme)
        {
            Valore = valore;
            Seme = seme;
        }

        public void Mostra()
        {
            Console.WriteLine($"{Valore} di {Seme}");
        }
    }

    public static void MostraCarte()
    {
        Carta carta1 = new Carta("Asso", "Cuori");
        Carta carta2 = new Carta("Re", "Picche");

        carta1.Mostra();
        carta2.Mostra();
    }
    #endregion

    #region 21. Utilizzare un `enum` in un'istruzione condizionale.

    public enum Stato
    {
        Attivo,
        Inattivo,
        Sospeso
    }

    public static void ControllaStato()
    {
        Stato statoCorrente = Stato.Attivo;

        if (statoCorrente == Stato.Attivo)
        {
            Console.WriteLine("Il sistema è operativo");
        }
        else
        {
            Console.WriteLine("Il sistema non è attivo");
        }
    }
    #endregion

    #region 22. Dichiarare una `struct` che contiene un array come proprietà.

    public struct Squadra
    {
        public string Nome;
        public string[] Giocatori;

        public Squadra(string nome, string[] giocatori)
        {
            Nome = nome;
            Giocatori = giocatori;
        }
    }

    public static void MostraSquadra()
    {
        string[] giocatori = { "Adams", "Ricci", "Zapata" };
        Squadra squadra = new Squadra("TorinoFC", giocatori);

        Console.WriteLine($"Squadra: {squadra.Nome}");
        Console.WriteLine("Giocatori:");
        foreach (string g in squadra.Giocatori)
        {
            Console.WriteLine($"- {g}");
        }
    }
    #endregion

    #region 23. Scrivere un programma che converte un valore `double` in `float` usando il casting esplicito.

    public static void ConvertDouble()
    {
        double numeroDouble = 123.456789;
        float numeroFloat = (float)numeroDouble;

        Console.WriteLine($"Double: {numeroDouble}");
        Console.WriteLine($"Float: {numeroFloat}");
    }
    #endregion

    #region 24. Utilizzare un `enum` per rappresentare i tipi di file supportati da un'app.

    public enum TipoFile
    {
        PDF,
        DOC,
        TXT,
        JPG,
        PNG
    }

    public static void MostraFormati()
    {
        Console.WriteLine("Formati supportati:");
        foreach (TipoFile tipo in Enum.GetValues(typeof(TipoFile)))
        {
            Console.WriteLine($"- {tipo}");
        }
    }
    #endregion

    #region 25. Creare una `struct` per rappresentare un vettore e calcolare il prodotto scalare.

    public struct Vettore
    {
        public int X;
        public int Y;

        public Vettore(int x, int y)
        {
            X = x;
            Y = y;
        }
    }

    public static void CalcolaProdotto()
    {
        Vettore v1 = new Vettore(3, 4);
        Vettore v2 = new Vettore(1, 2);

        int prodotto = (v1.X * v2.X) + (v1.Y * v2.Y);

        Console.WriteLine($"Vettore 1: ({v1.X}, {v1.Y})");
        Console.WriteLine($"Vettore 2: ({v2.X}, {v2.Y})");
        Console.WriteLine($"Prodotto scalare: {prodotto}");
    }
    #endregion

    static void Main(string[] args)
    {
        Console.WriteLine("\n========== ESERCIZIO 1 ==========");
        StampaGiorni();

        Console.WriteLine("\n========== ESERCIZIO 2 ==========");
        MostraPriorita();

        Console.WriteLine("\n========== ESERCIZIO 3 ==========");
        ScegliColore(Colore.Rosso);
        ScegliColore(Colore.Blu);

        Console.WriteLine("\n========== ESERCIZIO 4 ==========");
        CalcolaDistanza();

        Console.WriteLine("\n========== ESERCIZIO 5 ==========");
        MostraRettangolo();

        Console.WriteLine("\n========== ESERCIZIO 6 ==========");
        MostraVeicoli();

        Console.WriteLine("\n========== ESERCIZIO 7 ==========");
        UsaPersona();

        Console.WriteLine("\n========== ESERCIZIO 8 ==========");
        ConvertToEnum();

        Console.WriteLine("\n========== ESERCIZIO 9 ==========");
        MostraLivelli();

        Console.WriteLine("\n========== ESERCIZIO 10 ==========");
        UsaColore();

        Console.WriteLine("\n========== ESERCIZIO 11 ==========");
        MostraStagioni();

        Console.WriteLine("\n========== ESERCIZIO 12 ==========");
        MostraLibro();

        Console.WriteLine("\n========== ESERCIZIO 13 ==========");
        MostraMesi();

        Console.WriteLine("\n========== ESERCIZIO 14 ==========");
        MostraUtenti();

        Console.WriteLine("\n========== ESERCIZIO 15 ==========");
        MostraCasting();

        Console.WriteLine("\n========== ESERCIZIO 16 ==========");
        MostraErrori();

        Console.WriteLine("\n========== ESERCIZIO 17 ==========");
        CalcolaDistanza3D();

        Console.WriteLine("\n========== ESERCIZIO 18 ==========");
        MostraPermessi();

        Console.WriteLine("\n========== ESERCIZIO 19 ==========");
        UsaData();

        Console.WriteLine("\n========== ESERCIZIO 20 ==========");
        MostraCarte();

        Console.WriteLine("\n========== ESERCIZIO 21 ==========");
        ControllaStato();

        Console.WriteLine("\n========== ESERCIZIO 22 ==========");
        MostraSquadra();

        Console.WriteLine("\n========== ESERCIZIO 23 ==========");
        ConvertDouble();

        Console.WriteLine("\n========== ESERCIZIO 24 ==========");
        MostraFormati();

        Console.WriteLine("\n========== ESERCIZIO 25 ==========");
        CalcolaProdotto();
    }
}
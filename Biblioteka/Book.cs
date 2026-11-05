public class Book
{
    // Title un Author ir tikai lasāmas, IsBorrowed var mainīt tikai pati klase (private set)
    public string Title { get; }
    public string Author { get; }
    public bool IsBorrowed { get; private set; }

    public Book(string title, string author)
    {
        Title = title;
        Author = author;
        IsBorrowed = false; // Jaunai grāmatai sākotnēji ir false
    }

    public bool Borrow()
    {
        if (IsBorrowed)
        {
            return false; // Jau izsniegta
        }

        IsBorrowed = true;
        return true; // Veiksmīgi izsniegta
    }

    public bool Return()
    {
        if (!IsBorrowed)
        {
            return false; // Nav izsniegta, nav ko atdot
        }

        IsBorrowed = false;
        return true; // Veiksmīgi atgriezta
    }
}

// Paskaidrojums:
// 1. IsBorrowed ir ar private set, lai ievērotu principu - ārpus klases neviens nevar vienkārši izmainīt grāmatas stāvokli (piem., padarīt to par izsniegtu bez aizņemšanās loģikas), to var kontrolēt tikai caur metodēm Borrow() un Return().
// 2. Book un BookPrinter ir atsevišķas klases, lai ievērotu SOLID S Single Responsibility / Vienas atbildības principu. 
//    Klasei Book jāatbild tikai par grāmatas datiem un stāvokli, bet izvade (konsole, u.c.) ir cita atbildība, ko veic BookPrinter.
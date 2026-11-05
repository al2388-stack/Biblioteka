public class BookPrinter
{
    public void Print(Book book)
    {
        // Pārbaudām stāvokli un izvadām atbilstošu tekstu latviešu valodā
        string status = book.IsBorrowed ? "izsniegta" : "brīva";
        Console.WriteLine($"{book.Title} ({book.Author}) - {status}");
    }
}
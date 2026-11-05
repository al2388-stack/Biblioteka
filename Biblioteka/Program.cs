class Program
{
    static void Main(string[] args)
    {
        var book = new Book("Zelta zirgs", "Rainis");
        var printer = new BookPrinter();

        Console.WriteLine(book.Borrow()); // True
        Console.WriteLine(book.Borrow()); // False

        printer.Print(book);             // Izvada: Zelta zirgs (Rainis) - izsniegta

        Console.WriteLine(book.Return()); // True

        printer.Print(book);             // Izvada: Zelta zirgs (Rainis) - brīva
    }
}
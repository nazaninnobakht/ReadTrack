// See https://aka.ms/new-console-template for more information
using ReadTrack.Console;

Console.WriteLine("Welcome to ReadTrack!");
Console.WriteLine("Your personal reading tracker.");

Book firstBook = new Book
{
    Title = "Clean Code",
    PageCount = 400,
};

Book secondBook = firstBook;
secondBook.Title = "Refactoring";


static void Replace(ref Book book)
{
    book = new Book
    {
        Title = "DDD"
    };
}

Book book = new Book
{
    Title = "Clean Code"
};

Replace(ref book);

Console.WriteLine(book.Title);
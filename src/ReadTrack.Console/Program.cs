// See https://aka.ms/new-console-template for more information
using ReadTrack.Console;

Console.WriteLine("Welcome to ReadTrack!");
Console.WriteLine("Your personal reading tracker.");

Book book = new Book
{
    Title = "Clean Code",
    PageCount = 464,
    CurrentPage = 150
};

double progress =
    ReadingProgressCalculator.Calculate(
        book.CurrentPage,
        book.PageCount);

Console.WriteLine($"Book: {book.Title}");

Console.WriteLine($"Total Pages: {book.PageCount}");

Console.WriteLine($"Current Page: {book.CurrentPage}");

Console.WriteLine($"Progress: {progress:F2}%");


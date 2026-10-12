// See https://aka.ms/new-console-template for more information
using ReadTrack.Console;

Console.WriteLine("Welcome to ReadTrack!");
Console.WriteLine("Your personal reading tracker.");

Console.WriteLine("Book title: ");
string title = Console.ReadLine() ?? string.Empty;

Console.WriteLine("Page count: ");
string? pageCountInput = Console.ReadLine();

if(!int.TryParse(pageCountInput, out var pageCount))
{
    Console.WriteLine("Page count must be a valid number.");
    return;
}

if(pageCount <= 0)
{
    Console.WriteLine("Page count must be greater than zero.");
    return;
}

Book book = new Book()
{
    Title = title,
    PageCount = pageCount,
    CurrentPage = 0
};

Console.WriteLine();
Console.WriteLine("Book created:");
Console.WriteLine($"Title: {book.Title}");
Console.WriteLine($"Page: {book.PageCount}");
Console.WriteLine("Current page: ");
string? currentPageInput = Console.ReadLine();

int CurrentPage = book.CurrentPage;

double progress = (double)CurrentPage / pageCount * 100;

Console.WriteLine($"Reading prpgress: {progress:F2}%");




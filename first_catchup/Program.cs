using System;

class Program
{
    static void Main()
    {
        Book book = new Book();
        book.Title = "C# Programming";
        book.Pages = 500;
        Console.WriteLine($"本のタイトル: {book.Title}\nページ数: {book.Pages}");
    }
}
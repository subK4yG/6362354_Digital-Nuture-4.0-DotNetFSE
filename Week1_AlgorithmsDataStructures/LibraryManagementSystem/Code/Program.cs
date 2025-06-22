using System;
class Book
{
    public int id;
    public string title;
    public string author;

    public void Show()
    {
        Console.WriteLine($"{id} - {title} - {author}");
    }
}
class Program
{
    static Book[] books = new Book[]
    {
        new Book { id = 1, title = "C", author = "Mr. Vishnu" },
        new Book { id = 2, title = "Java", author = "Dr. Brahma" },
        new Book { id = 3, title = "Python", author = "Mr. Ram" },
        new Book { id = 4, title = "C#", author = "Dr. Shiva" },
    };
    static Book Linear(string name)
    {
        foreach (var b in books)
            if (b.title == name)
                return b;
        return null;
    }
    static Book Binary(string name)
    {
        int l = 0, r = books.Length - 1;
        while (l <= r)
        {
            int m = (l + r) / 2;
            int cmp = string.Compare(books[m].title, name);
            if (cmp == 0) return books[m];
            else if (cmp < 0) l = m + 1;
            else r = m - 1;
        }
        return null;
    }
    static void Main()
    {
        Console.WriteLine("Linear Search: 'Python'");
        var b1 = Linear("Python");
        if (b1 != null) b1.Show(); else Console.WriteLine("Not found");
        Console.WriteLine("\nBinary Search: 'Java'");
        Array.Sort(books, (a, b) => a.title.CompareTo(b.title));
        var b2 = Binary("Java");
        if (b2 != null) b2.Show(); else Console.WriteLine("Not found");
    }
}

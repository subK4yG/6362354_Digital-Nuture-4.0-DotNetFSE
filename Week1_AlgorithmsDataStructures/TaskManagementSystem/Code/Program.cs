using System;
class Task
{
    public int id;
    public string name;
    public string status;
    public Task next;
}
class List
{
    Task head;
    public void Add(int id, string name, string status)
    {
        Task t = new Task { id = id, name = name, status = status, next = null };
        if (head == null) head = t;
        else
        {
            Task temp = head;
            while (temp.next != null) temp = temp.next;
            temp.next = t;
        }
    }
    public void Show()
    {
        Task t = head;
        Console.WriteLine("All Tasks:");
        while (t != null)
        {
            Console.WriteLine($"{t.id} - {t.name} - {t.status}");
            t = t.next;
        }
    }
    public Task Find(int id)
    {
        Task t = head;
        while (t != null)
        {
            if (t.id == id) return t;
            t = t.next;
        }
        return null;
    }
    public void Del(int id)
    {
        if (head == null) return;
        if (head.id == id) { head = head.next; return; }
        Task prev = head, curr = head.next;
        while (curr != null)
        {
            if (curr.id == id)
            {
                prev.next = curr.next;
                return;
            }
            prev = curr;
            curr = curr.next;
        }
    }
}
class Program
{
    static void Main()
    {
        List tasks = new List();
        tasks.Add(1, "Login page", "done");
        tasks.Add(2, "Payment API", "pending");
        tasks.Add(3, "Email notif", "in progress");
        tasks.Show();
        Console.WriteLine("\nSearch Task ID 2:");
        var t = tasks.Find(2);
        if (t != null) Console.WriteLine($"{t.id} - {t.name} - {t.status}");
        Console.WriteLine("\nDelete Task ID 1:");
        tasks.Del(1);
        Console.WriteLine("\nAfter Deletion:");
        tasks.Show();
    }
}

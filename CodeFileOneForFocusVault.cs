using System;

class RemindeUser
{
    static void RemindUser(string task)
    {
        Console.WriteLine($"Reminder: Time to complete '{task}'!");
    }
}

static void TrackDeadline(string task, DateTime deadline)
{
    Console.WriteLine($"Task: {task}, Deadline: {deadline}");
}

static void Main()
{
    string task = "Morning Exercise";
    DateTime deadline = DateTime.Now.AddHours(2);

    RemindUser(task);
    TrackDeadline(task, deadline);
}
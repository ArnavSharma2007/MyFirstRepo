using System;

class ReminderApp
{
    static void RemindUser(string task)
    {
        Console.WriteLine($"Reminder: Time to complete '{task}'!");
    }

    static void Main()
    {
        RemindUser("Morning Exercise");
    }
}
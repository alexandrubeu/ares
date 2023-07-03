namespace ares;

public class Student:IStudent
{
    public void SayMyName()
    {
        string name = "";
        name = Console.ReadLine();
        Console.WriteLine($"My name is {name}");
    }
}
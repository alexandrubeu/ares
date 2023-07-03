namespace ares;

public class StudentEduard : IStudent
{
    public void SayMyName()
    {
        Console.WriteLine("My name is Eduard");
    }
}


public class Student : IStudent
{
    public void SayMyName()
    {
        string name = "";
        name = Console.ReadLine();
        Console.WriteLine($"My name is {name}");
        //Comment again
    }
}

public class Student1 : IStudent
{
    public void SayMyName()
    {
        Console.WriteLine("My name is Lungu Igor");
    }
}
namespace ares;

public interface IStudent
{
    public void SayMyName();
}

public class StudentDarius : IStudent
{
    public void SayMyName()
    {
        Console.WriteLine("Darius");
    }
}
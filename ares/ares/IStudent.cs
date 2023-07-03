namespace ares;

public interface IStudent
{
    public void SayMyName();
}

class Student : IStudent
{
    private string name;

    public void Student(string name)
    {
        this.name = name;
    }
    
    public void SayMyName() 
    {
        Console.WriteLine(this.name);
    }
}
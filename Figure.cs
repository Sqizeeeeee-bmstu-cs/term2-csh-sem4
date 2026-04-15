

public abstract class Figure(string type)
{
    public string Type { get; } = type;

    public abstract double Area { get; }

    public override string ToString() => Type;

}


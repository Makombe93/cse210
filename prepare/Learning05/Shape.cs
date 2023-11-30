// Shape.cs
public class Shape
{
    private string color;

    public Shape(string color)
    {
        this.color = color;
    }

    public string GetColor()
    {
        return color;
    }

    public virtual float GetArea()
    {
        //Output for unknown shapes
        return 0;
    }
}

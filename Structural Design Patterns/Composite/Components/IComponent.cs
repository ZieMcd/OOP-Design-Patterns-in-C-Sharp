namespace Composite.Components;

public interface IComponent
{
    public string Name { get; }

    void Display(string currentPath);
}
using Composite.Components;

namespace Composite.Leafs;

public class File : IComponent
{
    public string Name { get; }
    
    public File(string name)
    {
        Name = name;
    }

    public void Display(string currentPath)
    {
        Console.WriteLine(currentPath + Name);
    }
}
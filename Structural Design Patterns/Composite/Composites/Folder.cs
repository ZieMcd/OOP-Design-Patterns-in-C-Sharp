using Composite.Components;

namespace Composite.Composites;

public class Folder : IComponent
{
    private readonly List<IComponent> _childern;

    public Folder(string name)
    {
        _childern = new();
        Name = name;
    }

    public string Name { get; }
    
    public void Display(string currentPath)
    {
        Console.WriteLine(currentPath + Name + Path.DirectorySeparatorChar);
    }

    public void Add(IComponent component)
    {
        _childern.Add(component);
    }

    public void Remove(string componentName)
    {
        var childToRemove = _childern.FirstOrDefault(c => c.Name == componentName);

        if (childToRemove is not null) _childern.Remove(childToRemove);
    }

    public void DisplayChildren(string path)
    {
        foreach (var child in _childern)
        {
            child.Display(path + Name + Path.DirectorySeparatorChar);

            if (child is Folder folder)
            {
                folder.DisplayChildren(path + Name + Path.DirectorySeparatorChar);
            }
        }
    }
}
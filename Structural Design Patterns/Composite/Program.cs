using Composite.Composites;

var rootFolder = new Folder("Root"); 
rootFolder.Add(new Folder("Desktop"));
rootFolder.Add(new Folder("Downloads"));

var documentsFolder = new Folder("Documents");
documentsFolder.Add(new Composite.Leafs.File("RandomFile.txt"));

rootFolder.Add(documentsFolder);

rootFolder.DisplayChildren(string.Empty);
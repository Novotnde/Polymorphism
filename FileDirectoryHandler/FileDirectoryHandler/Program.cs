using System;
using FileDirectoryHandler;

public class Program
{
    public static void Main()
    {

        FileItem file1 = new FileItem { Name = "document.txt", Content = "This is a document." };
        FileItem file2 = new FileItem { Name = "image.jpg", Content = "Image metadata here." };

        FileDirectoryHandler.Directory dir = new FileDirectoryHandler.Directory { Name = "MyFolder" };

        dir.AddItem(file1);
        dir.AddItem(file2);


        Console.WriteLine(file1.Name + ": " + file1.Display());
        Console.WriteLine(file2.Name + ": " + file2.Display());

        Console.WriteLine(dir.Name + ": " + dir.Display());
    }
}

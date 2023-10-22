using System;
namespace FileDirectoryHandler
{
    public class FileItem : Item
    {

        public string Content { get; set; }

        public override string Display()
        {
            return Content;
        }

    }
}
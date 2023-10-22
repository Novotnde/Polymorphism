using System;
namespace FileDirectoryHandler
{
	public class Item
	{
        public string Name { get; set; }

        public virtual string Display()
        {
            return  "Ite,";
       }
    }
}


using System;
namespace FileDirectoryHandler
{
	public class Directory : Item 
	{
        List<Item > Items;

        public Directory()
        {
            Items = new List<Item>();
        }

        public override string Display()
        {
            return string.Join(", ", Items.Select(i => i.Name)); 
        }

            public void AddItem(Item item)
        {
            Items.Add(item);
        }
    }
}


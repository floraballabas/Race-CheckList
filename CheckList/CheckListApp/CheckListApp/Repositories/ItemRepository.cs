using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CheckListApp.Entities;
using CheckListApp.Models;

namespace CheckListApp.Repositories
{
    public class ItemRepository
    {
        ItemContext itemContext;
        public ItemRepository(ItemContext itemContext)
        {
            this.itemContext = itemContext;
        }

        public List<Item> GetList()
        {
            return itemContext.Items.ToList();
        }

        public void AddItem(string name, RaceCategory raceCategory)
        {
            var item = new Item()
            {
                Name = name,
                RaceCategory = raceCategory
            };

            itemContext.Items.Add(item);
            itemContext.SaveChanges();
        }

        public Item GetId(int id)
        {
            return itemContext.Items.FirstOrDefault(x => x.Id == id);
        }

        public void DeleteItem(int id)
        {
            itemContext.Items.Remove(GetId(id));
            itemContext.SaveChanges();
        }

        public void UpdateItem(Item item)
        {
            itemContext.Items.Update(item);
            itemContext.SaveChanges();
        }
    }
}

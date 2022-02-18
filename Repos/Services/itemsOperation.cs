using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NewProject1Crud.Repos.Services;
using NewProject1Crud.Models;
using NewProject1Crud.Repos.Interface;

namespace NewProject1Crud.Repos.Services
{
    public class itemsOperation : IItemsData
    {
        List<ItemsData> Items;
        public itemsOperation()
        {
            Items = new List<ItemsData>()
            {
                new ItemsData()
                {

                }
            };
        }

        public int countItems()
        {
            return Items.Count();
        }

        public ItemsData Create(ItemsData items)
        {
            items.Id = Items.Count + 1;
            Items.Add(items);
            return items;
        }

        public List<ItemsData> GetItemsDeta()
        {
            return Items.ToList();
        }
    }
    
}

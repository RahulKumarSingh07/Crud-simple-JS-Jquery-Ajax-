using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NewProject1Crud.Models;

namespace NewProject1Crud.Repos.Interface
{
    public interface IItemsData
    {
        ItemsData Create(ItemsData items);
        List<ItemsData> GetItemsDeta();
        int countItems();
    }
}

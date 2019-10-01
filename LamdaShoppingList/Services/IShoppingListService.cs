using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LamdaShoppingList.Model;

namespace LamdaShoppingList.Services
{
    public interface IShoppingListService
    {
         Dictionary<string, int> GetItemsFromShoppingList();
         void AddItemToShoppingList(ShoppingListModel shoppingList);
         void RemoveItem(string name);
    }
}

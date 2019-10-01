using LamdaShoppingList.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LamdaShoppingList.Services
{
    public class ShoppingListService: IShoppingListService
    {
        private readonly Dictionary<string, int> _shoppingListStorage = new Dictionary<string, int>();

        public Dictionary<string, int> GetItemsFromShoppingList()
        {
            return _shoppingListStorage;
        }

        public void AddItemToShoppingList(ShoppingListModel shoppingList)
        {
            _shoppingListStorage.Add(shoppingList.Name, shoppingList.Quantity);
        }

        public void RemoveItem(string name)
        {
            _shoppingListStorage.Remove(name);
        }
    }

  
}

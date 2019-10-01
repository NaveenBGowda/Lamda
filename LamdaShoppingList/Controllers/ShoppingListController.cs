using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LamdaShoppingList.Model;
using LamdaShoppingList.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LamdaShoppingList.Controllers
{
    [Route("v1/ShoppingList")]
    [ApiController]
    public class ShoppingListController : Controller
    {

        private readonly IShoppingListService _shoppingListService;

        public ShoppingListController(IShoppingListService shoppingListService)
        {
            _shoppingListService = shoppingListService;
        }
        [HttpGet]

        public IActionResult GetShoppingList()
        {
          var result=  _shoppingListService.GetItemsFromShoppingList();
            return Ok(result);

        }
        [HttpPost]

        public IActionResult AddItemToShoppingList([FromBody] ShoppingListModel shoppingList)
        {
            _shoppingListService.AddItemToShoppingList(shoppingList);
            return Ok();
        }
        [HttpDelete]

        public IActionResult DeleteItemsToShoppingList([FromBody] ShoppingListModel shoppingList)
        {
            _shoppingListService.RemoveItem(shoppingList.Name);
            return Ok();
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
//.
//.
using MenuItemListing.Model;
using Microsoft.AspNetCore.Authorization;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MenuItemListing.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuItemController : ControllerBase
    {


        public List<MenuItem> menuItems = new List<MenuItem>
            {
                new MenuItem(){ Id = 101, Name = "Burger", Active=true, DateOfLaunch = DateTime.Now.AddDays(1), FreeDelivery = false, Price = 45},
                new MenuItem(){ Id = 102, Name = "Pizza", Active=true, DateOfLaunch = DateTime.Now, FreeDelivery = true, Price = 100}
            };
        // GET: api/<MenuItemController>
        [HttpGet]
        public IEnumerable<MenuItem> Get()
        {
            return menuItems;
        }

        // GET api/<MenuItemController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return menuItems.FirstOrDefault(menuItem => menuItem.Id == id).Name;
        }
    }
}

using GraphQLProject.Interfaces;
using GraphQLProject.Models;

namespace GraphQLProject.Services
{
    public class MenuRepository : IMenuRepository
    {
        private static List<Menu> menuList = new List<Menu>
        {
            new Menu { Id = 1, Name = "Pizza", Description = "Cheese Pizza", Price = 9.99 },
            new Menu { Id = 2, Name = "Burger", Description = "Beef Burger", Price = 5.99 },
            new Menu { Id = 3, Name = "Pasta", Description = "Spaghetti Bolognese", Price = 12.99 }
        };
        public Menu AddMenu(Menu menu)
        {
            menuList.Add(menu);
            return menu;
        }

        public void DeleteMenu(int id)
        {
            menuList.RemoveAt(id);
        }

        public List<Menu> GetAllMenus()
        {
            return menuList;
        }

        public Menu GetMenuById(int id)
        {
           return menuList.Find(menuList => menuList.Id == id);
        }

        public void UpdateMenu(int id, Menu menu)
        {
            menuList[id] = menu;
        }
    }
}

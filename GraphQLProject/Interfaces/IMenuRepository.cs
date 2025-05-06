using GraphQLProject.Models;

namespace GraphQLProject.Interfaces
{
    public interface IMenuRepository
    {
        List<Menu> GetAllMenus();
        Menu GetMenuById(int id);

        Menu AddMenu(Menu menu);
        void UpdateMenu(int id, Menu menu);
        void DeleteMenu(int id);
    }
}

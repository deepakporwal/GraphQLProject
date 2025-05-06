using GraphQL;
using GraphQL.Types;
using GraphQLProject.Interfaces;
using GraphQLProject.Models;
using GraphQLProject.Type;

namespace GraphQLProject.Query
{
    public class MenuQuery : ObjectGraphType
    {

        public MenuQuery(IMenuRepository menuRepository)
        {
            Field<ListGraphType<MenuType>>("menus" ).Resolve(
                context =>
                {
                    return menuRepository.GetAllMenus();
                });

            Field<MenuType>("menu")
                .Argument<IntGraphType>("id", "The ID of the menu")
                .Resolve(context =>
                {
                    var id = context.GetArgument<int>("id");
                    return menuRepository.GetMenuById(id);
                });
        }
    }
}

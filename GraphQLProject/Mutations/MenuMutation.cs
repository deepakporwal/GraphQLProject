
using GraphQL;
using GraphQL.Types;
using GraphQLProject.Interfaces;
using GraphQLProject.Models;
using GraphQLProject.Type;

namespace GraphQLProject.Mutations
{
    public class MenuMutation : ObjectGraphType
    {
        public MenuMutation(IMenuRepository menuRepository)
        {
            Field<MenuType>(
                 "addMenu")
                 .Arguments(new QueryArguments(
                     new QueryArgument<NonNullGraphType<MenuInputType>> { Name = "menu" }
                 )).Resolve(
                 context =>
                 {
                     var menu = context.GetArgument<Menu>("menu");
                     return menuRepository.AddMenu(menu);
                 }
            );
            Field<MenuType>(
                "updateMenu").
                Arguments(new QueryArguments(
                    new QueryArgument<NonNullGraphType<IntGraphType>> { Name = "id" },
                    new QueryArgument<NonNullGraphType<MenuInputType>> { Name = "menu" }))
                .Resolve(            
                context =>
                {
                    var id = context.GetArgument<int>("id");
                    var menu = context.GetArgument<Menu>("menu");
                    menuRepository.UpdateMenu(id, menu);
                    return menu;
                }
            );
            Field<StringGraphType>(
                "deleteMenu").
                Arguments(new QueryArguments(
                    new QueryArgument<NonNullGraphType<IntGraphType>> { Name = "id" }
                )).Resolve(
                context =>
                {
                    var id = context.GetArgument<int>("id");
                    menuRepository.DeleteMenu(id);
                    return $"Menu with ID {id} deleted successfully.";
                }
            );
        }
    }
}

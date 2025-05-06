using GraphQL.Types;

namespace GraphQLProject.Type
{
    public class MenuType :ObjectGraphType<Models.Menu>
    {
        public MenuType()
        {
            Field(x => x.Id);
            Field(x => x.Name);
            Field(x => x.Description);
            Field(x => x.Price);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GraphQL;
using GraphQL.Types;
using GraphQLDemo.Types;

namespace GraphQLDemo
{
    public class Query : ObjectGraphType<object>
    {
        public Query(Data data)
        {
            Name = "Query";
            Field<JediType>("Jedi",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<IntGraphType>> {Name = "id", Description = "id of the jedi"}
                ),
                resolve: context => data.GetJedi(0));
            Field<JediType>("Jedis", resolve: context => data.GetJedis());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using GraphQL.Types;
using GraphQL.Utilities;

namespace GraphQLDemo
{
    public class Schema : GraphQL.Types.Schema
    {
        public Schema(IServiceProvider provider)
            : base(provider)
        {
            Query = provider.GetRequiredService<Query>();
            //Mutation = provider.GetRequiredService<StarWarsMutation>();
        }
    }
}

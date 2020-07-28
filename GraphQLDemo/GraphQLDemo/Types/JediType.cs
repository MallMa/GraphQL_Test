using System;
using System.Collections.Generic;
using System.Text;
using GraphQL.Types;

namespace GraphQLDemo.Types
{
    class JediType : ObjectGraphType<Jedi>
    {
        public JediType(Data data)
        {
            Name = "Jedi";

            Field(j => j.Id).Description("id of the Jedi");
            Field(j => j.Name).Description("Name of the Jedi");
            Field(j => j.Side).Description("on which side of the Force the Jedi is");
        }
    }
}

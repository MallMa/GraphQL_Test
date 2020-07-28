using System;
using System.Collections.Generic;
using System.Text;
using GraphQL.Types;
using GraphQL.Server;
using GraphQL.Server.Ui.Playground;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using GraphQL.Server.Transports;
using GraphQLDemo.Types;

namespace GraphQLDemo
{
    class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<Data>();
            services.AddSingleton<Query>();
            services.AddSingleton<JediType>();
            services.AddSingleton<ISchema, Schema>();
            services.AddLogging(builder => builder.AddConsole());
            services.AddHttpContextAccessor();

            services.AddGraphQL(options =>
            {
                options.EnableMetrics = true;
                options.ExposeExceptions = true;
            })
            .AddSystemTextJson(deserializerSettings => { }, serializerSettings => { })
            .AddDataLoader()
            .AddUserContextBuilder(httpContext => new GraphQLUserContext { User = httpContext.User });
        }

        public void Configure(IApplicationBuilder app)
        {
            // add http for Schema at default url /graphql
            app.UseGraphQL<ISchema>();

            // use graphql-playground at default url /ui/playground
            app.UseGraphQLPlayground(new GraphQLPlaygroundOptions());
        }
    }
}

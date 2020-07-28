using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using System.Threading.Tasks;

namespace GraphQLDemo
{
    class Program
    {
        public static Task Main(string[] args) => WebHost.CreateDefaultBuilder<Startup>(args).Build().RunAsync();
        
        // ReSharper disable once InvalidXmlDocComment
        /** OLD
        static void Main(string[] args)
        {
            var schema = Schema.For(@"
                type Jedi {
                    name: String,
                    side: String,
                    id: ID
                }

                type Query {
                    hello: String
                    jedis: [Jedi]
                    jedi(id: ID): Jedi
                }
            ", _ => {
                _.Types.Include<Query>(); 
            });


            var json = schema.Execute(_ =>
            {
                _.Query = "{ jedi(id: 1) {name, side } }";
            });

            Console.WriteLine(json);
        }
        **/
    }
}

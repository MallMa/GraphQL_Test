using System;
using System.Collections.Generic;
using System.Text;
using GraphQLDemo.Types;

namespace GraphQLDemo
{
    public class Data
    {
        List<Jedi> Jedis;

        public Data()
        {
            Jedis = new List<Jedi>()
            {
                new Jedi() { Name = "Luke", Side = "Light", Id=0 },
                new Jedi() { Name = "Yoda", Side = "Light", Id=1 },
                new Jedi() { Name = "Darth Vader", Side = "Dark", Id=2 }
            };
        }

        public IEnumerable<Jedi> GetJedis()
        {
            return Jedis;
        }

        public Jedi GetJedi(int id)
        {
            return Jedis[id];
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace GraphQLDemo.Types
{
    public class Jedi
    {
        public string Name { get; set; }
        public string Side { get; set; }
        public int Id  { get; set; }

        public Jedi()
        {
            Name = "";
            Side = "";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almanapp.Models
{
    class TestClass
    {
        public List<Person>? persons { get; set; }
    }

    internal class Person
    {
        public string? date { get; set; }
        public string? firstname { get; set; }
        public string? lastname { get; set; }
    }
}

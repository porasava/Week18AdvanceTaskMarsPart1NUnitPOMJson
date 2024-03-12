using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week18AdvanceTaskMarsPart1NUnitPOMJson.Models
{
    public class ModelLogin
    {
        public string username { get; set; }
        public string password { get; set; }
    }
    public class TestData
    {
        public List<ModelLogin> Login { get; set; }

    }
}

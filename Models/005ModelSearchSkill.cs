using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week18AdvanceTaskMarsPart1NUnitPOMJson.Models
{
    public class _005ModelSearchSkill
    {
        public string TestCaseId { get; set; }
        public string Skill { get; set; }
        public string buttonName { get; set; }
        public string UsernameSearch { get; set; }
        public string SkillSearch { get; set; }
    }
    public class TestDataSearchSkill
    {
        public List<_005ModelSearchSkill> SearchSkill { get; set; }

    }
}

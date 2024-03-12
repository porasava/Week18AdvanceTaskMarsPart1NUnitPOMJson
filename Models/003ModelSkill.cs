using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week18AdvanceTaskMarsPart1NUnitPOMJson.Models
{
    public class _003ModelSkill
    {
        public string TestCaseId { get; set; }
        public string SkillName { get; set; }
        public string SkillLevel { get; set; }
        public string SkillEdit { get; set; }
        public string SkillDelete { get; set; }
    }

    public class TestDataSkill
    {
        public List<_003ModelSkill> Skill { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week18AdvanceTaskMarsPart1NUnitPOMJson.Models
{
    public class _004ModelShareSkill
    {
        public string TestCaseId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string Subcategory { get; set; }
        public string Tags { get; set; }
        public string SkillExchange { get; set; }
        public string TitleListing { get; set; }
        public string TitleEdit { get; set; }
    }
    public class TestDataShareSkill
    {
        public List<_004ModelShareSkill> ShareSkill { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week18AdvanceTaskMarsPart1NUnitPOMJson.Models
{
    public class _001ModelOverall
    {
        public string TestCaseId { get; set; }
        public string availabiltyTypeInput { get; set; }
        public string AvailabilityHourTypeInput { get; set; }
        public string availabiltyTargetInput { get; set; }
        


    }
    public class TestDataOverall
    {
        public List<_001ModelOverall> Overall { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week18AdvanceTaskMarsPart1NUnitPOMJson.Models
{
    public class _006ModelNotification
    {
        public string TestCaseId { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string username2 { get; set; }
        public string title { get; set; }
        public string MessageRequestText { get; set; }

    }
    public class TestDataNotification
    {
        public List<_006ModelNotification> Notification { get; set; }

    }
}

using AventStack.ExtentReports.MarkupUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week18AdvanceTaskMarsPart1NUnitPOMJson.Models
{
    public class _002ModelLanguage
    {
        public string TestCaseId { get; set; }
        public string Language { get; set; }
        public string LanguageLevel { get; set; }
        public string Language2 { get; set; }
        public string Language3 { get; set; }
        public string Language4 { get; set; }
        public string LanguageEdit { get; set; }
        public string LanguageLevel2 { get; set; }
        public string LanguageDelete { get; set; }
    }
    public class TestDataLanguage
    {
        public List<_002ModelLanguage> Language { get; set; }

    }
}

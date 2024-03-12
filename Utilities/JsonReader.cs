using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using Week18AdvanceTaskMarsPart1NUnitPOMJson.Models;
using AventStack.ExtentReports.MarkupUtils;

namespace Week18AdvanceTaskMarsPart1NUnitPOMJson.Utilities
{
    public static class JsonReader
    {
        public static List<ModelLogin> ReadLoginData(string filePath)
        {
            var jsonString = File.ReadAllText(filePath);
            var testData = JsonSerializer.Deserialize<TestData>(jsonString);

            if (testData != null && testData.Login.Any())
            {
                return testData.Login;
            }
            else
            {
                // Handle the case where no data is found or return an empty list
                return new List<ModelLogin>();
            }
        }

        public static List<_002ModelLanguage> ReadLanguageData(string filePath)
        {
            var jsonString = File.ReadAllText(filePath);
            var testData = JsonSerializer.Deserialize<TestDataLanguage>(jsonString);

            if (testData != null && testData.Language.Any())
            {
                return testData.Language;
            }
            else
            {
                // Handle the case where no data is found or return an empty list
                return new List<_002ModelLanguage>();
            }
        }

        public static List<_003ModelSkill> ReadSkillData(string filePath)
        {
            var jsonString = File.ReadAllText(filePath);
            var testData = JsonSerializer.Deserialize<TestDataSkill>(jsonString);

            if (testData != null && testData.Skill.Any())
            {
                return testData.Skill;
            }
            else
            {
                // Handle the case where no data is found or return an empty list
                return new List<_003ModelSkill>();
            }
        }

        public static List<_004ModelShareSkill> ReadShareSkillData(string filePath)
        {
            var jsonString = File.ReadAllText(filePath);
            var testData = JsonSerializer.Deserialize<TestDataShareSkill>(jsonString);

            if (testData != null && testData.ShareSkill.Any())
            {
                return testData.ShareSkill;
            }
            else
            {
                // Handle the case where no data is found or return an empty list
                return new List<_004ModelShareSkill>();
            }
        }
        public static List<_005ModelSearchSkill> ReadSearchSkillData(string filePath)
        {
            var jsonString = File.ReadAllText(filePath);
            var testData = JsonSerializer.Deserialize<TestDataSearchSkill>(jsonString);

            if (testData != null && testData.SearchSkill.Any())
            {
                return testData.SearchSkill;
            }
            else
            {
                // Handle the case where no data is found or return an empty list
                return new List<_005ModelSearchSkill>();
            }
        }

        public static List<_006ModelNotification> ReadNotificationData(string filePath)
        {
            var jsonString = File.ReadAllText(filePath);
            var testData = JsonSerializer.Deserialize<TestDataNotification>(jsonString);

            if (testData != null && testData.Notification.Any())
            {
                return testData.Notification;
            }
            else
            {
                // Handle the case where no data is found or return an empty list
                return new List<_006ModelNotification>();
            }
        }

        public static List<_001ModelOverall> ReadOverallData(string filePath)
        {
            var jsonString = File.ReadAllText(filePath);
            var testData = JsonSerializer.Deserialize<TestDataOverall>(jsonString);

            if (testData != null && testData.Overall.Any())
            {
                return testData.Overall;
            }
            else
            {
                // Handle the case where no data is found or return an empty list
                return new List<_001ModelOverall>();
            }
        }
    }
}

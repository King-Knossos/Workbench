﻿using System.Collections.Generic;
using System.Linq;
using System.Text;
using FillAPixRobot.Interfaces;

namespace FillAPixRobot
{
    // ToDo: Remove after test is done!
    public class SensoryUnitCountContainer
    {
        public Dictionary<ISensoryUnit, (int UnitCount, int Negative, int Positive)> UnitCountDictonary { get; }
        public SensoryUnitCountContainer(Dictionary<ISensoryUnit, (int UnitCount, int Negative, int Positive)> unitCountDictonary)
        {
            UnitCountDictonary = unitCountDictonary;
        }

        public override string ToString()
        {
            var output = new StringBuilder();
            output.Append("{ UnitsDictonary: \n[\n");
            foreach(var entry in UnitCountDictonary.OrderBy(e => e.Value.Negative + e.Value.Positive))
            {
                output.Append($"\t{entry.Key} \t UnitCount: \t {entry.Value.UnitCount} \t Negative: \t {entry.Value.Negative} \t Positive: \t {entry.Value.Positive} \n");
            }
            output.Append("]\n}");
            return output.ToString();
        }
    }

    public class SensoryPatternCountContainer
    {
        public Dictionary<ISensoryPattern, (int Count, int Negative, int Positive)> PatternCountDictonary { get; }
        public SensoryPatternCountContainer(Dictionary<ISensoryPattern, (int Count, int Negative, int Positive)> patternCountDictonary)
        {
            PatternCountDictonary = patternCountDictonary;
        }

        public override string ToString()
        {
            var output = new StringBuilder();
            output.Append("{ PatternsDictonary: \n[\n");
            foreach (var entry in PatternCountDictonary.OrderBy(e => e.Value.Negative + e.Value.Positive))
            {
                output.Append($"\t{entry.Key} \t Count: \t {entry.Value.Count} \t Negative: \t {entry.Value.Negative} \t Positive: \t {entry.Value.Positive} \n");
            }
            output.Append("]\n}");
            return output.ToString();
        }
    }

}

﻿using System.Collections.Generic;

using FillAPixRobot.Enums;

namespace FillAPixRobot.Interfaces
{
    public interface IActionMemory
    {
        IPuzzleAction Action { get; }

        int CallCount { get; }
        int DifferenceCount { get; }
        int NoDifferenceCount { get; }
        double NegProcentualNoDifference { get; }

        int PositiveFeedbackCount { get; }
        int NegativeFeedbackCount { get; }
        double NegProcentualNegativeFeedback { get; }

        Dictionary<ISensoryUnit, int> DifferentUnits { get; }
        Dictionary<ISensoryUnit, int> NoDifferentUnits { get; }

        Dictionary<IPartialSnapshotCompression, int> PositveDictPartialSnapshotCompressions { get; } 
        Dictionary<IPartialSnapshotCompression, int> NegativeDictPartialSnapshotCompressions { get; }

        Dictionary<ISensoryPattern, int> GetNoDifferencePattern(FieldOfVisionTypes fieldOfVision);
        void RememberDifference(bool isDifferent, ISensationSnapshot snapshot);
        double CheckForDifferencePattern(ISensationSnapshot snapshot);

        Dictionary<ISensoryPattern, int> GetNegativeFeedbackPattern(FieldOfVisionTypes fieldOfVision);
        void RememberFeedback(int feedbackValue, ISensationSnapshot snapshot);
        double CheckForPositiveFeedback(ISensationSnapshot snapshot);

        double CheckForNegativeFeedback(ISensationSnapshot snapshot);
        double CheckForNotNegativeFeedbackPattern(ISensationSnapshot snapshot);

        double GetPositiveFeedbackPercentage(IPartialSnapshotCompression partialSnapshotCompression);

        double GetNegativeFeedbackPercentage(IPartialSnapshotCompression partialSnapshotCompression);
    }
}

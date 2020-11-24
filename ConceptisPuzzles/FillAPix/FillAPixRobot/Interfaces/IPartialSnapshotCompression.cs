﻿using FillAPixRobot.Enums;
using System;
using System.Collections.Generic;

namespace FillAPixRobot.Interfaces
{
    public interface IPartialSnapshotCompression : IComparable
    {
        long Id { get; }
        CompressionTypes CompressionType { get; set; }
        DirectionTypes Direction { get; set; }
        FieldOfVisionTypes FieldOfVision { get; set; }
        Dictionary<ISensoryPattern, int> SensoryPatternCounts { get; }
    }
}

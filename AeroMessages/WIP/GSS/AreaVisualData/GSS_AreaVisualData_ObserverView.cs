using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroIfAttribute;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using AeroMessages.Common;
using System.Numerics;
using System;
namespace AeroMessages.GSS.AreaVisualData
{
    [Aero(true)]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 20, 1)]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 20, 3)]
    public partial class AreaVisualData_ObserverView
    {
        private Vector3 Position;
        private ScopeBubbleInfoData ScopeBubbleInfo;

        [AeroNullable] private ContextFlag ContextFlags_0;
        [AeroNullable] private ContextFlag ContextFlags_1;
        [AeroNullable] private ContextFlag ContextFlags_2;
        [AeroNullable] private ContextFlag ContextFlags_3;
        [AeroNullable] private ContextFlag ContextFlags_4;
        [AeroNullable] private ContextFlag ContextFlags_5;
        [AeroNullable] private ContextFlag ContextFlags_6;
        [AeroNullable] private ContextFlag ContextFlags_7;
        [AeroNullable] private ContextFlag ContextFlags_8;
        [AeroNullable] private ContextFlag ContextFlags_9;
        [AeroNullable] private ContextFlag ContextFlags_10;
        [AeroNullable] private ContextFlag ContextFlags_11;
        [AeroNullable] private ContextFlag ContextFlags_12;
        [AeroNullable] private ContextFlag ContextFlags_13;
        [AeroNullable] private ContextFlag ContextFlags_14;
        [AeroNullable] private ContextFlag ContextFlags_15;

        [AeroNullable] private ContextFlag ContextFlags_16;
        [AeroNullable] private ContextFlag ContextFlags_17;
        [AeroNullable] private ContextFlag ContextFlags_18;
        [AeroNullable] private ContextFlag ContextFlags_19;
        [AeroNullable] private ContextFlag ContextFlags_20;
        [AeroNullable] private ContextFlag ContextFlags_21;
        [AeroNullable] private ContextFlag ContextFlags_22;
        [AeroNullable] private ContextFlag ContextFlags_23;

        // TODO: Bitfield - ContextTeams
        [AeroNullable] private ContextTeam ContextTeams_0;
        [AeroNullable] private ContextTeam ContextTeams_1;
        [AeroNullable] private ContextTeam ContextTeams_2;
        [AeroNullable] private ContextTeam ContextTeams_3;
    }

    [AeroBlock]
    public struct ContextFlag
    {
        [AeroArray(3)]
        public byte[] Unk;
    }

    
    [AeroBlock]
    public struct ContextTeam
    {
        // TODO
        public byte Unk; // Not confirmed
    }
     
}
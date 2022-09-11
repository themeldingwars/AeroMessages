using Aero.Gen.Attributes;
using System.Numerics;
using AeroMessages.Common;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using static Aero.Gen.Attributes.AeroIfAttribute;
namespace AeroMessages.GSS.V66.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 2, 175)]
    public partial class DailyLoginRewardsUpdateEvt
    {   
        [AeroArray(typeof(byte))] public DailyRewardsData1[] Unk1;
        [AeroArray(typeof(byte))] public DailyRewardsData2[] Unk2;
        public uint Unk3;
        public uint Unk4;
        public uint Unk5;
    }

    [AeroBlock]
    public struct DailyRewardsData1
    {
        public uint Unk1;
        [AeroString] public string Unk2;
        public byte Unk3;
        public byte Unk4;
    }

    [AeroBlock]
    public struct DailyRewardsData2
    {
        public uint Unk1;
        public uint Unk2;
        public uint Unk3;
        public uint Unk4;

        // This might be conditional
        [AeroArray(typeof(byte))] public DailyRewardsData2Inner[] Unk5;
    }

    [AeroBlock]
    public struct DailyRewardsData2Inner
    {
        public uint Unk1;
        public uint Unk2;
    }
}
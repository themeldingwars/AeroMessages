using Aero.Gen.Attributes;
using AeroMessages.Common;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.Matrix.V25
{
    [Aero]
    [AeroMessageId(MsgType.Matrix, MsgSrc.Message, 28)]
    public partial class UpdateDevZoneInfo
    { 
        [AeroArray(typeof(byte))]
        public DevZoneInfo1[] Unk1;

        [AeroArray(typeof(byte))]
        public DevZoneInfo2[] Unk2;
    }

    [AeroBlock]
    public struct DevZoneInfo1
    {
        [AeroString] public string Unk1;
        public ushort Unk2;
    }

    [AeroBlock]
    public struct DevZoneInfo2
    {
        [AeroString] public string Unk1;
        public uint Unk2;
    }
}
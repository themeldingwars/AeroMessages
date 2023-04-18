using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using AeroMessages.Common;
namespace AeroMessages.GSS.V66.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 2, 237)]
    public partial class ExecuteTinkeringPlan
    {
        public uint Unk1;
        [AeroArray(typeof(byte))] public TinkeringData[] Unk2;
        [AeroArray(typeof(byte))] public TinkeringData[] Unk3;
        [AeroArray(typeof(byte))] public TinkeringData[] Unk4;
    }

    [AeroBlock]
    public struct TinkeringData {
        public ulong Unk1;
        public uint Unk2;
    }
}
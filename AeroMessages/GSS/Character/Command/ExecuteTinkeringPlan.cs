using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, GssCharacterCommand.ExecuteTinkeringPlan, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V67)]
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
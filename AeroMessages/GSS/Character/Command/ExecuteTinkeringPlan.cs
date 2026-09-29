using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, GssCharacterCommand.ExecuteTinkeringPlan, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V74)]
    public partial class ExecuteTinkeringPlan
    {
        public uint PlanId;
        [AeroArray(typeof(byte))] public TinkeringData[] ItemInputs;
        [AeroArray(typeof(byte))] public TinkeringData[] SubtypeInputs;
        [AeroArray(typeof(byte))] public TinkeringData[] ArrayInputs;
    }

    [AeroBlock]
    public struct TinkeringData {
        public ulong ItemGuid;
        public uint ItemSdbId;
    }
}
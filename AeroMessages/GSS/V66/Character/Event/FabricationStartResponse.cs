using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 2, 179)]
    public partial class FabricationStartResponse
    {
        public FabricationCommonData1 Response;
        public uint Unk2;
    }
}
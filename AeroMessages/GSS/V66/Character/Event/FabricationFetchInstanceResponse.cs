using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 2, 178)]
    public partial class FabricationFetchInstanceResponse
    {
        public FabricationCommonData1 Response;
        public uint Unk2;
    }
}
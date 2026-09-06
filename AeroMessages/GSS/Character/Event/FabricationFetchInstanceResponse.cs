using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterMessage.Fabrication_FetchInstance_Response, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V74)]
    public partial class FabricationFetchInstanceResponse
    {
        public FabricationCommonData1 Response;
        public uint Unk2;
    }
}
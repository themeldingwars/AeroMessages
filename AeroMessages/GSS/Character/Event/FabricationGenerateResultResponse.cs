using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterMessage.Fabrication_GenerateResult_Response, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V74)]
    public partial class FabricationGenerateResultResponse
    {
        public uint Unk1;
    }
}